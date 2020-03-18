using System;
using System.Diagnostics.CodeAnalysis;

namespace Ex_Carta
{
    class Program
    {
        static void Main(string[] args)
        {
            Baralho b = new Baralho();

            bool flag = false;

            while (!flag)
            {
                ConsoleKeyInfo info = Console.ReadKey();

                Console.WriteLine("");
                Console.WriteLine("/////////////////////////////");
                Console.WriteLine("");
                Console.WriteLine("(1) Shuffle");
                Console.WriteLine("(2) Draw a Card");
                Console.WriteLine("(3) Check Card");
                Console.WriteLine("(4) Print Deck");
                Console.WriteLine("");
                Console.WriteLine("/////////////////////////////");
                Console.WriteLine("");
                
                if (info.KeyChar == '1')
                {
                    Console.WriteLine("Shuffling...");
                    b.Shuffle();
                    Console.WriteLine("Shuffle Done!");
                }
                
                if (info.KeyChar == '2')
                {
                    Console.WriteLine($"You draw the card: { b.DrawACard().Nome }");
                }

                if (info.KeyChar == '3')
                {
                    Console.WriteLine("What card do u want to search? ");
                    string card = Console.ReadLine();
                    if (b.CheckCard(card) == false)
                    {
                        Console.WriteLine("That card isn't on the deck. Please try searching like 'ÁS DE PAUS'.");
                    }
                    else
                    {
                        Console.WriteLine("That card is on the deck!");
                    }
                }

                if (info.KeyChar == '4')
                {
                    b.PrintDeck();
                }

                if (info.KeyChar == '0')
                {
                    flag = true;
                }
            }
        }
    }
}