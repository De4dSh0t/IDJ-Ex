using System;

namespace Ex_Racional
{
    public class Racional
    {
        private int numerator;
        private int denominator;

        public int Numerator
        {
            set
            {
                if (value.GetType() != typeof(int)) //Caso o user introduza um valor não inteiro...
                {
                    throw new InvalidOperationException("Introduza um valor inteiro!");
                }

                numerator = value;
            }
        }

        public int Denominator
        {
            set
            {
                if (value.GetType() != typeof(int)) //Caso o user introduza um valor não inteiro...
                {
                    throw new InvalidOperationException("Introduza um valor inteiro!");
                }

                denominator = value;
            }
        }

        public Racional()
        {
            Numerator = 1;
            Denominator = 1;
        }

        public Racional(int n, int d)
        {
            Numerator = n;
            Denominator = d;
        }
    }
}