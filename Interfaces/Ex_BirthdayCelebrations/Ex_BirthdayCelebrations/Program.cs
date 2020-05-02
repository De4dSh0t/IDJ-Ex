using System;
using System.Collections.Generic;

namespace Ex_BirthdayCelebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> ids = new List<string>();
            List<string> birthdays = new List<string>();

            while (input != "End")
            {
                string[] words = input.Split(" ");
                IIdentifiable identifiable;
                IBirthable birthable;

                switch (words[0])
                {
                    case "Citizen":
                    {
                        birthable = new Citizen(words[1], Int32.Parse(words[2]), words[3], words[4]);
                        birthdays.Add(birthable.Birthday);
                        break;
                    }
                    case "Robot":
                    {
                        identifiable = new Robot(words[1], words[2]);
                        ids.Add(identifiable.Id);
                        break;
                    }
                    case "Pet":
                    {
                        birthable = new Pet(words[1], words[2]);
                        birthdays.Add(birthable.Birthday);
                        break;
                    }
                }

                input = Console.ReadLine();
            }

            string year = Console.ReadLine();

            for (int i = 0; i < birthdays.Count; i++)
            {
                if (birthdays[i].Contains(year))
                {
                    Console.WriteLine(birthdays[i]);
                }
                else
                {
                    Console.WriteLine("<Empty Output>");
                }
            }
        }
    }
}