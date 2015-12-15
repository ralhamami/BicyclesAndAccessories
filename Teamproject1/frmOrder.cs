using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Teamproject2
{
    public partial class frmOrder : Form
    {
        //Get the list of products from the database
        List<Inventory> inventory = MainDB.GetProducts();
        //Will store the customer id
        int cid;

        public frmOrder(int cid)
        {
            this.cid = cid;
            InitializeComponent();
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the data and convert to numbers
                int inStock = Convert.ToInt32(txtQuantityinInventory.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);

                //If the quantity is greater than stock, don't process
                if (quantity > inStock)
                {
                    MessageBox.Show("The quantity requested exceeds the quantity in stock.");
                }
                else
                {
                    //Otherwise, make order and if successful, display
                    if (MainDB.MakeOrder(inventory[cboProducts.SelectedIndex].ProductID, cid, quantity))
                    {
                        MessageBox.Show("Order successfully made!");
                        this.Close();
                    }
                    //Otherwise, display failure
                    else
                    {
                        MessageBox.Show("There was a problem making your order.");
                    }
                }
            }
            //For all other exceptions, display semi-generic error
            catch (Exception)
            {
                MessageBox.Show("Please enter whole number value for quantity.");
            }
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            //Upon loading, initalize a new list
            //and add only the product names to it
            List<string> names = new List<string>();
            for(int i=0; i<inventory.Count(); i++){
                names.Add(inventory[i].Name);
            }
            //Then create a binding source that has its datasource set
            //to the list of names, then set the datasource of the combobox
            //to the binding source
            BindingSource bs = new BindingSource();
            bs.DataSource = names;
            cboProducts.DataSource = bs;
        }

        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Each time the index of the selected product changes,
            //update the relevant data on screen
            txtQuantityinInventory.Text = inventory[cboProducts.SelectedIndex].Quantity.ToString();
            txtUnitPrice.Text = inventory[cboProducts.SelectedIndex].Price.ToString();
           
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            //Everytime the text is changed in the quantity textbox
            //update the total textbox to give a preview of the total
            try
            {
                if (txtQuantity.TextLength > 0)
                {
                    Decimal total = Convert.ToDecimal(txtUnitPrice.Text) * Convert.ToInt32(txtQuantity.Text);
                    txtTotalPrice.Text = total.ToString("c");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please call customer service and provide the following error message: " 
                    + ex.Message);
            }
        }
    }
}
