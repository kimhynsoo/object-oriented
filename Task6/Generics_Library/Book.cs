using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics_Library
{
    public class Book : Media
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book(string title, string publisher, string author, int pages)
        {
            Title = title;
            Publisher = publisher;
            Author = author;
            Pages = pages;
        }

        public void display_info()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Pages: {Pages}");
        }
        
    }
}