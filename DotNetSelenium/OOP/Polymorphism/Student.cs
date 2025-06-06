using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetSelenium.OOP.Abstraction;

namespace DotNetSelenium.OOP.Polymorphism
{
    public class Student : Person
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

        public override void Mananca()
        {
            Console.WriteLine("Student mananca");
        }


    }
}
