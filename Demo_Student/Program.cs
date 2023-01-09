using System;

namespace Demo_Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Duy";
            student1.Age = 30;
            student1.Gpa = 2.3;
            student1.PrintStudent();

            var student2 = new Student("Tan", 40, 2.8);
            Console.WriteLine(student2.ToString());
            Console.ReadLine();
        }
    }
}
