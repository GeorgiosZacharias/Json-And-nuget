using System;
using Newtonsoft.Json;
public class Person{
    public string Name { get; set; }
    public int Age {get; set;}

   

    public void PrintPerson(){
        Console.WriteLine($"{Name} , {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
      string json = "{\"Name\": \"John Doe\", \"Age\": 30}";
        Person? person = JsonConvert.DeserializeObject<Person>(json);
            if (person != null)
                {
                    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                    person.PrintPerson();
                }
            else
                {
                    Console.WriteLine("Failed to deserialize JSON");
                }
                
        Person newPerson = new Person { Name = "Ping Jeong", Age = 25 };
        string newJson = JsonConvert.SerializeObject(newPerson);
        Console.WriteLine($"Serialized JSON: {newJson}");
        newPerson.PrintPerson();
    }
}