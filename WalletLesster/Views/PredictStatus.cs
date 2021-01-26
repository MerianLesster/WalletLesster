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
    public partial class PredictStatus : Form
    {
        Transaction transactionData = new Transaction();
        List<Transaction> transactionArr = new List<Transaction>();
        List<Transaction> expenseTransactionArr = new List<Transaction>();
        WalletLessterTempData tempData = new WalletLessterTempData();
        static int userId = 1;

        public PredictStatus()
        {
            InitializeComponent();
            if (File.Exists(@"D:\WL_LoggedInUserTempData.xml") == true)
            {
                tempData.ReadXml(@"D:\WL_LoggedInUserTempData.xml");
                userId = tempData.User[0].Id;
            }
            dpPredictDate.MinDate = DateTime.Today;
            pnlPredictionResult.Visible = false;
        }

        private void btnPredictStatus_Click(object sender, EventArgs e)
        {
            double oneDayExpense = 0;
            double totalExpense = 0;
            int totalDays = 0;
            double inR = 0;
            double noOfDaysFromPredictionDate = 0;
            double avgPredictedExp = 0;
            bool finalStatus;
            using (WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1())
            {
                var blogs = from b in db.Transactions where b.UserId.Equals(userId) select b;
                transactionArr = blogs.ToList();
                if (transactionArr.Count == 0)
                {
                    MessageBox.Show("You have not done any transactions", "Unable to predict", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                for (int i = 0; i < transactionArr.Count; i++)
                {
                    if (transactionArr[i].Type.Equals("Expense"))
                    {
                        totalExpense += transactionArr[i].Amount;
                        expenseTransactionArr.Add(transactionArr[i]);
                    }
                }
                var orderedExpenseArr = expenseTransactionArr.OrderBy(x => x.Date).ToList();
                if (orderedExpenseArr.Count < 2)
                {
                    lblTip.Text = "Please add minimum of two records to predict your financial status based on your expense";
                    lblTip.ForeColor = Color.White;
                    panelTip.BackColor = Color.Red;
                    return;
                }
                totalDays = Convert.ToInt32((Convert.ToDateTime(orderedExpenseArr[0].Date) - Convert.ToDateTime(orderedExpenseArr[orderedExpenseArr.Count - 1].Date)).TotalDays);
                oneDayExpense = totalExpense / totalDays;
                inR = (orderedExpenseArr[orderedExpenseArr.Count - 2].Amount - orderedExpenseArr[orderedExpenseArr.Count - 1].Amount) / totalExpense * 100;
                noOfDaysFromPredictionDate = (Convert.ToDateTime(dpPredictDate.Value) - Convert.ToDateTime(orderedExpenseArr[orderedExpenseArr.Count - 1].Date)).TotalDays;
                avgPredictedExp = noOfDaysFromPredictionDate * inR * oneDayExpense;
                finalStatus = orderedExpenseArr[orderedExpenseArr.Count - 1].Amount > avgPredictedExp;
                pnlPredictionResult.Visible = true;
                if (finalStatus == true)
                {
                    lblStatus.Text = "Status is Good";
                    pictureBoxStatus.Image = Properties.Resources.Happy;
                }
                else
                {
                    lblStatus.Text = "Status is BAD";
                    pictureBoxStatus.Image = Properties.Resources.Sad;
                }
            }
        }

        private void btnPredictStatus_MouseLeave(object sender, EventArgs e)
        {
            btnPredictStatus.BackgroundImage = Properties.Resources.green_btn;
        }

        private void btnPredictStatus_MouseHover(object sender, EventArgs e)
        {
            btnPredictStatus.BackgroundImage = Properties.Resources.blue_btn;
        }
    }
}
