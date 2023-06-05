using Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infoeduka.Authentication
{
    public partial class LoginForm : Form
    {
        private List<User> allUsers;
        private User authenticatedUser;
        private bool authenticated = false;

        public LoginForm(List<User> allUsers)
        {
            this.allUsers = allUsers;
            InitializeComponent();
        }

        public User GetAuthenticatedUser()
        {
            return authenticatedUser;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!authenticated) DialogResult = DialogResult.Cancel;
        }

        private void Authenticate()
        {
            // Check if the login info is correct
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            foreach (User user in allUsers)
            {
                if (user.Email == email && user.Password == password)
                {
                    authenticatedUser = user;
                    DialogResult = DialogResult.OK;
                    authenticated = true;
                }
            }

            if (!authenticated) MessageBox.Show(
                 "Incorrect email or password",
                 "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authenticate();
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Try to authenticate when the user presses enter on password input
            if (e.KeyCode == Keys.Enter)
            {
                Authenticate();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // And then show the other one
            RegisterForm register = new RegisterForm(allUsers);
            if(register.ShowDialog() == DialogResult.OK)
            {
                User newUser = register.GetUser();
                tbEmail.Text = newUser.Email;
                tbPassword.Text = newUser.Password;

                allUsers = User.LoadAllUsers();
            }
        }
    }
}
