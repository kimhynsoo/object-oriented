using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Person
    {
        private string id;
        public string Name;
        protected DateTime brithDate;

        public Person()
        {
            Console.WriteLine("New person");
            
        }

        public Person(DateTime bd){
            brithDate = bd;
        }

        public virtual int GetAge()
        {
            return DateTime.Now.Year - brithDate.Year;
        }

        public override string ToString()
        {
            return $"Name: {Name} " + base.ToString();
        }
    }
}