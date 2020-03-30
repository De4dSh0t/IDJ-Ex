using System;

namespace Ex_BeerCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] words = input.Split(" ");
                
                int BuyBeer = int.Parse(words[0]);
                int DrinkBeer = int.Parse(words[1]);
                
                if (BuyBeer != 0)
                {
                    BeerCounter.BeerInStock(BuyBeer);
                }

                if (DrinkBeer != 0)
                {
                    BeerCounter.DrinkBeer(DrinkBeer);
                }

                input = Console.ReadLine();
            }
            
            //Console.WriteLine($"{ BeerCounter.BeerInStock(0) } { BeerCounter.DrinkBeer(0) }");
        }
    }
}