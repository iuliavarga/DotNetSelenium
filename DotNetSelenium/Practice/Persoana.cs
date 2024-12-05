using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.Practice
{


    public static class Persoana
    {
        public static string FirstName { get; set; } = "Julia";
        public static string LastName { get; set; } = "Varga";
        public static string Gender { get; set; } = "F";
        public static int Age { get; set; } = 35;
        public static int YearsToAdd { get; set; } = 2;
        
        public static int CalculateAge(int YearsToAdd)
        {
            int CalculateAge = YearsToAdd + Age;
            return CalculateAge;
        }       

        public static void DisplayUserDetails(string FirstName, string LastName, string Gender, int Age)
        {
            int FutureAge = CalculateAge(YearsToAdd);

            Console.WriteLine("The person's details are as follows: ");
            Console.WriteLine("- First Name: " + FirstName);
            Console.WriteLine("- Last name: " + LastName);
            Console.WriteLine("- Gender: " + Gender);
            Console.WriteLine(value: "You will be " + FutureAge + " years old in " + YearsToAdd + " years!");
        }


        [Test]
        public static void DisplayPerson()
        {
            DisplayUserDetails(FirstName, LastName, Gender, Age);
        }

    }
 }
