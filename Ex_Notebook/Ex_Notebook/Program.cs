using System;

namespace Ex_Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook n = new Notebook("Intel", "i5-8300h", 2.30, "Samsung", "K4AAG085WC", 12, "Nvidia", "GTX 1050Ti", 1291, "Samsung", "PM961", 256);

            Console.WriteLine(n.ToString());
        }
    }
}