namespace PS_Billing
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.lblBill = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblSearchBill = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.picboxInfo = new System.Windows.Forms.PictureBox();
            this.picboxReport = new System.Windows.Forms.PictureBox();
            this.picboxTaxes = new System.Windows.Forms.PictureBox();
            this.picboxAdmin = new System.Windows.Forms.PictureBox();
            this.picboxBill = new System.Windows.Forms.PictureBox();
            this.picboxStaff = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTaxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.Color.White;
            this.lblBill.Location = new System.Drawing.Point(56, 132);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(94, 24);
            this.lblBill.TabIndex = 6;
            this.lblBill.Text = "Create Bill";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.ForeColor = System.Drawing.Color.White;
            this.lblReport.Location = new System.Drawing.Point(332, 132);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(66, 24);
            this.lblReport.TabIndex = 7;
            this.lblReport.Text = "Report";
            // 
            // lblSearchBill
            // 
            this.lblSearchBill.AutoSize = true;
            this.lblSearchBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBill.ForeColor = System.Drawing.Color.White;
            this.lblSearchBill.Location = new System.Drawing.Point(190, 217);
            this.lblSearchBill.Name = "lblSearchBill";
            this.lblSearchBill.Size = new System.Drawing.Size(99, 24);
            this.lblSearchBill.TabIndex = 8;
            this.lblSearchBill.Text = "Search Bill";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(69, 292);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(65, 24);
            this.lblAdmin.TabIndex = 9;
            this.lblAdmin.Text = "Admin";
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.ForeColor = System.Drawing.Color.White;
            this.lblStaff.Location = new System.Drawing.Point(336, 292);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(53, 24);
            this.lblStaff.TabIndex = 10;
            this.lblStaff.Text = "Staffs";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.ForeColor = System.Drawing.Color.White;
            this.lblW.Location = new System.Drawing.Point(377, 1);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(97, 24);
            this.lblW.TabIndex = 20;
            this.lblW.Text = "00:00 AM";
            // 
            // picboxClose
            // 
            this.picboxClose.Image = global::PS_Billing.Properties.Resources.Remove_32x32;
            this.picboxClose.Location = new System.Drawing.Point(489, 1);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(32, 32);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxClose.TabIndex = 21;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picboxInfo
            // 
            this.picboxInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.picboxInfo.Image = ((System.Drawing.Image)(resources.GetObject("picboxInfo.Image")));
            this.picboxInfo.Location = new System.Drawing.Point(471, 270);
            this.picboxInfo.Name = "picboxInfo";
            this.picboxInfo.Size = new System.Drawing.Size(38, 38);
            this.picboxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxInfo.TabIndex = 5;
            this.picboxInfo.TabStop = false;
            this.picboxInfo.Click += new System.EventHandler(this.picboxInfo_Click);
            // 
            // picboxReport
            // 
            this.picboxReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxReport.Image = ((System.Drawing.Image)(resources.GetObject("picboxReport.Image")));
            this.picboxReport.Location = new System.Drawing.Point(326, 36);
            this.picboxReport.Name = "picboxReport";
            this.picboxReport.Size = new System.Drawing.Size(82, 82);
            this.picboxReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxReport.TabIndex = 4;
            this.picboxReport.TabStop = false;
            // 
            // picboxTaxes
            // 
            this.picboxTaxes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxTaxes.Image = ((System.Drawing.Image)(resources.GetObject("picboxTaxes.Image")));
            this.picboxTaxes.Location = new System.Drawing.Point(199, 121);
            this.picboxTaxes.Name = "picboxTaxes";
            this.picboxTaxes.Size = new System.Drawing.Size(82, 82);
            this.picboxTaxes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxTaxes.TabIndex = 3;
            this.picboxTaxes.TabStop = false;
            this.picboxTaxes.Click += new System.EventHandler(this.picboxTaxes_Click);
            // 
            // picboxAdmin
            // 
            this.picboxAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picboxAdmin.Image")));
            this.picboxAdmin.Location = new System.Drawing.Point(60, 201);
            this.picboxAdmin.Name = "picboxAdmin";
            this.picboxAdmin.Size = new System.Drawing.Size(82, 82);
            this.picboxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxAdmin.TabIndex = 2;
            this.picboxAdmin.TabStop = false;
            this.picboxAdmin.Click += new System.EventHandler(this.picboxAdmin_Click);
            // 
            // picboxBill
            // 
            this.picboxBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxBill.Image = ((System.Drawing.Image)(resources.GetObject("picboxBill.Image")));
            this.picboxBill.Location = new System.Drawing.Point(60, 36);
            this.picboxBill.Name = "picboxBill";
            this.picboxBill.Size = new System.Drawing.Size(82, 82);
            this.picboxBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxBill.TabIndex = 1;
            this.picboxBill.TabStop = false;
            this.picboxBill.Click += new System.EventHandler(this.picboxBill_Click);
            // 
            // picboxStaff
            // 
            this.picboxStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxStaff.Image = ((System.Drawing.Image)(resources.GetObject("picboxStaff.Image")));
            this.picboxStaff.Location = new System.Drawing.Point(326, 201);
            this.picboxStaff.Name = "picboxStaff";
            this.picboxStaff.Size = new System.Drawing.Size(82, 82);
            this.picboxStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxStaff.TabIndex = 0;
            this.picboxStaff.TabStop = false;
            this.picboxStaff.Click += new System.EventHandler(this.picboxStaff_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(521, 320);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblSearchBill);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.picboxInfo);
            this.Controls.Add(this.picboxReport);
            this.Controls.Add(this.picboxTaxes);
            this.Controls.Add(this.picboxAdmin);
            this.Controls.Add(this.picboxBill);
            this.Controls.Add(this.picboxStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxTaxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxStaff;
        private System.Windows.Forms.PictureBox picboxBill;
        private System.Windows.Forms.PictureBox picboxAdmin;
        private System.Windows.Forms.PictureBox picboxTaxes;
        private System.Windows.Forms.PictureBox picboxReport;
        private System.Windows.Forms.PictureBox picboxInfo;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblSearchBill;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.PictureBox picboxClose;
    }
}