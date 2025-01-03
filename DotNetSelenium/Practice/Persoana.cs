using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.Practice
{


    public static class Persoana
    {
        public static string firstName { get; set; } = "Julia";
        public static string lastName { get; set; } = "Varga";
        public static string gender { get; set; } = "Other";
        public static int age { get; set; } = 98;
        public static int yearsToAdd { get; set; } = 2;

      


        public static int CalculateAge(int yearsToAdd)
        {
            int CalculateAge = yearsToAdd + age;
            return CalculateAge;
        }       

        public static void DisplayUserDetails(string firstName, string lastName, string gender, int age)
        {
            int FutureAge = CalculateAge(yearsToAdd);

            
            Console.WriteLine("The person's details are as follows: ");
            Console.WriteLine("- First Name: " + firstName);
            Console.WriteLine("- Last name: " + lastName);
            Console.WriteLine("- Gender: " + gender);
            Console.WriteLine(value: "You will be " + FutureAge + " years old in " + yearsToAdd + " years!");
           // Console.WriteLine("\n");
            Console.WriteLine(IsOld(age));
            ShowGender(gender);


        }


        public static string IsOld(int age)
        {

            return GetAge(age);

         }

        private static string GetAge(int age)
            {

                if (age >= 100)
                {
                    return "You are ancient!";
                }
                else if (age >= 50)
                {
                    return "You are still old!";
                }
                else
                {
                   return "You are still young!";
                }
            }


        public static void ShowGender(string gender)
        {
            switch (gender)
            {
                case "Male":
                    Console.WriteLine("You are a male!");
                    break;
                case "Female":
                    Console.WriteLine("You are a female!");
                    break;
                default:
                    Console.WriteLine("You haven't specified your gender");
                    break;

            }


        }





        [Test]
        public static void DisplayPerson()
        {
              DisplayUserDetails(firstName, lastName, gender, age);
            //Console.WriteLine(IsOld(age));
           //ShowGender(gender);

        }






    }
 }




