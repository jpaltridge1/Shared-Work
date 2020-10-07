using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inout
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Implement a temperature converter from Celcius to Fahrenhiet
             * 
             * Jan.15,2020
             */


            //input: Celsius temperature
            //          String inputTemp
            //           double thecelsiusTemperature

            //output: Farenheit temperature
            //          double theFarenheitTemperature

            //expression (ct * 9 /5) + 32
            //check with ct = 0 expect ft = 32
            //check with ct = -40 expect ft = -40
            //check with ct = 100 expect ft = 212

            Console.Write("Enter a Celsius Temperature:\t");

            // to obtain the keystrokes that the users types ( input
            // use .readline()

           
            String inputTemp = Console.ReadLine();

            // need to convert the string to a double
            //to do this use will need to use parsing
            // syntax:  dataTypeto.Parse(string)

            double theCelsiusTemperature = double.Parse(inputTemp);

            double theFahrenheitTemperature = (theCelsiusTemperature * (9.0 / 5.0) + 32.0);

            Console.WriteLine($"The Temperature you entered of {theCelsiusTemperature} degrees Celsius is {theFahrenheitTemperature} degrees Fahrenheit");

            //to ensure that your display stays wether you run without debuging (Cntrl +F5 ), or with debugging (F5) or the start button add a Console.Readline()

            Console.ReadLine();
        }
    }
}
