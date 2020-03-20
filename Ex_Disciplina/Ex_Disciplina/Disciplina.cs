using System;

namespace Ex_Disciplina
{
    public class Disciplina
    {
        private string name; //Nome da disciplina
        private int weekly; //Carga horária semanal
        private bool type; //Se é semestral ou anual
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
                if (value != "DJD" || value != "ARTES" || value != "TCM")
                {
                    throw new InvalidOperationException("Cursos: 'DJD', 'ARTES' e 'TCM'!");
                }

                course = value;
            }
        }

        Disciplina()
        {
            name = "";
            Weekly = 0;
            type = false;
            teacher = "";
            Course = "";
            NStudents = 0;
        }

        Disciplina(string n, int w, bool t, string nT, string c, int nS)
        {
            name = n;
            Weekly = w;
            type = t;
            teacher = nT;
            Course = c;
            NStudents = nS;
        }
        
        
    }
}