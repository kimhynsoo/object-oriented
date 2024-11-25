using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics_Library
{
    public class Library<T> where T : Media
    {
        private List<T> media_list = new List<T>();

        public void add_media(T media)
        {
            media_list.Add(media);
            Console.WriteLine($"{media.Title} added successfully");
        }

        public void display_media()
        {
            foreach (T media in media_list)
            {
                media.display_info();
            }
        }

        public void search_media(string title)
        {
            foreach (T media in media_list)
            {
                if (media.Title == title)
                {
                    media.display_info();
                    return;
                }
            }
            Console.WriteLine("Media not found");
        }

        
    }
}