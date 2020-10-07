using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalconditions
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Logical conditions are 2 or more conditions separated by a logic operator
             * Relative Operators 
             * > , >= , < , <= , == , !=
             * operand operator operan
             *  high > low
             *  
             *  Logical Operators
             *  || (or) , && (and) , ! (not)
             */

            int Age = 6;

            if (Age < 4)
            {
                Console.WriteLine("Too Young!");

            }

            else if (Age > 14) 
            {
                Console.WriteLine("Too Old!");

            }

            else
            {
                Console.WriteLine("Welcome to the League!");

            }

            // but what if about using logical operators
            //Note  the operand is repeasted for each relative test condition
            // (Age < 4 || > 14)
            // (Age < 4 && Age > 14) is incorrects as you can not be less than 4 and greater than 14 at the same time

            //truth table
            //conditions   or    and
            // T   T       T        T
            // T   F       T        F
            // F   T       T        F
            // F   F       F        F

            //summary && is only true if both conditions are true
            // || is only false if Both conditions are false



            if (Age < 4 || Age > 14)
            {
                Console.WriteLine("Sorry you are not in the age bracket for this league!");

            }

            else
            {
                Console.WriteLine("Welcome to the league!");
            }


        }

    }
}
