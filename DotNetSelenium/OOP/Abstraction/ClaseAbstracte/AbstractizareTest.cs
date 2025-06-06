using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.OOP.Abstraction.ClaseAbstracte
{
    public class AbstractizareTest
    {

        [Test]

        public void TestMethod()
        {
            Cerc cerc = new Cerc { Culoare = "Albastru", Raza = 5 };
            //Cerc cerc1 = new Cerc();
            //cerc1.Culoare = "Rosu";
            //cerc1.Raza = 5; 
            cerc.CalculAria();
            cerc.Deseneaza();

            Patrat patrat = new Patrat { Culoare = "Verde", Latura = 4 };
            patrat.CalculAria();
            patrat.Deseneaza();

        }
    }
}
