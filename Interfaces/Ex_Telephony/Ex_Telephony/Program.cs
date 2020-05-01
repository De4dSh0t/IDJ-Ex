using System;

namespace Ex_Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string url = Console.ReadLine();
            string[] numbers = number.Split(" ");
            string[] urls = url.Split(" ");
            
            try
            {
                IModel smartphone = new Smartphone();
                for (int i = 0; i < numbers.Length; i++)
                {
                    smartphone.Number = numbers[i];
                    Console.WriteLine(smartphone.Call());
                }

                for (int i = 0; i < urls.Length; i++)
                {
                    smartphone.URL = urls[i];
                    Console.WriteLine(smartphone.Browse());
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}