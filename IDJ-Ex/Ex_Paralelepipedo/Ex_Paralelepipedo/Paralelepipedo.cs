namespace Ex_Paralelepipedo
{
    public class Paralelepipedo
    {
        private int alt;
        private int lar;
        private int com;

        public int Altura { 
            get { return alt; }
            set
            {
                alt = value;
                if (value < 0) alt = 0;
            }
        }
        public int Largura {
            get { return lar; }
            set
            {
                lar = value;
                if (value < 0) lar = 0;
            }
        }
        public int Comprimento
        {
            get { return com; }
            set
            {
                com = value;
                if (value < 0) com = 0;
            }
        }
        public Paralelepipedo()
        {
            Altura = Largura = Comprimento = 0;
        }
        public Paralelepipedo(int m)
        {
            Altura = Largura = Comprimento = m;
        }

        public Paralelepipedo(int a,int l,int c)
        {
            Altura = a;
            Largura = l;
            Comprimento = c;
        }

        public int Volume()
        {
            return alt * lar * com;            
        }

        public int Area()
        {
            return 2 * alt * lar + 2 * alt * com + 2 * lar * com;
        }
        
        public bool IsACube()
        {
            bool cube = false;
            if (alt == lar && lar == com && com == alt) cube = true;
            return cube;
        }

        public bool Is3D()
        {
            bool ddd = true;
            if (alt != 0 && lar != 0 && com != 0) ddd = false;
            return ddd;
        }

        public override string ToString()
        {
            return $"Altura: {alt.ToString()} Largura: {lar.ToString()} Comprimento: {com.ToString()}";
        }
    }
}