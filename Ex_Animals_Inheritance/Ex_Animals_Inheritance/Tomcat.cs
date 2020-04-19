namespace Ex_Animals_Inheritance
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender) : base(name, age, gender) {}

        public string ProduceSound()
        {
            return "Give me one billion b***h";
        }
    }
}