using System;
using System.Text;

namespace Ex_BookShop_Inheritance
{
    public class Book
    {
        private string title;
        private string author;
        private double price;

        protected string Title
        {
            get => title;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                title = value;
            }
        }

        protected string Author
        {
            get => author;
            set
            {
                string[] words = value.Split();

                if (Char.IsLetter(words[1][0]) == false)
                {
                    throw new ArgumentException("Author not valid!");
                }

                author = value;
            }
        }

        protected virtual double Price
        {
            get => price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                
                price = Math.Round(value, 1);
            }
        }

        public Book(string author, string title, double price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder sB = new StringBuilder();
            sB.Append("Type: ").Append(GetType().Name)
                .Append(Environment.NewLine)
                .Append("Title: ").Append(Title)
                .Append(Environment.NewLine)
                .Append("Author: ").Append(Author)
                .Append(Environment.NewLine)
                .Append("Pice: ").Append(Price).Append(" €")
                .Append(Environment.NewLine);

            return sB.ToString();
        }
    }
}