using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletLesster.Models;

namespace WalletLesster.Views
{
    public partial class AddTransaction : Form
    {
        const int SPACER = 3;
        WalletLessterTempData tempData = new WalletLessterTempData();
        List<TransactionCustomCtrl> transactionArr = new List<TransactionCustomCtrl>();
        WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1();

        bool showErrorMsg = false;
        public AddTransaction()
        {
            InitializeComponent();
            this.AddAnotherTransaction(new object(), new EventArgs());
            // To populate the fields from the database
            /*if (File.Exists(@"D:\WalletLessterTempData.xml") == true)
            {
                tempData.ReadXml(@"D:\WalletLessterTempData.xml");
                WalletLessterTempData.TransactionRow data = tempData.Transaction[0];
                if(data.IsMerchantNull() == false)
                {
                    this.txtFirstName = data.Merchant;
                }
            }*/
        }

        private async void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in transactionArr)
                {
                    showErrorMsg = item.TriggerValidationMessage();
                }
                if (showErrorMsg)
                {
                    lblTip.Text = "Please Enter All the Fileds";
                    lblTip.ForeColor = Color.White;
                    panelTip.BackColor = Color.Red;
                }
                else
                {
                    tempData.Transaction.Clear();
                    for (int i = 0; i < transactionArr.Count; i++)
                    {
                        tempData.Transaction.AddTransactionRow(transactionArr[i].GetTransactionType(),
                            transactionArr[i].GetMerchantText(),
                            transactionArr[i].GetCategoryText(),
                            transactionArr[i].GetAmountValue(),
                            transactionArr[i].GetDateValue(),
                            transactionArr[i].GetRecurrenceValue(),
                            transactionArr[i].GetDescriptionText());
                    }
                    // Store first
                    tempData.WriteXml(@"D:\WalletLessterTempData.xml");
                    tempData.ReadXml(@"D:\WL_LoggedInUserTempData.xml");
                    int id = tempData.User[0].Id;
                    // Forward to Database
                    for (int i = 0; i < transactionArr.Count; i++)
                    {
                        if (File.Exists(@"D:\WalletLessterTempData.xml") == true)
                        {
                            tempData.ReadXml(@"D:\WalletLessterTempData.xml");
                            WalletLessterTempData.TransactionRow data = tempData.Transaction[i];
                            Transaction transactionData = new Transaction();
                            transactionData.Type = data.Type;
                            transactionData.Merchant = data.Merchant;
                            transactionData.Category = data.Category;
                            transactionData.Amount = data.Amount;
                            transactionData.Date = data.Date;
                            transactionData.Recurrence = data.Recurrence;
                            transactionData.Description = data.Description;
                            transactionData.UserId = id;
                            if (transactionArr[i].GetCategoryValue() == null)
                            {
                                return;
                            }
                            transactionData.CategoryId = Convert.ToInt32(transactionArr[i].GetCategoryValue());
                            transactionData.MerchantId = Convert.ToInt32(transactionArr[i].GetMerchantValue());
                            db.Transactions.Add(transactionData);
                        }
                    }
                    await db.SaveChangesAsync();
                    ManageTransactions manageTransactions = new ManageTransactions();
                    manageTransactions.RefreshDataGridView();
                    lblTip.Text = "Tip...";
                    lblTip.ForeColor = Color.Black;
                    panelTip.BackColor = Color.White;
                    MessageBox.Show("Transactions added successfully", "Success");
                    this.Hide();
                }
                //MessageBox.Show("Do you want to add more transactions?", "Information", MessageBoxButtons.YesNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Error");
                throw;
            }
        }

        private void RemoveSite_Click(Object sender, ContentArgs e)
        {
            lblTip.Text = "Tip...";
            lblTip.ForeColor = Color.Black;
            panelTip.BackColor = Color.White;
            TransactionCustomCtrl updateList;

            for (int i = e.index; i < panelTransactions.Controls.Count; i++)
            {
                updateList = (TransactionCustomCtrl)panelTransactions.Controls[i];
                updateList.Location = new Point(0, updateList.Location.Y - updateList.Height - SPACER);
                updateList.index = i - 1;
            }
            transactionArr.RemoveAt(e.index);
            panelTransactions.Controls.RemoveAt(e.index);
            if (transactionArr.Count == 0)
            {
                this.btnSaveTransaction.Enabled = false;
            }
        }

        private void AddAnotherTransaction(object sender, EventArgs e)
        {
            TransactionCustomCtrl transContent = new TransactionCustomCtrl();
            TransactionCustomCtrl previous;

            panelTransactions.Controls.Add(transContent);
            if (panelTransactions.Controls.Count < 2)
            {
                transContent.Location = new Point(0, 0);
            }
            else
            {
                previous = (TransactionCustomCtrl)panelTransactions.Controls[panelTransactions.Controls.Count - 2];
                transContent.Location = new Point(0, previous.Location.Y + previous.Height + SPACER);
            }
            transContent.onRemoveSite += new TransactionCustomCtrl.RemoveSiteEventHandler(RemoveSite_Click);
            transContent.index = panelTransactions.Controls.Count - 1;
            transContent.Width = panelTransactions.Width;
            transContent.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            transactionArr.Add(transContent);
            if (transactionArr.Count > 0)
            {
                this.btnSaveTransaction.Enabled = true;
            }
        }

        public void showTip(string tip, string type)
        {
            lblTip.Text = tip;
            if (type.Equals("Error"))
            {
                lblTip.ForeColor = Color.White;
                panelTip.BackColor = Color.Red;
                btnSaveTransaction.Enabled = false;
            }
            else
            {
                lblTip.ForeColor = Color.Black;
                panelTip.BackColor = Color.White;
                btnSaveTransaction.Enabled = true;
            }
        }
    }
}
