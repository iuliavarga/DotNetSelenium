using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using NUnit.Framework.Interfaces;

namespace DotNetSelenium.Practice
{

    public static class Persoana
    {
        public static string firstName { get; set; } = "Julia";
        public static string lastName { get; set; } = "Varga";
        public static string gender { get; set; } = "Other";
        public static int age { get; set; } = 98;
        public static int yearsToAdd { get; set; } = 2;
        public static List<string> Skills { get; set; } = new List<string>()
        {
            "Cooking",
            "Photography",
            "Progaming",
            "Testing",
            "Ninja",
            "Swimming",
            "CIA",
            "Dancing",
            "Singing"
        };



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


        //public static void AddSkills(string skill)
        //{
        //    Skills.Add(skill);
        //    Console.WriteLine($"Added a new skill: {skill}");

        //}

       public static void DisplaySkill()
        {

            List<string> displayListFilter = new List<string>();


            foreach (var skill in Skills)
            {

                Console.WriteLine($"Added a new skill: {skill}");
                displayListFilter.Add(skill);
               
             }


            string skillJoin = string.Empty;

            foreach (var skill in displayListFilter)
            {
                if (skill == "CIA" || skill == "Ninja" || skill == "Dancing" || skill == "Singing")
                    continue;
                skillJoin += ";  " + skill;
            }
            
            Console.WriteLine("The person has the following skills:  \n" + skillJoin);

            foreach (var skill in Skills)
            {


                if (skill == "Ninja")
                {
                    continue;
                }

                else if (skill == "CIA")
                {

                    Console.WriteLine(">>>>>Classified information, no further skills are displayed!<<<<<");
                    break;
                }                

            }

         
        }


        public static void CountTo(int number)
        {
            int startNumber = 1;
         
            Console.WriteLine("Counting to 100:");

            do
            {

                if (startNumber == 10)
                {
                    Console.WriteLine();
                    Console.WriteLine("Number skipped!");
                }
                else if (startNumber == 99)
                {
                    Console.WriteLine();
                    Console.WriteLine("Cannot count pass 99!");
                    break;
                }
                else
                {

                    Console.Write(startNumber + "; ");
                }
                startNumber++;
               

            }

            while (startNumber <= number);    
            
            
        }







        [Test]
        public static void DisplayPerson()
        {
            //  DisplayUserDetails(firstName, lastName, gender, age);
            //  Console.WriteLine(IsOld(age));
            //  ShowGender(gender);


            //AddSkills("Cooking1");
            //AddSkills("Photography");
            //AddSkills("Progaming");
            //AddSkills("Testing");
            //AddSkills("Ninja");
            //AddSkills("Swimming");
            //AddSkills("CIA");
            //AddSkills("Dancing");
            //AddSkills("Singing");

            //DisplaySkill();

            CountTo(100);
             

        }






    }
}




