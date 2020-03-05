using System;

namespace Ex_Paralelepipedo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Paralelepipedo p = new Paralelepipedo(r.Next(-10, 100), r.Next(-10, 100), r.Next(-10,100));

            Console.WriteLine("");
            Console.WriteLine("////////////////////////////////////////////////////");
            Console.WriteLine($"Volume: {p.Volume()}");
            Console.WriteLine($"Área Total: {p.Area()}");
            Console.WriteLine($"É 3D? {p.Is3D()}");
            Console.WriteLine($"É um cubo? {p.IsACube()}");
            Console.WriteLine($"Dimensões: {p.ToString()}");
            Console.WriteLine("////////////////////////////////////////////////////");
            Console.WriteLine("");
        }
    }
}
