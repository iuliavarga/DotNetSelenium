using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.Metoda
{
    public class MyFirstClass
    {
        [Test]
        public void metodaTestNumbers()
        {
           // sumNumbers();
           // sumNumbers(1, 2);
           // sumNumbers(1, 2, 3);
          
          int sum = GetResult(1, 2, 3);
          Console.WriteLine("Afisa suma: " + sum);


        }

        public void sumNumbers()
        {
            int number1 = 5;
            int number2 = 7;
            int sum = number1 + number2;
            Console.WriteLine("Rezultatul adunarii este " + sum);

        }

        public void sumNumbers(int number1, int number2)
        {
            int sum = number1 + number2;
            Console.WriteLine("Rezultatul adunarii este " + sum);
        }

        public void sumNumbers(int number1, int number2, int number3)
        {
            int sum = number1 + number2 + number3;
            Console.WriteLine("Rezultatul adunarii este " + sum);
        }

        public int GetResult(int number1, int number2, int number3)
        {
            int sum = number1 + number2 + number3;
            return sum;
        }

    }

   
}
