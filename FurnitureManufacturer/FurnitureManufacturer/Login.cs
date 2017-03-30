using FurnitureManufacturer.BL;
using FurnitureManufacturer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FurnitureManufacturer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try { 
            //UserOperations bl = new UserOperations();

            //User user = new User();

            //user.UserName = "admin";
            //user.Password = "admin";
            //user.firstName = "Alex";
            //user.lastName = "Vid";
            //user.IsAdmin = true;
            //bl.AddUser(user);

            UserOperations bl = new UserOperations();

            User user = bl.Login(txtUser.Text, txtPassword.Text);

            if (user.IsAdmin)
            {
                Admin adminForm = new Admin();
                adminForm.Show();
            }
            else
            {
                Accounts accountsForm = new Accounts(user);
                accountsForm.user = user;
                accountsForm.Show();
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}


    }
}
