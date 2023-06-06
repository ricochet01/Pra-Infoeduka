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

namespace Infoeduka.Lecturer
{
    public partial class LecturerScreen : UserControl
    {
        private User user;

        public LecturerScreen(User user)
        {
            InitializeComponent();

            this.user = user;
            InitData(Subject.LoadSubjects());
        }

        private void InitData(List<Subject> subjects)
        {
            flpContainer.Controls.Clear();
            lblLecturerName.Text = user.ToString().Length > 15
                ? user.ToString().Substring(0, 15) + "..."
                : user.ToString();

            subjects.ForEach(subject =>
            {
                List<User> lecturers = subject.Lecturers;
                if(lecturers.Contains(user))
                {
                    flpContainer.Controls.Add(new Label
                    {
                        Text = subject.Name,
                        AutoSize = true
                    });
                }
            });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the lecturer?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                user.DeleteJsonFile();
                Parent.Controls.Remove(this);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditLecturerPrompt prompt = new EditLecturerPrompt(user);
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                List<Subject> s = prompt.GetLecturerSubjects();
                // Deleting the original subject file
                user.DeleteJsonFile();

                // Removing the original lecturer from all subjects
                foreach (Subject subject in s)
                {
                    subject.RemoveLecturer(user);
                }

                user = prompt.GetLecturer();

                // Saving the new data to another file
                user.SaveToJsonFile();

                // And then adding the new user to all subjects
                foreach (Subject subject in s)
                {
                    subject.AddLecturer(user);
                    subject.SaveToJsonFile();
                }

                // Editing the data on user input controls
                InitData(s);
            }
        }
    }
}
