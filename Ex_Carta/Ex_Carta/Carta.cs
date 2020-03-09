using System.Diagnostics.Tracing;

namespace Ex_Carta
{
    public class Carta
    {
        private string nome { get; set; }
        public Naipe naipes { get; set; }

        public Carta(string n, Naipe naipe)
        {
            nome = n;
            naipes = naipe;
        }
    }
}