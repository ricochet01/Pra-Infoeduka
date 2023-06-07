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

namespace Infoeduka.Notifications
{
    public partial class NotificationFilter : UserControl
    {
        private List<Subject> subjects = Subject.LoadSubjects();
        private IDictionary<Subject, bool> selectedSubjects = new Dictionary<Subject, bool>();

        public NotificationFilter()
        {
            InitializeComponent();

            for(int i = 0; i < subjects.Count; i++)
            {
                Subject s = subjects[i];

                clbSubjects.Items.Add(s);
                clbSubjects.SetItemChecked(i, true);

                selectedSubjects.Add(s, true);
            }

            clbSubjects.ItemCheck += clbSubjects_ItemCheck;
        }

        public IDictionary<Subject, bool> GetSelectedSubjects()
        {
            return selectedSubjects;
        }

        private void clbSubjects_ItemCheck(object? sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                List<Subject> checkedItems = new List<Subject>();
                Subject s = (Subject)clbSubjects.Items[e.Index];

                // Store their checked value for later use in filtering
                selectedSubjects[s] = e.NewValue == CheckState.Checked;

                MainForm mainParentForm = Parent as MainForm;
                List<Subject> checkedSubjects = clbSubjects.SelectedItems.Cast<Subject>().ToList();

                // Filter the notifications on the main form
                mainParentForm.FilterNotifications(selectedSubjects);
            }));
        }

        private void tbSearchBar_TextChanged(object sender, EventArgs e)
        {
            // First, we clear all items in the check list
            string text = tbSearchBar.Text.Trim().ToLower();
            clbSubjects.Items.Clear();

            for(int i = 0; i < subjects.Count; i++)
            {
                Subject s = subjects[i];
                string name = s.Name.ToLower();

                // Go through every subject and add those that match the filter text
                if (name.Contains(text))
                {
                    clbSubjects.Items.Add(s);

                    int index = clbSubjects.Items.IndexOf(s);
                    bool selected = selectedSubjects[s];

                    // Reassign their checked value
                    clbSubjects.SetItemChecked(index, selected);
                }
            }
        }
    }
}
