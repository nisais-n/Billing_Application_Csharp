using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace PS_Billing
{
    
    public partial class frmLogin : Form
    {
        public string us;
        
        public frmLogin()
        {
            InitializeComponent();
            lblW.Text = DateTime.Now.ToString("hh:mm tt");
        }

           
        private void cleartext()
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            lblwarning1.Visible = false;
            lblwarning2.Visible = false;
            txtusername.Focus(); 
        }

       


        private void frmlogin_Load(object sender, EventArgs e) 
        {
                         mysql m1 = new mysql();
            string un = txtusername.Text, pw = m1.MD5Hash(txtpassword.Text);
            DataTable dt1;
            dt1 = m1.select("select * from staffs");
            int x = 0;
            foreach (DataRow dr in dt1.Rows)
            {
                if(dt1.Rows[x][0].ToString()==un)
                {
                    if(dt1.Rows[x][6].ToString() == "admin")
                    {
                        us = "admin";
                                             
                    }

                    if (dt1.Rows[x][5].ToString() == pw)
                    {
                        mysql usl = new mysql();
                        m1.add("INSERT INTO CURRENT(type) VALUES('" +us+ "')");
                        frmHome fh = new frmHome();
                        this.Hide();
                        if (us == "admin")
                        {
                           MessageBox.Show("Admin Login", "Login Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Staff Login", "Login Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        fh.Show();
                    }
                    else
                    {
                        lblwarning1.Visible = true;
                    }
                }
                else
                {
                    lblwarning2.Visible = true;
                }               
                x++;
            }
           }
       
        
        
        private void btnclear_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mysql d1 = new mysql();
            d1.Delete("DELETE FROM CURRENT ");
            d1.Delete("DELETE FROM ADMIN ");
            d1.add("INSERT INTO ADMIN(val) VALUES('" +0+"')");
            Application.Exit();
        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {

        }

    }
}