using System;

namespace Ex_Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook n1 = new Notebook("Intel", "i5-8300h", 2.30, "Samsung", "K4AAG085WC", 16, "Nvidia", "GTX 1050Ti", 1291, "Samsung", "PM961", 256);
            Notebook n2 = new Notebook("AMD", "Ryzen 7 3700X", 3.60, "HyperX", "Fury", 8, "Radeon", "RX570 OC", 1268, "Samsung", "PM961", 256);

            Console.WriteLine(n1.ToString());
            Console.WriteLine($"Is cpu1 greater than cpu2? { n1.CompareCpu(n1, n2) }");
            Console.WriteLine($"Is ram1 greater than ram2? { n1.CompareMemory(n1, n2) }");
        }
    }
}