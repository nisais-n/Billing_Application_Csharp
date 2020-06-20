using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace PS_Billing
{
    public partial class frmTaxDetails : Form
    {

        public frmTaxDetails()
        {
            InitializeComponent();
            lblW.Text = DateTime.Now.ToString("hh:mm tt");
        }
        
        

        #region refresh
        public void refresh()
        {
            mysql m2 = new mysql();
            DataTable dt2;
            dt2 = m2.select("SELECT taxid as 'TAX No',taxname as 'TAX Name', value as 'TAX Value' FROM TAX");
            datagridviewtax.DataSource = dt2;
            datagridviewtax.RowsDefaultCellStyle.BackColor = Color.LightYellow;
            datagridviewtax.Columns[0].Width = 40;
            datagridviewtax.Columns[1].Width = 70;
            datagridviewtax.Columns[2].Width = 480;
            datagridviewtax.Columns[3].Width = 89;
            datagridviewtax.Columns[1].ReadOnly = true;
            datagridviewtax.Columns[2].ReadOnly = true;
            datagridviewtax.Columns[3].ReadOnly = true;

        }
        #endregion

        #region frmload
        private void frmtaxdetails_Load(object sender, EventArgs e)
        {

            mysql usl = new mysql();
            DataTable adsel;
            adsel = usl.select("SELECT type FROM CURRENT");
            foreach (DataRow dr in adsel.Rows)
            {
                if (adsel.Rows[0][0].ToString() == "admin")
                {

                    panelUpdate.Visible = true;
                    datagridviewtax.Location = new Point(0, 235);
                }
                else
                {

                    panelUpdate.Visible = false;
                    datagridviewtax.Location = new Point(0, 111);
                }
            }



            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            datagridviewtax.Columns.Add(chk);
            chk.HeaderText = "Select";
            chk.Name = "chk";
            //datagridviewtax.Columns.Insert(0, chk);

            refresh();
        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            
            this.Close();

            mysql usl = new mysql();
            DataTable dtusl;
            dtusl = usl.select("SELECT val FROM ADMIN");
            foreach (DataRow dr in dtusl.Rows)
            {
                if (dtusl.Rows[0][0].ToString() == "1")
                {
                    mysql d1 = new mysql();
                    d1.Delete("DELETE FROM ADMIN ");
                    d1.add("INSERT INTO ADMIN(val) VALUES('" + 0 + "')");

                    frmAdminDashboard ad = new frmAdminDashboard();
                    ad.Show();
                }
                else
                {
                    mysql d1 = new mysql();
                    d1.Delete("DELETE FROM ADMIN ");
                    d1.add("INSERT INTO ADMIN(val) VALUES('" + 0 + "')");
                    frmHome fh = new frmHome();
                    fh.Show();
                }
            }
        }

        #endregion

        #region cashieradd 
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TAX No");
            dt.Columns.Add("Description");
            dt.Columns.Add("TAX Value");

            foreach (DataGridViewRow row in datagridviewtax.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["chk"].Value);
                if (isSelected)
                {
                    dt.Rows.Add(row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value);
                }
            }

            frmBill adD = new frmBill();
            adD.adddettail = dt;
            adD.Show();
        }
        #endregion
        private void btnadd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmadd adA = new frmadd();
            adA.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        #region Delete
        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult messageYesNo = MessageBox.Show("Do You Want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (messageYesNo == DialogResult.Yes)
            {
                List<string> selectedItem = new List<string>();
                DataGridViewRow drow = new DataGridViewRow();
                for (int i = 0; i <= datagridviewtax.Rows.Count - 1; i++)
                {
                    drow = datagridviewtax.Rows[i];
                    if (Convert.ToBoolean(drow.Cells[0].Value) == true) //checking if  checked or not.  
                    {
                        string id = drow.Cells[1].Value.ToString();
                        selectedItem.Add(id); //If checked adding it to the list  
                    }
                }
                foreach (string s in selectedItem) //using foreach loop to delete the records stored in list.  
                {
                    mysql d1 = new mysql();
                    MessageBox.Show(d1.Delete("DELETE FROM TAX WHERE taxid ='" + s + "'"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                refresh();
            }
        }
        #endregion

        #region Update |Select

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DialogResult messageYesNo = MessageBox.Show("Do You Want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (messageYesNo == DialogResult.Yes)
            {
                DialogResult yes = MessageBox.Show("Check and edit the rows", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(yes == DialogResult.OK)
                {

                    foreach (DataGridViewRow row in datagridviewtax.Rows)
                    {
                        bool isSelected = Convert.ToBoolean(row.Cells["chk"].Value);
                        if (isSelected)
                        {
                            txtboxtaxno.Text = row.Cells[1].Value.ToString();
                            txtboxtaxname.Text = row.Cells[2].Value.ToString();
                            txtValue.Text = row.Cells[3].Value.ToString();
                            txtboxtaxname.Enabled = false;
                            txtboxtaxno.Enabled = false;
                        }
                    }
                }
              }
            else
            {
                MessageBox.Show("Please Check the list you want to update");
            }
        }
        #endregion

        #region Save
        private void btnSave_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in datagridviewtax.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["chk"].Value);
                if (isSelected)
                {
                    for (int i = 0; i < datagridviewtax.Rows.Count; i++)
                    {
                        mysql upd1 = new mysql();
                        MessageBox.Show(upd1.Update("UPDATE tax SET value='" + txtValue.Text + "' WHERE taxid = '" + txtboxtaxno.Text + "' ;"), "Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }


            }

        }

        #endregion

        //#region cell_click
        //private void datagridviewtax_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = this.datagridviewtax.Rows[e.RowIndex];
        //        txtboxtaxno.Text = row.Cells[1].Value.ToString();
        //        txtboxtaxname.Text = row.Cells[2].Value.ToString();
        //        txtValue.Text = row.Cells[3].Value.ToString();

        //    }
        //}
        //#endregion

        #region Search
        private void txtSearchNo_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchNo.Text == string.Empty)
            {
                refresh();
            }
            else
            {
                mysql m3 = new mysql();
                DataTable dt3;
                dt3 = m3.select("SELECT taxid as 'TAX No',taxname as 'TAX Name', value as 'TAX Value' FROM TAX WHERE taxid like '%" + txtSearchNo.Text + "%' ");
                datagridviewtax.DataSource = dt3;
                datagridviewtax.RowsDefaultCellStyle.BackColor = Color.LightYellow;
                datagridviewtax.Columns[0].Width = 40;
                datagridviewtax.Columns[1].Width = 70;
                datagridviewtax.Columns[2].Width = 480;
                datagridviewtax.Columns[3].Width = 89;
                datagridviewtax.Columns[1].ReadOnly = true;
                datagridviewtax.Columns[2].ReadOnly = true;
                datagridviewtax.Columns[3].ReadOnly = true;

            }
        }


        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchName.Text == string.Empty)
            {
                refresh();
            }
            else
            {
                mysql m4 = new mysql();
                DataTable dt4;
                dt4 = m4.select("SELECT taxid as 'TAX No',taxname as 'TAX Name', value as 'TAX Value' FROM TAX WHERE taxname like '%" + txtSearchName.Text + "%' ");
                datagridviewtax.DataSource = dt4;
                datagridviewtax.RowsDefaultCellStyle.BackColor = Color.LightYellow;
                datagridviewtax.Columns[0].Width = 40;
                datagridviewtax.Columns[1].Width = 70;
                datagridviewtax.Columns[2].Width = 480;
                datagridviewtax.Columns[3].Width = 89;
                datagridviewtax.Columns[1].ReadOnly = true;
                datagridviewtax.Columns[2].ReadOnly = true;
                datagridviewtax.Columns[3].ReadOnly = true;
            }
        }


        #endregion

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtboxtaxno.Text = "";
            txtboxtaxname.Text = "" ;
            txtValue.Text = "";
                
                }
    }
}

    




   






