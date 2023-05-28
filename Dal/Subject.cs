using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dal
{
    public class Subject
    {
        public const string DIRECTORY_NAME = "subjects";
        public string Name { get; set; }
        public List<User> Lecturers { get; set; }

        public Subject(string name)
        {
            Name = name;
            Lecturers = new List<User>();
        }

        public void AddLecturer(User user)
        {
            Lecturers.Add(user);
        }

        public void SaveToJsonFile()
        {
            string json = JsonSerializer.Serialize(this);

            if (!Directory.Exists(DIRECTORY_NAME)) Directory.CreateDirectory(DIRECTORY_NAME);
            File.WriteAllText($"{DIRECTORY_NAME}\\{Name.ToLower()}.json", json);
        }

        public static Subject ReadFromJsonFile(string path)
        {
            string json = File.ReadAllText(path);
            Subject? subject = JsonSerializer.Deserialize<Subject>(json);

            return subject;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
