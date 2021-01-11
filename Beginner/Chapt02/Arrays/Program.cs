using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ruta archivo
            string filePath = @"c:\Users\memob\Downloads\Population.csv";

            ReadFile readFile = new ReadFile(filePath);

            Country[] countries = readFile.ReadCountryNFile(15);

            int i = 1;
            foreach (var country in countries)
            {
                Console.WriteLine($" {i.ToString().PadRight(3)}  {country.Name.PadRight(18)} {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)} ");
                i++;
            }

            _=Console.ReadLine();
        }
    }
}
