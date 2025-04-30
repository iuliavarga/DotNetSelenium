using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.OOP.Inheritance
{
    public class Student : Person
    {
        public string university;
        public string profil;
        public bool bursa;

        public Student(string name, int age, double weight, string university, string profil, bool bursa) : base(name, age, weight)
        {
            this.university = university;
            this.profil = profil;
            this.bursa = bursa;
        }

        public void InfoStudent()
        {
            InfoPerson();
            Console.WriteLine($"University: {university}");
            Console.WriteLine($"Profil: {profil}");
            Console.WriteLine($"Bursa: {bursa}");
        }
    }
}
