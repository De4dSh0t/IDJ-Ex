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
            r.ToString();
            r.Add(r, r2);
        }
    }
}