using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics_Library
{
    public class Video : Media
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Director { get; set; }
        public string Duration { get; set; }

        public Video(string title, string publisher, string director, string duration)
        {
            Title = title;
            Publisher = publisher;
            Director = director;
            Duration = duration;
        }

        public void display_info()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"Duration: {Duration}");
        }
    }
    
}