using System;
using System.Windows.Forms;

namespace Teamproject2
{
    public partial class frmMenuCust : Form
    {
        //Used to store current user
        string currentUser;
        public frmMenuCust(string login)
        {
            InitializeComponent();
            //Set the current user string and set the title
            currentUser = login;
            //Set the title to the current user's account
            this.Text = "Account: "+currentUser;
        }

        private void btnManageCust_Click(object sender, EventArgs e)
        {
            frmManageCustomer manageCust = new frmManageCustomer(currentUser);
            manageCust.ShowDialog();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int cid = MainDB.GetUser(currentUser);
            frmOrder makeOrder = new frmOrder(cid);
            makeOrder.ShowDialog();
        }
    }
}
