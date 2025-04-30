using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.OOP.Inheritance
{
    public class Test
    {
        [Test]

        //mostenire = concept prin care o clasa copil mosteneste proprietatile si metodele unei clase parinte
        //se poate mosteni o singura clasa
        //clasa copil preia proprietatille si metodele clasei parinte
        public void TestMethod()
        {
            //var person = new Person("Mihai", 30, 70.5);
            //person.InfoPerson();

            //var angajat = new Angajat("Ion", 28, 75.0, "Developer", 5000, "TechCorp");
            //angajat.InfoAngajat();

            var student = new Student("Maria", 22, 60.0, "Universitatea Tehnica", "Informatica", true);
            student.InfoStudent();
        }
    }
}
