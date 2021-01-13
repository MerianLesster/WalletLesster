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
            lblTitle.Visible = false;
            btnCloseForm.Visible = false;
        }

        private void EditProfille(object sender, EventArgs e)
        {
            lblTitle.Text = "Edit Profile";
            hideLabels(false);
            lblConfirmPassword.Visible = true;
            prefillData();
            hideTextfields(true);
            lblTitle.Visible = true;
            btnUpdateProfile.Visible = true;
            btnCreateAccount.Visible = false;
            btnCloseForm.Visible = true;
            btnEditProfile.Visible = false;
            btnCreateProfile.Visible = false;
            //btnDeleteAccount.Visible = false;
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
                    var userData = db.Users.Where(user => user.Id == userId).FirstOrDefault();
                    //userData.Id = data.Id;
                    userData.FullName = data.FullName;
                    userData.Username = data.Username;
                    userData.Email = data.Email;
                    userData.Password = data.Password;
                    userData.Currency = data.Currency;
                    db.Entry(userData).State = EntityState.Modified;
                    db.SaveChanges();
                    var newUserData = db.Users.Where(user => user.Id == data.Id).FirstOrDefault();
                    tempData.User.AddUserRow(newUserData.FullName, newUserData.Username, newUserData.Email, newUserData.Password, newUserData.Currency, newUserData.Id);
                    tempData.WriteXml(@"D:\WL_LoggedInUserTempData.xml");
                    MessageBox.Show("Account Updated Successfully! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCloseForm_Click(sender, e);
                    prefillData();
                    btnCloseForm.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Create New Account";
            hideLabels(false);
            lblConfirmPassword.Visible = true;
            txtFullName.Text = "";
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            cmbCurrency.Text = "";
            hideTextfields(true);
            lblTitle.Visible = true;
            btnCreateAccount.Visible = true;
            btnUpdateProfile.Visible = false;
            btnCloseForm.Visible = true;
            btnEditProfile.Visible = false;
            btnCreateProfile.Visible = false;
            //btnDeleteAccount.Visible = false;
        }
        private async void CreateProfile(object sender, EventArgs e)
        {
            if (this.txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                try
                {
                    // Then Forword it to a Webservice or a Database

                    User userData = new User();
                    userData.FullName = txtFullName.Text;
                    userData.Username = txtUsername.Text;
                    userData.Email = txtEmail.Text;
                    userData.Password = txtPassword.Text;
                    userData.Currency = cmbCurrency.Text;
                    db.Users.Add(userData);
                    await db.SaveChangesAsync();
                    MessageBox.Show("Account Created Successfully! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCloseForm_Click(sender, e);
                    btnCloseForm.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Password didn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            hideLabels(true);
            hideTextfields(false);
            btnUpdateProfile.Visible = false;
            btnCreateAccount.Visible = false;
            lblConfirmPassword.Visible = false;
            lblTitle.Visible = false;
            btnCloseForm.Visible = false;
            btnEditProfile.Visible = true;
            btnCreateProfile.Visible = true;
            //btnDeleteAccount.Visible = true;
        }

        /*private async void DeleteAccount(object sender, EventArgs e)
        {
            User userModel = new User();
            userModel = db.Users.Where(user => user.Id == userId).FirstOrDefault();
            if (MessageBox.Show("Are you sure you want to delete your account? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                var entry = db.Entry(userModel);
                if (entry.State == EntityState.Detached)
                {
                    db.Users.Attach(userModel);
                }
                db.Users.Remove(userModel);
                await db.SaveChangesAsync();
                SignInScreen signInScreen = new SignInScreen();
                this.Close();
                signInScreen.Show();
            }
        }*/

    }
}
