using System;

namespace Ex_BookShop_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                
                Book book = new Book(author, title, price);
                GoldenEditionBook gB = new GoldenEditionBook(author, title, price);
                
                Console.WriteLine(book);
                Console.WriteLine(gB);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}