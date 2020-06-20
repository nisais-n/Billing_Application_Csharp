using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PS_Billing
{
    public partial class frmSearchBill : Form
    {
        public frmSearchBill()
        {
            InitializeComponent();
            lblW.Text = DateTime.Now.ToString("hh:mm tt");
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtContact.Enabled = false;
            txtPaymentMethod.Enabled = false;
            txtTotal.Enabled = false;
         }

        private void refresh()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtxBillNoSearch.Text = "";
            txtPaymentMethod.Text = "";
            lblBillDateSearch.Text = "";
            txtTotal.Text = "";
            datagridBillSearch.DataSource = "";
        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome nH = new frmHome();
            nH.Show();
        }

        private void billDetailSearch()
        {
            fillData();
            fillTextboxes();   
        }

        private void fillData()
        {
            try
            {
                mysql m3 = new mysql();
                DataTable dt3;

                if (txtxBillNoSearch.Text != "")
                {
                    dt3 = m3.select("SELECT taxid as 'TAX No',detail as 'TAX Name', taxvalue as 'TAX Value' FROM billdetail WHERE bill_no like '%" + txtxBillNoSearch.Text + "%' ");
                    datagridBillSearch.DataSource = dt3;
                    datagridBillSearch.Columns[0].Width = 70;
                    datagridBillSearch.Columns[1].Width = 480;
                    datagridBillSearch.Columns[2].Width = 89;
                    datagridBillSearch.Columns[0].ReadOnly = true;
                    datagridBillSearch.Columns[1].ReadOnly = true;
                    datagridBillSearch.Columns[2].ReadOnly = true;
                    datagridBillSearch.DataSource = dt3;


                }
                else
                {
                    MessageBox.Show("Enter a valid bill number!!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void fillTextboxes()
        {
            try
            {
                mysql m3 = new mysql();
                DataTable dt1;

                if (txtxBillNoSearch.Text != "")
                {
                      dt1 = (m3.select("SELECT name FROM bills WHERE bill_no like '%" + txtxBillNoSearch.Text + "%' "));
                      txtName.Text = Convert.ToString( dt1.Rows[0][0]);

                      dt1 = (m3.select("SELECT address FROM bills WHERE bill_no like '%" + txtxBillNoSearch.Text + "%' "));
                      txtAddress.Text = Convert.ToString(dt1.Rows[0][0]);

                     dt1 = (m3.select("SELECT contact FROM bills WHERE bill_no like '%" + txtxBillNoSearch.Text + "%' "));
                     txtContact.Text = Convert.ToString(dt1.Rows[0][0]);

                     dt1 = (m3.select("SELECT date FROM bills WHERE bill_no like '%" + txtxBillNoSearch.Text + "%' "));
                     lblBillDateSearch.Text = Convert.ToString(dt1.Rows[0][0]);

                     dt1 = (m3.select("SELECT payment FROM bills WHERE bill_no like '%" + txtxBillNoSearch.Text + "%' "));
                     txtPaymentMethod.Text = Convert.ToString(dt1.Rows[0][0]);

                     dt1 = (m3.select("SELECT total FROM bills WHERE bill_no like '%" + txtxBillNoSearch.Text + "%' "));
                     txtTotal.Text = Convert.ToString(dt1.Rows[0][0]);

                }
                else
                {
                    MessageBox.Show("Enter a valid bill number!!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            billDetailSearch();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
