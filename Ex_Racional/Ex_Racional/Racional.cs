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

        public int FindMDC() //Método usado para encontrar o Máximo Divisor Comum de uma função (usada em "ToString()")
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

        public string Add(Racional fract1, Racional fract2)
        {
            Racional result = new Racional();

            //Exemplo: (1/2) + (1/3) = (2*1)/(1*3) = 2/3
            int newNumerator = fract1.denominator * fract2.numerator; 
            int newDenominator = fract1.numerator * fract2.denominator;

            //Defino o numerador e o denominador na nova fração ("result")
            result.numerator = newNumerator;
            result.denominator = newDenominator;
            
            //Passo pelo processo de descobrir o "mdc" e depois devolvo a nova fração em forma de string
            return result.ToString();
        }

        public string Subtract(Racional fract1, Racional fract2)
        {
            Racional subFract1 = new Racional(); //Resultado da operação de multiplicação do numerador e denominador pelo denominador da outra fração
            Racional subFract2 = new Racional(); //Resultado da operação de multiplicação do numerador e denominador pelo denominador da outra fração
            Racional result = new Racional();
            
            //Exemplo: (1/2)-(1/3) = ((1*3)/(2*3)) / ((1*2)/(3*2)) = (3/6)-(2/6) = 1/6
            //1º - Multiplicar o Numerador e o Denominador pelo Denominador da outra fração (e vice-versa)
            subFract1.numerator = fract1.numerator * fract2.denominator;
            subFract1.denominator = fract1.denominator * fract2.denominator;
            subFract2.numerator = fract2.numerator * fract1.denominator;
            subFract2.denominator = fract2.denominator * fract1.denominator;
            //2º - Subtrair os Numeradores das duas "subFract"
            result.numerator = subFract1.numerator - subFract2.numerator;
            //3º - Igualar o denominador do "result" a um dos denominadores do "subFract"
            result.denominator = subFract1.denominator;
            
            //Passo pelo processo de descobrir o "mdc" e depois devolvo a nova fração em forma de string
            return result.ToString();
        }

        public string Multiply(Racional fract1, Racional fract2)
        {
            Racional result = new Racional();
            
            //Exemplo: (1/2)*(1/3) = (1*1)/(2*3) = 1/6
            int newNumerator = fract1.numerator * fract2.numerator;
            int newDenominator = fract1.denominator * fract2.denominator;
            
            //Defino o numerador e o denominador na nova fração ("result")
            result.numerator = newNumerator;
            result.denominator = newDenominator;
            
            //Passo pelo processo de descobrir o "mdc" e depois devolvo a nova fração em forma de string
            return result.ToString();
        }

        public string Divide(Racional fract1, Racional fract2)
        {
            Racional result = new Racional();
            
            //Exemplo: (1/2)/(1/3) = (1*3)/(2*1) = 3/2
            int newNumerator = fract1.numerator * fract2.denominator;
            int newDenominator = fract1.denominator * fract2.numerator;
            
            //Defino o numerador e o denominador na nova fração ("result")
            result.numerator = newNumerator;
            result.denominator = newDenominator;
            
            //Passo pelo processo de descobrir o "mdc" e depois devolvo a nova fração em forma de string
            return result.ToString();
        }

        public float ResultInNumber(Racional fract)
        {
            return (float)fract.numerator / fract.denominator;
        }
    }
}