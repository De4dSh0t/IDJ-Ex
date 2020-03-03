using System;

namespace Ex_Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo rect = new Retangulo(10, 3);

            Console.WriteLine("");
            Console.WriteLine("//////////////////////////////////");
            Console.WriteLine($"Perímetro: {rect.Perimetro()}");
            Console.WriteLine($"Área: {rect.Area()}");
            Console.WriteLine($"É um quadrado? {rect.Quadrado()}");
            Console.WriteLine($"Dimensões: {rect.ToString()}");
            Console.WriteLine("//////////////////////////////////");
            Console.WriteLine("");
        }
    }
}