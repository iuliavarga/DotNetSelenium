using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.Practice
{
    public class PracticeArraysLists
    {
        [Test]


        public void InputNumber()
        {
            ListNumber(6);
        }


        public void ListNumber(int n)
        {

            Console.WriteLine($"Please input a number for list: {n}");

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(i);
              
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"Your list contains the following items [{i}]: {numbers[i]} " );

            }


            Console.WriteLine("Your list contains the following items: " + string.Join(", ", numbers));


            List<int> evenNumbers = new List<int>();

            List<int> oddNumbers = new List<int>();

            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                }
                else
                {
                    oddNumbers.Add(i);
                }
            }


            Console.WriteLine("The list of even numbers is: " + string.Join(", ", evenNumbers));
            Console.WriteLine("The list of odd numbers is: " + string.Join(", ", oddNumbers));

            int evenSum = 0;
            int oddSum = 0;

            foreach (int i in evenNumbers)
            {
                evenSum += i;
            }

            foreach (int i in oddNumbers)
            {
                oddSum += i;
            }


            Console.WriteLine("The sum of even numbers is: " + evenSum);
            Console.WriteLine("The sum of odd numbers is: " + oddSum);

        }


    }
}
