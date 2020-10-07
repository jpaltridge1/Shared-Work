using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision1
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, highest;

            String message;
            string inputValue;

            Console.Write("Enter the First Number: ");
            inputValue = Console.ReadLine();

            if (!int.TryParse(inputValue, out first))
            {

                Console.WriteLine("You did not enter a number. you entered a Letter please restart.");
            }
            // reused the inputValue because previous value was stored elsewhere

            Console.Write("\nEnter the Second Number: ");
            inputValue = Console.ReadLine();
            second = int.Parse(inputValue);

            if (first > second)
            {
                highest = first;
                message = "first";
                Console.WriteLine($"The Highest Number between {first} and {second} is {highest} which was the {message} number input !");
                Console.WriteLine($"First = {first}, Second = {second}, the {message} number entered had the higher value of : {highest}");
                Console.ReadKey();
            }

            else
            {
                highest = second;
                message = "second";
                Console.WriteLine($"The Highest Number between {first} and {second} is {highest} which was the {message} number input !");
                Console.WriteLine($"First = {first}, Second = {second}, the {message} number entered had the higher value of : {highest}");
                Console.ReadKey();
             }
        }
    }
}
