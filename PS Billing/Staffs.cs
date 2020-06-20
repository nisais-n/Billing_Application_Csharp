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
    public partial class frmStaffs : Form
    {
        public frmStaffs()
        {
            InitializeComponent();
            lblW.Text = DateTime.Now.ToString("hh:mm tt");
            
        }
        mysql usl = new mysql();
        DataTable adsel;

        private void picboxClose_Click(object sender, EventArgs e) 
        {
            adsel = usl.select("SELECT val FROM ADMIN");
            foreach (DataRow dr in adsel.Rows)
            {
                
                if (adsel.Rows[0][0].ToString() == "1")
                {
                    mysql d1 = new mysql();
                    d1.Delete("DELETE FROM ADMIN ");
                    d1.add("INSERT INTO ADMIN(val) VALUES('" + 0 + "')");
                    frmAdminDashboard ad = new frmAdminDashboard();
                    ad.Show();
                    this.Hide();
                }
                else
                {
                    mysql d1 = new mysql();
                    d1.Delete("DELETE FROM ADMIN ");
                    d1.add("INSERT INTO ADMIN(val) VALUES('" + 0 + "')");
                    frmHome fH = new frmHome();
                    fH.Show();
                    this.Hide();
                }
            }
        }
       
        private void refresh()
        {            
            adsel = usl.select("SELECT val FROM ADMIN");
            foreach (DataRow dr in adsel.Rows)
            {
                #region admin slect
                if (adsel.Rows[0][0].ToString() == "1")
                {
                    mysql m2 = new mysql();
                    DataTable dt2;
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    datagridStaffDetail.Columns.Add(chk);
                    chk.HeaderText = "Select";
                    chk.Name = "chk";
                    dt2 = m2.select("SELECT Staff_ID  as 'Staff ID',First_Name as 'First Name', Last_Name as 'Last Name', Address as 'Address',Contact_No as 'Contact No' FROM Staffs");
                    datagridStaffDetail.DataSource = dt2;
                    btnedit.Visible = true;
                    
                    datagridStaffDetail.Columns[0].Width = 55;
                    datagridStaffDetail.Columns[1].Width = 80;
                    datagridStaffDetail.Columns[2].Width = 130;
                    datagridStaffDetail.Columns[3].Width = 130;
                    datagridStaffDetail.Columns[4].Width = 150;
                    datagridStaffDetail.Columns[5].Width = 130;
                    datagridStaffDetail.Columns[0].ReadOnly = false;
                    datagridStaffDetail.Columns[1].ReadOnly = true;
                    datagridStaffDetail.Columns[2].ReadOnly = true;
                    datagridStaffDetail.Columns[3].ReadOnly = true;
                    datagridStaffDetail.Columns[4].ReadOnly = true;
                    datagridStaffDetail.Columns[5].ReadOnly = true;
                }
                #endregion
               
                else
                {
                    mysql m2 = new mysql();
                    DataTable dt2;
                    dt2 = m2.select("SELECT Staff_ID  as 'Staff ID',First_Name as 'First Name', Last_Name as 'Last Name', Address as 'Address',Contact_No as 'Contact No' FROM Staffs");
                    datagridStaffDetail.DataSource = dt2;
                    datagridStaffDetail.Columns[0].Width = 100;
                    datagridStaffDetail.Columns[1].Width = 140;
                    datagridStaffDetail.Columns[2].Width = 140;
                    datagridStaffDetail.Columns[3].Width = 160;
                    datagridStaffDetail.Columns[4].Width = 130;
                    datagridStaffDetail.Columns[0].ReadOnly = false;
                    datagridStaffDetail.Columns[1].ReadOnly = false;
                    datagridStaffDetail.Columns[2].ReadOnly = false;
                    datagridStaffDetail.Columns[3].ReadOnly = false;
                    datagridStaffDetail.Columns[4].ReadOnly = false;
                }
                
            }
        }
        private void frmStaffs_Load(object sender, EventArgs e)
        {
             refresh();       
             // datagridStaffDetail.RowsDefaultCellStyle.BackColor = Color.LightYellow;
        }


        private void btnedit_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Staff id");
            dt.Columns.Add("f name");
            dt.Columns.Add("s name");
            dt.Columns.Add("address");
            dt.Columns.Add("contact");
            foreach (DataGridViewRow row in datagridStaffDetail.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["chk"].Value);
                if (isSelected)
                {
                    dt.Rows.Add(row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value);
                }
            }
            frmEditStaff eD = new frmEditStaff();
            eD.adddettail = dt;
            eD.Show();
            this.Hide();
        }
    }
    }