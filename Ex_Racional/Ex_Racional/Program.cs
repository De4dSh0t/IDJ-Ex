using System;

namespace Ex_Racional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Racional r = new Racional(1, 2);
            Racional r2 = new Racional(1, 3);
            Console.WriteLine(r.ToString());
            Console.WriteLine(r.Add(r, r2));
            Console.WriteLine(r.Subtract(r, r2));
            Console.WriteLine(r.Multiply(r, r2));
            Console.WriteLine(r.Divide(r, r2));
        }
    }
}