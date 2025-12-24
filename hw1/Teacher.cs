using System;

namespace hw1;

public class Teacher : Person
{

    public Teacher(){}

    public Teacher(string name):base(name){}

    public void Explain()
    {
        System.Console.WriteLine($"{Name} (teacher) is explaining");
    }

    public override string ToString()
    {
        return $"Teacher name : {Name}";
    }

}
