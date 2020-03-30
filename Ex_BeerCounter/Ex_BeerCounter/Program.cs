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
                
                BeerCounter.BeerInStock(BuyBeer);
                BeerCounter.DrinkBeer(DrinkBeer);

                input = Console.ReadLine();
            }
            
            Console.WriteLine($"{ BeerCounter.beerInStock } { BeerCounter.beersDrankCount }");
        }
    }
}