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
    public partial class frmadd : Form
    {
        public frmadd()
        {
            InitializeComponent();
            txtboxtaxno.Focus();
        }

        private void cleartext()
        {
            txtboxtaxno.Text = "";
            txtboxtaxname.Text = "";
            txtValue.Text = "";
            txtboxtaxno.Focus();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            mysql m1 = new mysql();
            MessageBox.Show(m1.add("INSERT INTO TAX(taxid,taxname,Value) VALUES('" + txtboxtaxno.Text + "','" + txtboxtaxname.Text + "','"+txtValue.Text+"')"),"Done",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

                  this.Close();
            frmTaxDetails ft = new frmTaxDetails();
            ft.Show();
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cleartext();
        }
    }
}
