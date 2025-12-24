
using System.Runtime.CompilerServices;
using hw1;

Person[] people=new Person[3];

System.Console.WriteLine("============Study Manegment============");
System.Console.WriteLine("Enter 3 name of persons : ");
System.Console.WriteLine();
for(int i = 0; i < 3; i++)
{
    System.Console.Write($"Name {1+i} : ");
    string name = Console.ReadLine();
    if (i == 0)
    {
        people[i]=new Teacher(name);
    }
    else 
    {
        people[i]=new Student(name);
    }
}
System.Console.WriteLine();

foreach (Person person in people)
{
    
System.Console.WriteLine(person.ToString());

}
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine(new string('=',20));
System.Console.WriteLine();
foreach (Person person in people)
{
    
if(person is Teacher teacher)
    {
        teacher.Explain();
    }
    else if(person is Student student)
    {
        student.Study();
    }

}

