using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.VisualBasic;

namespace PS_Billing
{
    public partial class frmBill : Form
    {

        public frmBill()
        {
            InitializeComponent();
            timer1.Start();
            txtTotal.Enabled = true;
            datagridBill.Enabled = false;
            PaymentPanel.Visible = false;


        }

        public string PaymentDetail="CASH";
        public string pDet = "CASH";

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTodayDate.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss tt");
        }

        #region load_form
        private void frmBill_Load(object sender, EventArgs e)
        {
            datagridBill.DataSource = adddettail;
            datagridBill.Columns[0].Width = 86;
            datagridBill.Columns[1].Width =437;
            datagridBill.Columns[2].Width = 100;
            

         
        }
        public DataTable adddettail ;


          
      

        private void datagridBill_DataSourceChanged(object sender, EventArgs e)
        {

            int sum = 0;
            for (int i = 0; i < datagridBill.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(datagridBill.Rows[i].Cells[2].Value);
            }
            txtTotal.Text = sum.ToString();
        }

        #endregion

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTaxDetails n1 = new frmTaxDetails();
            n1.Show();
        }

      

        private void btnPrint_Click(object sender, EventArgs e)
        {


            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument; //add the document to the dialog box...        

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();

            }


            //inserTing customer and bill detail
            insertbillandcustomer();
            
            // Getting data from DataGridView
            DataTable myDt = new DataTable();
            myDt = GetDTfromDGV(datagridBill);

            // Writing to sql
            WriteToSQL(myDt);


        }

        #region inserting bill in to database

        private void insertbillandcustomer()
        {
            mysql m1 = new mysql();
            MessageBox.Show(m1.add("INSERT INTO BILLS(bill_no,name,address,contact,date,total,payment) VALUES('" + txtxBillNo.Text + "','" + txtName.Text + "','" + txtAddress.Text + "','" + txtContact.Text + "','" + lblTodayDate.Text + "','" + txtTotal.Text + "','"+pDet+"')"), "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private DataTable GetDTfromDGV(DataGridView dgv)
        {
            // Macking our DataTable
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dt.Columns.Add(column.Name, typeof(string));
            }
            // Getting data
            foreach (DataGridViewRow dgvRow in dgv.Rows)
            {
                DataRow dr = dt.NewRow();
                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    dr[col] = dgvRow.Cells[col].Value;
                }
                dt.Rows.Add(dr);
            }
            // removing empty rows
            for (int row = dt.Rows.Count - 1; row >= 0; row--)
            {
                bool flag = true;
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    if (dt.Rows[row][col] != DBNull.Value)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    dt.Rows.RemoveAt(row);
                }
            }
            return dt;
        }

        private void WriteToSQL(DataTable dt)
        {
            mysql adp = new mysql();
            int x = 0;
            foreach (DataRow dr in dt.Rows)
            {
                adp.add("INSERT INTO billdetail(bill_no,taxid,detail,taxvalue) VALUES('" + txtxBillNo.Text + "','" + dt.Rows[x][0].ToString() + "','" + dt.Rows[x][1].ToString() + "','" + dt.Rows[x][2].ToString() + "')");
                x++;
            }
        }

        #endregion

        #region print code
        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            //this prints the reciept

            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 20;
            int startY = 10;
            int offset = 40;//SAPCE BETWEEN 
            string add =txtAddress.Text ;
                        

            #region Bill Header
            graphic.DrawString("_________*** AKMEEMANA PRADESHIYA SABHA ***_________", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY); 
            graphic.DrawString("............-------- PINNADUWA,WALAHANDUWA ------------............", new Font("Courier New", 14), new SolidBrush(Color.Gray), startX, startY+offset-20);
            offset = offset + 10;
            #endregion


            #region Body
            string name = Convert.ToString(lblName.Text)+" - " + txtName.Text.PadRight(32) + Convert.ToString( lblDate.Text)+" - "+Convert.ToString( lblTodayDate.Text)+"\n"+Convert.ToString(lblContact.Text)+" - " + Convert.ToString(txtContact.Text) + "\n".PadRight(41) + Convert.ToString(lblBillNo.Text) + " - " + Convert.ToString(txtxBillNo.Text);
            string address = Convert.ToString(lblAddress.Text)+" - \n" + add;
            string top = "Tax No".PadRight(20)+"Description".PadRight(50) + "Value";

            graphic.DrawString(name, font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(name, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 40;
            graphic.DrawString(address, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 60;
          //  graphic.DrawString(payment, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;

            graphic.DrawString("-------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset+10);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("-------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent

            #region get data

            DataGridView dgv = datagridBill;
            // Macking our DataTable
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dt.Columns.Add(column.Name, typeof(string));
            }
            // Getting data
            foreach (DataGridViewRow dgvRow in dgv.Rows)
            {
                DataRow dr = dt.NewRow();
                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    dr[col] = dgvRow.Cells[col].Value;
                }
                dt.Rows.Add(dr);
            }
            // removing empty rows
            for (int row = dt.Rows.Count - 1; row >= 0; row--)
            {
                bool flag = true;
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    if (dt.Rows[row][col] != DBNull.Value)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    dt.Rows.RemoveAt(row);
                }
            }

            #endregion


            int i = 0;

            foreach (DataRow dr in dt.Rows)
            {
                //create the string to print on the reciept
                string TaxId = dt.Rows[i][0].ToString();
                string TaxDetail = dt.Rows[i][1].ToString();
                string TaxVAlue = dt.Rows[i][2].ToString();


                //MessageBox.Show(item.Substring(item.Length - 5, 5) + "PROD TOTAL: " + productTotal);


                

                if (TaxDetail.Contains("  -"))
                {
                    string tLine = TaxId.PadRight(20) + TaxDetail.Substring(0, 24).PadRight(50) + TaxVAlue;

                    graphic.DrawString(tLine, new Font("Courier New", 12, FontStyle.Italic), new SolidBrush(Color.Red), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }
                else
                {
                    string Line = TaxId.PadRight(20) + TaxDetail.PadRight(50) + TaxVAlue;

                    graphic.DrawString(Line, font, new SolidBrush(Color.Black), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }
                i++;
            }


            #endregion

            #region FOOTER

            offset = offset + 20; //make some room so that the total stands out.
            graphic.DrawString("-------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 2;
            graphic.DrawString("-------------------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("TOTAL TO PAY ".PadRight(67) + String.Format("{0:c}","Rs." + txtTotal.Text), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("PAYMENT METHOD ".PadRight(70) + String.Format("{0:c}", PaymentDetail), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            //graphic.DrawString("CHANGE ".PadRight(30) + String.Format("{0:c}", change), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("             ********      Thank-you for your custom    ********              ", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15; 
          //  graphic.DrawString("                          please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);

        }

        #endregion


        #endregion


        private void panelshow()
        {
            if (RadioButtonCheque.Checked)
            {
                PaymentPanel.Visible = true;
                txtChequeNo.Focus();
            }
            else
            {
                PaymentPanel.Visible = false;
                PaymentDetail = "CASH";

            }
        }

        private void RadioButtonCheque_CheckedChanged(object sender, EventArgs e)
        {
            panelshow();
        }

        private void RadioButtonCash_CheckedChanged(object sender, EventArgs e)
        {
            panelshow();
        }

        private void txtChequeNo_TextChanged(object sender, EventArgs e)
        {

            string cno = txtChequeNo.Text;
            pDet = "CHEQUE";
            PaymentDetail = "CHEQUE\n".PadRight(60) + Convert.ToString(lblChequeNo.Text) + " - " + cno;
        }
    }
}
