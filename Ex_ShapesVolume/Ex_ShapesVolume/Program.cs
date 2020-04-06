using System;

namespace Ex_ShapesVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangularPrism tP = new TriangularPrism();
            Cube c = new Cube();
            Cylinder cy = new Cylinder();
            
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] words = input.Split(" ");

                switch (words[0])
                {
                    case "Cube":
                    {
                        c.SideLength = double.Parse(words[1]);
                        Console.WriteLine($"Result: { VolumeCalculator.VolumeCube() }");
                        break;
                    }

                    case "Cylinder":
                    {
                        cy.Radius = double.Parse(words[1]);
                        cy.Height = double.Parse(words[2]);
                        Console.WriteLine($"Result: { VolumeCalculator.VolumeCylinder() }");
                        break;
                    }

                    case "TrianglePrism":
                    {
                        tP.BaseSide = double.Parse(words[1]);
                        tP.Height = double.Parse(words[2]);
                        tP.Length = double.Parse(words[3]);
                        Console.WriteLine($"Result: { VolumeCalculator.VolumeTP() }");
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Please insert 'Cube', 'Cylinder' or 'TrianglePrism'!");
                        break;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}