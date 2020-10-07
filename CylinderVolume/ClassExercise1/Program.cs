using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Purpose: To find the volume of a cylinder
             * 
             * Input: Height in cm and Radius in cm
             * 
             * Output: Volume in cm cubed
             * 
             * Author: Jeff Paltridge
             * 
             * Last Modified: 2020/01/17
             */

            String inputHeightcm, inputRadiuscm;

            Double heightCm, radiusCm, totalVolume;

            // PI determined with Math.PI function

            Console.WriteLine("This Program is used to find the volume of a Cylinder! \n ");
            
            Console.Write("\nPlease Enter the Radius in Centimeters: ");
            inputRadiuscm = Console.ReadLine();

            Console.Write("Please Enter Height in Centimeters: ");
            inputHeightcm = Console.ReadLine();

            heightCm = Double.Parse(inputHeightcm);
            radiusCm = Double.Parse(inputRadiuscm);

            totalVolume = (Math.PI * (radiusCm * radiusCm) * heightCm);

            Console.WriteLine($"\nThe volume of a Cylinder with a radius of {radiusCm:0.00} and a height of {heightCm:0.00} is : {totalVolume:0.00} Cubic Centimeters.");
            Console.ReadLine();

        }
    }
}
