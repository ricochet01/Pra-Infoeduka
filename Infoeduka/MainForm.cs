using Dal;
using Infoeduka.Authentication;
using Infoeduka.Lecturer;
using Infoeduka.notifications;
using Infoeduka.Notifications;
using System.Diagnostics;

namespace Infoeduka
{
    public partial class MainForm : Form
    {
        private Color buttonColor = SystemColors.Control;
        private Color activeButtonColor = SystemColors.ActiveCaption;
        private Color disabledButtonColor = SystemColors.ControlDarkDark;

        private User currentUser;
        private MenuType currentMenu;

        private bool filterVisible = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Notification n = new Notification("Hello world!", "lorem ipsum", user.GetSignature(), s.Name);
            //n.SaveToJsonFile();

            List<User> users = User.LoadAllUsers();

            // Prompting the user to log in
            LoginForm login = new LoginForm(users);
            if(login.ShowDialog() == DialogResult.Cancel)
            {
                Close();
            }

            // If the user's successfully authenticated, we proceed
            currentUser = login.GetAuthenticatedUser();

            DisplayNotifications();
            ChangeButtonColors(btnHome);

            if (currentUser.UserType != UserType.Admin)
            {
                btnLecturers.Hide();
                btnSubjects.Hide();
            }

            lblUsername.Text = currentUser.ToString();
            // Moving the label to the left so that the entire text fits within bounds
            int x = Width - lblUsername.Width - 16;
            lblUsername.Location = new Point(x, lblUsername.Location.Y);

            notificationFilter.Visible = filterVisible;
            
        }

        public void FilterNotifications(IDictionary<Subject, bool> checkedSubjects)
        {
            List<string> subjectNames = new List<string>();
            // Populating the subject names list

            foreach(KeyValuePair<Subject, bool> checkedSubject in checkedSubjects)
            {
                Subject subject = checkedSubject.Key;
                if (checkedSubject.Value) subjectNames.Add(subject.Name);
            }

            foreach (NotificationScreen screen in flpContainer.Controls.OfType<NotificationScreen>())
            {
                Notification n = screen.GetNotification();

                screen.Visible = subjectNames.Contains(n.Subject);
            }
        }

        private void DisplayNotifications()
        {
            lblCurrentMenu.Text = "Notifications";
            flpContainer.Controls.Clear();

            List<Notification> notifications = Notification.LoadNotifications();
            foreach(Notification n in notifications)
            {
                flpContainer.Controls.Add(new NotificationScreen(n, currentUser));
            }

            FilterNotifications(notificationFilter.GetSelectedSubjects());
        }

        private void DisplayLecturers()
        {
            lblCurrentMenu.Text = "Lecturers";
            flpContainer.Controls.Clear();

            List<User> l = User.LoadLecturers();
            foreach (User u in l)
            {
                flpContainer.Controls.Add(new LecturerScreen(u));
            }
        }

        private void DisplaySubjects()
        {
            lblCurrentMenu.Text = "Subjects";
            flpContainer.Controls.Clear();

            List<Subject> l = Subject.LoadSubjects();
            foreach (Subject s in l)
            {
                flpContainer.Controls.Add(new SubjectScreen(s));
            }
        }

        private void ChangeMenu(MenuType menu)
        {
            currentMenu = menu;

            // Hide the filter when we change the menu
            filterVisible = false;
            notificationFilter.Visible = filterVisible;

            // Disable the add button
            DisableButtons(menu);

            switch (menu)
            {
                case MenuType.Notifications:
                    DisplayNotifications();
                    break;
                case MenuType.Lecturers:
                    DisplayLecturers();
                    break;
                case MenuType.Subjects:
                    DisplaySubjects();
                    break;
            }
        }

        private void DisableButtons(MenuType menu)
        {
            // First we check if we have to disable the add button
            bool shouldDisableAddButton = menu == MenuType.Lecturers;
            btnAdd.Enabled = !shouldDisableAddButton;

            if (shouldDisableAddButton) btnAdd.BackColor = disabledButtonColor;
            else btnAdd.BackColor = buttonColor;

            // And then, we disable the filter button
            bool shouldDisableFilterButton = (menu == MenuType.Lecturers) || (menu == MenuType.Subjects);
            btnFilter.Enabled = !shouldDisableFilterButton;

            if(shouldDisableFilterButton) btnFilter.BackColor = disabledButtonColor;
            else btnFilter.BackColor = buttonColor;

        }

        private void uiButton_MouseEnter(object sender, EventArgs e)
        {
            PictureBox? pb = sender as PictureBox;
            pb.BorderStyle = BorderStyle.FixedSingle;
        }

        private void uiButton_MouseLeave(object sender, EventArgs e)
        {
            PictureBox? pb = sender as PictureBox;
            pb.BorderStyle = BorderStyle.None;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(currentMenu == MenuType.Subjects)
            {
                SubjectPrompt subjectPopup = new SubjectPrompt("Add new subject", null);
                if (subjectPopup.ShowDialog() == DialogResult.OK)
                {
                    Subject newSubject = subjectPopup.GetSubject();

                    SubjectScreen subjectScreen = new SubjectScreen(newSubject);
                    flpContainer.Controls.Add(subjectScreen);
                    newSubject.SaveToJsonFile();
                }
            }
            else if(currentMenu == MenuType.Notifications)
            {
                NotificationPrompt notificationPopup = 
                    new NotificationPrompt("Add new notification", null, currentUser);
                if (notificationPopup.ShowDialog() == DialogResult.OK)
                {
                    Notification newNotification = notificationPopup.GetNotification();

                    NotificationScreen notificationScreen = new NotificationScreen(newNotification, currentUser);
                    flpContainer.Controls.Add(notificationScreen);
                    newNotification.SaveToJsonFile();
                }
            }

        }

        private void ChangeButtonColors(Button active)
        {
            foreach (Button btn in Controls.OfType<Button>())
            {
                if (!btn.Enabled) continue;

                if (btn == active) btn.BackColor = activeButtonColor;
                else btn.BackColor = buttonColor;
            }
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            ChangeMenu(MenuType.Subjects);
            ChangeButtonColors(sender as Button);
        }

        private void btnLecturers_Click(object sender, EventArgs e)
        {
            ChangeMenu(MenuType.Lecturers);
            ChangeButtonColors(sender as Button);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ChangeMenu(MenuType.Notifications);
            ChangeButtonColors(sender as Button);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Filter button is only enabled when the user is at home
            filterVisible = !filterVisible;

            notificationFilter.Visible = filterVisible;
        }
    }
}