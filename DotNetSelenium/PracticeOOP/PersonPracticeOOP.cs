using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotNetSelenium.PracticeOOP
{

    //abstract base class Person
    public abstract class PersonPracticeOOP
    {
        public string Name { get; set; }

        public PersonPracticeOOP(string name)
        {
            this.Name = name;
        }

        //abstract method must be implemented in derived classes
        public abstract void DisplayInfo();



    }
}
