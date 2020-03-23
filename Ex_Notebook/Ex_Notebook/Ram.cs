﻿using System;

namespace Ex_Notebook
{
    public struct Ram
    {
        private string name;
        private string model;
        private float capacity;

        public string Name
        {
            get { return name; }
            set { name = TrimString(value); }
        }

        public string Model
        {
            get { return model; }
            set { model = TrimString(value); }
        }

        public float Capacity
        {
            get { return capacity; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Are you sure that isn't a comb?");
                }

                capacity = value;
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
    }
}