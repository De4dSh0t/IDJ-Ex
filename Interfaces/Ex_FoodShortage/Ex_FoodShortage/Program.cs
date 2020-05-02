using System;
using System.Collections.Generic;

namespace Ex_FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPersons = Int32.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            Dictionary<string, object> persons = new Dictionary<string, object>();

            for (int i = 0; i < nPersons; i++)
            {
                string personInfo = Console.ReadLine();
                string[] words = personInfo.Split(" ");

                //Serve para verificar se existe nomes repetidos. Caso exista, voltar um index atrás para colocar info nova
                if (names.Contains(words[0]))
                {
                    Console.WriteLine("<Name already exists>");
                    i--;
                    break;
                }
                
                if (words.Length == 4)
                {
                    persons.Add(words[0], new Citizen(words[0], Int32.Parse(words[1]), words[2], words[3]));
                    names.Add(words[0]);
                }
                else if (words.Length == 3)
                {
                    persons.Add(words[0], new Rebel(words[0], Int32.Parse(words[1]), words[2]));
                    names.Add(words[0]);
                }
            }

            string input = Console.ReadLine();
            IBuyer buyer = null;

            while (input != "End")
            {
                foreach (var p in persons)
                {
                    if (input == p.Key)
                    {
                        if (p.Value.GetType() == typeof(Citizen))
                        {
                            Citizen c = new Citizen();
                            c.BuyFood();
                        }
                        else if (p.Value.GetType() == typeof(Rebel))
                        {
                            Rebel r = new Rebel();
                            r.BuyFood();
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(buyer.Food);
        }
    }
}