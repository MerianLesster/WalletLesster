using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletLesster.Models;

namespace WalletLesster.Views
{
    public partial class SignInForm : Form
    {
        WalletLessterTempData tempData = new WalletLessterTempData();
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid username and password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    using (WalletLessterDataModelContainer1 db = new WalletLessterDataModelContainer1())
                    {
                        bool validUser = db.Users.Any(user => user.Username.Equals(txtUsername.Text) && user.Password.Equals(txtPassword.Text));
                        if (validUser)
                        {
                            tempData.User.Clear();
                            var userData = db.Users.Where(user => user.Username == txtUsername.Text).FirstOrDefault();
                            MessageBox.Show(String.Format("Welcome {0}! ", userData.FullName), "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tempData.User.AddUserRow(userData.FullName, userData.Username, userData.Email, userData.Password, userData.Currency, userData.Id);
                            tempData.WriteXml(@"D:\WL_LoggedInUserTempData.xml");
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                            this.ParentForm.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password! ", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }

        }
    }
}
