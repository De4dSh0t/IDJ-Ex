using System.Diagnostics.Tracing;

namespace Ex_Carta
{
    public class Carta
    {
        //public Nome nomes { get; set; }
        //public Naipe naipes { get; set; }
        //private string nome;
        public string Nome { get; }

        public Carta(string n)
        {
            Nome = n;
        }
    }
}