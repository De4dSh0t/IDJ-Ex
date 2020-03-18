using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Ex_Carta
{
    public class Baralho
    {
        Carta[] c = new Carta[52];
        private int currentIndex = 0;

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

            for (int i = 0; i < 52; i++) //Print de todas as cartas (para verificar)
            {
                Console.WriteLine(c[i].Nome);
            }
        }

        public void Shuffle()
        {
            Random r = new Random();
            Carta[] tempCard = new Carta[1];

            for (int i = 0; i < 52; i++)
            {
                int chosen = r.Next(0, 53);
                int toChange = r.Next(0, 53);
                tempCard[0] = c[chosen];
                c[chosen] = c[toChange];
                c[toChange] = tempCard[0];
            }
        }

        public Carta DrawACard()
        {
            if (c[currentIndex] == null)
            {
                throw new InvalidOperationException("Deck is empty!");
            }

            return c[currentIndex++];
        }
    }
}