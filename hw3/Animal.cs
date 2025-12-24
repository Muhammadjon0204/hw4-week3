using System;

namespace hw3;

public abstract class Animal
{

public string Name
    {
        get;
        set;
    }="";

public  void SetName(string name)
    {
        Name=name;
    }

public  void GetName()
    {
        System.Console.WriteLine($"Animal is {Name}");
    }

public abstract void Eat();



}
