using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.PracticeOOP
{

    //inheritance Employee class inherits from Person class, Interface IPersonPracticeOOP
    public class EmployeePracticeOOP : PersonPracticeOOP, IPersonPracticeOOP
    {
        public EmployeePracticeOOP(string name) : base(name)
        {

        }
        //polymorphism override abstract method from Person class
        public override void DisplayInfo()
        {
            Console.WriteLine($"Employee name is: {Name}");
        }

        //polymorphism overloading method DisplayInfo with additional parameter
        public void DisplayInfo(string department)
        {
            Console.WriteLine($"Employee name is: {Name}, Position: {department}");
        }

        //implementation of interface method
        public void ContactInfo()
        {
            Console.WriteLine("Contact info for employee.");
        }


    }
}
