using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetSelenium.OOP.Abstraction.Interfete;

namespace DotNetSelenium.OOP.Abstraction 
{
    public class EmployeeStudent : Person, IEmployee, IStudent
    {
    private string Company { get; set; }
    private double Salary { get; set; }
    private string University { get; set; }
    public string Profile { get; set; }

    public EmployeeStudent(string nume, string prenume, int varsta, string company, double salary, string university, string profile) : base(nume, prenume, varsta)
    {
        Company = company;
        Salary = salary;
        University = university;
        Profile = profile;
    }

        public void GoToWork()
        {
            Console.WriteLine($"EmployeeStudent is going to work.");
        }

        public void TakeBreak()
        {
            Console.WriteLine($"EmployeeStudent is taking a break.");
        }

        public void AttendMeeting()
        {
            Console.WriteLine($"EmployeeStudent is attending a meeting.");
        }

        public void Study()
        {
            Console.WriteLine($"EmployeeStudent is studying.");
        }

        public void TakeExam()
        {
            Console.WriteLine($"EmployeeStudent is taking an exam.");
        }

        public void AttendClass()
        {
            Console.WriteLine($"EmployeeStudent is attending class.");
        }

    }

}

