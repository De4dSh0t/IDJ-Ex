using System;
using System.Linq;

namespace Ex_Telephony
{
    public class Smartphone : IModel
    {
        private string number;
        private string url;
        
        public string Number
        {
            get => number;
            set => number = value;
        }

        public string URL
        {
            get => url;
            set
            {
                if (value.Any(char.IsDigit))
                {
                    throw new ArgumentException("Invalid url!");
                }

                url = value;
            }
        }

        public string Call()
        {
            return $"Calling... {number}";
        }

        public string Browse()
        {
            return $"Browsing... {url}";
        }
    }
}