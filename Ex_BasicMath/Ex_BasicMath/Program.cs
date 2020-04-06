using System;

namespace Ex_BasicMath
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            while (input != "End")
            {
                string[] words = input.Split(" ");
                float n1 = float.Parse(words[1]);
                float n2 = float.Parse(words[2]);
                
                switch (words[0])
                {
                    case "Sum":
                    {
                        Console.WriteLine($"Result: {MathUtil.Sum(n1, n2)}");
                        break;
                    }

                    case "Subtract":
                    {
                        Console.WriteLine($"Result: {MathUtil.Subtract(n1, n2)}");
                        break;
                    }

                    case "Multiply":
                    {
                        Console.WriteLine($"Result: {MathUtil.Multiply(n1, n2)}");
                        break;
                    }

                    case "Divide":
                    {
                        Console.WriteLine($"Result: {MathUtil.Divide(n1, n2)}");
                        break;
                    }

                    case "Percentage":
                    {
                        Console.WriteLine($"Result: {MathUtil.Percentage(n1, n2)}");
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Please insert 'Sum', 'Subtract', 'Multiply', 'Divide' or 'Percentage'!");
                        break;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}