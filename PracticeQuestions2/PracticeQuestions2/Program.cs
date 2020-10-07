using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions2
{
    class Program
    {
        static void Main(string[] args)
        {
            string hoursInput, packageTypeInput;
            double Hours, totalCost, addHoursCost;

            const double PACKA = 9.95;
            const double PACKB = 13.95;
            const double PACKC = 19.95;
            const double PACKAOVER = 2.00;
            const double PACKBOVER = 1.00;
            const double PACKAHRS = 10;
            const double PACKBHRS = 20;
            Console.Write("Please Enter your Package Letter (A, B or C): ");
            packageTypeInput = Console.ReadLine();

            Console.Write("Please Enter the total amount of Hours you have used: ");
            hoursInput = Console.ReadLine();
            Hours = double.Parse(hoursInput);

            switch (packageTypeInput)
            {
                case "a":
                case "A":
                    {
                        addHoursCost = PACKAOVER * (Hours - PACKAHRS);
                        totalCost = addHoursCost + PACKA;
                        Console.WriteLine($"The total cost of the {Hours:0} hours under package {packageTypeInput} with be: ${totalCost:0.00}.");
                    }
                    break;

                case "b":
                case "B":
                    {
                        addHoursCost = PACKBOVER * (Hours - PACKBHRS);
                        totalCost = addHoursCost + PACKB;
                        Console.WriteLine($"The total cost of the {Hours:0} hours under package {packageTypeInput} with be: ${totalCost:0.00}.");
                    }
                    break;

                case "c":
                case "C":
                    {
                        addHoursCost = 0;
                        totalCost = addHoursCost + PACKC;
                        Console.WriteLine($"The total cost of the {Hours:0} hours under package {packageTypeInput} with be: ${totalCost:0.00}.");
                    }
                    break;

            }//eos

            Console.ReadKey();
                                          
        }
    }
}
