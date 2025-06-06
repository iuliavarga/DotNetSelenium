using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetSelenium.OOP.Abstraction;

namespace DotNetSelenium.OOP.Polymorphism
{
    public class Employee : Person
    {
        private string Company { get; set; }
        private double Salary { get; set; }

        public Employee(string nume, string prenume, int varsta, string company, double salary) : base(nume, prenume, varsta)
        {
            Company = company;
            Salary = salary;
        }

        public void DisplayEmployee()
        {
            DisplayInfo();
            Console.WriteLine($"working at {Company} with salary: {Salary}.");
        }

        public override void Mananca()
        {
            Console.WriteLine("Employee mananca");
        }


    }
}
