using System;

namespace hw1;

public class Student : Person
{

public Student(){}

public Student(string name) : base(name){}

public void Study()
    {
        System.Console.WriteLine($"{Name} (student) is studying");
    }

    public override string ToString()
    {
        return $"Student name : {Name}";
    }

}
