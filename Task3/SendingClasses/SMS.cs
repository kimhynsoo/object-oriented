using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendingClasses
{
    public class SMS : Message
    {
        public string To;

        public override void Send()
        {
            Console.WriteLine("Sending SMS");
            Console.WriteLine("To :" + To);
            Console.WriteLine("Content :" + Content);
        }

        public SMS(string to, string content)
        {
            To = to;
            Content = content;
        }


    }
}