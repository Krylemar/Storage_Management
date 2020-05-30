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

namespace Skladov_Softuer
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new LoginScreen();
            newForm.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var register = new LoginViewBusiness();
            register.Register(firstNameField.Text, lastNameField.Text, emailField.Text, usernameField.Text, passwordField.Text, 1);
            this.Hide();
            var newForm = new LoginScreen();
            MessageBox.Show("Регистрацията ви е успешна");
            newForm.Show();
        }
    }
}
