using System.Collections.Generic;

namespace Ex_Carta
{
    public class Baralho
    {
        Carta[] cartas = new Carta[52];
        private int currentIndex = 0;

        public Baralho()
        {}

        public void AddCard(Carta nCarta)
        {
            cartas[currentIndex++] = nCarta;
        }

        public Carta GetCard()
        {
            return cartas[--currentIndex];
        }

        public void Shuffle()
        {
            
        }
    }
}