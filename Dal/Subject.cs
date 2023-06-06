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
        public static string DIRECTORY_NAME = 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @".infoeduka\subjects");
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

        public void RemoveLecturer(User user)
        {
            Lecturers.Remove(user);
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

        public static List<Subject> LoadSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            if (!Directory.Exists(DIRECTORY_NAME))
            {
                Directory.CreateDirectory(DIRECTORY_NAME);
                return subjects;
            }

            string[] files =
                Directory.GetFiles(DIRECTORY_NAME, "*.json", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                subjects.Add(ReadFromJsonFile(file));
            }

            return subjects;
        }

        public void DeleteJsonFile()
        {
            File.Delete($"{DIRECTORY_NAME}\\{Name.ToLower()}.json");
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Subject subject &&
                   Name == subject.Name &&
                   EqualityComparer<List<User>>.Default.Equals(Lecturers, subject.Lecturers);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Lecturers);
        }
    }
}
