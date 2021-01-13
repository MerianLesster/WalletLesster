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
    public partial class TransactionCustomCtrl : UserControl
    {
        public int index = 0;
        WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1();
        WalletLessterTempData tempData = new WalletLessterTempData();
        public delegate void RemoveSiteEventHandler(Object sender, ContentArgs e);
        public event RemoveSiteEventHandler onRemoveSite;
        static int userId = 1;

        public TransactionCustomCtrl()
        {
            InitializeComponent();
            if (File.Exists(@"D:\WL_LoggedInUserTempData.xml") == true)
            {
                tempData.ReadXml(@"D:\WL_LoggedInUserTempData.xml");
                userId = tempData.User[0].Id;
            }

            //Fetch from database and Add Categories into Category combobox DataSource
            changeCategoryList();

            //Fetch from database and Add Merchants into Merchant combobox DataSource
            var merchantObj = from merchant in db.Merchants where merchant.UserId.Equals(userId) select merchant;
            /*if (merchantObj.ToList().Count == 0)
            {
                AddTransaction addTransaction = new AddTransaction();
                addTransaction.showTip("Please add minimum one Merchant to add a transaction", "Error");
            }*/
            cmbMerchant.DataSource = merchantObj.ToList();
            cmbMerchant.DisplayMember = "Name";
            cmbMerchant.ValueMember = "Id";
        }
        public String GetTransactionType()
        {
            string value;
            bool isChecked = rbIncome.Checked;
            if (isChecked)
                value = rbIncome.Text;
            else
                value = rbExpense.Text;
            return value;
        }
        public String GetMerchantText()
        {
            return this.cmbMerchant.Text;
        }
        public String GetMerchantValue()
        {
            return this.cmbMerchant.SelectedValue.ToString();
        }
        public String GetCategoryText()
        {
            return this.cmbCategory.Text;
        }
        public String GetCategoryValue()
        {
            return this.cmbCategory.SelectedValue.ToString();
        }
        public Double GetAmountValue()
        {
            return Convert.ToDouble(this.txtAmount.Text);
        }
        public DateTime GetDateValue()
        {
            return this.dpTransDate.Value.Date;
        }
        public Boolean GetRecurrenceValue()
        {
            return this.cbxRecurrence.Checked;
        }
        public String GetDescriptionText()
        {
            return this.txtDescription.Text;
        }

        public Boolean TriggerValidationMessage()
        {
            if (this.GetCategoryText().Equals("") || this.GetMerchantText().Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void removeTransaction(object sender, EventArgs e)
        {
            onRemoveSite(this, new ContentArgs(index));
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

            var categoryObj = from b in db.Categories where b.UserId.Equals(userId) && b.Type.Equals(value) select b;
            /*            if (categoryObj.ToList().Count == 0)
                        {
                            AddTransaction addTransaction = new AddTransaction();
                            addTransaction.showTip("Please add minimum one Category to add a transaction", "Error");
                        }*/
            cmbCategory.DataSource = categoryObj.ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }
    }

    public class ContentArgs : EventArgs
    {
        public int index;

        public ContentArgs(int value)
        {
            index = value;
        }
    }
}
