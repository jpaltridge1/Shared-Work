using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keypress;
            String kmString, mileString;
            double totalKM, totalMiles, km, miles;
            const double convfromMiles = 1.60934;
            const double convfromKm = 0.621371;

            Console.WriteLine("This Program  is here to convert Mileage for either Miles to Kilometers or Kilometers to Miles.\n");
            Console.WriteLine("Please press (k) to convert Miles to Kilometers or Press (m) to Convert Kilometers to Miles. \n");
            keypress = Console.ReadKey();
            
            if (keypress.KeyChar == 'k')
            {```
                Console.WriteLine("\n Please enter distance in Miles: ");
                mileString = Console.ReadLine();
                miles = double.Parse(mileString);
                totalKM = miles * convfromMiles;
                Console.WriteLine($"\n Your conversion of {miles:0.00} Miles to Kilometers is: {totalKM:0.00}");
            }

            if (keypress.KeyChar == 'm')
            {
                Console.WriteLine("\n Please enter distance in Kilometers: ");
                kmString = Console.ReadLine();
                km = double.Parse(kmString);
                totalMiles = km * convfromKm;
                Console.WriteLine($"\n Your conversion of {km:0.00} Kilometers to Miles is: {totalMiles:0.00}");
            }
                        
        }
    }
}
