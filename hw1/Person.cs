using System;

namespace hw1;

public class Person
{

public string Name{get; set;}="";

public Person(){}

public Person(string name)
    {
        Name=name;
    }

    public override string ToString()
    {
        return $"Person name : {Name}";
    }
    

}
