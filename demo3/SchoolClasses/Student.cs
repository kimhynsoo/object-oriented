using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public /*sealed*/ class Student : Person //Inheritance
    {
        public int Semester;
        public string Faculty;
        private string Advisor;
        public Student()
        {
            Console.WriteLine("New student");
        }
        public Student(DateTime dt) :base(dt)
        {
        }

        public sealed override int GetAge() //sealed : block the inheritance
        {
            DateTime today = DateTime.Now;
            TimeSpan difference = today.Subtract(brithDate);
            double days = difference.TotalDays;
            int age=(int)days/365;
            return age;
        }

        public override string ToString()
        {
            return $"Faculty: {Faculty} " + base.ToString();
        }
    }
}