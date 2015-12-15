using System;
using System.Windows.Forms;

namespace Teamproject2
{
    public partial class frmManageZip : Form
    {
        public frmManageZip()
        {
            InitializeComponent();
        }

        //Gets the zipcodes through MainDB and loads them into list
        //as the DataSource
        private void btnDisplayZip_Click(object sender, EventArgs e)
        {
            lstZipCode.DataSource = MainDB.GetZips(); ;
        }

        //Validates character length of zipcode, stores in database
        //and refreshes list
        private void btnAddZip_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            if (txtAddZip.Text.Length < 5)
            {
                MessageBox.Show("Please enter a valid 5 digit Zipcode.");
            }
            else
            {
                MainDB.AddZip(txtAddZip.Text);
                txtAddZip.Clear();
                lstZipCode.DataSource = MainDB.GetZips();
            }
        }

        //Deletes the selected zip code from the list, the database, and refreshes
        private void btnDeleteZip_Click(object sender, EventArgs e)
        {
            if (lstZipCode.SelectedIndex < 0)
            {
                MessageBox.Show("Nothing is selected.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete Zipcode" + lstZipCode.SelectedItem + "?", "Delete Zip", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MainDB.DeleteZip(lstZipCode.SelectedItem.ToString());
                    lstZipCode.DataSource = MainDB.GetZips();
                }
            }
        }

        //When the form loads, sets the ListBox to no selection
        //and the DataSource
        private void frmManageZip_Load(object sender, EventArgs e)
        {
            lstZipCode.DataSource = MainDB.GetZips();
            lstZipCode.SelectedIndex = -1;
        }

        //Clears the textbox used to add zipcodes
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddZip.Clear();
            txtAddZip.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
