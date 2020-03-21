using System;
using System.Threading.Channels;

namespace Ex_Racional
{
    class Program
    {
        static void Main(string[] args)
        {
            // Racional r = new Racional(1, 2);
            // Racional r2 = new Racional(1, 3);
            // Console.WriteLine(r.ToString());
            // Console.WriteLine(r.Add(r, r2));
            // Console.WriteLine(r.Subtract(r, r2));
            // Console.WriteLine(r.Multiply(r, r2));
            // Console.WriteLine(r.Divide(r, r2));
            // Console.WriteLine(r.ResultInNumber(r));

            Racional fract = new Racional();
            
            bool flag = false;
            bool firstRun = true; 

            while (!flag)
            {
                ConsoleKeyInfo info = Console.ReadKey();

                if (firstRun == true) //Serve para impedir que o programa pergunte sempre qual o numerador e o denominador que queremos
                {
                    //Perguntar ao User qual o Numerador e Denominador da fração pretendida
                    Console.WriteLine("Numerator: ");
                    string n = Console.ReadLine();
                    int numerator = Int32.Parse(n);
                
                    Console.WriteLine("Denominator: ");
                    string d = Console.ReadLine();
                    int denominator = Int32.Parse(d);
                
                    //Criar a fração pretendida
                    fract.Numerator = numerator;
                    fract.Denominator = denominator;

                    firstRun = false; 
                }

                Console.WriteLine("");
                Console.WriteLine("/////////////////////////////");
                Console.WriteLine("(1) Print");
                Console.WriteLine("(2) Print as a Float");
                Console.WriteLine("(3) Add");
                Console.WriteLine("(4) Subtract");
                Console.WriteLine("(5) Multiply");
                Console.WriteLine("(6) Divide");
                Console.WriteLine("/////////////////////////////");
                Console.WriteLine("");

                if (info.KeyChar == '1')
                {
                    Console.WriteLine(fract.ToString());
                }

                if (info.KeyChar == '2')
                {
                    Console.WriteLine(fract.ResultInNumber(fract));
                }

                if (info.KeyChar == '3')
                {
                    Console.WriteLine("Numerator of new fraction: ");
                    string nA = Console.ReadLine();
                    int numeratorA = Int32.Parse(nA);

                    Console.WriteLine("Denominator of new fraction: ");
                    string dA = Console.ReadLine();
                    int denominatorA = Int32.Parse(dA);
                    
                    //Criar a nova fração pretendida
                    Racional fractA = new Racional(numeratorA, denominatorA);

                    Console.WriteLine($"{fract} + {fractA} = { fract.Add(fract, fractA) }");
                }

                if (info.KeyChar == '4')
                {
                    Console.WriteLine("Numerator of new fraction: ");
                    string nS = Console.ReadLine();
                    int numeratorS = Int32.Parse(nS);

                    Console.WriteLine("Denominator of new fraction: ");
                    string dS = Console.ReadLine();
                    int denominatorS = Int32.Parse(dS);
                    
                    Racional fractS = new Racional(numeratorS, denominatorS);
                    
                    Console.WriteLine($"{fract} - {fractS} = { fract.Subtract(fract, fractS) }");
                }

                if (info.KeyChar == '5')
                {
                    Console.WriteLine("Numerator of new fraction: ");
                    string nM = Console.ReadLine();
                    int numeratorM = Int32.Parse(nM);

                    Console.WriteLine("Denominator of new fraction: ");
                    string dM = Console.ReadLine();
                    int denominatorM = Int32.Parse(dM);
                    
                    Racional fractM = new Racional(numeratorM, denominatorM);
                    
                    Console.WriteLine($"{fract} x {fractM} = { fract.Multiply(fract, fractM) }"); //O "fractM" vai aparecer como já simplificado
                }

                if (info.KeyChar == '6')
                {
                    Console.WriteLine("Numerator of new fraction: ");
                    string nD = Console.ReadLine();
                    int numeratorD = Int32.Parse(nD);

                    Console.WriteLine("Denominator of new fraction: ");
                    string dD = Console.ReadLine();
                    int denominatorD = Int32.Parse(dD);
                    
                    Racional fractD = new Racional(numeratorD, denominatorD);
                    
                    Console.WriteLine($"{fract} / {fractD} = { fract.Divide(fract, fractD) }");
                }
            }
        }
    }
}