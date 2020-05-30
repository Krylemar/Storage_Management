using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Business;


namespace Storage_Management
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }


        private void UsernameField_TextChanged(object sender, EventArgs e)
        {
        }


        private void PasswordField_TextChanged(object sender, EventArgs e)
        {
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ErrorMsgLabel.Text = "Зареждане...";
            ErrorMsgLabel.ForeColor = Color.Blue;
            Thread.Sleep(1000);
            var login = new LoginViewBusiness();
            if (login.Login(UsernameField.Text, PasswordField.Text) == true)
            {
                this.Hide();
                var newForm = new MainScreen();
                newForm.Show();
            }
            else
            {
                ErrorMsgLabel.Text = "Грешно потребителско име или парола";
                ErrorMsgLabel.ForeColor = Color.DarkRed;
                Thread.Sleep(1000);
                ErrorMsgLabel.ForeColor = Color.IndianRed;
                Thread.Sleep(1000);
                ErrorMsgLabel.ForeColor = Color.Red;
            }
        }

        private void ErrorMsgLabel_Click(object sender, EventArgs e)
        {
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new RegisterScreen();
            newForm.Show();
        }
    }
}
