using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendingClasses
{
    public class Email : Message
    {
        public List<string> To = new List<string>();
        public string Subject;

        public string From;

        public void AddRecipent(string recipent)
        {
            To.Add(recipent);
        }

        public override void Send()
        {
            Console.WriteLine("Sending Email");
            Console.WriteLine("From :" + From);
            Console.WriteLine("To :");
            foreach (var recipent in To)
            {
                Console.WriteLine(recipent);
            }
            Console.WriteLine("Subject :" + Subject);
            Console.WriteLine("Content :" + Content);
        }

        public Email(string subject, string from, string content)
        {
            Subject = subject;
            From = from;
            Content = content;
        }


        
    }
}