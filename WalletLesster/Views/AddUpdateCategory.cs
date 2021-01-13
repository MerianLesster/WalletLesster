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
    public partial class AddUpdateCategory : Form
    {
        WalletLessterTempData tempData = new WalletLessterTempData();
        WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1();
        int userId = 0;
        public string FormType { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public AddUpdateCategory()
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
                txtCategoryName.Text = Name;
            }
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

        private async void AddUpdateCategoryAction(object sender, EventArgs e)
        {

            if (txtCategoryName.Text.Equals(""))
            {
                lblTip.Text = "Please fill the Category name";
                lblTip.ForeColor = Color.White;
                panelTip.BackColor = Color.Red;
                return;
            }
            lblTip.Text = "Tip...";
            lblTip.ForeColor = Color.Black;
            panelTip.BackColor = Color.White;
            List<Transaction> transactionArr = new List<Transaction>();

            tempData.Category.Clear();
            tempData.Category.AddCategoryRow(GetTransactionType(), txtCategoryName.Text);
            // Store first
            tempData.WriteXml(@"D:\WalletLessterTempCategory.xml");
            if (FormType.Equals("Add"))
            {
                try
                {
                    // Then Forword it to a Webservice or a Database
                    if (File.Exists(@"D:\WalletLessterTempCategory.xml") == true)
                    {
                        tempData.ReadXml(@"D:\WalletLessterTempCategory.xml");
                        WalletLessterTempData.CategoryRow data = tempData.Category[0];
                        Category category = new Category();
                        category.Type = data.Type;
                        category.Name = data.Name;
                        category.UserId = userId;
                        db.Categories.Add(category);
                        await db.SaveChangesAsync();
                        MessageBox.Show("Category Created Successfully! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (File.Exists(@"D:\WalletLessterTempCategory.xml") == true)
                    {
                        tempData.ReadXml(@"D:\WalletLessterTempCategory.xml");
                        WalletLessterTempData.CategoryRow data = tempData.Category[0];
                        var categoryData = db.Categories.Where(category => category.Id == Id).FirstOrDefault();
                        categoryData.Type = data.Type;
                        categoryData.Name = data.Name;
                        categoryData.UserId = userId;
                        db.Entry(categoryData).State = EntityState.Modified;
                        await db.SaveChangesAsync();
                        Transaction transactionData = new Transaction();
                        var transactionObj = from b in db.Transactions where b.CategoryId.Equals(Id) select b;
                        transactionArr = transactionObj.ToList();
                        for (int i = 0; i < transactionArr.Count; i++)
                        {
                            transactionArr[i].Category = data.Name;
                            transactionArr[i].CategoryId = Id;
                            db.Entry(transactionArr[i]).State = EntityState.Modified;
                        }
                        await db.SaveChangesAsync();
                        MessageBox.Show("Category Updated Successfully! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex), "Error while Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddUpdateCategory_Activated(object sender, EventArgs e)
        {
            lblTitle.Text = String.Format("{0} Category", FormType);
            btnAddUpdateCategory.Text = String.Format("{0} Category", FormType);
        }

        private void AddUpdateCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManageCategory manageMerchant = new ManageCategory();
            manageMerchant.RefreshDataGridView();
        }

        private void AddUpdateCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManageCategory manageMerchant = new ManageCategory();
            manageMerchant.RefreshDataGridView();
        }
    }
}
