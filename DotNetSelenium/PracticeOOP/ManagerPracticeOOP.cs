using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.PracticeOOP
{
    //inheritance Manager class inherits from Person class and interface IPersonPracticeOOP
    public class ManagerPracticeOOP : PersonPracticeOOP, IPersonPracticeOOP
    {
        //encapsulation private fields, not accessible outside this class
        private int teamSize;
        private decimal bonus;

        public ManagerPracticeOOP(string name, int teamSize, decimal bonus) : base(name)
        {
            this.teamSize = teamSize;
            this.bonus = bonus;
        }

        // getter/setter methods that control access to private fields
        public void SetTeamSize(int size)
        {
            this.teamSize = size;
        }

        public int GetTeamSize()
        {
            return teamSize;
        }

        public void SetBonus(decimal amount)
        {
            this.bonus = amount;
        }

        public decimal GetBonus()
        {
            return bonus;
        }

        //polymorphism override abstract method from Person class
        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager name is: {Name} , Leads a team of {teamSize} people, bonus: {bonus}");
        }

        //polymorphism overloading method DisplayInfo with additional parameter
        public void DisplayInfo(string department)
        {
            Console.WriteLine($"Manager name is: {Name}, Leads a team of {teamSize} people, bonus: {bonus}, Department: {department}");
        }

        //implementation of interface method
        public void ContactInfo()
        {
            Console.WriteLine("Contact info for manager.");
        }
    }
}
