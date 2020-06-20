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
    public partial class frmEditStaff : Form
    {

        public DataTable adddettail;
        public frmEditStaff()
        {
            InitializeComponent();
        }

        string enypw;

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

        private void frmEditStaff_Load(object sender, EventArgs e)
        {
            txtxStaffId.Text = Convert.ToString( adddettail.Rows[0][0]);
            txtFirstName.Text = Convert.ToString(adddettail.Rows[0][1]);
            txtSecondName.Text = Convert.ToString(adddettail.Rows[0][2]);
            txtAddress.Text = Convert.ToString(adddettail.Rows[0][3]);
            txtContact.Text = Convert.ToString(adddettail.Rows[0][4]);
                     

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            mysql d1 = new mysql();
            d1.Delete("DELETE FROM ADMIN ");
            d1.add("INSERT INTO ADMIN(val) VALUES('" + 0 + "')");

            this.Close();
            frmAdminDashboard adash = new frmAdminDashboard();
            adash.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mysql upd1 = new mysql();
            enypw = upd1.MD5Hash(txtPassword.Text);
            MessageBox.Show(upd1.Update("UPDATE STAFFS SET FIRST_NAME ='" + txtFirstName.Text + "',LAST_NAME ='" + txtSecondName.Text + "',ADDRESS ='" + txtAddress.Text + "',CONTACT_NO ='" + txtContact.Text + "',PASSWORD ='" + enypw + "',TYPE ='" +ComboBoxRoleType.SelectedItem + "' WHERE STAFF_ID = '" + txtxStaffId.Text + "' ;"), "Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            mysql d1 = new mysql();
            d1.Delete("DELETE FROM STAFFS WHERE STAFF_ID = '"+txtxStaffId.Text+"'");
        }
    }
}
