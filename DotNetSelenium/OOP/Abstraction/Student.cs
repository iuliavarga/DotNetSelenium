using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetSelenium.OOP.Abstraction.Interfete;

namespace DotNetSelenium.OOP.Abstraction
{
    public class Student : Person, IStudent
    {
        private string University { get; set; }
        public string Profile { get; set; }
        private bool HaveScholarship { get; set; }

        public Student(string nume, string prenume, int varsta, string university, string profile, bool haveScholarship) : base(nume, prenume, varsta)
        {
            University = university;
            Profile = profile;
            HaveScholarship = haveScholarship;
        }

        public void DisplayStudent()
        {
            DisplayInfo();
            Console.WriteLine($"Student at {University} with profile {Profile}.");
            Console.WriteLine($"Have schorlaship {HaveScholarship}.");
        }

        public void Study()
        {
            Console.WriteLine($"Student is studying.");
        }

        public void TakeExam()
        {
            Console.WriteLine($"Student is taking an exam.");
        }

        public void AttendClass()
        {
            Console.WriteLine($"Student is attending class.");
        }
    }
}
