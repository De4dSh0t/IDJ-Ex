using System;

namespace Ex_AlunoISMAI
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno("Rui Silva", 36062, 1, "DJD");
            Aluno b = new Aluno("Fábio Almeida", 36438, 1, "DJD");

            Console.WriteLine("");
            Console.WriteLine("/////////////////////////////////////////////");
            Console.WriteLine($"{a.ToString()}");
            Console.WriteLine($"Foi inscrito antes de {b.Nome}? {a.InscritoAntes(b)}");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"{b.ToString()}");
            Console.WriteLine($"Foi inscrito antes de {a.Nome}? {b.InscritoAntes(a)}");
            Console.WriteLine("/////////////////////////////////////////////");
            Console.WriteLine("");
        }
    }
}