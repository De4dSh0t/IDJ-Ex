using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Ex_Carta
{
    public class Baralho
    {
        Carta[] c = new Carta[52];
        private int currentIndex = 0; //Usada em "DrawACard()"

        public Baralho()
        {
            int nomeI = 0; //"Index" do ENUM "Nome"
            int naipeI = 0; //"Index" do ENUM "Naipe"
            int cartasI = 0; //"Index" do nº de 'cartas'
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    //O "Enum.GetName" retorna o nome de uma constante presente num ENUM com um valor específico.
                    //Aqui uso a variável "nomeI" como index de forma a ir buscar a constante pretendida. No fim, incremento de forma a passar para a próxima constante.
                    //Atenção: O "naipeI" não incrementa dentro deste loop pois quero que todas as constantes do ENUM NOME juntem-se a cada constante do ENUM NAIPE.
                    c[cartasI++] = new Carta($"{Enum.GetName(typeof(Nome), nomeI++)} DE {Enum.GetName(typeof(Naipe), naipeI)}");
                }

                nomeI = 0;
                naipeI++;
            }
        }

        public void Shuffle()
        {
            Random r = new Random();
            Carta[] tempCard = new Carta[1];

            for (int i = 0; i < 52; i++)
            {
                int chosen = r.Next(0, 52);
                int toChange = r.Next(0, 52);
                tempCard[0] = c[chosen];
                c[chosen] = c[toChange];
                c[toChange] = tempCard[0];
            }
        }

        public Carta DrawACard()
        {
            if (currentIndex > c.Length - 1)
            {
                throw new InvalidOperationException("Deck is empty!");
            }

            return c[currentIndex++];
        }

        public bool CheckCard(string cardName) //Ver se uma carta específica encontra-se no baralho
        {
            for (int i = currentIndex; i < c.Length - 1; i++) //Começa em "currentIndex" pois, caso tiremos uma carta do baralho, só devemos comparar às cartas que ainda estão no baralho
            {
                if (cardName == c[i].Nome)
                {
                    return true;
                }
            }

            return false;
        }

        public void PrintDeck()
        {
            for (int i = currentIndex; i < c.Length - 1; i++) //Começa em "currentIndex" pois, caso tiremos uma carta do baralho, só devemos dar print às cartas que ainda estão no baralho
            {
                Console.WriteLine(c[i].Nome);
            }
        }
    }
}