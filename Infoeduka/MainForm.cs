using Dal;
using System.Diagnostics;

namespace Infoeduka
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //User admin = new User("admin", "", "admin", "admin", UserType.Admin);
            //admin.SaveToJsonFile();

            //for (int i = 0; i < 10; i++)
            //{
            //    User u = new User
            //        ("FirstName" + i, "LastName" + i, "user" + i + "@email.com", "password", UserType.Lecturer);
            //    u.SaveToJsonFile();
            //}

            //List<User> allUsers = new List<User>();

            //string[] files =
            //    Directory.GetFiles("users", "*.json", SearchOption.AllDirectories);

            //foreach (string file in files)
            //{
            //    allUsers.Add(User.ReadFromJsonFile(file));
            //}

            //Subject s = new Subject("Matematika JEDAN");
            //User user = allUsers[0];

            //s.AddLecturer(user);
            //// lblUser.Text = user.ToString();
            //// Debug.WriteLine(allUsers.Count);
            //// allUsers.ForEach(Console.WriteLine);

            //// lblSubjects.Text = s.ToString();

            //user.SaveToJsonFile();
            //s.SaveToJsonFile();

            //Notification n = new Notification("Hello world!", "lorem ipsum", user.GetSignature(), s.Name);
            //n.SaveToJsonFile();

            List<Subject> l = Subject.LoadSubjects();
            foreach (Subject s in l)
            {
                flpContainer.Controls.Add(new LecturersScreen(s));
            }
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
            SubjectPrompt subjectPopup = new SubjectPrompt("Add new subject", null);
            if(subjectPopup.ShowDialog() == DialogResult.OK)
            {
                Subject newSubject = subjectPopup.GetSubject();
                newSubject.SaveToJsonFile();
            }
        }
    }
}