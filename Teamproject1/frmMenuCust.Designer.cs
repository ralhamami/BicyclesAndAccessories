namespace Teamproject2
{
    partial class frmMenuCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuCust));
            this.btnManageCust = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageCust
            // 
            this.btnManageCust.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCust.Location = new System.Drawing.Point(7, 3);
            this.btnManageCust.Name = "btnManageCust";
            this.btnManageCust.Size = new System.Drawing.Size(234, 30);
            this.btnManageCust.TabIndex = 1;
            this.btnManageCust.Text = "Manage Customer Info";
            this.btnManageCust.UseVisualStyleBackColor = true;
            this.btnManageCust.Click += new System.EventHandler(this.btnManageCust_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGoBack.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(7, 75);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(234, 30);
            this.btnGoBack.TabIndex = 3;
            this.btnGoBack.Text = "Log Out";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(7, 39);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(234, 30);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Make an Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // frmMenuCust
            // 
            this.AcceptButton = this.btnManageCust;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnGoBack;
            this.ClientSize = new System.Drawing.Size(247, 108);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnManageCust);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuCust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageCust;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnOrder;
    }
}