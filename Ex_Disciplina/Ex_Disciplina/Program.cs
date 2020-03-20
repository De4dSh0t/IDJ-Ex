using System;

namespace Ex_Disciplina
{
    class Program
    {
        static void Main(string[] args)
        {
            Disciplina d = new Disciplina("Introdução ao Desenvolvimento de Jogos", 3, false, "Jaime Fins", "DJD", 20);

            Console.WriteLine("");
            Console.WriteLine("///////////////////////////////////////////////////////////////////");
            Console.WriteLine(d.ToString());
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"Carga Horária Total: { d.TotalWorkload() } horas");
            Console.WriteLine("///////////////////////////////////////////////////////////////////");
        }
    }
}