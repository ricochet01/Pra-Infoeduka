using Dal;
using System.Diagnostics;

namespace Infoeduka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // User admin = new User("admin", "", "admin", "admin", UserType.Admin);
            // admin.SaveToJsonFile();

            List<User> allUsers = new List<User>();

            string[] files =
                Directory.GetFiles("users", "*.json", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                allUsers.Add(User.ReadFromJsonFile(file));
            }

            Subject s = new Subject("Matematika JEDAN");
            User user = allUsers[0];

            s.AddLecturer(user);
            lblUser.Text = user.ToString();
            // Debug.WriteLine(allUsers.Count);
            // allUsers.ForEach(Console.WriteLine);

            lblSubjects.Text = s.ToString();

            user.SaveToJsonFile();
            s.SaveToJsonFile();

            Notification n = new Notification("Hello world!", "lorem ipsum", user.GetSignature(), s.Name);
            n.SaveToJsonFile();
        }
    }
}