using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teamproject2
{
    public partial class frmMenuAdmin : Form
    {
        //Stores current user
        string currentUser;

        public frmMenuAdmin(string login)
        {
            InitializeComponent();
            //Set the current user string and set the title
            currentUser = login;
            //Sets the form title to the user's account
            this.Text = "Account: " + currentUser;
        }

        private void btnManageCust_Click(object sender, EventArgs e)
        {
            frmManageCustomer manageCust = new frmManageCustomer(currentUser);
            manageCust.ShowDialog();
        }

        private void btnManageZip_Click(object sender, EventArgs e)
        {
            frmManageZip manageZip = new frmManageZip();
            manageZip.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSalesData salesData = new frmSalesData();
            salesData.ShowDialog();
        }
    }
}
