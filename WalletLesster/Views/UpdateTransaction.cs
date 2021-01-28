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
        WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1();
        WalletLessterTempData tempData = new WalletLessterTempData();
        ManageTransactions instanceTrans;
        int userId = 0;
        public int Id { get; set; }
        public string Type { get; set; }
        public string Merchant { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public bool Recurrence { get; set; }
        public string Description { get; set; }
        public UpdateTransaction()
        {
            InitializeComponent();
            tempData.ReadXml(@"D:\WL_LoggedInUserTempData.xml");
            userId = tempData.User[0].Id;
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
                txtDescription.Text = Description;
                if (Recurrence)
                {
                    cbxRecurrence.Checked = true;
                }
            }
        }
        public void getParentInstance(ManageTransactions obj)
        {
            instanceTrans = obj;
        }
        private async void UpdateTransactionData(object sender, EventArgs e)
        {
            btnUpdateTransaction.Image = Properties.Resources.loader;
            try
            {
                var trasactionData = db.Transactions.Where(trasaction => trasaction.Id == Id).FirstOrDefault();
                string value;
                bool isChecked = rbIncome.Checked;
                if (isChecked)
                    value = rbIncome.Text;
                else
                    value = rbExpense.Text;
                trasactionData.Type = value;
                trasactionData.Merchant = cmbMerchant.Text;
                trasactionData.Category = cmbCategory.Text;
                trasactionData.Amount = Convert.ToDouble(txtAmount.Text);
                trasactionData.Date = dpTransDate.Value;
                trasactionData.Recurrence = cbxRecurrence.Checked;
                trasactionData.Description = txtDescription.Text;
                trasactionData.UserId = userId;
                if (cmbCategory.SelectedValue == null)
                {
                    return;
                }
                trasactionData.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue.ToString());
                trasactionData.MerchantId = Convert.ToInt32(cmbMerchant.SelectedValue.ToString());
                db.Entry(trasactionData).State = EntityState.Modified;
                await db.SaveChangesAsync();
                instanceTrans.RefreshDataGridView();
                MessageBox.Show("Transaction Updated Successfully! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                btnUpdateTransaction.Image = null;
                MessageBox.Show(Convert.ToString(ex), "Error while Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTransaction_Activated(object sender, EventArgs e)
        {
            var blogs = from b in db.Merchants where b.UserId.Equals(userId) select b;
            cmbMerchant.DataSource = blogs.ToList();
            cmbMerchant.DisplayMember = "Name";
            cmbMerchant.ValueMember = "Id";
            prefilData();
            changeCategoryList();
        }

        private void rbIncome_CheckedChanged(object sender, EventArgs e)
        {
            changeCategoryList();
        }

        private void changeCategoryList()
        {
            string value;
            bool isChecked = rbIncome.Checked;
            if (isChecked)
                value = rbIncome.Text;
            else
                value = rbExpense.Text;

            var blogs = from b in db.Categories where b.UserId.Equals(userId) && b.Type.Equals(value) select b;
            cmbCategory.DataSource = blogs.ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        private void btnUpdateTransaction_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateTransaction.BackgroundImage = Properties.Resources.green_btn;
        }

        private void btnUpdateTransaction_MouseHover(object sender, EventArgs e)
        {
            btnUpdateTransaction.BackgroundImage = Properties.Resources.blue_btn;
        }
    }
}
