using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletLesster.Models;

namespace WalletLesster.Views
{
    public partial class ManageTransactions : Form
    {
        Transaction transactionModel = new Transaction();
        WalletLessterTempData tempData = new WalletLessterTempData();
        static int userId = 1;
        public ManageTransactions()
        {
            InitializeComponent();
            if (File.Exists(@"D:\WL_LoggedInUserTempData.xml") == true)
            {
                tempData.ReadXml(@"D:\WL_LoggedInUserTempData.xml");
                userId = tempData.User[0].Id;
            }
        }
        private void ShowAddTransaction(object sender, EventArgs e)
        {
            AddTransaction dashboard = new AddTransaction();
            dashboard.ShowDialog();
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
                    updateTransactionMdl.CategoryId = transactionModel.CategoryId;
                    updateTransactionMdl.Amount = transactionModel.Amount;
                    updateTransactionMdl.Date = transactionModel.Date;
                    updateTransactionMdl.Recurrence = transactionModel.Recurrence;
                    updateTransactionMdl.ShowDialog();
                }
            }
        }

        /*public void UpdateFunction(int Id, string Type, string Merchant, string Category, double Amount, DateTime Date, bool Recurrence)
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
        }*/

        private void ManageTransactions_Load(object sender, EventArgs e)
        {
            //IsMdiContainer = true;
            // TODO: This line of code loads data into the 'walletLessterDatabaseDataSet.Transactions' table. You can move, or remove it, as needed.
            //this.transactionsTableAdapter.Fill(this.walletLessterDatabaseDataSet.Transactions);
            RefreshDataGridView();
        }

        private void ManageTransactions_Activated(object sender, EventArgs e)
        {

            RefreshDataGridView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
