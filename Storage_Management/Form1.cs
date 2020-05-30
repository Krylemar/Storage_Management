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
using Microsoft.SqlServer.Server;

namespace Storage_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var reg = new LoginViewBusiness();
            try
            {
                if (reg.Register(RegFirstName.Text, RegLastName.Text, RegEmail.Text, RegUsername.Text, RegPass.Text, int.Parse(RegStorageId.Text)))
                {
                    label1.Text = "Succeeded";
                }
                else label1.Text = "Failed";
            }
            catch (FormatException) 
            {
                label1.Text = "Fields Cannot be Empty!";
            }

            //try
            //{
            //    var login = new LoginViewBusiness();
            //    if (login.Login(RegUsername.Text, RegPass.Text))
            //    {
            //        label1.Text = "Succeeded";
            //    }
            //    else label1.Text = "Failed";
            //}
            //catch (ArgumentNullException)
            //{
            //    label1.Text = "Login or Password fields are empty";
            //}
        }
    }
}
