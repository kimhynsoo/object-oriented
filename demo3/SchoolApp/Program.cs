using SchoolClasses;

DateTime bd = new DateTime(2000, 11, 5);
Person p = new Person(bd);  
p.Name = "Hyeonsu"; 
int ageP=p.GetAge();
Console.WriteLine(ageP);
Console.WriteLine(p.ToString());

DateTime date = new DateTime(2000,11,5);

Student s = new Student(date);

s.Name="Minsu";
s.Faculty = "FAI";
s.Semester = 7;
int ageS = s.GetAge();
Console.WriteLine(ageS);
Console.WriteLine(s.ToString());


// Cast (conversion) 
Person ps = s as Person;
if(ps != null)
{
    Console.WriteLine(ps.Name);
}
//Console.WriteLine(ps.Faculty);   // Error

Student sp = p as Student;
if(sp != null)
{
    Console.WriteLine(sp.Name);
}

ForeignStudent fs = new ForeignStudent();
fs.Name = "Jinno";
fs.Contury = "Korea";

if(fs is Person)
{
    Person pf = (Person)fs;
    Console.WriteLine(pf.Name);
}
Console.WriteLine(fs.ToString());


if (p is ForeignStudent) //false
{
    ForeignStudent fp = (ForeignStudent)p;
    Console.WriteLine(fp.Name);
}

List<Person> people = new List<Person>();
people.Add(p);
people.Add(s);
people.Add(fs);

