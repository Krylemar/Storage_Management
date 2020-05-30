using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Storage_Management
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        { 
            var newForm = new LoginScreen();
            this.Hide();
            newForm.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var register = new LoginViewBusiness();
            register.Register(firstNameField.Text, lastNameField.Text, emailField.Text, usernameField.Text, passwordField.Text, 1);
            var newForm = new LoginScreen();
            MessageBox.Show("Регистрацията ви е успешна");
            this.Hide();
            newForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
