namespace PS_Billing
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richtxtAbout = new System.Windows.Forms.RichTextBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // richtxtAbout
            // 
            this.richtxtAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.richtxtAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxtAbout.Font = new System.Drawing.Font("Goudy Old Style", 11F);
            this.richtxtAbout.ForeColor = System.Drawing.Color.White;
            this.richtxtAbout.Location = new System.Drawing.Point(125, 4);
            this.richtxtAbout.Name = "richtxtAbout";
            this.richtxtAbout.ReadOnly = true;
            this.richtxtAbout.Size = new System.Drawing.Size(231, 262);
            this.richtxtAbout.TabIndex = 3;
            this.richtxtAbout.Text = "About Program:\n\n*Multiple transaction entry\n*Smilified UI\n*Reports\n*Unique ADMIN " +
    "\n*Add,remove,edit users\n\nCreated:         June 2019\n\nDeveloper:       Nisais_N\n\n" +
    "Email:\t         n.nisais@gmail.com.";
            // 
            // picboxClose
            // 
            this.picboxClose.Image = global::PS_Billing.Properties.Resources.Remove_32x32;
            this.picboxClose.Location = new System.Drawing.Point(310, -1);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(23, 24);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxClose.TabIndex = 22;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(335, 253);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richtxtAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richtxtAbout;
        private System.Windows.Forms.PictureBox picboxClose;
    }
}