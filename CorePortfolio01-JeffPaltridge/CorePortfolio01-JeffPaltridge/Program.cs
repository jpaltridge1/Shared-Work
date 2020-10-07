using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePortfolio01_JeffPaltridge
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Purpose: Amortization program
                
                Input: Principle, Anual Interest Rate, Number of years to pay off loan
                
                Process(es): Calculate and write  monthly payment,  get and write  principle amount, get  and write annual interest rate , convert anual interest rate to monthly,
                             get and write number of years, calculate number of months,
                                
                
                Output:  Example:
                            -----------------------------------
                            | Amortization Payment Calculator |
                            -----------------------------------
                            This program is used to calculate the monthly payments on a loan.
                            Enter principle amount of the loan: 20000
                            Enter annual interest rate in percentage: 7.5
                            Enter number of years to pay off the loan: 5
                            Monthly payment amount is: $400.76
                            Principle amount is: $20000.00
                            Annual interest rate: 7.5%
                            Number of payments: 60
                            Number of years: 5
                
                Author: Jeff Paltridge
                Last modified: 2020.01.20
            */
            // Math.Pow((1+r),n)
            // rate /12 /100 to get proper %
            // A = P((r(Math.Pow((1 + r), n))) / (Math.Pow((1 + r), n) - 1));

            String principleInput, interestInput, yearsInput;
            
            double Principle, Rate, amountPerMonth, monthlyInterest, Years, numPayments;
            const double MonthsinYear = 12;

            Console.Write("\t*************************************\n");
            Console.Write("\t*                                   *\n");
            Console.Write("\t*  Amortization Payment Calculator  *\n");
            Console.Write("\t*                                   *\n");
            Console.Write("\t*************************************\n");
            Console.WriteLine("\n\tThis Program is used to Calculate the Monthly Payments of a Loan.\n");
            
            Console.Write("Enter the Principle amount of the loan: ");
            principleInput = Console.ReadLine();
            Principle = double.Parse(principleInput);

            Console.Write("Enter the Annual interest rate in percentage: ");
            interestInput = Console.ReadLine();
            Rate = Double.Parse(interestInput);
            monthlyInterest = ((Rate / MonthsinYear / 100));


            Console.Write("Enter the number of Years to pay off the loan: ");
            yearsInput = Console.ReadLine();
            Years = double.Parse(yearsInput);
            numPayments = Years * MonthsinYear;

            amountPerMonth = Principle * ((monthlyInterest * (Math.Pow((1 + monthlyInterest), numPayments)) / (Math.Pow((1 + monthlyInterest), numPayments) - 1)));


            Console.Write($"\nMonthly payment amount is: \t${amountPerMonth:0.00}");
            Console.Write($"\nThe Principle amount is: \t${Principle:0.00}");
            Console.Write($"\nAnnual interest: \t\t{Rate:0.0}%");
            Console.Write($"\nNumber of payments: \t\t{numPayments}");
            Console.Write($"\nNumber of years: \t\t{Years}\n");
            Console.ReadKey();

        }
    }
}
