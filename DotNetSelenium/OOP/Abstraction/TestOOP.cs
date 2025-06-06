using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.OOP.Abstraction
{
    public class TestOOP
    {
        [Test]

        public void Test()
        {
            Employee employee = new Employee("John", "Doe", 30, "TechCorp", 60000);
            employee.GoToWork();
            employee.TakeBreak();
            EmployeeStudent employeeStudent = new EmployeeStudent("Jane", "Smith", 22, "TechCorp", 50000, "MIT", "Computer Science");
            employeeStudent.GoToWork();
            employeeStudent.Study();


        }


    }
}
