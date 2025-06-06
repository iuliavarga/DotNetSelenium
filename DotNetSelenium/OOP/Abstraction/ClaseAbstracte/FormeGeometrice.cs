using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.OOP.Abstraction.ClaseAbstracte
{
    public abstract class FormeGeometrice
    {
        public string Culoare { get; set; }

        public abstract void CalculAria();

        public void Deseneaza()
        {
            Console.WriteLine($"Deseneaza forma geometrica");
        }
    }
}
