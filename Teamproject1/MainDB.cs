using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace Teamproject2
{
    //Struct to create Customer data objects
    public struct Customer
    {
        public string LoginName;
        public string Password;
        public string AccountID;
        public string Address1;
        public string Address2;
        public string City;
        public string State;
        public string Zipcode;
    }

    //Struct to create inventory data objects
    public struct Inventory
    {
        public int ProductID;
        public int Quantity;
        public string Name;
        public decimal Price;
    }

    //Class that can be called statically for database operations
    public static class MainDB
    {
        //Conection string that accesses database through relative path
        static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
            + "Data Source=..\\..\\..\\BicyclesAndAccessories.accdb";

        //Pulls records based on login Search. This is used for general user info page
        public static Customer searchLogin(string loginName)
        {
            Customer c = new Customer();

            OleDbConnection conn = new OleDbConnection(connectionString);
            string SelectStmt = 
                "SELECT c.*,l.* FROM tblCustomer c INNER JOIN " +
                "tblLogin l ON c.CustomerID = l.AccountID WHERE l.LoginName LIKE(@loginName+'%')";

            OleDbCommand SelectCmd = new OleDbCommand(SelectStmt, conn);
            SelectCmd.Parameters.AddWithValue("@loginName", loginName);

            try
            {
                conn.Open();
                OleDbDataReader ReadR = SelectCmd.ExecuteReader();
                while (ReadR.Read())
                {
                    c.AccountID = ReadR["CustomerID"].ToString();
                    c.LoginName = ReadR["LoginName"].ToString();
                    c.Address1 = ReadR["AddressLine1"].ToString();
                    c.Address2 = ReadR["AddressLine2"].ToString();
                    c.City = ReadR["City"].ToString();
                    c.State = ReadR["State"].ToString();
                    c.Zipcode = ReadR["ZipCode"].ToString();
                }
                ReadR.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return c;
        }

        //This is used when saving edits to customer records
        public static void UpdateCustomer(Customer cust)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            string CmdStmt = "UPDATE tblCustomer SET AddressLine1 = @add1, AddressLine2 = @add2, " +
                "City = @City, State = @State, ZipCode = @Zipcode WHERE CustomerID = @accountID";

            OleDbCommand SelectCmd = new OleDbCommand(CmdStmt, conn);
            SelectCmd.Parameters.AddWithValue("@add1", cust.Address1);
            SelectCmd.Parameters.AddWithValue("@add2", cust.Address2);
            SelectCmd.Parameters.AddWithValue("@City", cust.City);
            SelectCmd.Parameters.AddWithValue("@State", cust.State);
            SelectCmd.Parameters.AddWithValue("@Zipcode", cust.Zipcode);
            SelectCmd.Parameters.AddWithValue("@accountID", cust.AccountID);
            try
            {
                conn.Open();
                SelectCmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        //This is used to authorize the user at the login page
        public static bool Authorize(string login, string password)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            string SelectStmt = "SELECT LoginName,InsertPass FROM tblLogin WHERE LoginName " + 
                "IN(@login) AND InsertPass IN(@pass)";

            OleDbCommand SelectCmd = new OleDbCommand(SelectStmt, conn);
            SelectCmd.Parameters.AddWithValue("@login", login);
            SelectCmd.Parameters.AddWithValue("@pass", password);

            try
            {
                conn.Open();
                OleDbDataReader ReadR = SelectCmd.ExecuteReader();
                if (ReadR.Read())
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        //Used to get all zipcodes from the database
        public static List<string> GetZips()
        {
            List<string> zips = new List<string>();
            OleDbConnection conn = new OleDbConnection(connectionString);
            string SelectStmt = "SELECT ZipCode FROM tblDelivery";

            OleDbCommand SelectCmd = new OleDbCommand(SelectStmt, conn);

            try
            {
                conn.Open();
                OleDbDataReader ReadR = SelectCmd.ExecuteReader();
                while (ReadR.Read())
                {
                    zips.Add(ReadR["ZipCode"].ToString());
                }
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return zips;
        }

        //This is used to add new zip codes to the database
        public static bool AddZip(string zip)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            string INSERTStmt = "INSERT INTO tblDelivery(ZipCode) VALUES(@zip)";

            OleDbCommand INSERTCmd = new OleDbCommand(INSERTStmt, conn);
            INSERTCmd.Parameters.AddWithValue("@zip", zip);

            try
            {
                conn.Open();
                int count = INSERTCmd.ExecuteNonQuery();
                if (count == 1)
                    return true;
                return false;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        //This is used to delete zipcodes from the database
        public static bool DeleteZip(string zip)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            string INSERTStmt = "DELETE FROM tblDelivery WHERE ZipCode=@zip";

            OleDbCommand INSERTCmd = new OleDbCommand(INSERTStmt, conn);
            INSERTCmd.Parameters.AddWithValue("@zip", zip);

            try
            {
                conn.Open();
                int count = INSERTCmd.ExecuteNonQuery();
                if (count == 1)
                    return true;
                return false;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        //This is used to add a new customer from the signup portion of the program
        public static bool AddCustomerDetails(Customer newCustomer)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            string INSERTStmt = "INSERT INTO tblCustomer(AddressLine1,AddressLine2,City,State,ZipCode)"+
                " VALUES(@add1,@add2,@City,@State,@Zipcode)";

            OleDbCommand INSERTCmd = new OleDbCommand(INSERTStmt, conn);
            INSERTCmd.Parameters.AddWithValue("@add1", newCustomer.Address1);
            INSERTCmd.Parameters.AddWithValue("@add2", newCustomer.Address2);
            INSERTCmd.Parameters.AddWithValue("@City", newCustomer.City);
            INSERTCmd.Parameters.AddWithValue("@State", newCustomer.State);
            INSERTCmd.Parameters.AddWithValue("@Zipcode", newCustomer.Zipcode);

            try
            {
                conn.Open();
                int count1 = INSERTCmd.ExecuteNonQuery();                
                if (count1 == 1)
                {
                    return true;                    
                }
                    return false;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        //This is used to add the login credentials from the signup portion of the program
        public static bool AddLoginDetails(Customer newCustomer)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            string INSERTStmt = "INSERT INTO tblLogin(AccountID,LoginName,InsertPass) "+
                "VALUES(@accID,@login,@pass)";

            OleDbCommand INSERTCmd = new OleDbCommand(INSERTStmt, conn);
            INSERTCmd.Parameters.AddWithValue("@accID", GetCustomerID());
            INSERTCmd.Parameters.AddWithValue("@login", newCustomer.LoginName);
            INSERTCmd.Parameters.AddWithValue("@pass", newCustomer.Password);

            try
            {
                conn.Open();
                int count1 = INSERTCmd.ExecuteNonQuery();
                if (count1 == 1)
                {
                    return true;
                }
                return false;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        //This is used by AddLoginDetails to get the customer id of the last
        //customer signed up in order to maintain the relationship
        //between the login and the customer tables
        public static string GetCustomerID()
        {
            string lastCID="NONE";
            OleDbConnection conn = new OleDbConnection(connectionString);
            string SelectStmt = "SELECT MAX(CustomerID) FROM tblCustomer";

            OleDbCommand SelectCmd = new OleDbCommand(SelectStmt, conn);

            try
            {
                conn.Open();
                OleDbDataReader ReadR = SelectCmd.ExecuteReader();
                while (ReadR.Read())
                {
                    lastCID = ReadR[0].ToString();
                }
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return lastCID;
        }

        //This is used to get the currently logged in user
        //throughout the program, but mainly in making orders
        //in order to apply the sales order to the correct customer
        public static int GetUser(string login)
        {
            int cid = -1;
            OleDbConnection conn = new OleDbConnection(connectionString);
            string SelectStmt = "SELECT AccountID FROM tblLogin WHERE LoginName=@login";
            OleDbCommand SelectCmd = new OleDbCommand(SelectStmt, conn);
            SelectCmd.Parameters.AddWithValue("@login", login);
            try
            {
                conn.Open();
                OleDbDataReader ReadR = SelectCmd.ExecuteReader();
                while (ReadR.Read())
                {
                    cid = Convert.ToInt32(ReadR["AccountID"]);
                }
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return cid;
        }

        //This is used to get all products for the order form
        public static List<Inventory> GetProducts()
        {
            List<Inventory> products = new List<Inventory>();

            OleDbConnection conn = new OleDbConnection(connectionString);
            string SelectStmt = "SELECT ID, Quantity, Product, UnitPrice FROM tblInventory";

            OleDbCommand SelectCmd = new OleDbCommand(SelectStmt, conn);

            try
            {
                conn.Open();
                OleDbDataReader ReadR = SelectCmd.ExecuteReader();
                while (ReadR.Read())
                {
                    Inventory i = new Inventory();
                    i.ProductID = Convert.ToInt32(ReadR["ID"]);
                    i.Quantity = Convert.ToInt32(ReadR["Quantity"]);
                    i.Name = ReadR["Product"].ToString();
                    i.Price = Convert.ToDecimal(ReadR["UnitPrice"]);
                    products.Add(i);
                }
                ReadR.Close();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return products;
        }

        //This is used to make the order by inserting all
        //necessary data into the sales table
        public static bool MakeOrder(int pid,int cid, int quant)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            string INSERTStmt = "INSERT INTO Sales(ProductID,CustomerID,Quantity) VALUES(@prodId,@custId,@quant)";

            OleDbCommand INSERTCmd = new OleDbCommand(INSERTStmt, conn);
            INSERTCmd.Parameters.AddWithValue("@prodId", pid);
            INSERTCmd.Parameters.AddWithValue("@custId", cid);
            INSERTCmd.Parameters.AddWithValue("@quant",quant);

            try
            {
                conn.Open();
                int count1 = INSERTCmd.ExecuteNonQuery();
                if (count1 == 1)
                {
                    UpdateInventory(quant);
                    return true;
                }
                return false;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        //This is used from within the make order function
        //to update the inventory count after an order has been made
        public static bool UpdateInventory(int quant)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            string INSERTStmt = "UPDATE tblInventory SET Quantity=Quantity - @quant";
            
            OleDbCommand INSERTCmd = new OleDbCommand(INSERTStmt, conn);
            INSERTCmd.Parameters.AddWithValue("@quant", quant);

            try
            {
                conn.Open();
                int count1 = INSERTCmd.ExecuteNonQuery();
                if (count1 == 1)
                {
                    return true;
                }
                return false;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        //This is used to run custom queries from the Access Database,
        //retrieve the data, and store them in a DataSet object
        public static DataSet GetQuery(string query)
        {
            DataSet ds = new DataSet();
            OleDbConnection cnt2 = new OleDbConnection(connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cnt2;
            cmd.CommandText = "Execute ["+query+"]";
            adapter.SelectCommand = cmd;

            try
            {
                cnt2.Open();
                int count = adapter.Fill(ds);
                return ds;
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                cnt2.Close();
            }
        }
    }
}