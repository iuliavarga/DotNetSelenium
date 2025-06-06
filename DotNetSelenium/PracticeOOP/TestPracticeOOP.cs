using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DotNetSelenium.OOP.Abstraction;
using DotNetSelenium.OOP.Polymorphism;

namespace DotNetSelenium.PracticeOOP
{
    public class TestPracticeOOP
    {
        private List<PersonPracticeOOP> people;

        [SetUp]
        public void Setup()
        {

            people = new List<PersonPracticeOOP>
            {
                new EmployeePracticeOOP("julia"),
                new ManagerPracticeOOP("maria", 10, 1500),
                new EmployeePracticeOOP("ion"),
                new ManagerPracticeOOP("alex", 5, 2000)
            };

        }

        [Test]
        public void TestMethod()
        {        
            //polymorphism DisplayInfo()
            foreach (var person in people)
            {
                person.DisplayInfo();                
            }

            Console.WriteLine("");

            //polymorphism DisplayInfo() with parameter 
            foreach (var person in people)
            {
                if (person is EmployeePracticeOOP employee)
                {
                    employee.DisplayInfo("Developer");
                }
                else if (person is ManagerPracticeOOP manager)
                {
                    manager.DisplayInfo("HR");
                }
            }

            Console.WriteLine("");

            //interface method ContactInfo() 
            foreach (var person in people)
            {
                if (person is IPersonPracticeOOP iperson)
                {
                    iperson.ContactInfo();
                }
            }


        }
    }
}
