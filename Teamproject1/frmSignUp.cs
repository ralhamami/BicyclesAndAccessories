using System;
using System.Windows.Forms;

namespace Teamproject2
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //Create a new customer object and set the details
            //retrieved from the textboxes
            Customer newCustomer = new Customer();
            newCustomer.Address1 = txtAddress1.Text;
            newCustomer.Address2 = txtAddress2.Text;
            newCustomer.City = txtCity.Text;
            newCustomer.State = txtState.Text;
            newCustomer.Zipcode = txtZipcode.Text;
            newCustomer.LoginName = txtLoginName.Text;
            newCustomer.Password = txtPassword.Text;

            //Attempt to add the customer to the database
            bool Success1 = MainDB.AddCustomerDetails(newCustomer);
            //Then attempt to add the login details for that customer
            bool Success2 = MainDB.AddLoginDetails(newCustomer);
            //If both operations were a success
            //then clear the textboxes and display a message
            if (Success1 && Success2)
            {
                MessageBox.Show("Signed up.");
                this.Close();
            }
            //Otherwise display an error message and clear
            else
            {
                MessageBox.Show("Signup Failed.");
                btnClear_Click(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            txtLoginName.Clear();
            txtPassword.Clear();
            txtState.Clear();
            txtZipcode.Clear();
        }
    }
}
