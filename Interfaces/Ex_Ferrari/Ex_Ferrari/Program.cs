using System;

namespace Ex_Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            ICar car = new Ferrari(name, "488-Spider");

            Console.WriteLine($"{car.Model} | {car.Brakes} | {car.GasPedal} | {car.Name}");
        }
    }
}