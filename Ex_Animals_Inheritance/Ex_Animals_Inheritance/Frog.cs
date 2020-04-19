namespace Ex_Animals_Inheritance
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string gender) : base(name, age ,gender) {}

        public string ProduceSound()
        {
            return "Frogggg";
        }
    }
}