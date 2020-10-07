using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a method that holds the actual code for this case
             * the B case will CALL the method to execute this action is reffered to as calling the statement
             * calling requires your code to use the method name
             * 
             * your program will branch to the requested  
             * 
             * 
             * the syntax for a method requires
             * 
             * accesstype returndatatype MethodName([list of parameters])
             * {
             *      //your method code
             * }//eom
             * 
             * 
             * accesstype:  public or private
             *              protected, internal, have static reference
             *              
             *  returndatatype: if you are returning nothing use the keyword void
             *                  otherwise, return a single value such as int, double, decimal ect.
             *                  
             *  MethodName: continious string of characters which will be used within
             *                your program code to reference this coding block
             *  
             *  it is best to use a meaningful name
             *  
             *  [list of parameters] this is a set of local variables that will be used to recieve values from the calling statement
             *                  a parameter is a set of datatype variable name
             *                  parameters are separated by using a comma ,
             *  do
             *  {
             * 
             *  }while (menuOption.ToUpper() !="X");
             * 
             * 
             */

            string menuOption;
            bool flag = false;


            while (flag == false)
            {
                Console.WriteLine("Select a Menu Option:");
                Console.WriteLine("A) Even or Odds Game");
                Console.WriteLine("B) Heads or Tails Game");
                Console.WriteLine("C) Sum of Squares");
                Console.WriteLine("X) to Exit");
                Console.Write("Please Enter your selection: ");
                menuOption = Console.ReadLine();


                switch (menuOption.ToUpper())
                {

                    case "A":
                        {

                            string promptline = "\n\nPlease Enter a Whole Number or 0 to exit: ";

                            int number = GetIntergerInput(promptline);

                            if (number % 2 == 0)
                            {
                                Console.WriteLine($"\n\nThe number {number} is Even!\n\n");
                            }

                            else
                            {
                                Console.WriteLine($"\n\nThe number {number} is Odd!\n\n");
                            }
                           // Even_Or_Odds();
                            break;
                        }


                    case "B":
                        {
                            Heads_or_Tails_Game();//calling statement
                            break;
                        }


                    case "C":
                        {

                            //sum of squares
                            //loop 4 times
                            int number = GetIntergerInput("\n\nEnter a number greater than 0 : ");
                           if (number < 1)
                            {
                                Console.WriteLine($"{number} is not greater than 0! Unable to do sum of Squares!");

                            }

                            else
                            {
                                int sumofsquares = 0;
                                sumofsquares = SumofSquaresMethod(number);
                                Console.WriteLine($"\n\nThe total of {sumofsquares} is the sum of squares for the number {number}! \n\n");

                            }

                            break;
                        }

                    case "X":
                        {
                            Console.WriteLine("Thank You for playing!");
                            flag = true;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("You have Enter an Invaild Menu Selection! Please Retry.");
                            break;
                        }

                }

            }
        }
            

        
     static public void Heads_or_Tails_Game()//method header
     {

        string inputString;
        do
        {

            Console.WriteLine("Enter  a H (Heads) or T (Tails) or Q (Quit)");
            inputString = Console.ReadLine();
            if (inputString.ToUpper() == "H")
            {
                Console.WriteLine("Heads");
            }
            else if (inputString.ToUpper() == "T")
            {
                Console.WriteLine("Tails");
            }

        } while (!inputString .ToUpper().Equals("Q"));
        
     }
      
        static public void Even_Or_Odds() //subroutine (does not return value)
        {


        }

        /*
         * Pass data into/return data from a method
         * 
         * local variables are not automatically passed to any called method
         * 
         * methodname(drivervariable, anothervariable)
         *                  Arguments (calling statement name)
         *                  
         *        Pass by value          
         *  methodname(int localcopyofDV, string localcopyofAV    )
         *                      parameter (method version naming)
         *                      locally declared (die at end of method)
         *                      
         *    for return data you must define datatype replace (void) with (return)
         *    
         *    
         *    return datatypeof
         *    
         *    
         * 
         */


           static public int GetIntergerInput(string promptline)
           {
            bool validFlag = false;
            int number = 0;
            do
            {
                Console.Write(promptline);
                string inputString = Console.ReadLine();

                if (int.TryParse(inputString, out number))
                {
                  validFlag = true;
                }


            } while (validFlag == false);

            // if your method indicates that a return datatype is specified
            // you must have at least 1 return statement in your method code

            return number;

           }
    

        static public int SumofSquaresMethod(int seednumber) //function (returns a value)
        {
            int finalsquare = 0;
            for(int loopcounter = 1; loopcounter <= seednumber; loopcounter++)
            {
                finalsquare += loopcounter * loopcounter;

            }
            return finalsquare;
        }


        /*
         * Method stub
         *    static public int SumofSquaresMethod(int seednumber)
         *    {
         *    return 0;
         *    }
         *    
         */

    }//eom
}
