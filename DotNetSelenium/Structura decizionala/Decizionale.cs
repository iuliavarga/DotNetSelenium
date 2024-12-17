using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V117.Debugger;

namespace DotNetSelenium.Structura_decizionala
{
    public class Decizionale
    {
        [Test]

        public void Decizie()
        {
            //VerificareNumar(5, 10);
            //VerificareNumar(11, 10);
            ComparareDigits(5);
            VerificareMasina("dacie");
        }

        public void VerificareNumar(int x, int y)
        {
            if (x < y)
            {
                Console.WriteLine($"Numarul {x} este mai mic decat {y} ");
            }
            else
            {
                Console.WriteLine($"Numarul {y} este mai mic decat {x} ");

            }

        }

        public void ComparareDigits(int x)
        {
            if (x < 5)
            {
                Console.WriteLine($"Numarul {x} este mai mic 5");
            }
            else if (x > 5)
            {
                Console.WriteLine($"Numarul {x} este mai mare 5");
            }
            else
            {
                Console.WriteLine($"Numarul {x} este egal 5");
            }

        }

        public void VerificareMasina(string masina)
        {
            switch (masina)
            {
                case "Mercedes":
                    Console.WriteLine("Este disponibl Mercedes");
                    break;
                case "BMW":
                    Console.WriteLine("Este disponibl BMW");
                    break;
                case "Fiat":
                    Console.WriteLine("Este disponibl Fiat");
                    break;
                default:
                    Console.WriteLine("Marca nu este disponibila");
                    break;

            }


        }


    }
}
