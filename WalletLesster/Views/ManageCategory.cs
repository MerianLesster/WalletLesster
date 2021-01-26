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
    public partial class ManageCategory : Form
    {
        WalletLessterTempData tempData = new WalletLessterTempData();
        WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1();
        Category categoryModel = new Category();
        static int userId = 1;

        public ManageCategory()
        {
            InitializeComponent();
            if (File.Exists(@"D:\WL_LoggedInUserTempData.xml") == true)
            {
                tempData.ReadXml(@"D:\WL_LoggedInUserTempData.xml");
                userId = tempData.User[0].Id;
            }
        }

        private void ManageCategory_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void ShowAddCategoryForm(object sender, EventArgs e)
        {
            AddUpdateCategory addUpdateCategory = new AddUpdateCategory();
            addUpdateCategory.FormType = "Add";
            addUpdateCategory.ShowDialog();
        }

        public void RefreshDataGridView()
        {
            dgvCategory.AutoGenerateColumns = false;
            using (WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1())
            {
                var blogs = from b in db.Categories where b.UserId.Equals(userId) select b;
                dgvCategory.DataSource = blogs.ToList();
            }
        }

        private async void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryModel.Id = Convert.ToInt32(dgvCategory.CurrentRow.Cells["Id"].Value);
            using (WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1())
            {
                categoryModel = db.Categories.Where(category => category.Id == categoryModel.Id).FirstOrDefault();

                if (dgvCategory.Columns[e.ColumnIndex].Name == "Delete")
                {
                    string messageText = String.Format("Are you sure that you want to delete the category {0}?", categoryModel.Name);
                    if (MessageBox.Show(messageText, "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            var entry = db.Entry(categoryModel);
                            if (entry.State == EntityState.Detached)
                            {
                                db.Categories.Attach(categoryModel);
                            }
                            db.Categories.Remove(categoryModel);
                            await db.SaveChangesAsync();
                            RefreshDataGridView();
                        }
                        catch (DbUpdateException ex)
                        {
                            MessageBox.Show("This category is being used in a transaction, therefore inorder to delete the category you will have to delete its associated transaction", "Failed to Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                if (dgvCategory.Columns[e.ColumnIndex].Name == "Update")
                {
                    AddUpdateCategory addUpdateCategory = new AddUpdateCategory();
                    addUpdateCategory.Id = categoryModel.Id;
                    addUpdateCategory.Type = categoryModel.Type;
                    addUpdateCategory.Name = categoryModel.Name;
                    addUpdateCategory.FormType = "Update";
                    addUpdateCategory.prefilData();
                    addUpdateCategory.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void dgvCategory_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void dgvCategory_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddCategoty_MouseLeave(object sender, EventArgs e)
        {
            btnAddCategoty.BackgroundImage = Properties.Resources.yellow_btn;
        }

        private void btnAddCategoty_MouseHover(object sender, EventArgs e)
        {
            btnAddCategoty.BackgroundImage = Properties.Resources.orange_btn;
        }
    }
}
