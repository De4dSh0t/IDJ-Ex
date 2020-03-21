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

                if (value == 0) //Caso o user introduza um denominador = 0...
                {
                    throw new InvalidOperationException("Não pode dividir por 0!");
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

        public int FindMDC()
        {
            int mdc = 0; //Máximo Divisor Comum
            int max; //Serve para armazenar o maior valor (entre o Numerador e o Denominador)

            if (numerator > denominator)
            {
                max = numerator;
            }
            else
            {
                max = denominator;
            }

            for (int i = max; i > 0; i--) //Serve para encontrar o "mdc". Percorre-se ao contrário, pois o objetivo é encontrar o "mdc" e não todos os divisores possíveis (otimizado)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    mdc = i;
                    break;
                }

                mdc = 1;
            }

            return mdc;
        }

        public override string ToString()
        {
            int mdc = FindMDC();
            int n = numerator;
            int d = denominator;
            
            //Reduzir fração
            if (mdc != 0)
            {
                n = numerator / mdc;
                d = denominator / mdc;
            }

            return $"{n}/{d}";
        }

        public Racional Add(Racional fract1, Racional fract2)
        {
            Racional result = new Racional();

            //Exemplo: (1/2) + (1/3) = (2*1)/(1*3) = 2/3
            int newNumerator = fract1.denominator * fract2.numerator; 
            int newDenominator = fract1.numerator * fract2.denominator;

            //Defino o numerador e o denominador na nova fração ("result")
            result.numerator = newNumerator;
            result.denominator = newDenominator;
            
            //Passo pelo processo de descobrir o "mdc" e depois dou print da nova fração
            result.ToString();
            
            return result;
        }
    }
}