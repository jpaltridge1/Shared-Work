using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This program will tellyou if the number entered is even or odd
             */

            string inputNumber;
            int testNumber, resultNumber;
            const int Two = 2;
            Console.Write("Please enter a Whole Number: ");
            inputNumber = Console.ReadLine();
            testNumber = int.Parse(inputNumber);

            resultNumber = (testNumber % Two);


            if (resultNumber == 0)
            {
                Console.WriteLine($"The Number {testNumber} is Even!");
                Console.ReadLine();
            }

            else if (resultNumber == 1)
            {
                Console.WriteLine($"The Number {testNumber} is Odd!");
                Console.ReadLine();
                    
            }
        }
    }
}
