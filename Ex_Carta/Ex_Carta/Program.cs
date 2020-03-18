using System;
using System.Diagnostics.CodeAnalysis;

namespace Ex_Carta
{
    class Program
    {
        static void Main(string[] args)
        {
            Baralho b = new Baralho();
            b.Shuffle();
            Console.WriteLine($"Carta retirada: {b.DrawACard().Nome}");
            b.CheckCard("ÁS DE PAUS");
            b.PrintDeck();
        }
    }
}