using Dal;
using Infoeduka.notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infoeduka.Notifications
{
    public partial class NotificationScreen : UserControl
    {
        private Notification notification;
        private User author;

        public NotificationScreen(Notification notification, User author)
        {
            InitializeComponent();

            this.notification = notification;
            this.author = author;

            InitData();
        }

        private void InitData()
        {
            lblTitle.Text = notification.Title.Length > 15 ?
                notification.Title.Substring(0, 15) + "...":
                notification.Title;
            lblBody.Text = notification.Message;
            lblSubject.Text = notification.Subject;
            lblDatePublished.Text = notification.GetFormattedDate();

            int x = Width - lblDatePublished.Width;
            int y = lblDatePublished.Location.Y;
            lblDatePublished.Location = new Point(x, y);

            // Setting the author label location based on the name length
            lblAuthor.Text = notification.Author;
            int xa = Width - lblAuthor.Width - 24;
            int ya = lblAuthor.Location.Y;
            lblAuthor.Location = new Point(xa, ya);

            bool userIsPublisher = author.ToString() == notification.Author;
            btnEdit.Visible = userIsPublisher;
            btnDelete.Visible = userIsPublisher;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            NotificationPrompt prompt = new NotificationPrompt("Edit notification", notification, author);
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                // Deleting the original subject file
                notification.DeleteJsonFile();

                notification = prompt.GetNotification();
                // Editing the data on user input controls
                InitData();
                // Saving the new data to another file
                notification.SaveToJsonFile();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the notification?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                notification.DeleteJsonFile();
                Parent.Controls.Remove(this);
            }
        }

        public Notification GetNotification()
        {
            return notification;
        }
    }
}
