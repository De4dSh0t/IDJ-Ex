namespace Ex_BookShop_Inheritance
{
    public class GoldenEditionBook : Book
    {
        protected override double Price => base.Price * 1.3;
        public GoldenEditionBook(string author, string title, double price) : base(author, title, price) {}
    }
}