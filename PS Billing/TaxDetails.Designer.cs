using System.Windows.Forms;

namespace PS_Billing
{
    partial class frmTaxDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaxDetails));
            this.datagridviewtax = new System.Windows.Forms.DataGridView();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchNo = new System.Windows.Forms.TextBox();
            this.lbltxtNo = new System.Windows.Forms.Label();
            this.lbltaxnmae = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.pnlcontrols = new System.Windows.Forms.Panel();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.lblUpdateValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblUpdatetaxname = new System.Windows.Forms.Label();
            this.lblUpdateTaxNo = new System.Windows.Forms.Label();
            this.txtboxtaxno = new System.Windows.Forms.TextBox();
            this.txtboxtaxname = new System.Windows.Forms.TextBox();
            this.lblW = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewtax)).BeginInit();
            this.pnlcontrols.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridviewtax
            // 
            this.datagridviewtax.AllowUserToAddRows = false;
            this.datagridviewtax.AllowUserToDeleteRows = false;
            this.datagridviewtax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewtax.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagridviewtax.Location = new System.Drawing.Point(0, 111);
            this.datagridviewtax.Name = "datagridviewtax";
            this.datagridviewtax.RowHeadersVisible = false;
            this.datagridviewtax.Size = new System.Drawing.Size(682, 304);
            this.datagridviewtax.TabIndex = 5;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.Color.White;
            this.lblsearch.Location = new System.Drawing.Point(6, 38);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(66, 20);
            this.lblsearch.TabIndex = 1;
            this.lblsearch.Text = "Search";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(183, 35);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(217, 26);
            this.txtSearchName.TabIndex = 2;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // txtSearchNo
            // 
            this.txtSearchNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchNo.Location = new System.Drawing.Point(78, 35);
            this.txtSearchNo.Name = "txtSearchNo";
            this.txtSearchNo.Size = new System.Drawing.Size(86, 26);
            this.txtSearchNo.TabIndex = 1;
            this.txtSearchNo.TextChanged += new System.EventHandler(this.txtSearchNo_TextChanged);
            // 
            // lbltxtNo
            // 
            this.lbltxtNo.AutoSize = true;
            this.lbltxtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtNo.ForeColor = System.Drawing.Color.White;
            this.lbltxtNo.Location = new System.Drawing.Point(88, 64);
            this.lbltxtNo.Name = "lbltxtNo";
            this.lbltxtNo.Size = new System.Drawing.Size(57, 16);
            this.lbltxtNo.TabIndex = 4;
            this.lbltxtNo.Text = "TAX.NO";
            // 
            // lbltaxnmae
            // 
            this.lbltaxnmae.AutoSize = true;
            this.lbltaxnmae.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaxnmae.ForeColor = System.Drawing.Color.White;
            this.lbltaxnmae.Location = new System.Drawing.Point(243, 64);
            this.lbltaxnmae.Name = "lbltaxnmae";
            this.lbltaxnmae.Size = new System.Drawing.Size(76, 16);
            this.lbltaxnmae.TabIndex = 5;
            this.lbltaxnmae.Text = "TAX.NAME";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Snow;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(19, 13);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(99, 26);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "New Tax";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Snow;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(395, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 26);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Snow;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(269, 13);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(99, 26);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Select";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Snow;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(145, 13);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(99, 26);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // pnlcontrols
            // 
            this.pnlcontrols.Controls.Add(this.btnclear);
            this.pnlcontrols.Controls.Add(this.btnadd);
            this.pnlcontrols.Controls.Add(this.btndelete);
            this.pnlcontrols.Controls.Add(this.btnSave);
            this.pnlcontrols.Controls.Add(this.btnupdate);
            this.pnlcontrols.Location = new System.Drawing.Point(27, 76);
            this.pnlcontrols.Name = "pnlcontrols";
            this.pnlcontrols.Size = new System.Drawing.Size(613, 53);
            this.pnlcontrols.TabIndex = 4;
            // 
            // picboxClose
            // 
            this.picboxClose.Image = global::PS_Billing.Properties.Resources.Remove_32x32;
            this.picboxClose.Location = new System.Drawing.Point(650, 1);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(32, 32);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxClose.TabIndex = 22;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Snow;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(416, 35);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(99, 26);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(547, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Refresh");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.lblUpdateValue);
            this.panelUpdate.Controls.Add(this.txtValue);
            this.panelUpdate.Controls.Add(this.lblUpdatetaxname);
            this.panelUpdate.Controls.Add(this.pnlcontrols);
            this.panelUpdate.Controls.Add(this.lblUpdateTaxNo);
            this.panelUpdate.Controls.Add(this.txtboxtaxno);
            this.panelUpdate.Controls.Add(this.txtboxtaxname);
            this.panelUpdate.Location = new System.Drawing.Point(0, 83);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(682, 151);
            this.panelUpdate.TabIndex = 25;
            // 
            // lblUpdateValue
            // 
            this.lblUpdateValue.AutoSize = true;
            this.lblUpdateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateValue.ForeColor = System.Drawing.Color.White;
            this.lblUpdateValue.Location = new System.Drawing.Point(584, 57);
            this.lblUpdateValue.Name = "lblUpdateValue";
            this.lblUpdateValue.Size = new System.Drawing.Size(52, 16);
            this.lblUpdateValue.TabIndex = 27;
            this.lblUpdateValue.Text = "VALUE";
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(569, 28);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(86, 26);
            this.txtValue.TabIndex = 24;
            // 
            // lblUpdatetaxname
            // 
            this.lblUpdatetaxname.AutoSize = true;
            this.lblUpdatetaxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatetaxname.ForeColor = System.Drawing.Color.White;
            this.lblUpdatetaxname.Location = new System.Drawing.Point(192, 57);
            this.lblUpdatetaxname.Name = "lblUpdatetaxname";
            this.lblUpdatetaxname.Size = new System.Drawing.Size(76, 16);
            this.lblUpdatetaxname.TabIndex = 26;
            this.lblUpdatetaxname.Text = "TAX.NAME";
            // 
            // lblUpdateTaxNo
            // 
            this.lblUpdateTaxNo.AutoSize = true;
            this.lblUpdateTaxNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTaxNo.ForeColor = System.Drawing.Color.White;
            this.lblUpdateTaxNo.Location = new System.Drawing.Point(37, 57);
            this.lblUpdateTaxNo.Name = "lblUpdateTaxNo";
            this.lblUpdateTaxNo.Size = new System.Drawing.Size(57, 16);
            this.lblUpdateTaxNo.TabIndex = 25;
            this.lblUpdateTaxNo.Text = "TAX.NO";
            // 
            // txtboxtaxno
            // 
            this.txtboxtaxno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxtaxno.Location = new System.Drawing.Point(27, 28);
            this.txtboxtaxno.Name = "txtboxtaxno";
            this.txtboxtaxno.ReadOnly = true;
            this.txtboxtaxno.Size = new System.Drawing.Size(86, 26);
            this.txtboxtaxno.TabIndex = 22;
            // 
            // txtboxtaxname
            // 
            this.txtboxtaxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxtaxname.Location = new System.Drawing.Point(124, 28);
            this.txtboxtaxname.Name = "txtboxtaxname";
            this.txtboxtaxname.ReadOnly = true;
            this.txtboxtaxname.Size = new System.Drawing.Size(435, 26);
            this.txtboxtaxname.TabIndex = 23;
            this.txtboxtaxname.Text = " ";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.ForeColor = System.Drawing.Color.White;
            this.lblW.Location = new System.Drawing.Point(543, -2);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(97, 24);
            this.lblW.TabIndex = 26;
            this.lblW.Text = "00:00 AM";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Snow;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(510, 13);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(99, 26);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // frmTaxDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(685, 418);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.lbltaxnmae);
            this.Controls.Add(this.lbltxtNo);
            this.Controls.Add(this.txtSearchNo);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.datagridviewtax);
            this.Controls.Add(this.btnAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTaxDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax Details";
            this.Load += new System.EventHandler(this.frmtaxdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewtax)).EndInit();
            this.pnlcontrols.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridviewtax;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchNo;
        private System.Windows.Forms.Label lbltxtNo;
        private System.Windows.Forms.Label lbltaxnmae;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel pnlcontrols;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.Button btnAddUser;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private Panel panelUpdate;
        private Label lblUpdateValue;
        private TextBox txtValue;
        private Label lblUpdatetaxname;
        private Label lblUpdateTaxNo;
        private TextBox txtboxtaxno;
        private TextBox txtboxtaxname;
        private Label lblW;
        private Button btnclear;
    }
}