using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.StructuriRepetitive
{
    public class StructuriRepetitive
    {

        [Test]
        //public void Test()
        //{


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

            //List<string> numeColegi = new List<string>
            //{
            //   "A",
            //   "B", 
            //   "C"
            //};

            //foreach (string numeColeg in numeColegi)
            //{
            //    Console.WriteLine(numeColeg);
            //}        


      //  }

        //curs while si do while

        public void WhileLoop()
        {
            //int counter = 18;
            //while (counter < 36)
            //{
            //    Console.WriteLine($"The current counter value is: {counter}");
            //    counter++;
            //}

            //   MethodWile(1,3);
            // WhileBreak(1, 5, 4);
            // WhileBreak2(1, 5, 4);
            DoWhileMethod();
        }

        public void MethodWile(int counter, int limit)
        {
            while (counter < limit)
            {
                Console.WriteLine($"The current counter value is: {counter}");
                counter++;
            }

        }

        public void WhileBreak(int counter, int limit, int stoppValue)
        {
            while (counter <= limit)
            {
                Console.WriteLine($"The current counter value is: {counter}");
                counter++;
                if (counter == stoppValue)
                {
                    break;
                }

            }
        }

        public void WhileBreak2(int counter, int limit, int skipValue)
        {
            while (counter <= limit)
            {
                counter++;
                if (counter == skipValue)
                {
                   
                    continue;
                }
                //else
                //{
                //    Console.WriteLine($"The current counter value is: {counter}");
                //    counter++;
                //}
                Console.WriteLine($"The current counter value is: {counter}");
                counter++;

            }
        }

        public void DoWhileMethod()
        {
            int counter = -5;
            do
            {
                Console.WriteLine($"The current counter value is: {counter}");
                counter++;
            }
            while(counter <= 10);
        }



    }
}
