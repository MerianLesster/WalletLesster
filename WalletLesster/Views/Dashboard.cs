using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletLesster.Models;


namespace WalletLesster.Views
{
    public partial class Dashboard : Form
    {
        Transaction transactionModel = new Transaction();
        WalletLessterTempData tempData = new WalletLessterTempData();
        static int userId = 1;
        public Dashboard()
        {
            InitializeComponent();
            this.StartTimer();
            DateTime dateTime = DateTime.Today;
            lblDate.Text = dateTime.ToString("dddd, MMM dd, yyyy");
            if (File.Exists(@"D:\WL_LoggedInUserTempData.xml") == true)
            {
                tempData.ReadXml(@"D:\WL_LoggedInUserTempData.xml");
                lblWelcome.Text = String.Format("{0}!", tempData.User[0].FullName);
                userId = tempData.User[0].Id;
            }
        }
        private Form activeForm = null;
        public void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        Timer tmr = null;
        private void StartTimer()
        {
            tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse(DateTime.Now.ToString());
            lblTime.Text = dt.ToString("hh:mm:ss tt");
        }
        private void CloseApplication(object sender, FormClosedEventArgs e)
        {
            //exit application when form is closed
            Application.Exit();
        }

        private void ShowManageTransactions(object sender, EventArgs e)
        {
            openChildFormInPanel(new ManageTransactions());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInScreen signInScreen = new SignInScreen();
            signInScreen.Show();
        }

        private void showProfile(object sender, EventArgs e)
        {
            openChildFormInPanel(new Profile());
        }

        private void showDashboard(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void ShowManageMerchant(object sender, EventArgs e)
        {
            openChildFormInPanel(new ManageMerchant());
        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(160, 213, 219);
        }

        private void btnManageTrans_MouseHover(object sender, EventArgs e)
        {
            btnManageTrans.BackColor = Color.FromArgb(160, 213, 219);
        }

        private void ShowManageCategory(object sender, EventArgs e)
        {
            openChildFormInPanel(new ManageCategory());

        }

        private void btnManageCategory_MouseHover(object sender, EventArgs e)
        {
            btnManageTrans.BackColor = Color.FromArgb(160, 213, 219);
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            btnManageTrans.BackColor = Color.FromArgb(160, 213, 219);
        }

        private void ShowGenerateReport(object sender, EventArgs e)
        {
            openChildFormInPanel(new TransactionReport());

        }
    }
}
