using System;

namespace Ex_AnimalClinic
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            AnimalClinic aC = new AnimalClinic();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] words = input.Split(" ");
                a.Name = words[0];
                a.Breed = words[1];

                switch (words[2])
                {
                    case "heal":
                    {
                        aC.HealAnimal(a);
                        break;
                    }

                    case "rehabilitate":
                    {
                        aC.RehabAnimal(a);
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Please insert 'heal' or 'rehabilitate'!");
                        break;
                    }
                }
                
                input = Console.ReadLine();
                
                if (input == "End")
                {
                    Console.WriteLine($"Total healed animals: { aC.HealedAnimalsCount }");
                    Console.WriteLine($"Total rehabilitated animals: { aC.RehabAnimalsCount }");
                }
            }
        }
    }
}