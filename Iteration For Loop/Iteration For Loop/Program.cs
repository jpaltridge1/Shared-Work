using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             *  for is a pre-test loop
             * 
             * for(setup; conditions, stepping (increment or detriment)
             *    (setup = initialize)
             *    
             *    {
             *      Processing code block
             *    }
             *    
             *    for(int counter:1; counter<stopNumber; counter ++) // if end with a ; with stop the loop and treat the code block as a normal code block
             *    {
             *      codeblock
             *    }
             *    
             *    
             * Sample of Pre-Test Loops
             * 
             * While loop
             * for loop
             * 
             * code a while loop that rate the components of a for loop into visable individual items
             *
             * counter: will count the number of times through the loop
             * while condition: counter is < my stop value (stop value is either and upper limit or lower limit)
             * 
             * go through the loop 7 times count the number of even number , number of odd numbers
             * after the loop print out the even an odd number totals
             * 
             * int evenNumbers = 0;
             * int oddNumbers = 0;
             * 
             * 
             * 
             *eof = end of if
             * eol = end of loop
             * eow = end of while
             */


            string inputNumber;
            int testNumber, resultNumber;
            const int TWO = 2;
            const int LOOPMAX = 7;
            //int loopCounter = 1;//(replaced by for loop)
            int evenNumbers = 0;
            int oddNumbers = 0;

            //  while (loopCounter <= LOOPMAX) //(replaced by for loop)



            for (int forCounter = 1; forCounter <= LOOPMAX; forCounter++) 
            {
                Console.Write("Please enter a Whole Number: ");
                inputNumber = Console.ReadLine();
                testNumber = int.Parse(inputNumber);

                resultNumber = (testNumber % TWO);

                if (resultNumber == 0)
                {
                    evenNumbers++ ;                }

                else if (resultNumber == 1)
                {
                    oddNumbers++ ;
                }//eof

                //increment the loop counter
               // loopCounter++; //(replaced by for loop)
            }

            Console.WriteLine($" There were {evenNumbers} EVEN numbers");

            Console.WriteLine($" There were {oddNumbers} ODD numbers");

        }
    }
}
