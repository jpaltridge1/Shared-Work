using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            string gradeLetter;
            string percentageRange;

            /* as Case Decision structure can be used when you have a single arument value compared to a series of literal values
             *  (case is and equal sign)
             * the structure begins with the switch(arg value) {...}
             * with in a switch structure  you have  "cases" a case represents one "if" test against the argument value
             * the case must end with a "break;" command
             * the break sends your execution to the end of the switch structure
             * the last case in your switch is a special case called "default"
             * default executes if NONE of the previous cases were exectued
             * you can have multiple case statements coded for a particular case coding code block
             * 
             * multiple case statements for a particular case coding block are implied logical  OR (||) tests
             */


            Console.Write("Please Enter the Letter grade you wish to convert: ");
            gradeLetter = Console.ReadLine();
                       

            //switch (gradeLetter)
            //{
            //    case "a":
            //    case "A":
            //        {
            //            //logic for this particular case
            //            percentageRange = "85 - 100";
            //            break;
            //        }

            //    case "b":
            //    case "B":
            //        {
            //            //logic for this particular case
            //            percentageRange = "70 - 84";
            //            break;
            //        }


            //    case "c":
            //    case "C":
            //        {
            //            //logic for this particular case
            //            percentageRange = "55 - 69";
            //            break;
            //        }



            //    case "d":
            //    case "D":
            //        {
            //            //logic for this particular case
            //            percentageRange = "40 - 54";
            //            break;
            //        }


            //    case "f":
            //    case "F":
            //        {
            //            //logic for this particular case
            //            percentageRange = "0 - 39";
            //            break;
            //        }

            //    default:
            //        {

            //            //the implied test on this case is "None of the above"

            //            percentageRange = "invaild letter grade";
            //            break;
            //        }

            //}//eos

            //Console.WriteLine($"Your grade letter ({gradeLetter}) is {percentageRange}");

            //Console.ReadKey();

            switch (gradeLetter.ToUpper()) // temp conversion to uppercase
            {
                case "a":
                case "A":
                    {
                        //logic for this particular case
                        percentageRange = "85 - 100";
                        break;
                    }

                case "b":
                case "B":
                    {
                        //logic for this particular case
                        percentageRange = "70 - 84";
                        break;
                    }


                case "c":
                case "C":
                    {
                        //logic for this particular case
                        percentageRange = "55 - 69";
                        break;
                    }



                case "d":
                case "D":
                    {
                        //logic for this particular case
                        percentageRange = "40 - 54";
                        break;
                    }


                case "f":
                case "F":
                    {
                        //logic for this particular case
                        percentageRange = "0 - 39";
                        break;
                    }

                default:
                    {

                        //the implied test on this case is "None of the above"

                        percentageRange = "invaild letter grade";
                        break;
                    }

            }//eos

            Console.WriteLine($"Your grade letter ({gradeLetter}) is {percentageRange}");

            Console.ReadKey();


        }
    }
}
