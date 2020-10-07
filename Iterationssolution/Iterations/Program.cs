using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputNumber;
            int testNumber, resultNumber;
            const int TWO = 2;







            /* The loop structure demostrated is a a Pre-Test, a Pre-test is also known as a Do While
             * Pre-Test checks to see if the condition is true BEFORE executing the code
             * after the code has exectuted, the Pre-Test condition is still true
             * if the condition is still true the loop code is re-executed
             * if the condition is false the loop ternates and the execution continues with the remainder of the program.
             */

            Console.Write("Do you with to play the Even or Odd Game? ");

            string answer = Console.ReadLine();

            //loop construction
            //answer.ToUpper().Equals("Y")
            //answer =="Y || answer == "y"








            while (answer.Equals("Y") || answer.Equals("y"))
            {
                //within this coding block you are inside your loop, this loop will terminate if answer is not Y y


                //TODO: Place Loop Logic here

                Console.Write("Please enter a Whole Number: ");
                inputNumber = Console.ReadLine();
                testNumber = int.Parse(inputNumber);

                resultNumber = (testNumber % TWO);

                if (resultNumber == 0)
                {
                    Console.WriteLine($"The Number {testNumber} is Even!");
                }

                else if (resultNumber == 1)
                {
                    Console.WriteLine($"The Number {testNumber} is Odd!");
                }



                //ask if the user wishes to contiue playing the game
                //give the user an oppertunity to exit the loop

                Console.Write("Do you with to play the Even or Odd Game? ");

                answer = Console.ReadLine();

            }//eow (End of While)

            Console.WriteLine("You have Terminated the game!");
            Console.ReadKey();

                //string inputNumber;
                //int testNumber, resultNumber;
                //const int TWO = 2;

                //Console.Write("Please enter a Whole Number: ");
                //inputNumber = Console.ReadLine();
                //testNumber = int.Parse(inputNumber);

                //resultNumber = (testNumber % TWO);


                //if (resultNumber == 0)
                //{
                //    Console.WriteLine($"The Number {testNumber} is Even!");
                //    Console.ReadLine();
                //}

                //else if (resultNumber == 1)
                //{
                //    Console.WriteLine($"The Number {testNumber} is Odd!");
                //    Console.ReadLine();






        }
    }
    
}
