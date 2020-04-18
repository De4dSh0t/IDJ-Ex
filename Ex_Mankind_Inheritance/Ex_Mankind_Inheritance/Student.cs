using System;

namespace Ex_Mankind_Inheritance
{
    public class Student : Human
    {
        private int number;

        public int Number
        {
            get => number;
            set
            {
                if (number.ToString().Length < 5 || number.ToString().Length > 10) //Verifica se o comprimento do número está entre 5 a 10 números 
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
            }
        }
        
        public Student(string firstName, string lastName) : base(firstName, lastName) {}
    }
}