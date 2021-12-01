using System;

namespace Hierarchy_class_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Country cntry1 = new Country();

            cntry1.name = "Azerbaijan";
            cntry1.currency = "Manat";
            cntry1.language = "Azerbaijani";
            cntry1.location = "Caucasian";
            
            Console.WriteLine("Country name :" +cntry1.name );
            Console.WriteLine("Country currency :" + cntry1.currency);
            Console.WriteLine("Country language :" + cntry1.language);
            Console.WriteLine("Country location :" + cntry1.location);
            cntry1.countryProfile();

        }

    }
}
