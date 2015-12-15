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
    public partial class frmSalesData : Form
    {
        //Will store the dataset retrieved from the database
        DataSet ds;

        public frmSalesData()
        {
            InitializeComponent();
        }

        //For all of the following methods:
        //Button from menustrip is clicked
        //The instruction label is set to invisible
        //The dataset is retrieved from the database executing the specified query
        //The dataset is set as the source of the datagridview
        //The necessary columns are set to currency format
        private void salesTotaledByCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblInstruction.Visible = false;
            ds = MainDB.GetQuery("SalesTotaledbyCustomer");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["SalesTotal"].DefaultCellStyle.Format = "c";
        }

        private void profitTotaledByCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblInstruction.Visible = false;
            ds = MainDB.GetQuery("ProfitTotaledbyCustomer");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["ProfitTotal"].DefaultCellStyle.Format = "c";
        }

        private void totalSalesByProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblInstruction.Visible = false;
            ds = MainDB.GetQuery("TotalSalesbyProduct");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["SalesTotal"].DefaultCellStyle.Format = "c";
        }

        private void totalProfitByProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblInstruction.Visible = false;
            ds = MainDB.GetQuery("TotalProfitbyProduct");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["ProfitTotal"].DefaultCellStyle.Format = "c";
        }

        private void totalSalesByZipcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblInstruction.Visible = false;
            ds = MainDB.GetQuery("TotalSalesbyZip");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["SalesTotal"].DefaultCellStyle.Format = "c";
        }

        private void totalProfitByZipcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblInstruction.Visible = false;
            ds = MainDB.GetQuery("TotalProfitbyZip");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["ProfitTotal"].DefaultCellStyle.Format = "c";
        }
    }
}
