using System;

namespace Ex_Ferrari
{
    public class Ferrari : ICar
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Brakes { get; set; }
        public string GasPedal { get; set; }

        public Ferrari(string name, string model)
        {
            Name = name;
            Model = model;
            Brakes = "Brakes!";
            GasPedal = "Zadu6avamsA!";
        }
    }
}