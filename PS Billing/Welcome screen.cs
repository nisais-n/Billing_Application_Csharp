using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PS_Billing
{
    public partial class frmWelcome_screen : Form
    {
        public frmWelcome_screen()
        {
            InitializeComponent();
            lblW.Text = DateTime.Now.ToString("hh:mm tt");
            


        }

        private void activateHeavyWork()
        {
            Thread.Sleep(100);
        }

        private void frmWelcome_screen_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            this.timer1.Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 75; i <= 100; i++)
            {
                activateHeavyWork();
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            circularProgressBar1.Value = e.ProgressPercentage;
            lblsec.Text = e.ProgressPercentage.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(circularProgressBar1.Maximum==100)
            {
                this.Hide();
                frmLogin objlogin = new frmLogin();
                objlogin.Show();
            }
        }
     }
}