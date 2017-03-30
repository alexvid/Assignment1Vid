using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FurnitureManufacturer.BL;
using FurnitureManufacturer.Models;

namespace FurnitureManufacturer
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.UserName = txtUserName.Text;
                user.Password = txtPassword.Text;
                user.firstName = txtFirstName.Text;
                user.lastName = txtFirstName.Text;
                user.IsAdmin = chkAdmin.Checked;

                UserOperations bl = new UserOperations();
                bl.AddUser(user);

                MessageBox.Show("Operation succesful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.UserName = txtUserName.Text;
                user.Password = txtPassword.Text;

                UserOperations bl = new UserOperations();
                bl.DeleteUser(user);

                MessageBox.Show("Operation succesful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.UserName = txtUserName.Text;
                user.Password = txtPassword.Text;
                user.firstName = txtFirstName.Text;
                user.lastName = txtFirstName.Text;
                user.IsAdmin = chkAdmin.Checked;

                UserOperations bl = new UserOperations();
                bl.UpdateUser(user);

                MessageBox.Show("Operation succesful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void List_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.UserName = txtUserName.Text;

                UserOperations bl = new UserOperations();
                gridEmployee.DataSource = bl.ListUser(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            try
            {
                int ID;
                string text = txtId.Text;
                if (text == "")
                    ID = 0;
                else
                    ID = Convert.ToInt32(text);

                UserOperations bl = new UserOperations();
                gridEmployee.DataSource = bl.ListHistory(ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
