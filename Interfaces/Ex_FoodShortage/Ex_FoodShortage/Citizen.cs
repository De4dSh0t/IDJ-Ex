namespace Ex_FoodShortage
{
    public class Citizen : IBuyer
    {
        private int food;
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthday { get; set; }
        public int Food
        {
            get => food;
            set => food = value;
        }

        public Citizen() {}

        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthday;
        }

        public void BuyFood()
        {
            food += 10;
        }
    }
}