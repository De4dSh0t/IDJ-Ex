using System;

namespace Ex_TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] words = input.Split( " ");
                if (words[1] == "Celsius")
                {
                    double n = Double.Parse(words[0]);
                    Console.WriteLine($"{Math.Round(TempConverter.ToFahrenheit(n), 2)} Fahrenheit");
                }
                else if(words[1] == "Fahrenheit")
                {
                    double n = Double.Parse(words[0]);
                    Console.WriteLine($"{Math.Round(TempConverter.ToCelsius(n), 2)} Celsius");
                }

                input = Console.ReadLine();
            }
        }
    }
}