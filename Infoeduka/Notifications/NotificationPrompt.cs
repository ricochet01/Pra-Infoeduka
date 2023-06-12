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

namespace Infoeduka.notifications
{
    public partial class NotificationPrompt : Form
    {
        private User user;

        public NotificationPrompt(string title, Notification notification, User user)
        {
            InitializeComponent();
            this.Text = title;
            this.user = user;

            List<Subject> availableSubjects = user.GetEnrolledSubjects();
            availableSubjects.ForEach(s => cbSubjects.Items.Add(s));

            if (notification != null)
            {
                tbTitle.Text = notification.Title;
                rtbBody.Text = notification.Message;

                int index = -1;
                for (int i = 0; i < availableSubjects.Count; i++)
                {
                    Subject subject = availableSubjects[i];
                    if (subject.Name == notification.Subject)
                    {
                        index = i;
                        break;
                    }
                }

                cbSubjects.SelectedIndex = index;
            }
        }

        public Notification GetNotification()
        {
            string selectedSubject = cbSubjects.SelectedItem.ToString();
            return new Notification(tbTitle.Text, rtbBody.Text, user.GetSignature(), selectedSubject);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!FormValid())
            {
                MessageBox.Show(
                    "You must fill in all fields!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private bool FormValid()
        {
            // There must be a title, body and a selected subject
            return (tbTitle.Text.Length > 0)
                && (rtbBody.Text.Length > 0)
                && cbSubjects.SelectedIndex >= 0;
        }
    }
}
