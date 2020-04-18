using System;

namespace Ex_Mankind_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Student
                string student = Console.ReadLine();
                string[] sWords = student.Split();
                Student s = new Student(sWords[0], sWords[1]);
                s.Number = Int32.Parse(sWords[2]);

                //Worker
                string worker = Console.ReadLine();
                string[] wWords = worker.Split();
                Worker w = new Worker(wWords[0], wWords[1]);
                w.WeekSalary = double.Parse(wWords[2]);
                w.WorkHoursPerDay = double.Parse(wWords[3]);

                //Print
                Console.WriteLine(s);
                Console.WriteLine($"Faculty Number: {s.Number}");
                Console.WriteLine("");
                
                Console.WriteLine(w);
                Console.WriteLine($"Week Salary: {w.WeekSalary}");
                Console.WriteLine($"Hours per day: {w.WorkHoursPerDay}");
                Console.WriteLine($"Salary per hour: {w.SalaryPerHour()}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}