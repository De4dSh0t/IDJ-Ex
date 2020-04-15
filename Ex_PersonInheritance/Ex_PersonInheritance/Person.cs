﻿using System;
using System.Text;

namespace Ex_PersonInheritance
{
    public class Person
    {
        private string name;
        private int age;

        protected virtual string Name
        {
            get => name;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }
                name = value;
            }
        }

        protected virtual int Age 
        {
            get => age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Please, insert a valid age.");
                }

                age = value;
            }
        }

        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Name: {name}, Age: {age}");

            return stringBuilder.ToString();
        }
    }
}