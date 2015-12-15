namespace Teamproject2
{
    partial class frmSalesData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesData));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesTotaledByCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profitTotaledByCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalSalesByProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalProfitByProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalSalesByZipcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalProfitByZipcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataSourceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(366, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataSourceToolStripMenuItem
            // 
            this.dataSourceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesTotaledByCustomerToolStripMenuItem,
            this.profitTotaledByCustomerToolStripMenuItem,
            this.totalSalesByProductToolStripMenuItem,
            this.totalProfitByProductToolStripMenuItem,
            this.totalSalesByZipcodeToolStripMenuItem,
            this.totalProfitByZipcodeToolStripMenuItem});
            this.dataSourceToolStripMenuItem.Name = "dataSourceToolStripMenuItem";
            this.dataSourceToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.dataSourceToolStripMenuItem.Text = "Data Source";
            // 
            // salesTotaledByCustomerToolStripMenuItem
            // 
            this.salesTotaledByCustomerToolStripMenuItem.Name = "salesTotaledByCustomerToolStripMenuItem";
            this.salesTotaledByCustomerToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.salesTotaledByCustomerToolStripMenuItem.Text = "Sales Totaled by Customer";
            this.salesTotaledByCustomerToolStripMenuItem.Click += new System.EventHandler(this.salesTotaledByCustomerToolStripMenuItem_Click);
            // 
            // profitTotaledByCustomerToolStripMenuItem
            // 
            this.profitTotaledByCustomerToolStripMenuItem.Name = "profitTotaledByCustomerToolStripMenuItem";
            this.profitTotaledByCustomerToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.profitTotaledByCustomerToolStripMenuItem.Text = "Profit Totaled by Customer";
            this.profitTotaledByCustomerToolStripMenuItem.Click += new System.EventHandler(this.profitTotaledByCustomerToolStripMenuItem_Click);
            // 
            // totalSalesByProductToolStripMenuItem
            // 
            this.totalSalesByProductToolStripMenuItem.Name = "totalSalesByProductToolStripMenuItem";
            this.totalSalesByProductToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.totalSalesByProductToolStripMenuItem.Text = "Total Sales by Product";
            this.totalSalesByProductToolStripMenuItem.Click += new System.EventHandler(this.totalSalesByProductToolStripMenuItem_Click);
            // 
            // totalProfitByProductToolStripMenuItem
            // 
            this.totalProfitByProductToolStripMenuItem.Name = "totalProfitByProductToolStripMenuItem";
            this.totalProfitByProductToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.totalProfitByProductToolStripMenuItem.Text = "Total Profit by Product";
            this.totalProfitByProductToolStripMenuItem.Click += new System.EventHandler(this.totalProfitByProductToolStripMenuItem_Click);
            // 
            // totalSalesByZipcodeToolStripMenuItem
            // 
            this.totalSalesByZipcodeToolStripMenuItem.Name = "totalSalesByZipcodeToolStripMenuItem";
            this.totalSalesByZipcodeToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.totalSalesByZipcodeToolStripMenuItem.Text = "Total Sales by Zipcode";
            this.totalSalesByZipcodeToolStripMenuItem.Click += new System.EventHandler(this.totalSalesByZipcodeToolStripMenuItem_Click);
            // 
            // totalProfitByZipcodeToolStripMenuItem
            // 
            this.totalProfitByZipcodeToolStripMenuItem.Name = "totalProfitByZipcodeToolStripMenuItem";
            this.totalProfitByZipcodeToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.totalProfitByZipcodeToolStripMenuItem.Text = "Total Profit by Zipcode";
            this.totalProfitByZipcodeToolStripMenuItem.Click += new System.EventHandler(this.totalProfitByZipcodeToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(366, 237);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblInstruction
            // 
            this.lblInstruction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(16, 113);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(334, 46);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "Please select a Data Source from the menu...";
            // 
            // frmSalesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 261);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSalesData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Data";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesTotaledByCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profitTotaledByCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalSalesByProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalProfitByProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalSalesByZipcodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalProfitByZipcodeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblInstruction;
    }
}