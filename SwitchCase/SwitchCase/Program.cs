using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //example 2 Switch case 
            //print out the month name
            //single argument variable
            // this single arg variable will be tested again multiple const values
            //the case test is an == test


            int monthNumber = 2;
            
            switch (monthNumber)
            {
                case 1:
                    {
                        // do any logic that is required when month number is 1

                        Console.WriteLine("The name of the month is January!");
                    }
                    break;

               
                case 2:
                    {
                        Console.WriteLine("The name of the month is Febuary! ");
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("The name of the month is March! ");
                    }
                    break;


                case 4:
                    {
                        Console.WriteLine("The name of the month is April! ");
                    }
                    break;


                case 5:
                    {
                        Console.WriteLine("The name of the month is May! ");
                    }
                    break;


                case 6:
                    {
                        Console.WriteLine("The name of the month is June!");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Too late in the Year to think!");
                    }
                    break;
                   


            }

        }
    }
}
