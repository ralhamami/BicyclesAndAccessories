namespace Teamproject2
{
    partial class frmManageZip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageZip));
            this.lstZipCode = new System.Windows.Forms.ListBox();
            this.btnAddZip = new System.Windows.Forms.Button();
            this.btnDeleteZip = new System.Windows.Forms.Button();
            this.txtAddZip = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstZipCode
            // 
            this.lstZipCode.FormattingEnabled = true;
            this.lstZipCode.Location = new System.Drawing.Point(112, 12);
            this.lstZipCode.Name = "lstZipCode";
            this.lstZipCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstZipCode.Size = new System.Drawing.Size(117, 95);
            this.lstZipCode.TabIndex = 0;
            // 
            // btnAddZip
            // 
            this.btnAddZip.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddZip.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddZip.Location = new System.Drawing.Point(24, 156);
            this.btnAddZip.Name = "btnAddZip";
            this.btnAddZip.Size = new System.Drawing.Size(112, 23);
            this.btnAddZip.TabIndex = 2;
            this.btnAddZip.Text = "&Add Zipcode";
            this.btnAddZip.UseVisualStyleBackColor = true;
            this.btnAddZip.Click += new System.EventHandler(this.btnAddZip_Click);
            // 
            // btnDeleteZip
            // 
            this.btnDeleteZip.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteZip.Location = new System.Drawing.Point(142, 156);
            this.btnDeleteZip.Name = "btnDeleteZip";
            this.btnDeleteZip.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteZip.TabIndex = 3;
            this.btnDeleteZip.Text = "&Delete Zipcode";
            this.btnDeleteZip.UseVisualStyleBackColor = true;
            this.btnDeleteZip.Click += new System.EventHandler(this.btnDeleteZip_Click);
            // 
            // txtAddZip
            // 
            this.txtAddZip.Location = new System.Drawing.Point(112, 113);
            this.txtAddZip.Name = "txtAddZip";
            this.txtAddZip.Size = new System.Drawing.Size(117, 20);
            this.txtAddZip.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(142, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(24, 185);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zip Codes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Entry:";
            // 
            // frmManageZip
            // 
            this.AcceptButton = this.btnAddZip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(276, 229);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAddZip);
            this.Controls.Add(this.btnDeleteZip);
            this.Controls.Add(this.btnAddZip);
            this.Controls.Add(this.lstZipCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageZip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Zipcode";
            this.Load += new System.EventHandler(this.frmManageZip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstZipCode;
        private System.Windows.Forms.Button btnAddZip;
        private System.Windows.Forms.Button btnDeleteZip;
        private System.Windows.Forms.TextBox txtAddZip;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}