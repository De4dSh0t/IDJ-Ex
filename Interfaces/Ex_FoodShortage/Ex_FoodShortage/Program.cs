using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPersons = Int32.Parse(Console.ReadLine());
            Dictionary<string, IBuyer> persons = new Dictionary<string, IBuyer>();

            for (int i = 0; i < nPersons; i++)
            {
                string personInfo = Console.ReadLine();
                string[] words = personInfo.Split(" ");

                //Serve para verificar se existe nomes repetidos. Caso exista, voltar um index atrás para colocar info nova
                if (persons.ContainsKey(words[0]))
                {
                    Console.WriteLine("<Name already exists>");
                    i--;
                    break;
                }
                
                if (words.Length == 4)
                {
                    persons.Add(words[0], new Citizen(words[0], Int32.Parse(words[1]), words[2], words[3]));
                }
                else if (words.Length == 3)
                {
                    persons.Add(words[0], new Rebel(words[0], Int32.Parse(words[1]), words[2]));
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                foreach (var p in persons)
                {
                    if (p.Key == input)
                    {
                        p.Value.BuyFood();
                    }
                }

                input = Console.ReadLine();
            }

            int totalFood = 0;
            
            foreach (var p in persons)
            {
                totalFood += p.Value.Food;
            }

            Console.WriteLine(totalFood);
        }
    }
}