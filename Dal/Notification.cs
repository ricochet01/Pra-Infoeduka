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
        public const string DIRECTORY_NAME = "notifications";
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

        public void SaveToJsonFile()
        {
            string json = JsonSerializer.Serialize(this);

            if (!Directory.Exists(DIRECTORY_NAME)) Directory.CreateDirectory(DIRECTORY_NAME);

            string filename = $"{Created.ToString("dd-MM-yyyy-HH-mm-ss")}-{Subject}";
            File.WriteAllText($"{DIRECTORY_NAME}\\{filename}.json", json);
        }

        public static Notification ReadFromJsonFile(string path)
        {
            string json = File.ReadAllText(path);
            Notification? notification = JsonSerializer.Deserialize<Notification>(json);

            return notification;
        }

        public override string ToString()
        {
            return $"{Title}, {Subject}, {Created}";
        }
    }
}
