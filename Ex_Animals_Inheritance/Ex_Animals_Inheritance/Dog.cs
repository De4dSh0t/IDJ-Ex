﻿namespace Ex_Animals_Inheritance
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender) {}

        public string ProduceSound()
        {
            return "BauBau";
        }
    }
}