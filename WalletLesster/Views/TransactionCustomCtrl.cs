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
            var blogs = from b in db.Categories where b.UserId.Equals(userId) select b;
            cmbCategory.DataSource = blogs.ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
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
        public String GetMerchantValue()
        {
            return this.cmbMerchant.Text;
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
            return this.dpTransDate.Value;
        }
        public Boolean GetRecurrenceValue()
        {
            return this.cbxRecurrence.Checked;
        }

        public Boolean TriggerValidationMessage()
        {
            if (this.GetCategoryText().Equals("") || this.GetMerchantValue().Equals(""))
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
