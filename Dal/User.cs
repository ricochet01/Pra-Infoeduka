using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dal
{
    public class User
    {
        public static string DIRECTORY_NAME = 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @".infoeduka\users");

        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public UserType UserType { get; set; }

        public User(string firstName, string lastName, string email, string password, UserType userType)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            UserType = userType;
        }

        public void SaveToJsonFile()
        {
            string json = JsonSerializer.Serialize(this);

            if(!Directory.Exists(DIRECTORY_NAME)) Directory.CreateDirectory(DIRECTORY_NAME);
            File.WriteAllText($"{DIRECTORY_NAME}\\{Id}.json", json);
        }

        public static User ReadFromJsonFile(string path)
        {
            string json = File.ReadAllText(path);
            User? user = JsonSerializer.Deserialize<User>(json);

            return user;
        }

        public void DeleteJsonFile()
        {
            File.Delete($"{DIRECTORY_NAME}\\{Id}.json");
        }

        public List<Subject> GetEnrolledSubjects()
        {
            List<Subject> subjects = Subject.LoadSubjects();
            // Admin can post a notification for any subject
            if (UserType == UserType.Admin) return subjects;

            List<Subject> enrolledSubjects = new List<Subject>();

            subjects.ForEach(s =>
            {
                if (s.Lecturers.Contains(this)) enrolledSubjects.Add(s);
            });

            return enrolledSubjects;
        }

        public string GetSignature() => FirstName + " " + LastName;

        public static List<User> LoadLecturers()
        {
            return LoadAllUsers(true);
        }

        public static List<User> LoadAllUsers()
        {
            return LoadAllUsers(false);
        }

        private static User CreateAdminUser()
        {
            User admin = new User("Administrator", "", "admin", "admin", UserType.Admin);
            admin.SaveToJsonFile();

            return admin;
        }

        public static List<User> LoadAllUsers(bool lecturersOnly)
        {
            List<User> users = new List<User>();

            if(!Directory.Exists(DIRECTORY_NAME))
            {
                Directory.CreateDirectory(DIRECTORY_NAME);

                // Create the admin user if it doesn't exists
                User admin = CreateAdminUser();
                users.Add(admin);

                return users;
            }

            string[] files =
                Directory.GetFiles(DIRECTORY_NAME, "*.json", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                User user = ReadFromJsonFile(file);
                if (lecturersOnly)
                {
                    if (user.UserType == UserType.Lecturer) users.Add(user);
                }
                else
                {
                    users.Add(user);
                }
            }

            if(files.Length == 0)
            {
                User admin = CreateAdminUser();
                users.Add(admin);
            }

            return users;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   Id == user.Id &&
                   FirstName == user.FirstName &&
                   LastName == user.LastName &&
                   Email == user.Email &&
                   Password == user.Password &&
                   UserType == user.UserType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, FirstName, LastName, Email, Password, UserType);
        }
    }
}
