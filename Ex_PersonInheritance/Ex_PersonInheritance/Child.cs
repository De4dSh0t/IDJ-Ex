using System;

namespace Ex_PersonInheritance
{
    public class Child : Person
    {
        protected override int Age
        {
            get => base.Age;
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }
                
                base.Age = value;
            }
        }

        public Child(string name, int age) : base(name, age)
        {
            Age = age;
            base.Name = name;
            base.Age = Age;
        }
    }
}