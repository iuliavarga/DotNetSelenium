using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.OOP.Abstraction.ClaseAbstracte
{
    public class Cerc : FormeGeometrice
    {
        public int Raza { get; set; }
        public override void CalculAria()
        {
            Console.WriteLine($"Aria cercului este egala cu {Math.PI * Math.Pow(Raza, 2)}");
        }
    }

}
