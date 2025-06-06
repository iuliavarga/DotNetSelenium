using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.OOP.Abstraction.ClaseAbstracte
{
    public class Patrat : FormeGeometrice
    {
        public int Latura { get; set; }
        public override void CalculAria()
        {
            Console.WriteLine($"Aria patratului este: {Math.Pow(Latura,2)}");  
        }
    }
}
