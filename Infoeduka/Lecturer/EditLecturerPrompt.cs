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
    public partial class EditLecturerPrompt : Form
    {
        private User lecturer;
        private List<Subject> subjects;

        public EditLecturerPrompt(User lecturer)
        {
            InitializeComponent();
            this.lecturer = lecturer;

            LoadSubjects();

            // Loading all data
            tbFirstName.Text = lecturer.FirstName;
            tbLastName.Text = lecturer.LastName;

            // Inserting the subjects in which the lecturer is a part of
            subjects.ForEach(s =>
            {
                if(s.Lecturers.Contains(lecturer))
                {
                    cbSubjects.Items.Remove(s);
                    lbActiveSubjects.Items.Add(s);
                }
            });
        }

        private void LoadSubjects()
        {
            subjects = Subject.LoadSubjects();

            subjects.ForEach(l => cbSubjects.Items.Add(l));
        }

        public User GetLecturer()
        {
            User l = new User(
                tbFirstName.Text,
                tbLastName.Text,
                lecturer.Email,
                lecturer.Password,
                lecturer.UserType
            );

            return l;
        }
        
        public List<Subject> GetLecturerSubjects()
        {
            return lbActiveSubjects.Items.Cast<Subject>().ToList();
        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;

            Subject selectedSubject = (Subject)cmb.Items[selectedIndex];

            lbActiveSubjects.Items.Add(selectedSubject);
            cmb.Items.RemoveAt(selectedIndex);
            cmb.SelectedIndex = -1;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((tbFirstName.Text.Trim().Length == 0) || (tbLastName.Text.Trim().Length == 0))
            {
                MessageBox.Show(
                    "You must fill in the first and last name!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void lbActiveSubjects_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to remove the subject?",
            "Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            // Removing the lecturer if the user presses yes
            if (result == DialogResult.Yes)
            {
                int selectedSubject = lbActiveSubjects.SelectedIndex;
                Subject lec = (Subject)lbActiveSubjects.Items[selectedSubject];

                lbActiveSubjects.Items.RemoveAt(selectedSubject);
                // Returning the removed lecturer to the dropdown list
                cbSubjects.Items.Add(lec);
            }
        }
    }
}
