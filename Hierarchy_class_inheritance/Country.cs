using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy_class_inheritance
{
    class Country
    {
        public string name;
        public string currency;
        public string location;
        public string language;

        public Country()
        {
        }

        public void countryProfile()
        {
            Console.WriteLine(name + " " + currency + " " + location + " " + language);
        }
    }
}
