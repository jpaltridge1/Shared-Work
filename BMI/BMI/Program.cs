using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {

        static void Main(string[] args)
        {
            string Name, Units;

            Console.WriteLine("Please Enter your Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Press (M) for Metric or (I) for Imperial measurements:");
            Console.ReadKey();
        }
    }
}
