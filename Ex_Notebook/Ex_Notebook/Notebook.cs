using System;

namespace Ex_Notebook
{
    public class Notebook
    {
        private string cpu;
        private string ram;
        private string gpu;
        private string disk;

        public string Cpu
        {
            set
            {
                cpu = TrimString(value);
            }
        }

        public string Ram
        {
            set
            {
                ram = TrimString(value);
            }
        }

        public string Gpu
        {
            set
            {
                gpu = TrimString(value);
            }
        }

        public string Disk
        {
            set
            {
                disk = TrimString(value);
            }
        }

        private string TrimString(string str) //Método usado para truncar uma string (2 palavras)
        {
            int wordCount = 1;
            int usableChars = 0;
            string result = String.Empty; //Resultado final após o truncamento

            for (int i = 0; i < str.Length; i++) //Percorre todos os "Char" da string
            {
                if (str[i] == ' ' || str[i] == '\n' || str[i] == '\t') //Se um dos "char" for um espaço, uma nova linha ou um tab, então "wordCount" incrementa.
                {
                    wordCount++;
                }

                if (wordCount <= 2) //Enquanto o wordcount for menor/igual que 2, o "usableChars" vai incrementar de forma a saber quantos "char" é que posso usar
                {
                    usableChars++;
                }
            }

            if (wordCount > 2) //Usando o "usableChars", vou remover todos os "char" para além desse número
            {
                result = str.Remove(usableChars + 1, str.Length - (usableChars + 1));
            }

            return result;
        }

        public Notebook()
        {
            Cpu = String.Empty;
            Ram = String.Empty;
            Gpu = String.Empty;
            Disk = String.Empty;
        }

        public Notebook(string c, string r, string g, string d)
        {
            Cpu = c;
            Ram = r;
            Gpu = g;
            Disk = d;
        }
    }
}