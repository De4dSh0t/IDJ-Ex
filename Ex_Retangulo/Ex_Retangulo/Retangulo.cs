namespace Ex_Retangulo
{
    public class Retangulo
    {
        private int larg;
        private int comp;

        public int Largura
        {
            get { return larg; }
            set
            {
                if (value > 20)
                {
                    larg = 20;
                }
                else if (value < 0)
                {
                    larg = 0;
                }
                else
                {
                    larg = value;
                }
            }
        }

        public int Comprimento
        {
            get { return comp; }
            set
            {
                if (value > 20)
                {
                    comp = 20;
                }
                else if (value < 0)
                {
                    comp = 0;
                }
                else
                {
                    comp = value;
                }
            }
        }

        public Retangulo()
        {
            Largura = 1;
            Comprimento = 1;
        }

        public Retangulo(int l, int c)
        {
            Largura = l;
            Comprimento = c;
        }

        public int Perimetro()
        {
            return (larg + comp) * 2;
        }

        public int Area()
        {
            return larg * comp;
        }

        public bool Quadrado()
        {
            return larg == comp;
        }

        public string toString()
        {
            return $"Comprimento: {comp} e Largura: {larg}";
        }
    }
}