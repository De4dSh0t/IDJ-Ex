namespace Ex_Animals_Inheritance
{
    public class Kittens : Cat
    {
        public Kittens(string name, int age, string gender) : base(name, age, gender) {}

        public string ProduceSound()
        {
            return "Miau";
        }
    }
}