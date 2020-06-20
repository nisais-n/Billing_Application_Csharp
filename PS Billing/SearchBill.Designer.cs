namespace PS_Billing
{
    partial class frmSearchBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchBill));
            this.datagridBillSearch = new System.Windows.Forms.DataGridView();
            this.txtxBillNoSearch = new System.Windows.Forms.TextBox();
            this.lblBillNoSearch = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContactSearch = new System.Windows.Forms.Label();
            this.lblBillDateSearch = new System.Windows.Forms.Label();
            this.lblDateSearch = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddressSearch = new System.Windows.Forms.Label();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.btnSearchBill = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.lblRs = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBillSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridBillSearch
            // 
            this.datagridBillSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.datagridBillSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridBillSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridBillSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridBillSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridBillSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.datagridBillSearch.Location = new System.Drawing.Point(12, 166);
            this.datagridBillSearch.Name = "datagridBillSearch";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridBillSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridBillSearch.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.datagridBillSearch.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridBillSearch.Size = new System.Drawing.Size(627, 287);
            this.datagridBillSearch.TabIndex = 17;
            // 
            // txtxBillNoSearch
            // 
            this.txtxBillNoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxBillNoSearch.Location = new System.Drawing.Point(405, 29);
            this.txtxBillNoSearch.Name = "txtxBillNoSearch";
            this.txtxBillNoSearch.Size = new System.Drawing.Size(124, 22);
            this.txtxBillNoSearch.TabIndex = 35;
            // 
            // lblBillNoSearch
            // 
            this.lblBillNoSearch.AutoSize = true;
            this.lblBillNoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNoSearch.ForeColor = System.Drawing.Color.White;
            this.lblBillNoSearch.Location = new System.Drawing.Point(338, 29);
            this.lblBillNoSearch.Name = "lblBillNoSearch";
            this.lblBillNoSearch.Size = new System.Drawing.Size(53, 20);
            this.lblBillNoSearch.TabIndex = 34;
            this.lblBillNoSearch.Text = "Bill No";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(75, 136);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(158, 22);
            this.txtContact.TabIndex = 33;
            // 
            // lblContactSearch
            // 
            this.lblContactSearch.AutoSize = true;
            this.lblContactSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactSearch.ForeColor = System.Drawing.Color.White;
            this.lblContactSearch.Location = new System.Drawing.Point(8, 136);
            this.lblContactSearch.Name = "lblContactSearch";
            this.lblContactSearch.Size = new System.Drawing.Size(65, 20);
            this.lblContactSearch.TabIndex = 32;
            this.lblContactSearch.Text = "Contact";
            // 
            // lblBillDateSearch
            // 
            this.lblBillDateSearch.AutoSize = true;
            this.lblBillDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDateSearch.ForeColor = System.Drawing.Color.White;
            this.lblBillDateSearch.Location = new System.Drawing.Point(391, 61);
            this.lblBillDateSearch.Name = "lblBillDateSearch";
            this.lblBillDateSearch.Size = new System.Drawing.Size(13, 20);
            this.lblBillDateSearch.TabIndex = 31;
            this.lblBillDateSearch.Text = ".";
            // 
            // lblDateSearch
            // 
            this.lblDateSearch.AutoSize = true;
            this.lblDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSearch.ForeColor = System.Drawing.Color.White;
            this.lblDateSearch.Location = new System.Drawing.Point(338, 61);
            this.lblDateSearch.Name = "lblDateSearch";
            this.lblDateSearch.Size = new System.Drawing.Size(44, 20);
            this.lblDateSearch.TabIndex = 30;
            this.lblDateSearch.Text = "Date";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(75, 61);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(242, 68);
            this.txtAddress.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(75, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 22);
            this.txtName.TabIndex = 28;
            // 
            // lblAddressSearch
            // 
            this.lblAddressSearch.AutoSize = true;
            this.lblAddressSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressSearch.ForeColor = System.Drawing.Color.White;
            this.lblAddressSearch.Location = new System.Drawing.Point(8, 61);
            this.lblAddressSearch.Name = "lblAddressSearch";
            this.lblAddressSearch.Size = new System.Drawing.Size(68, 20);
            this.lblAddressSearch.TabIndex = 27;
            this.lblAddressSearch.Text = "Address";
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSearch.ForeColor = System.Drawing.Color.White;
            this.lblNameSearch.Location = new System.Drawing.Point(8, 29);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(51, 20);
            this.lblNameSearch.TabIndex = 26;
            this.lblNameSearch.Text = "Name";
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.BackColor = System.Drawing.Color.Snow;
            this.btnSearchBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBill.Location = new System.Drawing.Point(362, 132);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(99, 26);
            this.btnSearchBill.TabIndex = 36;
            this.btnSearchBill.Text = "&Search";
            this.btnSearchBill.UseVisualStyleBackColor = false;
            this.btnSearchBill.Click += new System.EventHandler(this.btnSearchBill_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Snow;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(485, 132);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 26);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.lblPaymentMethod.Location = new System.Drawing.Point(338, 94);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(129, 20);
            this.lblPaymentMethod.TabIndex = 38;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentMethod.Location = new System.Drawing.Point(473, 94);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.Size = new System.Drawing.Size(124, 22);
            this.txtPaymentMethod.TabIndex = 39;
            // 
            // picboxClose
            // 
            this.picboxClose.Image = global::PS_Billing.Properties.Resources.Remove_32x32;
            this.picboxClose.Location = new System.Drawing.Point(620, -1);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(32, 32);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxClose.TabIndex = 40;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // lblRs
            // 
            this.lblRs.AutoSize = true;
            this.lblRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRs.ForeColor = System.Drawing.Color.White;
            this.lblRs.Location = new System.Drawing.Point(507, 463);
            this.lblRs.Name = "lblRs";
            this.lblRs.Size = new System.Drawing.Size(29, 17);
            this.lblRs.TabIndex = 43;
            this.lblRs.Text = "Rs.";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(536, 457);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(103, 26);
            this.txtTotal.TabIndex = 42;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(413, 463);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 22);
            this.lblTotal.TabIndex = 41;
            this.lblTotal.Text = "TOTAL";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW.ForeColor = System.Drawing.Color.White;
            this.lblW.Location = new System.Drawing.Point(521, -1);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(97, 24);
            this.lblW.TabIndex = 44;
            this.lblW.Text = "00:00 AM";
            // 
            // frmSearchBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(651, 490);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblRs);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.txtPaymentMethod);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.btnSearchBill);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtxBillNoSearch);
            this.Controls.Add(this.lblBillNoSearch);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContactSearch);
            this.Controls.Add(this.lblBillDateSearch);
            this.Controls.Add(this.lblDateSearch);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAddressSearch);
            this.Controls.Add(this.lblNameSearch);
            this.Controls.Add(this.datagridBillSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearchBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBill";
            ((System.ComponentModel.ISupportInitialize)(this.datagridBillSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridBillSearch;
        private System.Windows.Forms.TextBox txtxBillNoSearch;
        private System.Windows.Forms.Label lblBillNoSearch;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContactSearch;
        private System.Windows.Forms.Label lblBillDateSearch;
        private System.Windows.Forms.Label lblDateSearch;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddressSearch;
        private System.Windows.Forms.Label lblNameSearch;
        private System.Windows.Forms.Button btnSearchBill;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.Label lblRs;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblW;
    }
}