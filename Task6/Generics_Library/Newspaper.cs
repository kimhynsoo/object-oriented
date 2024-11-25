using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics_Library
{
    public class Newspaper : Media
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Date { get; set; }
        public string Headline { get; set; }

        public Newspaper(string title, string publisher, string date, string headline)
        {
            Title = title;
            Publisher = publisher;
            Date = date;
            Headline = headline;
        }

        public void display_info()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Headline: {Headline}");
        }

    }
}