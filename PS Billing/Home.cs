using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_Billing
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            lblW.Text = DateTime.Now.ToString("hh:mm tt");
            picboxAdmin.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mysql d1 = new mysql();
            d1.Delete("DELETE FROM CURRENT ");
            d1.Delete("DELETE FROM ADMIN ");
            d1.add("INSERT INTO ADMIN(val) VALUES('" + 0 + "')");
            this.Hide();
            frmLogin nl = new frmLogin();
            nl.Show();
        }

        private void picboxBill_Click(object sender, EventArgs e)
        {
            frmTaxDetails fd = new frmTaxDetails();
            fd.ShowDialog();
            this.Hide();
        }

        private void picboxInfo_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.ShowDialog();
        }

        private void picboxTaxes_Click(object sender, EventArgs e)
        {
            frmSearchBill srcBill = new frmSearchBill();
            srcBill.ShowDialog();
            this.Hide();
        }

        private void picboxStaff_Click(object sender, EventArgs e)
        {
            frmStaffs stdt = new frmStaffs();
            stdt.Show();
            this.Hide();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            mysql usl = new mysql();
            DataTable dtusl;
            dtusl = usl.select("SELECT type FROM CURRENT");
            foreach (DataRow dr in dtusl.Rows)
            {
                if (dtusl.Rows[0][0].ToString() == "admin")
                {
                    picboxAdmin.Enabled = true;
                }
            }
        }

        private void picboxAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminDashboard adDash = new frmAdminDashboard();
            adDash.ShowDialog();
           // this.Hide();
        }
    }
}

