using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.OOP.Polymorphism
{
    public class PolimorfismTest
    {
        [Test]

        public void TestMethod()
        {
            Person person = new Person("Ion", "Popescu", 30);
            person.Mananca(); // apelare metoda din clasa de baza

            Student student = new Student("Maria", "Ionescu", 20, "UPT", "Informatica", true);
            student.Mananca(); // apelare metoda suprascrisa in Student

        }
        //overloading - metoda cu acelasi nume, dar cu parametri diferiti
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(double a, double b)
        {
            return (int)(a + b);
        }

        
    }
}
