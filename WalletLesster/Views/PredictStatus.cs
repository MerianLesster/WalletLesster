using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public PredictStatus()
        {
            InitializeComponent();
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
                transactionArr = db.Transactions.ToList();
                for (int i = 0; i < transactionArr.Count; i++)
                {
                    if (transactionArr[i].Type.Equals("Expense"))
                    {
                        totalExpense += transactionArr[i].Amount;
                        expenseTransactionArr.Add(transactionArr[i]);
                    }
                }
                var orderedExpenseArr = expenseTransactionArr.OrderBy(x => x.Date).ToList();
                totalDays = Convert.ToInt32((Convert.ToDateTime(orderedExpenseArr[0].Date) - Convert.ToDateTime(orderedExpenseArr[orderedExpenseArr.Count - 1].Date)).TotalDays);
                oneDayExpense = totalExpense / totalDays;
                inR = (orderedExpenseArr[orderedExpenseArr.Count - 2].Amount - orderedExpenseArr[orderedExpenseArr.Count - 1].Amount) / totalExpense * 100;
                noOfDaysFromPredictionDate = (Convert.ToDateTime(dpPredictDate.Value) - Convert.ToDateTime(orderedExpenseArr[orderedExpenseArr.Count - 1].Date)).TotalDays;
                avgPredictedExp = noOfDaysFromPredictionDate * inR * oneDayExpense;
                finalStatus = orderedExpenseArr[orderedExpenseArr.Count - 1].Amount > avgPredictedExp;
                if (finalStatus == true)
                {
                    lblStatus.Text = "Status is Good";
                }
                else
                {
                    lblStatus.Text = "Status is BAD";
                }
            }
        }
    }
}
