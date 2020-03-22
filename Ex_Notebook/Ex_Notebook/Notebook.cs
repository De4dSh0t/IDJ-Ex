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
                int wordCount = 1;
                int usableChars = 0;
                string result = String.Empty; //Resultado final após o truncamento

                for (int i = 0; i < value.Length; i++) //Percorre todos os "Char" da string
                {
                    if (value[i] == ' ' || value[i] == '\n' || value[i] == '\t') //Se um dos "char" for um espaço, uma nova linha ou um tab, então "wordCount" incrementa.
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
                    result = value.Remove(usableChars + 1, value.Length - (usableChars + 1));
                }

                cpu = result;
            }
        }
    }
}