using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.StructuriRepetitive
{
    public class StructuriRepetitive
    {

        [Test]
        public void Test()
        {


            // for(int i= 1; i<=7; i++)
            // {
            //     Console.WriteLine(i);
            // }


            /* int i = 1;

             for(; i<=8; i++)
             {
                 Console.WriteLine(i);

             }*/

            /*int i = 0;

            for (; i <= 7; )
            {
                i++;
                Console.WriteLine(i);
                
            }*/

            /* string[] numeColegi = new string[3];
             numeColegi[0] = "A";
             numeColegi[1] = "B";
             numeColegi[2] = "C";

             for (int i = 0; i < numeColegi.Length; i++)
             {
                 Console.WriteLine(numeColegi[i]);
             }*/

            List<string> numeColegi = new List<string>
            {
               "A",
               "B", 
               "C"
            };

            foreach (string numeColeg in numeColegi)
            {
                Console.WriteLine(numeColeg);
            }

            


        }





    }
}
