using System;
using System.Diagnostics.CodeAnalysis;

namespace Ex_Carta
{
    class Program
    {
        static void Main(string[] args)
        {
            PreencherBaralho();
        }

        static public void PreencherBaralho()
        {
            Carta c;
            Baralho b = new Baralho();

            int nomeI = 0; //"Index" do ENUM "Nome"
            int naipeI = 0; //"Index" do ENUM "Naipe"

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    b.AddCard(c = new Carta((Nome) nomeI++, (Naipe) naipeI)); //O (Nome) nomeI significa que vai buscar o primeiro "nome" do ENUM de index "nomeI"
                }

                nomeI = 0;
                naipeI++;
            }
        }
    }
}