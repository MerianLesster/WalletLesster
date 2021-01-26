using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletLesster.Models;

namespace WalletLesster.Views
{
    public partial class ManageMerchant : Form
    {
        WalletLessterTempData tempData = new WalletLessterTempData();
        WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1();
        Merchant merchantModel = new Merchant();
        static int userId = 1;


        public ManageMerchant()
        {
            InitializeComponent();
            if (File.Exists(@"D:\WL_LoggedInUserTempData.xml") == true)
            {
                tempData.ReadXml(@"D:\WL_LoggedInUserTempData.xml");
                userId = tempData.User[0].Id;
            }
        }

        private void ManageMerchant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'walletLessterDBMerchantDataSet.Merchants' table. You can move, or remove it, as needed.
            //this.merchantsTableAdapter.Fill(this.walletLessterDBMerchantDataSet.Merchants);
            RefreshDataGridView();
        }

        private void ShowAddMerchantForm(object sender, EventArgs e)
        {
            AddUpdateMerchant addUpdateMerchant = new AddUpdateMerchant();
            addUpdateMerchant.FormType = "Add";
            addUpdateMerchant.ShowDialog();
        }

        public void RefreshDataGridView()
        {
            dgvMerchant.AutoGenerateColumns = false;
            using (WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1())
            {
                var blogs = from b in db.Merchants where b.UserId.Equals(userId) select b;
                dgvMerchant.DataSource = blogs.ToList();
            }
        }

        private async void dgvMerchant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            merchantModel.Id = Convert.ToInt32(dgvMerchant.CurrentRow.Cells["Id"].Value);
            using (WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1())
            {
                merchantModel = db.Merchants.Where(merchant => merchant.Id == merchantModel.Id).FirstOrDefault();

                if (dgvMerchant.Columns[e.ColumnIndex].Name == "Delete")
                {
                    string messageText = String.Format("Are you sure that you want to delete the merchant {0}?", merchantModel.Name);
                    if (MessageBox.Show(messageText, "Delete Merchant", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            var entry = db.Entry(merchantModel);
                            if (entry.State == EntityState.Detached)
                            {
                                db.Merchants.Attach(merchantModel);
                            }
                            db.Merchants.Remove(merchantModel);
                            await db.SaveChangesAsync();
                            RefreshDataGridView();
                        }
                        catch (DbUpdateException ex)
                        {
                            MessageBox.Show("This merchant is being used in a transaction, therefore inorder to delete the merchant you will have to delete its associated transaction", "Failed to Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                if (dgvMerchant.Columns[e.ColumnIndex].Name == "Update")
                {
                    AddUpdateMerchant addUpdateMerchant = new AddUpdateMerchant();
                    addUpdateMerchant.Id = merchantModel.Id;
                    addUpdateMerchant.Name = merchantModel.Name;
                    addUpdateMerchant.Number = merchantModel.Number;
                    addUpdateMerchant.FormType = "Update";
                    addUpdateMerchant.prefilData();
                    addUpdateMerchant.ShowDialog();
                }
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btnAddMerchant_MouseHover(object sender, EventArgs e)
        {
            btnAddMerchant.BackgroundImage = Properties.Resources.orange_btn;
        }

        private void btnAddMerchant_MouseLeave(object sender, EventArgs e)
        {
            btnAddMerchant.BackgroundImage = Properties.Resources.yellow_btn;
        }
    }
}
