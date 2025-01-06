using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V117.Inspector;

namespace DotNetSelenium.Practice
{
    public class VerificareNumerePare
    {

        [Test]
        
        public void VerificareNumar()
        {
            DetermninareNumerePare(0);
        }


        public void DetermninareNumerePare(int numar)
        {

            if (numar % 2 == 0)
            {
                Console.WriteLine($"{numar} este un numar par!");

                if (numar > 0)
                {
                    Console.WriteLine("Numarul este par pozitiv!");
                }
                else if (numar < 0)
                {
                    Console.WriteLine("Numarul este par negativ!");
                }
                else
                {
                    Console.WriteLine($"Si {numar} este un numar par!");
                }
               
            }
            else
            {
                Console.WriteLine($"{numar} este un numar impar!");
            }
    
        }


    }
}
