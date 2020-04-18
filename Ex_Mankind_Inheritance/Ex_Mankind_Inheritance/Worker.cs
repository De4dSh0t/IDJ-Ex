using System;

namespace Ex_Mankind_Inheritance
{
    public class Worker : Human
    {
        private string lastName;
        private double weekSalary;
        private double workHoursPerDay;

        public override string LastName
        {
            get => lastName;
            set
            {
                if (value.Length <= 3) //Verifica se o comprimento do nome é igual ou menor a 3 letras
                {
                    throw new ArgumentException("Expected length more than 3 letters! Argument: lastName (Worker)");
                }

                lastName = value;
            }
        }
        public double WeekSalary
        {
            get => weekSalary;
            set
            {
                if (value < 10) //Verifica se o salário semanal é menor que 10
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get => workHoursPerDay;
            set
            {
                if (value.ToString().Length < 1 || value.ToString().Length > 12) //Verifica se o comprimento do nº "workHoursPerDay" está entre 1 e 12
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                weekSalary = value;
            }
        }
        
        public Worker(string firstName, string lastName) : base(firstName, lastName) {}

        public double SalaryPerHour() //Calcula o salário por hora, consoante o salário semanal e o nº de horas por dia
        {
            return Math.Round(weekSalary / (workHoursPerDay * 7), 2);
        }
    }
}