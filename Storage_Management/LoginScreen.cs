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
using Microsoft.VisualBasic.Logging;
using Renci.SshNet.Security;

namespace Storage_Management
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void UsernameField_TextChanged(object sender, EventArgs e)
        {
        }


        private void PasswordField_TextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordField_KeyEnter(object sender, EventArgs e)
        {
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            try
            {
                var login = new LoginViewBusiness();
                if (login.Login(UsernameField.Text, PasswordField.Text) == true)
                {
                    var employeeName = new EmployeeBusiness();
                    string firstName = employeeName.GetEmployeeFirstName(UsernameField.Text);
                    string lastName = employeeName.GetEmployeeLastName(UsernameField.Text);
                    var newForm = new MainScreen(firstName, lastName);
                    this.Hide();
                    newForm.Show(); ;
                }
                else
                {
                    ErrorMsgLabel.Text = "Грешно потребителско име или парола";
                    ErrorMsgLabel.ForeColor = Color.Red;
                };
            }
            catch (ArgumentNullException)
            {
                ErrorMsgLabel.Text = "Грешка във въведените данни";
                ErrorMsgLabel.ForeColor = Color.Red; ;
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoginButton.PerformClick();
        }
    }
}
