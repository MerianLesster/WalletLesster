using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using WalletLesster.Models;

namespace WalletLesster.Views
{
    public partial class UpdateTransaction : Form
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Merchant { get; set; }
        public string Category { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public bool Recurrence { get; set; }
        public UpdateTransaction()
        {
            InitializeComponent();
            loader.Visible = false;
        }

        public void prefilData()
        {
            if (Type != null)
            {
                if (Type.Equals("Income"))
                {
                    rbIncome.Checked = true;
                    rbExpense.Checked = false;
                }
                else
                {
                    rbIncome.Checked = false;
                    rbExpense.Checked = true;
                }
                cmbMerchant.Text = Merchant;
                cmbCategory.Text = Category;
                txtAmount.Text = Convert.ToString(Amount);
                dpTransDate.Text = Convert.ToString(Date.Date);
                if (Recurrence)
                {
                    cbxRecurrence.Checked = true;
                }
            }
        }

        private void UpdateTransactionData(object sender, EventArgs e)
        {
            loader.Visible = true;
            btnUpdateTransaction.Location = new Point(847, 11);
            Id = Id;
            string value;
            bool isChecked = rbIncome.Checked;
            if (isChecked)
                value = rbIncome.Text;
            else
                value = rbExpense.Text;
            Type = value;
            Merchant = cmbMerchant.Text;
            Category = cmbCategory.Text;
            Amount = Convert.ToDouble(txtAmount.Text);
            Date = dpTransDate.Value;
            Recurrence = cbxRecurrence.Checked;
            Dashboard dashboard = new Dashboard();
            dashboard.UpdateFunction(Id, Type, Merchant, Category, Amount, Date, Recurrence);
            MessageBox.Show("Transaction Successfully Updated");
        }

    }
}
