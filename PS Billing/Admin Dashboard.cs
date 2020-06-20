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
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }
        
        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewStaff nSt = new frmNewStaff();
             nSt.Show();
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mysql adPri = new mysql();
            adPri.add("INSERT INTO ADMIN(val) VALUES('" + "1" + "')");
            this.Close();
            frmHome fh = new frmHome();
            fh.Show();
        }

        private void btnEditTaxes_Click(object sender, EventArgs e)
        {
            this.Hide();
            mysql adPri = new mysql();
            adPri.add("INSERT INTO ADMIN(val) VALUES('" + "1" + "')");
            frmTaxDetails txDt = new frmTaxDetails();
            txDt.Show();
            
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            mysql adPri = new mysql();
            adPri.Delete("DELETE FROM ADMIN ");
            adPri.add("INSERT INTO ADMIN(val) VALUES('" + "1" + "')");
            frmStaffs edSt = new frmStaffs();
            edSt.Show();
            
        }
    }
}
