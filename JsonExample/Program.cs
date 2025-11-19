using System;
using Newtonsoft.Json;
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
      string json = "{\"Name\": \"John Doe\", \"Age\": 30}";
        Person person = JsonConvert.DeserializeObject<Person>(json);
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}