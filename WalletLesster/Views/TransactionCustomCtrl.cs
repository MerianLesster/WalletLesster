using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalletLesster.Views
{
    public partial class TransactionCustomCtrl : UserControl
    {
        public int index = 0;

        public delegate void RemoveSiteEventHandler(Object sender, ContentArgs e);
        public event RemoveSiteEventHandler onRemoveSite;

        public TransactionCustomCtrl()
        {
            InitializeComponent();
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
        public String GetCategoryValue()
        {
            return this.cmbCategory.Text;
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
            if (this.GetCategoryValue().Equals("") || this.GetMerchantValue().Equals(""))
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
