using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class SignUpForm : Form
    {
        WalletLessterTempData tempData = new WalletLessterTempData();
        WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1();
        public SignUpForm()
        {
            InitializeComponent();
            cmbCurrency.Text = "LKR";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        public bool IsCorrectEmail(String email)
        {
            Regex emailPattern = new Regex(@"^[\w-\.]+@([\w -]+\.)+[\w-]{2,4}$");
            return !emailPattern.IsMatch(email);
        }

        private void RegisterUser(object sender, EventArgs e)
        {
            if (txtFullName.Text.Equals("") || txtUsername.Text.Equals("") || txtPassword.Text.Equals("") || txtConfirmPassword.Text.Equals(""))
            {
                MessageBox.Show("Please enter all the fields inorder to create an account.", "Invalid User Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (IsCorrectEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (this.txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                tempData.User.Clear(); // this will instantaly clear the existing data and overwrite the file with the latest
                tempData.User.AddUserRow(this.txtFullName.Text, txtUsername.Text, this.txtEmail.Text, this.txtPassword.Text, cmbCurrency.Text, 0);
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
                        userData.FullName = data.FullName;
                        userData.Username = data.Username;
                        userData.Email = data.Email;
                        userData.Password = data.Password;
                        userData.Currency = data.Currency;
                        db.Users.Add(userData);
                        db.SaveChanges();

                        MessageBox.Show("Account Created Successfully! Please signin with your username and password", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ParentForm.Hide();
                        SignInScreen signInScreen = new SignInScreen();
                        signInScreen.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Password didn't match. Please try again.", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnSignUp_MouseHover(object sender, EventArgs e)
        {
            btnSignUp.BackgroundImage = Properties.Resources.blue_btn;
        }

        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.BackgroundImage = Properties.Resources.green_btn;
        }
    }
}
