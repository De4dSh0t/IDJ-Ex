using System;

namespace Ex_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = Int32.Parse(Console.ReadLine());
            IPerson person = new Citizen(name, age);

            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
        }
    }
}