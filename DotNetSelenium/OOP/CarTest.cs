using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.OOP
{
    public class CarTest
    {

        [Test]
        public void MetodaTest()
        {
            var car1 = new Car("benzina", "rosie", 5, 1.3);
            car1.DisplayData();

            Console.WriteLine();

            Car car2 = new Car("motorina", "albastra", 2, 2.0);
            car2.DisplayData();

            Console.WriteLine();

            Car car3 = new Car("benzina", "alb", 4, 1.4, "automata");
            car3.DisplayData();

            
        }
    }
}
