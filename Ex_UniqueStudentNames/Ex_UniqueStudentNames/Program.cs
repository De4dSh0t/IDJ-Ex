using System;

namespace Ex_UniqueStudentNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            while (input != "End")
            {
                Student student = new Student(input);
                StudentGroup.group.Add(student.name);
                input = Console.ReadLine();
            }

            StudentGroup.nameCount = StudentGroup.group.Count;
            Console.WriteLine($"Nº de nomes diferentes: { StudentGroup.nameCount }");
        }
    }
}