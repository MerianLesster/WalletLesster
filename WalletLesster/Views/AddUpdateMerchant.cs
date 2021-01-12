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

        private async void AddUpdateMerchantAction(object sender, EventArgs e)
        {
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
                        /*Transaction transactionData = new Transaction();
                        var test123 = from b in db.Transactions where b.MerchantId.Equals(Id) select b;
                        transactionArr = test123.ToList();
                        for (int i = 0; i < transactionArr.Count; i++)
                        {
                            transactionArr[i].Merchant = data.Name;
                            transactionArr[i].MerchantId = Id;
                            db.Entry(test123).State = EntityState.Modified;
                        }
                        await db.SaveChangesAsync();*/
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
            lblTitle.Text = String.Format("{0} Merchant", FormType);
            btnAddUpdateMerchant.Text = String.Format("{0} Merchant", FormType);
        }
    }
}

