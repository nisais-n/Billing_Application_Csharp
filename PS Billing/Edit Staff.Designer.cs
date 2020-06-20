namespace PS_Billing
{
    partial class frmEditStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditStaff));
            this.lblHeading2 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFrmHeading = new System.Windows.Forms.Label();
            this.lblRoleType = new System.Windows.Forms.Label();
            this.ComboBoxRoleType = new System.Windows.Forms.ComboBox();
            this.lblSname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtxStaffId = new System.Windows.Forms.TextBox();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading2
            // 
            this.lblHeading2.AutoSize = true;
            this.lblHeading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHeading2.ForeColor = System.Drawing.Color.White;
            this.lblHeading2.Location = new System.Drawing.Point(144, 41);
            this.lblHeading2.Name = "lblHeading2";
            this.lblHeading2.Size = new System.Drawing.Size(241, 20);
            this.lblHeading2.TabIndex = 9;
            this.lblHeading2.Text = "PINNADUWA,WALAHANDUWA";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(113, 16);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(327, 25);
            this.lblHeading.TabIndex = 7;
            this.lblHeading.Text = "AKMIMANA PRADESHIYA SABA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHeading2);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 92);
            this.panel1.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblFrmHeading
            // 
            this.lblFrmHeading.AutoSize = true;
            this.lblFrmHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblFrmHeading.ForeColor = System.Drawing.Color.White;
            this.lblFrmHeading.Location = new System.Drawing.Point(5, 100);
            this.lblFrmHeading.Name = "lblFrmHeading";
            this.lblFrmHeading.Size = new System.Drawing.Size(101, 26);
            this.lblFrmHeading.TabIndex = 72;
            this.lblFrmHeading.Text = "Edit Staff";
            // 
            // lblRoleType
            // 
            this.lblRoleType.AutoSize = true;
            this.lblRoleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleType.ForeColor = System.Drawing.Color.White;
            this.lblRoleType.Location = new System.Drawing.Point(204, 188);
            this.lblRoleType.Name = "lblRoleType";
            this.lblRoleType.Size = new System.Drawing.Size(81, 20);
            this.lblRoleType.TabIndex = 70;
            this.lblRoleType.Text = "User Type";
            // 
            // ComboBoxRoleType
            // 
            this.ComboBoxRoleType.FormattingEnabled = true;
            this.ComboBoxRoleType.Items.AddRange(new object[] {
            "staff",
            "admin"});
            this.ComboBoxRoleType.Location = new System.Drawing.Point(291, 187);
            this.ComboBoxRoleType.Name = "ComboBoxRoleType";
            this.ComboBoxRoleType.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxRoleType.TabIndex = 69;
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSname.ForeColor = System.Drawing.Color.White;
            this.lblSname.Location = new System.Drawing.Point(251, 166);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(106, 16);
            this.lblSname.TabIndex = 68;
            this.lblSname.Text = "Second Name";
            this.lblSname.Visible = false;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.White;
            this.lblFname.Location = new System.Drawing.Point(69, 165);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(83, 16);
            this.lblFname.TabIndex = 67;
            this.lblFname.Text = "First Name";
            this.lblFname.Visible = false;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.Location = new System.Drawing.Point(254, 141);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(158, 22);
            this.txtSecondName.TabIndex = 66;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Snow;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(6, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 26);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Snow;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(129, 363);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 26);
            this.btnClear.TabIndex = 65;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtxStaffId
            // 
            this.txtxStaffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxStaffId.Location = new System.Drawing.Point(68, 187);
            this.txtxStaffId.Name = "txtxStaffId";
            this.txtxStaffId.ReadOnly = true;
            this.txtxStaffId.Size = new System.Drawing.Size(124, 22);
            this.txtxStaffId.TabIndex = 63;
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffId.ForeColor = System.Drawing.Color.White;
            this.lblStaffId.Location = new System.Drawing.Point(1, 187);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(62, 20);
            this.lblStaffId.TabIndex = 62;
            this.lblStaffId.Text = "Staff Id";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(68, 295);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(158, 22);
            this.txtContact.TabIndex = 61;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.White;
            this.lblContact.Location = new System.Drawing.Point(1, 295);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(65, 20);
            this.lblContact.TabIndex = 60;
            this.lblContact.Text = "Contact";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(68, 220);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(242, 68);
            this.txtAddress.TabIndex = 59;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(68, 141);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(158, 22);
            this.txtFirstName.TabIndex = 58;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(1, 220);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 57;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(1, 141);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "Name";
            // 
            // picClose
            // 
            this.picClose.Image = global::PS_Billing.Properties.Resources.Remove_32x32;
            this.picClose.Location = new System.Drawing.Point(437, 1);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(32, 32);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 73;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Snow;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(255, 363);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(99, 26);
            this.btndelete.TabIndex = 74;
            this.btndelete.Text = "&Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(145, 326);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(158, 22);
            this.txtPassword.TabIndex = 76;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(1, 326);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(138, 20);
            this.lblPassword.TabIndex = 75;
            this.lblPassword.Text = "Change Password";
            // 
            // frmEditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(474, 401);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFrmHeading);
            this.Controls.Add(this.lblRoleType);
            this.Controls.Add(this.ComboBoxRoleType);
            this.Controls.Add(this.lblSname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtxStaffId);
            this.Controls.Add(this.lblStaffId);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Staff";
            this.Load += new System.EventHandler(this.frmEditStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblHeading2;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFrmHeading;
        private System.Windows.Forms.Label lblRoleType;
        private System.Windows.Forms.ComboBox ComboBoxRoleType;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtxStaffId;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}