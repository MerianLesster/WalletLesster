using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Globalization;
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
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        Transaction transactionModel = new Transaction();
        WalletLessterTempData tempData = new WalletLessterTempData();
        List<Transaction> transactionArr = new List<Transaction>();
        static int userId = 1;
        public Dashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.StartTimer();
            DateTime dateTime = DateTime.Today;
            lblDate.Text = dateTime.ToString("dddd, MMM dd, yyyy");
            if (File.Exists(@"D:\WL_LoggedInUserTempData.xml") == true)
            {
                tempData.ReadXml(@"D:\WL_LoggedInUserTempData.xml");
                lblWelcome.Text = String.Format("Welcome {0}!", tempData.User[0].FullName);
                userId = tempData.User[0].Id;
            }
            ShowInitialActiveTab(true);
            ShowTotalIncomeExpense();


        }
        private Form activeForm = null;
        public void setLblWelcomeText(string username)
        {
            this.lblWelcome.Text = String.Format("Welcome {0}!", username);
        }
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

        private void ActivateButton(object senderBtn)
        {
            ShowInitialActiveTab(false);
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.Cyan;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Cyan;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = Color.Cyan;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(14, 32, 81);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void CloseApplication(object sender, FormClosedEventArgs e)
        {
            //exit application when form is closed
            Application.Exit();
        }

        private void ShowManageTransactions(object sender, EventArgs e)
        {
            openChildFormInPanel(new ManageTransactions());
            ActivateButton(sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Hide();
            SignInScreen signInScreen = new SignInScreen();
            signInScreen.Show();
        }

        private void showProfile(object sender, EventArgs e)
        {
            openChildFormInPanel(new Profile());
            ActivateButton(sender);
        }

        private void showDashboard(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(sender);
            ShowTotalIncomeExpense();
        }

        private void ShowManageMerchant(object sender, EventArgs e)
        {
            openChildFormInPanel(new ManageMerchant());
            ActivateButton(sender);
        }

        private void ShowManageCategory(object sender, EventArgs e)
        {
            openChildFormInPanel(new ManageCategory());
            ActivateButton(sender);

        }

        private void ShowGenerateReport(object sender, EventArgs e)
        {
            openChildFormInPanel(new TransactionReport());
            ActivateButton(sender);

        }

        private void ShowPredictStatus(object sender, EventArgs e)
        {
            openChildFormInPanel(new PredictStatus());
            ActivateButton(sender);
        }

        private String CurrencyFormatter(double amount)
        {
            var currencyFormatValue = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            currencyFormatValue.NumberGroupSeparator = ",";
            return amount.ToString("#,0.00", currencyFormatValue); // "1 234 897.11"
        }
        private void ShowTotalIncomeExpense()
        {
            double totalExpense = 0;
            double totalIncome = 0;
            using (WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1())
            {
                var blogs = from b in db.Transactions where b.UserId.Equals(userId) select b;
                transactionArr = blogs.ToList();
                for (int i = 0; i < transactionArr.Count; i++)
                {
                    if (transactionArr[i].Type.Equals("Income"))
                    {
                        totalIncome += transactionArr[i].Amount;
                    }
                    if (transactionArr[i].Type.Equals("Expense"))
                    {
                        totalExpense += transactionArr[i].Amount;
                    }
                }
                lblIncome.Text = CurrencyFormatter(totalIncome);
                lblExpence.Text = CurrencyFormatter(totalExpense);
                lblBalance.Text = CurrencyFormatter(totalIncome - totalExpense);
            }
        }
        private void ShowInitialActiveTab(bool status)
        {
            if (status == true)
            {
                btnDashboard.BackColor = Color.FromArgb(37, 36, 81);
                btnDashboard.ForeColor = Color.Cyan;
                btnDashboard.TextAlign = ContentAlignment.MiddleCenter;
                btnDashboard.IconColor = Color.Cyan;
                btnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnDashboard.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = Color.Cyan;
                leftBorderBtn.Location = new Point(0, btnDashboard.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
            else
            {
                btnDashboard.BackColor = Color.FromArgb(14, 32, 81);
                btnDashboard.ForeColor = Color.White;
                btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
                btnDashboard.IconColor = Color.White;
                btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }
    }
}
