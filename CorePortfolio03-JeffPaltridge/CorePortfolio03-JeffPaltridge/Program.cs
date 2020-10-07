using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePortfolio03_JeffPaltridge
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Purpose: calulating depreciation tables
             * 
             * Input: option selection, amount to depreciate, number of years to deprieciate 
             * 
             * Process(s): loop, switch, method
             * 
             * Output: option menu, input queries, depreciation values 
             * 
             * Author: Jeff Paltridge       
             * 
             * modified: March 4, 2020
             *              
             */

            string menuOption;
            decimal amount = 0m;
            decimal year = 0m;
            string amountString; 
            string yearString;
            bool amountBool = false;
            bool yearBool = false;

            do
            {
                Console.WriteLine("Please Enter: ");
                Console.WriteLine("\tA -To enter a new Amount and/or Number of Years, ");
                Console.WriteLine("\tB -To use the straight-line method, ");
                Console.WriteLine("\tC -To use the sum-of-years-digits method, ");
                Console.WriteLine("\tD -To use the double-declining balance method, ");
                Console.WriteLine("\tQ -To Quit, ");
                Console.Write("\nOption? ");
                menuOption = Console.ReadLine();

                switch (menuOption.ToUpper())
                {

                    case "A":
                        {

                            bool exitCounter = false;

                            while (exitCounter == false)
                            {
                                do
                                {
                                    Console.Write("\nHow much money is to be Depriciated: ");
                                    amountString = Console.ReadLine();
                                    if (amountString != "0")

                                    {

                                        if (decimal.TryParse(amountString, out amount) && amount > 0)
                                        {
                                            amountBool = true;
                                            
                                        }

                                        else
                                        {
                                            Console.WriteLine($"Invaild Value {amountString} . Try again or enter 0 to exit option! ");
                                        };

                                    }
                                    else
                                    {
                                        exitCounter = true;
                                        amountBool = true;
                                    }
                                } while (amountBool == false);//eow

                                if (exitCounter == false)
                                {

                                    do
                                    {
                                        Console.Write("Over How many Years? ");
                                        yearString = Console.ReadLine();

                                        if (yearString != "0")
                                        {

                                            if (decimal.TryParse(yearString, out year) && year > 0)
                                            {
                                                yearBool = true;
                                            }

                                            else
                                            {
                                                Console.WriteLine($"Invaild Value {yearString} . Try again or enter 0 to exit option! ");
                                            }
                                        }

                                        else
                                        {
                                            yearBool = true;
                                        }


                                        Console.WriteLine();

                                    } while (yearBool == false);//eow
                                }
                                exitCounter = true;   
                            }

                            amountBool = false;
                            yearBool = false;

                            break;
                           
                        }

                    case "B":
                        {
                            Straight_Line_Method(amount, year);
                            break;
                        }

                    case "C":
                        {
                            Sum_of_Years_Digits_Method(amount, year);
                            break;
                        }

                    case "D":
                        {
                            Double_Declining_Balance_Method(amount, year);
                            break;
                        }

                    case "Q":
                        {
                            Console.WriteLine("\nGood-Bye!\n");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine($"\n*** Invaild Menu Choice {menuOption}.\n");
                            break;
                        }
                }//eos

            } while (menuOption.ToUpper() != "Q"); //eow
        }

        public static void Straight_Line_Method(decimal amount, decimal year)
        {
            decimal loopMax = year;
            decimal amountInput = amount;
            decimal depreciationAmount;

            Console.WriteLine("\n  Year \t  Depreciation");
            Console.WriteLine("  ---- \t--------------");
            
            for (decimal depreciationCounter = 1; depreciationCounter <= loopMax; depreciationCounter++)
            {

                depreciationAmount = amountInput / year;
                Console.WriteLine("{0,6:0}{1,16:c}", depreciationCounter, depreciationAmount);
            }
            Console.WriteLine();
           
        }
        public static void Sum_of_Years_Digits_Method(decimal amount, decimal year)
        {
            decimal loopMax = year;
            decimal amountInput = amount;
            decimal yearSum = 0;
            decimal depreciationAmount;
            decimal yearTotal;

            Console.WriteLine("\n  Year \t  Depreciation");
            Console.WriteLine("  ---- \t--------------");
            for (decimal loopCounter = 1; loopCounter <= loopMax; loopCounter++)
            {
                yearSum += loopCounter;

            }

            for (decimal depreciationCounter = 1; depreciationCounter <= loopMax; depreciationCounter++)
            {

                yearTotal = (year - depreciationCounter + 1);
                depreciationAmount = amountInput * (yearTotal / yearSum);
                Console.WriteLine("{0,6:0}{1,16:c}", depreciationCounter, depreciationAmount);

            }
            Console.WriteLine();
        
        }

        public static void Double_Declining_Balance_Method(decimal amount, decimal year)
        {
            decimal amountTotal = amount;
            decimal loopMax = year;
            decimal depreciationAmount;

            Console.WriteLine("\n  Year \t  Depreciation");
            Console.WriteLine("  ---- \t--------------");
           
            for (decimal depreciationCounter = 1; depreciationCounter <= loopMax; depreciationCounter++)
            {
                depreciationAmount = (amountTotal * (2 / year));
                amountTotal -= depreciationAmount;

                Console.WriteLine("{0,6:0}{1,16:c}", depreciationCounter, depreciationAmount);

            }
            Console.ReadKey();

        }
    }
}
