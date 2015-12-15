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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Run the Authorize function to authorize/authenticate the user
            if (MainDB.Authorize(txtLogin.Text, txtPassword.Text))
            {
                //If it's an administrator, open the choose menu form with administrator argument
                if (txtLogin.Text.Contains("Administrator"))
                {
                    frmMenuAdmin form1 = new frmMenuAdmin("Administrator");
                    this.Hide();
                    form1.ShowDialog();
                    this.Show();
                    btnClear_Click(sender, e);
                }
                else
                {
                    //If general user, open the choose menu form with that user's login as an argument
                    frmMenuCust form1 = new frmMenuCust(txtLogin.Text);
                    this.Hide();
                    form1.ShowDialog();
                    this.Show();
                    btnClear_Click(sender, e);
                }
            }
            else
            {
                //If authorization failed, display an error message
                MessageBox.Show("Access Denied. Please check your login credentials!");
                btnClear_Click(sender,e);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPassword.Clear();
            txtLogin.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSignUp signup = new frmSignUp();
            this.Hide();
            signup.ShowDialog();
            this.Show();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
