namespace Ex_AlunoISMAI
{
    public class Aluno
    {
        private string nome;
        private int numero;
        private int ano;
        private string curso;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public Aluno(string nome, int numero, int ano, string curso)
        {
            Nome = nome;
            Numero = numero;
            Ano = ano;
            Curso = curso;
        }

        public override string ToString()
        {
            return $"{nome.ToString()} {numero.ToString()}, {ano.ToString()}º {curso.ToString()}.";
        }

        public bool InscritoAntes(Aluno a)
        {
            if (a.numero < numero) { return true; }
            else { return false; }
        }

        public string PrimeiroUltimoNome()
        {
            return "0";
        }
    }
}