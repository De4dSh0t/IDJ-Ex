namespace Ex_FoodShortage
{
    public class Rebel : IBuyer
    {
        private int food;
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food
        {
            get => food;
            set => food = value;
        }

        public Rebel() {}
        
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }
        
        public void BuyFood()
        {
            food += 5;
        }
    }
}