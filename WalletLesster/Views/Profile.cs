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
    public partial class Profile : Form
    {
        WalletLessterTempData tempData = new WalletLessterTempData();
        WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1();
        static int userId = 1;
        public Profile()
        {
            InitializeComponent();
            hideTextfields(false);
            prefillData();
            lblConfirmPassword.Visible = false;
        }

        private void EditProfille(object sender, EventArgs e)
        {
            hideLabels(false);
            lblConfirmPassword.Visible = true;
            hideTextfields(true);
        }

        private void hideLabels(bool visibility)
        {
            lblFullName.Visible = visibility;
            lblUsername.Visible = visibility;
            lblEmail.Visible = visibility;
            lblPassword.Visible = visibility;
            lblCurrency.Visible = visibility;
        }

        private void hideTextfields(bool visibility)
        {
            txtFullName.Visible = visibility;
            txtUsername.Visible = visibility;
            txtEmail.Visible = visibility;
            txtPassword.Visible = visibility;
            txtConfirmPassword.Visible = visibility;
            cmbCurrency.Visible = visibility;
            btnUpdateProfile.Visible = visibility;
        }

        private void prefillData()
        {
            if (File.Exists(@"D:\WL_LoggedInUserTempData.xml") == true)
            {
                tempData.ReadXml(@"D:\WL_LoggedInUserTempData.xml");
                WalletLessterTempData.UserRow data = tempData.User[0];
                userId = data.Id;
                lblNameHeader.Text = data.FullName;
                lblFullName.Text = data.FullName;
                lblUsername.Text = data.Username;
                lblEmail.Text = data.Email;
                lblPassword.Text = data.Password;
                lblCurrency.Text = data.Currency;

                txtFullName.Text = data.FullName;
                txtUsername.Text = data.Username;
                txtEmail.Text = data.Email;
                txtPassword.Text = data.Password;
                txtConfirmPassword.Text = "";
                cmbCurrency.Text = data.Currency;
            }
        }

        private void UpdateProfile(object sender, EventArgs e)
        {
            if (!this.txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Password didn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tempData.User.Clear(); // this will instantaly clear the existing data and overwrite the file with the latest
            tempData.User.AddUserRow(this.txtFullName.Text, txtUsername.Text, this.txtEmail.Text, this.txtPassword.Text, cmbCurrency.Text, userId);
            // Store first
            tempData.WriteXml(@"D:\WalletLessterTempData.xml");

            try
            {
                // Then Forword it to a Webservice or a Database
                if (File.Exists(@"D:\WalletLessterTempData.xml") == true)
                {
                    tempData.ReadXml(@"D:\WalletLessterTempData.xml");
                    WalletLessterTempData.UserRow data = tempData.User[0];
                    User userData = new User();
                    userData.Id = data.Id;
                    userData.FullName = data.FullName;
                    userData.Username = data.Username;
                    userData.Email = data.Email;
                    userData.Password = data.Password;
                    userData.Currency = data.Currency;
                    db.Entry(userData).State = EntityState.Added;
                    /*                    var entry = db.Entry(userData);
                                            if (entry.State == EntityState.Detached)
                                            {
                                                db.Transactions.Attach(userData);
                                            }*/
                    db.SaveChanges();
                    MessageBox.Show("Account Updated Successfully! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hideLabels(true);
                    hideTextfields(false);
                    prefillData();
                    lblConfirmPassword.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
