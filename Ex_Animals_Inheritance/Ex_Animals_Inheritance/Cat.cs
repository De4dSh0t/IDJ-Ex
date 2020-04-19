namespace Ex_Animals_Inheritance
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string gender) : base(name, age, gender) {}

        public string ProduceSound()
        {
            return "MiauMiau";
        }
    }
}