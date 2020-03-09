using System.Diagnostics.Tracing;

namespace Ex_Carta
{
    public class Carta
    {
        public Nome nomes { get; set; }
        public Naipe naipes { get; set; }

        public Carta(Nome n, Naipe naipe)
        {
            nomes = n;
            naipes = naipe;
        }
    }
}