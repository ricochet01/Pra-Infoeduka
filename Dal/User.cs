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
        public const string DIRECTORY_NAME = "users";

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

        public string GetSignature() => FirstName + " " + LastName;

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public static List<User> LoadLecturers()
        {
            List<User> lecturers = new List<User>();

            string[] files =
                Directory.GetFiles("users", "*.json", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                User user = ReadFromJsonFile(file);
                if(user.UserType == UserType.Lecturer) lecturers.Add(user);
            }

            return lecturers;
        }
    }
}
