using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalletLesster.Views
{
    public partial class SignInScreen : Form
    {
        public SignInScreen()
        {
            InitializeComponent();
            openChildFormInPanel(new SignInForm());
            this.btnSignIn.Visible = false;
            this.btnSignUp.Visible = true;
        }
        private Form activeForm = null;
        public void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void ShowSignInForm(object sender, EventArgs e)
        {
            openChildFormInPanel(new SignInForm());
            this.btnSignIn.Visible = false;
            this.btnSignUp.Visible = true;
            lblWelcome.Text = "Enter your details and start journey with us";
            lblWelcomeMsg.Text = "Hello, There!";
        }

        private void ShowSignUpForm(object sender, EventArgs e)
        {
            openChildFormInPanel(new SignUpForm());
            this.btnSignUp.Visible = false;
            this.btnSignIn.Visible = true;
            lblWelcome.Text = "Please login with your personal information";
            lblWelcomeMsg.Text = "Welcome Back!";
        }

        private void SignInScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_MouseLeave(object sender, EventArgs e)
        {
            btnSignIn.BackgroundImage = Properties.Resources.purple_btn;
        }

        private void btnSignIn_MouseHover(object sender, EventArgs e)
        {
            btnSignIn.BackgroundImage = Properties.Resources.blue_btn;

        }

        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.BackgroundImage = Properties.Resources.purple_btn;
        }

        private void btnSignUp_MouseHover(object sender, EventArgs e)
        {
            btnSignUp.BackgroundImage = Properties.Resources.blue_btn;
        }
    }
}
