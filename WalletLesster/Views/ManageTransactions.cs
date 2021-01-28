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
        //BindingList<Transaction> bindingList = new BindingList<Transaction>();

        static int userId = 1;
        public ManageTransactions()
        {
            InitializeComponent();
            if (File.Exists(@"D:\WL_LoggedInUserTempData.xml") == true)
            {
                tempData.ReadXml(@"D:\WL_LoggedInUserTempData.xml");
                userId = tempData.User[0].Id;
            }
            //RefreshDataGridView();
            //dgvTransaction.DataSource = bindingList;
        }
        private void ShowAddTransaction(object sender, EventArgs e)
        {
            AddTransaction addTransaction = new AddTransaction();
            addTransaction.getParentInstance(this);
            addTransaction.ShowDialog();
        }

        public void RefreshDataGridView()
        {
            dgvTransaction.AutoGenerateColumns = false;
            using (WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1())
            {
                var blogs = from b in db.Transactions where b.UserId.Equals(userId) select b;
                dgvTransaction.DataSource = blogs.ToList();
                lblTip.Text = "Tip";
                lblTip.ForeColor = Color.Black;
                panelTip.BackColor = Color.White;
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
                    string messageText = String.Format("Are you sure that you want to delete this {0} record?", transactionModel.Type);
                    if (MessageBox.Show(messageText, "Delete Transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    updateTransactionMdl.Description = transactionModel.Description;
                    updateTransactionMdl.getParentInstance(this);
                    updateTransactionMdl.ShowDialog();
                }
            }
        }

        private void ManageTransactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'walletLessterDBTransactionDataSet.Transactions' table. You can move, or remove it, as needed.
            //this.transactionsTableAdapter.Fill(this.walletLessterDBTransactionDataSet.Transactions);
            using (WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1())
            {
                cmbTransType.Text = "Income";
                cmbTransType_SelectedIndexChanged(sender, e);

                var merchants = from b in db.Merchants where b.UserId.Equals(userId) select b;
                cmbMerchant.DataSource = merchants.ToList();
                cmbMerchant.DisplayMember = "Name";
                cmbMerchant.ValueMember = "Id";
            }
            RefreshDataGridView();
        }

        private void ManageTransactions_Activated(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnAddTransaction_MouseHover(object sender, EventArgs e)
        {
            btnAddTransaction.BackgroundImage = Properties.Resources.orange_btn;
        }

        private void btnAddTransaction_MouseLeave(object sender, EventArgs e)
        {
            btnAddTransaction.BackgroundImage = Properties.Resources.yellow_btn;
        }

        private void FilterTransactions(object sender, EventArgs e)
        {
            dgvTransaction.AutoGenerateColumns = false;
            using (WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1())
            {
                var blogs = from b in db.Transactions where b.UserId.Equals(userId) && b.Recurrence.Equals(cbxRecurrence.Checked) && b.Type.Equals(cmbTransType.Text) && b.Merchant.Equals(cmbMerchant.Text) && b.Category.Equals(cmbCategory.Text) select b;
                dgvTransaction.DataSource = blogs.ToList();
                if (blogs.ToList().Count == 0)
                {
                    lblTip.Text = "No records found";
                    lblTip.ForeColor = Color.White;
                    panelTip.BackColor = Color.Red;
                }
            }
        }

        private void ClearFilter(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void cmbTransType_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1())
            {
                var blogs = from b in db.Categories where b.UserId.Equals(userId) && b.Type.Equals(cmbTransType.Text) select b;
                cmbCategory.DataSource = blogs.ToList();
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";
            }
        }

        private void ExportToCSV(object sender, EventArgs e)
        {
            if (dgvTransaction.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Transaction_Record.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dgvTransaction.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgvTransaction.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dgvTransaction.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dgvTransaction.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dgvTransaction.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Transaction records exported successfully!", "Exported to CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No transaction record found to export!", "Failed to export", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
