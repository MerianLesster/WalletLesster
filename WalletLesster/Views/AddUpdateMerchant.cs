using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletLesster.Models;

namespace WalletLesster.Views
{
    public partial class AddUpdateMerchant : Form
    {
        WalletLessterTempData tempData = new WalletLessterTempData();
        WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1();
        int userId = 0;
        public string FormType { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public AddUpdateMerchant()
        {
            InitializeComponent();
            tempData.ReadXml(@"D:\WL_LoggedInUserTempData.xml");
            userId = tempData.User[0].Id;


        }
        public void prefilData()
        {
            if (Name != null)
            {
                txtMerchantName.Text = Name;
                txtMerchantNumber.Text = Number;
            }
        }
        public bool IsCorrectMobileNumber(String strNumber)
        {
            Regex mobilePattern = new Regex(@"^(\+\d{1,3}[- ]?)?\d{10}$");
            return !mobilePattern.IsMatch(strNumber);
        }
        private async void AddUpdateMerchantAction(object sender, EventArgs e)
        {
            if (txtMerchantName.Text.Equals(""))
            {
                lblTip.Text = "Please fill the Category name";
                lblTip.ForeColor = Color.White;
                panelTip.BackColor = Color.Red;
                return;
            }
            if (IsCorrectMobileNumber(txtMerchantNumber.Text))
            {
                lblTip.Text = "Please enter a valid mobile number";
                lblTip.ForeColor = Color.White;
                panelTip.BackColor = Color.Red;
                return;
            }
            lblTip.Text = "Tip...";
            lblTip.ForeColor = Color.Black;
            panelTip.BackColor = Color.White;
            List<Transaction> transactionArr = new List<Transaction>();

            tempData.Merchant.Clear();
            tempData.Merchant.AddMerchantRow(txtMerchantName.Text, txtMerchantNumber.Text);
            // Store first
            tempData.WriteXml(@"D:\WalletLessterTempMerchant.xml");
            if (FormType.Equals("Add"))
            {
                try
                {
                    // Then Forword it to a Webservice or a Database
                    if (File.Exists(@"D:\WalletLessterTempMerchant.xml") == true)
                    {
                        tempData.ReadXml(@"D:\WalletLessterTempMerchant.xml");
                        WalletLessterTempData.MerchantRow data = tempData.Merchant[0];
                        Merchant merchant = new Merchant();
                        merchant.Name = data.Name;
                        merchant.Number = data.Number;
                        merchant.UserId = userId;
                        db.Merchants.Add(merchant);
                        await db.SaveChangesAsync();
                        MessageBox.Show("Merchant Created Successfully! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex), "Error while Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    if (File.Exists(@"D:\WalletLessterTempMerchant.xml") == true)
                    {
                        tempData.ReadXml(@"D:\WalletLessterTempMerchant.xml");
                        WalletLessterTempData.MerchantRow data = tempData.Merchant[0];
                        var merchantData = db.Merchants.Where(merchant => merchant.Id == Id).FirstOrDefault();
                        merchantData.Name = data.Name;
                        merchantData.Number = data.Number;
                        merchantData.UserId = userId;
                        db.Entry(merchantData).State = EntityState.Modified;
                        await db.SaveChangesAsync();
                        Transaction transactionData = new Transaction();
                        var transactionObj = from b in db.Transactions where b.MerchantId.Equals(Id) select b;
                        transactionArr = transactionObj.ToList();
                        for (int i = 0; i < transactionArr.Count; i++)
                        {
                            transactionArr[i].Merchant = data.Name;
                            transactionArr[i].MerchantId = Id;
                            db.Entry(transactionArr[i]).State = EntityState.Modified;
                        }
                        await db.SaveChangesAsync();
                        MessageBox.Show("Merchant Updated Successfully! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex), "Error while Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddUpdateMerchant_Activated(object sender, EventArgs e)
        {
            string fromName = String.Format("{0} Merchant", FormType);
            lblTitle.Text = fromName;
            btnAddUpdateMerchant.Text = fromName;
            this.Text = fromName;
        }

        private void AddUpdateMerchant_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManageMerchant manageMerchant = new ManageMerchant();
            manageMerchant.RefreshDataGridView();
        }

        private void btnAddUpdateMerchant_MouseHover(object sender, EventArgs e)
        {
            btnAddUpdateMerchant.BackgroundImage = Properties.Resources.blue_btn;
        }

        private void btnAddUpdateMerchant_MouseLeave(object sender, EventArgs e)
        {
            btnAddUpdateMerchant.BackgroundImage = Properties.Resources.green_btn;
        }
    }
}

