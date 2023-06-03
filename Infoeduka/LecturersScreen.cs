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

namespace Infoeduka
{
    public partial class LecturersScreen : UserControl
    {
        private Subject subject;

        public LecturersScreen(Subject subject)
        {
            InitializeComponent();

            this.subject = subject;
            InitData();
        }

        private void InitData()
        {
            // Removing existing labels
            flpLecturers.Controls.Clear();

            lbSubjectName.Text = subject.Name;
            subject.Lecturers.ForEach(l => flpLecturers.Controls.Add(new Label
            {
                Text = l.ToString(),
                AutoSize = true
            }));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SubjectPrompt prompt = new SubjectPrompt("Edit subject", subject);
            if(prompt.ShowDialog() == DialogResult.OK)
            {
                // Deleting the original subject file
                subject.DeleteJsonFile();

                subject = prompt.GetSubject();
                // Editing the data on the user control
                InitData();
                subject.SaveToJsonFile();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete the subject?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                subject.DeleteJsonFile();
                Parent.Controls.Remove(this);
            }
        }
    }
}
