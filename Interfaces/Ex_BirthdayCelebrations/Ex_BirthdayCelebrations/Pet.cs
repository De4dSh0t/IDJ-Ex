namespace Ex_BirthdayCelebrations
{
    public class Pet : IBirthable
    {
        public string Name { get; set; }
        public string Birthday { get; set; }

        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }
    }
}