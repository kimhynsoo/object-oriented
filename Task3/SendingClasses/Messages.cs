using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendingClasses
{
    public class Message
    {
        
        public  String Content;

        public virtual void Send()
        {
            Console.WriteLine("Sending message");
        }

       
    }
}