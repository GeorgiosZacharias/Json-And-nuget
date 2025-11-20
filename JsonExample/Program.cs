using System;

public class Person{
    public string Name { get; set; }
    public int Age {get; set;}

    public Person(string name , int age){
        Name=name;
        Age=age;
    }

    public void PrintPerson(){
        Console.WriteLine($"{Name} , {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
      
    }
}