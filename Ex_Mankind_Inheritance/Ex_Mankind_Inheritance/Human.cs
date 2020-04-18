using System;
using System.Text;

namespace Ex_Mankind_Inheritance
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get => firstName;
            set
            {
                if (Char.IsLower(value[0])) //Verifica se a primeira letra do "firstName" é minúscula
                {
                    throw new ArgumentException("Expected uppercase letter! Argument: firstName");
                }

                if (value.Length < 4) //Verifica se o nome tem pelo menos de 4 letras
                {
                    throw new ArgumentException("Expected lenght at least 4 letters! Argument: firstName");
                }

                firstName = value;
            }
        }

        public virtual string LastName
        {
            get => lastName;
            set
            {
                if (Char.IsLower(value[0])) //Verifica se a primeira letra do "lastName" é minúscula
                {
                    throw new ArgumentException("Expected uppercase letter! Argument: lastName");
                }

                if (value.Length < 3) //Verficia se o nome tem pelo menos de 3 letras
                {
                    throw new ArgumentException("Expected length at least 3 letters! Argument: lastName");
                }

                lastName = value;
            }
        }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            StringBuilder sB = new StringBuilder();

            sB.Append("First Name: ").Append(firstName)
                .Append(Environment.NewLine)
                .Append("Last Name: ").Append(lastName);

            return sB.ToString();
        }
    }
}