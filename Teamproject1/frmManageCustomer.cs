using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Teamproject2
{
    public partial class frmManageCustomer : Form
    {
        //Will store the current user
        string currentUser;

        public frmManageCustomer(string login)
        {
            InitializeComponent();
            //Set the current user to whatever was passed to this form from chooseMenu
            currentUser = login;
            //Set the title of the form to the current user
            this.Text = "Account: "+currentUser;
        }

        private void frmManageCustomer_Load(object sender, EventArgs e)
        {
            //When the form loads, if it is not administrator, disable some of the features
            //and auto-populate the user info for only the logged in general user
            if (!currentUser.Contains("Administrator"))
            {
                btnSearch.Visible = false;
                txtSearch.Visible = false;
                lblSearch.Visible = false;
                btnEdit.Enabled = true;
                Customer cs = MainDB.searchLogin(currentUser);
                txtAccoutID.Text = cs.AccountID;
                txtLogin.Text = cs.LoginName;
                txtAddress1.Text = cs.Address1;
                txtAddress2.Text = cs.Address2;
                txtCity.Text = cs.City;
                txtState.Text = cs.State;
                txtZip.Text = cs.Zipcode;
                btnFreeDelivery_Click(sender, e);
            }
        }

        //Clear All Data
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Search Database for specified login name
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Customer cs = MainDB.searchLogin(txtSearch.Text);
                txtAccoutID.Text = cs.AccountID;
                txtLogin.Text = cs.LoginName;
                txtAddress1.Text = cs.Address1;
                txtAddress2.Text = cs.Address2;
                txtCity.Text = cs.City;
                txtState.Text = cs.State;
                txtZip.Text = cs.Zipcode;
                btnEdit.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Method that actually clears all data since
        //it is used in multiple places
        public void clear()
        {
            txtSearch.Clear();
            txtAccoutID.Clear();
            txtLogin.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZip.Clear();
            txtSearch.Focus();
        }

        //Toggles the Enabled property of textboxes
        //depending on whether edit button has been clicked
        public void toggleEdit(bool value)
        {
            txtAddress1.Enabled = value;
            txtAddress2.Enabled = value;
            txtCity.Enabled = value;
            txtState.Enabled = value;
            txtZip.Enabled = value;
        }

        //Changed the word "Edit" to "Save" upon clicking
        //and enables all relevant textboxes for editing
        //then saves the data to the database through MainDB
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text.Contains("Edit"))
            {
                toggleEdit(true);
                btnEdit.Text = "&Save";
            }
            else
            {
                Customer cs = new Customer();
                cs.LoginName = txtLogin.Text;
                cs.AccountID = txtAccoutID.Text;
                cs.Address1 = txtAddress1.Text;
                cs.Address2 = txtAddress2.Text;
                cs.City = txtCity.Text;
                cs.State = txtState.Text;
                cs.Zipcode = txtZip.Text;
                MainDB.UpdateCustomer(cs);
                btnEdit.Text = "&Edit";
                toggleEdit(false);
                btnFreeDelivery_Click(sender, e);
                //If the current user is an administrator, then disable the edit button after
                //saving, but if general user do not
                if (currentUser.Contains("Administrator"))
                {
                    btnEdit.Enabled = false;
                    clear();
                }
            }
        }

        //Checks if Zipcode has free delivery and displays a MessageBox
        public void btnFreeDelivery_Click(object sender, EventArgs e)
        {
            List<string> zips = MainDB.GetZips();
            foreach (string value in zips)
            {
                if (txtZip.Text.Equals(value))
                {
                    MessageBox.Show("This Zipcode Qualifies for Free Delivery!!!");
                    return;
                }
            }
            MessageBox.Show("Sorry, This Zipcode Does Not Qualify for Free Delivery.");
        }
    }
}
