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
                lblWelcome.Text = String.Format("Welcome {0}!", tempData.User[0].FullName);
                userId = tempData.User[0].Id;
            }
        }
        System.Windows.Forms.Timer tmr = null;
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

        private void ShowAddTransaction(object sender, EventArgs e)
        {
            AddTransaction addTransaction = new AddTransaction();
            addTransaction.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'walletLessterDatabaseDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.walletLessterDatabaseDataSet.Transactions);

        }

        public void RefreshDataGridView()
        {
            dgvTransaction.AutoGenerateColumns = false;
            using (WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1())
            {
                var blogs = from b in db.Transactions where b.UserId.Equals(userId) select b;
                dgvTransaction.DataSource = blogs.ToList();
            }

        }

        private void dgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            transactionModel.Id = Convert.ToInt32(dgvTransaction.CurrentRow.Cells["Id"].Value);
            using (WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1())
            {
                transactionModel = db.Transactions.Where(transaction => transaction.Id == transactionModel.Id).FirstOrDefault();

                if (dgvTransaction.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Are you sure? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        var entry = db.Entry(transactionModel);
                        if (entry.State == EntityState.Detached)
                        {
                            db.Transactions.Attach(transactionModel);
                        }
                        db.Transactions.Remove(transactionModel);
                        db.SaveChanges();
                        RefreshDataGridView();

                    }
                }
                if (dgvTransaction.Columns[e.ColumnIndex].Name == "Update")
                {
                    UpdateTransaction updateTransactionMdl = new UpdateTransaction();
                    updateTransactionMdl.Id = transactionModel.Id;
                    updateTransactionMdl.Type = transactionModel.Type;
                    updateTransactionMdl.Merchant = transactionModel.Merchant;
                    updateTransactionMdl.Category = transactionModel.Category;
                    updateTransactionMdl.Amount = transactionModel.Amount;
                    updateTransactionMdl.Date = transactionModel.Date;
                    updateTransactionMdl.Recurrence = transactionModel.Recurrence;
                    updateTransactionMdl.prefilData();
                    updateTransactionMdl.ShowDialog();
                }
            }
        }



        public void UpdateFunction(int Id, string Type, string Merchant, string Category, double Amount, DateTime Date, bool Recurrence)
        {
            try
            {
                using (WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1())
                {
                    transactionModel.Id = Id;
                    transactionModel.Type = Type;
                    transactionModel.Merchant = Merchant;
                    transactionModel.Category = Category;
                    transactionModel.Amount = Amount;
                    transactionModel.Date = Date;
                    transactionModel.Recurrence = Recurrence;
                    transactionModel.UserId = userId;
                    db.Entry(transactionModel).State = EntityState.Modified;
                    db.SaveChanges();
                }
                RefreshDataGridView();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void dgvTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //RefreshDataGridView();
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //button2.Image
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInScreen signInScreen = new SignInScreen();
            signInScreen.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.ShowDialog();
        }
    }
}
