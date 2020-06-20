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
    public partial class frmNewStaff : Form
    {
        public frmNewStaff()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtxStaffId.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtPassword.Text = "";
            ComboBoxRoleType.SelectedIndex = 0;

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mysql d1 = new mysql();
            d1.Delete("DELETE FROM ADMIN ");
            d1.add("INSERT INTO ADMIN(val) VALUES('" + 0 + "')");

            this.Close();
            frmAdminDashboard adDash = new frmAdminDashboard();
            adDash.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
             mysql aduser = new mysql();
            string enypw =aduser .MD5Hash(txtPassword.Text);
            MessageBox.Show(aduser.add("INSERT INTO STAFFS(Staff_ID ,First_Name,Last_Name,Address,Contact_No,Password,type ) VALUES('" + txtxStaffId.Text + "','" + txtFirstName.Text + "','" + txtSecondName.Text + "','" + txtAddress.Text + "','" + txtContact.Text + "','" + enypw + "','" + Convert.ToString(ComboBoxRoleType.SelectedItem) + "')"), "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
