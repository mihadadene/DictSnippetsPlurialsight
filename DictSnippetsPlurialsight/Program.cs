using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictSnippetsPlurialsight
{
    class Program
    {
        static void Main(string[] args)
        {

            Country norway = new Country("Norway", "NOR", "Europe", 5_282_223);
            Country finland = new Country("Finland", "FIN", "Europe",5_511_303);

           var countries = new Dictionary<string, Country>()

           {
               { norway.Code, norway },
               { finland.Code, finland }
           };

            Country selectedCountry = countries["NOR"];
            Console.WriteLine(selectedCountry.Name);

            foreach(Country country in countries.Values)
            Console.WriteLine(country.Name);
            Console.ReadKey();

        }
    }
}
