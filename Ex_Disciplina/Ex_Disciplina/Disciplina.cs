using System;

namespace Ex_Disciplina
{
    public class Disciplina
    {
        private string name; //Nome da disciplina
        private int weekly; //Carga horária semanal
        private bool annual; //Se é semestral ou anual
        private string teacher; //Nome do docente
        private string course; //Nome do curso
        private int nStudents; //Nº de alunos inscritos

        public int Weekly
        {
            get { return weekly; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Introduza um valor igual/superior a 0!");
                }
                if(value > 8)
                {
                    throw new InvalidOperationException("Introduza um valor igual/inferior a 8!");
                }

                weekly = value;
            }
        }

        public int NStudents
        {
            get { return nStudents; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Introduza um valor igual/superior a 0!");
                }

                nStudents = value;
            }
        }

        public string Course
        {
            get { return course; }
            set
            {
                if (string.Equals(value, "DJD")|| string.Equals(value, "ARTES") || string.Equals(value, "TCM"))
                {
                    course = value;
                }
                else
                {
                    throw new InvalidOperationException("Cursos: 'DJD', 'ARTES' e 'TCM'!");
                }
            }
        }

        public Disciplina()
        {
            name = "";
            Weekly = 0;
            annual = false;
            teacher = "";
            Course = "";
            NStudents = 0;
        }

        public Disciplina(string n, int w, bool a, string nT, string c, int nS)
        {
            name = n;
            Weekly = w;
            annual = a;
            teacher = nT;
            Course = c;
            NStudents = nS;
        }

        public override string ToString()
        {
            return $"{name}, Prof. {teacher} - {course}";
        }

        public int TotalWorkload() //Calcula a carga horária global da disciplina (considerando que um semestre tem 15 semanas)
        {
            if (annual == false)
            {
                return weekly * 15;
            }
            else
            {
                return weekly * 30; //Pois, sendo anual, corresponde a dois semestres (15 * 2 = 30)
            }
        }
    }
}