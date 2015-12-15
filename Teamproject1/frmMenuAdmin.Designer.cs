namespace Teamproject2
{
    partial class frmMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdmin));
            this.btnSales = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnManageZip = new System.Windows.Forms.Button();
            this.btnManageCust = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSales
            // 
            this.btnSales.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Location = new System.Drawing.Point(6, 43);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(234, 30);
            this.btnSales.TabIndex = 9;
            this.btnSales.Text = "Manage Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGoBack.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(6, 115);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(234, 30);
            this.btnGoBack.TabIndex = 8;
            this.btnGoBack.Text = "Log Out";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnManageZip
            // 
            this.btnManageZip.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageZip.Location = new System.Drawing.Point(6, 79);
            this.btnManageZip.Name = "btnManageZip";
            this.btnManageZip.Size = new System.Drawing.Size(234, 30);
            this.btnManageZip.TabIndex = 7;
            this.btnManageZip.Text = "Manage Zipcode";
            this.btnManageZip.UseVisualStyleBackColor = true;
            this.btnManageZip.Click += new System.EventHandler(this.btnManageZip_Click);
            // 
            // btnManageCust
            // 
            this.btnManageCust.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCust.Location = new System.Drawing.Point(6, 7);
            this.btnManageCust.Name = "btnManageCust";
            this.btnManageCust.Size = new System.Drawing.Size(234, 30);
            this.btnManageCust.TabIndex = 6;
            this.btnManageCust.Text = "Manage Customer Info";
            this.btnManageCust.UseVisualStyleBackColor = true;
            this.btnManageCust.Click += new System.EventHandler(this.btnManageCust_Click);
            // 
            // frmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(247, 151);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnManageZip);
            this.Controls.Add(this.btnManageCust);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuAdmin";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnManageZip;
        private System.Windows.Forms.Button btnManageCust;
    }
}