using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.Multimi
{
    public class Multimi
    {
        [Test]
        public void Test1()
        {

            Dictionary<string, string> objects = new Dictionary<string, string>
            {
                {"object", "laptop" },
                {"fruit", "apple" },
                {"sport", "snowboard" },
            };

            foreach (var obj in objects)
            {
                Console.WriteLine($"The key is {obj.Key} ");
                Console.WriteLine($"The value is {obj.Value} ");
            }

            Dictionary<string, List<string>> classification = new Dictionary<string, List<string>>();
            List<string> citiesOfRomania = new List<string> { "Bucuresti", "Cluj-Napoca", "Timisoara" };
            List<string> citiesOfFrance = new List<string> { "Paris", "Lyon", "Marseille" };
            List<string> citiesOfGermany = new List<string> { "Berlin", "Munich", "Hamburg" };

           // classification.Add("Romania", citiesOfRomania);
            classification["Romania"] = citiesOfRomania;
            classification["France"] = citiesOfFrance;
            classification["Germany"] = citiesOfGermany;

            foreach (var key in classification.Keys)
            {
                Console.WriteLine($"The country is {key}");
                Console.WriteLine($"The city are " + string.Join(",", classification[key]));
            }




            //foreach (var key in classification)
            //{
            //    foreach(var value in key.Value)
            //    {
            //        Console.WriteLine($"The country is {key.Key}");
            //        Console.WriteLine($"The city is {value} ");
            //    }

            //}
        }


    }
}
