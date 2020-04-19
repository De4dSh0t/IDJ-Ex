using System;

namespace Ex_Animals_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            string input = Console.ReadLine();
            string[] iWords = input.Split(" ");

            try
            {
                while (input != "Beast!")
                {
                    switch (animal)
                    {
                        case "Dog":
                        {
                            Dog d = new Dog(iWords[0], Int32.Parse(iWords[1]), iWords[2]);
                            Console.WriteLine(d.ProduceSound());
                            break;
                        }

                        case "Frog":
                        {
                            Frog f = new Frog(iWords[0], Int32.Parse(iWords[1]), iWords[2]);
                            Console.WriteLine(f.ProduceSound());
                            break;
                        }

                        case "Cat":
                        {
                            if (iWords[2] == "Male")
                            {
                                Tomcat tC = new Tomcat(iWords[0], Int32.Parse(iWords[1]), iWords[2]);
                                Console.WriteLine(tC.ProduceSound());
                            }
                            else
                            {
                                Kittens k = new Kittens(iWords[0], Int32.Parse(iWords[1]), iWords[2]);
                                Console.WriteLine(k.ProduceSound());
                            }
                            break;
                        }
                    }

                    input = Console.ReadLine();
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}