using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.Sesiune2
{
    public class Cursant
    {
        string numeCursant;
        string prenumeCursant;
        int varsta;
        int cnp;
        bool esteActiv;
        char gen;
        float nota;
        double inaltime;

        [Test]
        public void metodaTest()
        {
            numeCursant = "varg";
            prenumeCursant = "julia";
            varsta = 20;
          //  cnp = 281818578462;
            var numarLung = 281818578462;
            esteActiv = false;
            gen = 'M';
            nota = 9.50F;
            inaltime = 1.63;

            Console.Write("Numele: " + numeCursant + "\n" );
            Console.WriteLine("Prenumele: " + prenumeCursant);
            Console.WriteLine("Varsta: " + numarLung);
         

        }

    }
}
