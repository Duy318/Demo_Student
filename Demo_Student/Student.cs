using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Student
{
    internal class Student:Object
    {
        public string? Name { get; set; }
        public int Age { get => age; set => age = value; }
        private int age;
        private double gpa;
        public double Gpa { set { if (value >= 0 && value <= 4) gpa = value; }
                get{ return gpa; }
        }
        //contructor
        public Student(string name, int age, double gpa)
        {
            Name = name;
            this.Age = age;
            this.gpa = gpa;
        }

        public Student()
        {
        }

        public void PrintStudent()
        {
            Console.WriteLine($"Student has Name={Name}, Age = {age}, GPA={gpa}");
        }
        public override string ToString()
        {
            return ($"Student has Name={Name}, Age = {age}, GPA={gpa}");
        }
    }
}
