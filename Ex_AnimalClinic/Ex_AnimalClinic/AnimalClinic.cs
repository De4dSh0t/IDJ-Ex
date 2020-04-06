using System;

namespace Ex_AnimalClinic
{
    public class AnimalClinic
    {
        private static int patientId; //Funciona como um index
        private static int healedAnimalsCount;
        private static int rehabAnimalsCount;

        public int HealedAnimalsCount => healedAnimalsCount;
        public int RehabAnimalsCount => rehabAnimalsCount;

        public void HealAnimal(Animal animal)
        {
            healedAnimalsCount++;
            patientId++;
            Console.WriteLine($"Patient {patientId}: [{animal.Name} ({animal.Breed})] has been healed!");
        }
        
        public void RehabAnimal(Animal animal)
        {
            rehabAnimalsCount++;
            patientId++;
            Console.WriteLine($"Patient {patientId}: [{animal.Name} ({animal.Breed})] has been rehabilitated!");
        }
    }
}