using System;

namespace Ex_MultipleImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = Int32.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            
            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            IBirthable birthable = new Citizen(name, age, id, birthdate);

            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.Birthdate);
        }
    }
}