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

                switch (words[1])
                {
                    case "Celsius":
                    {
                        double n = Double.Parse(words[0]);
                        Console.WriteLine($"{Math.Round(TempConverter.ToFahrenheit(n), 2)} Fahrenheit");
                        break;
                    }

                    case "Fahrenheit":
                    {
                        double n = Double.Parse(words[0]);
                        Console.WriteLine($"{Math.Round(TempConverter.ToCelsius(n), 2)} Celsius");
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Insert either 'Celsius' or 'Fahrenheit'!");
                        break;
                    }
                }
                
                input = Console.ReadLine();
            }
        }
    }
}