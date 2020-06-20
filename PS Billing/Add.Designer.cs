namespace PS_Billing
{
    partial class frmadd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadd));
            this.lbltaxnmae = new System.Windows.Forms.Label();
            this.lbltxtNo = new System.Windows.Forms.Label();
            this.txtboxtaxno = new System.Windows.Forms.TextBox();
            this.txtboxtaxname = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltaxnmae
            // 
            this.lbltaxnmae.AutoSize = true;
            this.lbltaxnmae.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaxnmae.ForeColor = System.Drawing.Color.White;
            this.lbltaxnmae.Location = new System.Drawing.Point(182, 86);
            this.lbltaxnmae.Name = "lbltaxnmae";
            this.lbltaxnmae.Size = new System.Drawing.Size(76, 16);
            this.lbltaxnmae.TabIndex = 9;
            this.lbltaxnmae.Text = "TAX.NAME";
            // 
            // lbltxtNo
            // 
            this.lbltxtNo.AutoSize = true;
            this.lbltxtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltxtNo.ForeColor = System.Drawing.Color.White;
            this.lbltxtNo.Location = new System.Drawing.Point(27, 86);
            this.lbltxtNo.Name = "lbltxtNo";
            this.lbltxtNo.Size = new System.Drawing.Size(57, 16);
            this.lbltxtNo.TabIndex = 8;
            this.lbltxtNo.Text = "TAX.NO";
            // 
            // txtboxtaxno
            // 
            this.txtboxtaxno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxtaxno.Location = new System.Drawing.Point(17, 57);
            this.txtboxtaxno.Name = "txtboxtaxno";
            this.txtboxtaxno.Size = new System.Drawing.Size(86, 26);
            this.txtboxtaxno.TabIndex = 0;
            // 
            // txtboxtaxname
            // 
            this.txtboxtaxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxtaxname.Location = new System.Drawing.Point(114, 57);
            this.txtboxtaxname.Name = "txtboxtaxname";
            this.txtboxtaxname.Size = new System.Drawing.Size(435, 26);
            this.txtboxtaxname.TabIndex = 1;
            this.txtboxtaxname.Text = " ";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Snow;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(335, 96);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(99, 26);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Snow;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(458, 96);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(99, 26);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PS_Billing.Properties.Resources.Remove_32x32;
            this.pictureBox2.Location = new System.Drawing.Point(637, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(574, 86);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(52, 16);
            this.lblValue.TabIndex = 21;
            this.lblValue.Text = "VALUE";
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(559, 57);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(86, 26);
            this.txtValue.TabIndex = 2;
            // 
            // frmadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(682, 151);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lbltaxnmae);
            this.Controls.Add(this.lbltxtNo);
            this.Controls.Add(this.txtboxtaxno);
            this.Controls.Add(this.txtboxtaxname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 83);
            this.Name = "frmadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltaxnmae;
        private System.Windows.Forms.Label lbltxtNo;
        private System.Windows.Forms.TextBox txtboxtaxno;
        private System.Windows.Forms.TextBox txtboxtaxname;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblValue;
  
    }
}