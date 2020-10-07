using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decisionstructure
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, second, highest;
            string message;

            Console.WriteLine("enter first number: ");
            first = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            second = double.Parse(Console.ReadLine());

            if (first > second)
            {
                highest = first;
                message = "first";
            }
            else
            {
                highest = second;
                message = "second";
            }

            Console.WriteLine("first = {0}, second = {1}, the {2} number had a higher value: {3}", first, second, message, highest);

            Console.ReadLine();

        }
    }
}
