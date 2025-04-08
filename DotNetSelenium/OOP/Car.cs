using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.OOP
{
    public class Car
    {
        string engine;
        string color;
        int doors;
        double cilinder;
        string gearboxtype;

        public Car(string engine, string color, int doors, double cilinder)
        {
            this.engine = engine;
            this.color = color;
            this.doors = doors;
            this.cilinder = cilinder;
        }

        public Car(string engine, string color, int doors, double cilinder, string gearboxtype)
        {
            this.engine=engine;
            this.color = color;
            this.doors = doors;
            this.cilinder = cilinder;
            this.gearboxtype = gearboxtype;
        }

        public void DisplayData()
        {
            Console.WriteLine($"Engine is: {engine}");
            Console.WriteLine($"Color is: {color}");
            Console.WriteLine($"Number of doors is: {doors}");
            Console.WriteLine($"Cilinder is: {cilinder}");

            if(gearboxtype != null)
            {
                Console.WriteLine($"Gearbox type is: {gearboxtype}");
            }

           

        }
    }
}
