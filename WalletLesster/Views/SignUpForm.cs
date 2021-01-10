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
    public partial class SignUpForm : Form
    {
        WalletLessterTempData tempData = new WalletLessterTempData();
        WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1();
        public SignUpForm()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterUser(object sender, EventArgs e)
        {
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
                        MessageBox.Show("Account Created Successfully! ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
    }
}
