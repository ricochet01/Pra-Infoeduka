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
    public partial class SubjectPrompt : Form
    {
        private Subject? data;

        public SubjectPrompt(string title, Subject data)
        {
            InitializeComponent();
            this.Text = title;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            LoadLecturers();

            if (data != null)
            {
                this.data = data;
                // TODO: Load all input fields with subject data
            }
        }

        private void LoadLecturers()
        {
            List<User> lecturers = User.LoadLecturers();

            lecturers.ForEach(l => cbLecturers.Items.Add(l));
        }

        private void cbLecturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;

            User selectedUser = (User)cmb.Items[selectedIndex];

            lbActiveLecturers.Items.Add(selectedUser);
            cmb.Items.RemoveAt(selectedIndex);
            cmb.SelectedIndex = -1;
        }

        private void lbActiveLecturers_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove the lecturer?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // Removing the lecturer if the user presses yes
            if(result == DialogResult.Yes)
            {
                int selectedLecturer = lbActiveLecturers.SelectedIndex;
                User lec = (User)lbActiveLecturers.Items[selectedLecturer];

                lbActiveLecturers.Items.RemoveAt(selectedLecturer);
                // Returning the removed lecturer to the dropdown list
                cbLecturers.Items.Add(lec);
            }
        }

        public Subject GetSubject()
        {
            Subject s = new Subject(tbSubjectName.Text);
            var listOfLecturers = lbActiveLecturers.Items.Cast<User>().ToList();

            s.Lecturers = listOfLecturers;

            return s;
        }
    }
}
