using System;
using System.Globalization;
using System.Linq;

double[] grades = new double[5];
Console.WriteLine("Input your 5 grades (numeric values.)");
for (int i=0; i<5; i++)
{
    grades[i]=double.Parse(Console.ReadLine());
}

double max= grades.Max();
double min= grades.Min();
double avg=grades.Average();

Console.WriteLine("Maximum grade is {0}\nMinimum grade is {1}\nThe Average of grades is {2}",max,min,avg.ToString("F2"));