using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dal
{
    public class Notification
    {
        public static string DIRECTORY_NAME = 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @".infoeduka\notifications");
        public string Title { get; set; }
        public string Message { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public DateTime Created { get; set; }

        public Notification(string title, string message, string author, string subject)
        {
            Title = title;
            Message = message;
            Author = author;
            Subject = subject;
            Created = DateTime.Now;
        }

        public string GetFormattedDate()
        {
            return Created.ToString("dd. MM. yyyy.");
        }

        public void SaveToJsonFile()
        {
            string json = JsonSerializer.Serialize(this);
            if (!Directory.Exists(DIRECTORY_NAME)) Directory.CreateDirectory(DIRECTORY_NAME);

            string filename = $"{Created.ToString("dd-MM-yyyy-HH-mm-ss")}-{Subject}";
            File.WriteAllText($"{DIRECTORY_NAME}\\{filename}.json", json);
        }

        public void DeleteJsonFile()
        {
            string filename = $"{Created.ToString("dd-MM-yyyy-HH-mm-ss")}-{Subject}";
            File.Delete($"{DIRECTORY_NAME}\\{filename}.json");
        }

        public static Notification ReadFromJsonFile(string path)
        {
            string json = File.ReadAllText(path);
            Notification? notification = JsonSerializer.Deserialize<Notification>(json);

            return notification;
        }

        public static List<Notification> LoadNotifications()
        {
            List<Notification> list = new List<Notification>();
            if (!Directory.Exists(DIRECTORY_NAME))
            {
                Directory.CreateDirectory(DIRECTORY_NAME);
                return list;
            }

            string[] files =
                Directory.GetFiles(DIRECTORY_NAME, "*.json", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                list.Add(ReadFromJsonFile(file));
            }

            return list;
        }

        public override string ToString()
        {
            return $"{Title}, {Subject}, {Created}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Notification notification &&
                   Title == notification.Title &&
                   Message == notification.Message &&
                   Author == notification.Author &&
                   Subject == notification.Subject &&
                   Created == notification.Created;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Message, Author, Subject, Created);
        }
    }
}
