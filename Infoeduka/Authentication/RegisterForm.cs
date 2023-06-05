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
    public partial class RegisterForm : Form
    {
        private List<User> allUsers;
        private User newUser;

        public RegisterForm(List<User> allUsers)
        {
            this.allUsers = allUsers;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(!FormValid())
            {
                MessageBox.Show(
                 "You must fill in all of the fields!",
                 "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                return;
            }

            // There cannot be two users with a same email address
            foreach(User u in allUsers)
            {
                if(tbEmail.Text == u.Email)
                {
                    MessageBox.Show(
                     "Email already exists!",
                     "Error",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                    return;
                }
            }

            // Checking the password validity
            if(tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show(
                 "The passwords must match!",
                 "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Warning);
                return;
            }

            // Finally, we can create the account
            newUser = new User(
                tbFirstName.Text,
                tbLastName.Text,
                tbEmail.Text,
                tbPassword.Text,
                UserType.Lecturer
            );

            newUser.SaveToJsonFile();
            DialogResult = DialogResult.OK;
        }

        public User GetUser()
        {
            return newUser;
        }

        private bool FormValid()
        {
            bool ok = true;

            foreach(TextBox tb in Controls.OfType<TextBox>())
            {
                string text = tb.Text.Trim();
                ok &= (text.Length > 0);
            }

            return ok;
        }
    }
}
