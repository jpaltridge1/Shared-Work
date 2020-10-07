using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexOF
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * find the location of a string within another string use the method .IndexOf()
             * 
             * 
             * 
             */


            /*
             * pseudo code (statements)
             * 
             * need an original string
             * declare any variables
             * do
             *      get string to look for (method GetString())
             *      find query string in original string
             *      test if found
             *          no: not found message
             *          yes: display index where found in original string
             * while not to stop
             * 
             * 
             *   string.IndexOf(querystring, start index position);
             *  [ ,length]
             *  
             *   if the query string is found in findinstring the result will be in an index of 0 or more
             *   if it is not found the result will be -1
             *   
             *  */


            string mystring = "CPSC1012 Fundemental Programing";
            int startpos = 0;
            string inputString = "";
            int indexat = 0;

            do
            {
                inputString = GetString();
                indexat = mystring.IndexOf(inputString, startpos, StringComparison.OrdinalIgnoreCase);
                if(!inputString.Equals("-1"))
                {
                    if(indexat <0)
                    {
                        Console.WriteLine($"{inputString} not found in {mystring}");
                    }

                    else
                    {
                        Console.WriteLine($"{inputString} found in {mystring} at {indexat}");
                        
                    }
                }

            } while (!inputString.Equals("-1"));

            startpos = 0;
            Console.ReadKey();


        }

        private static string GetString()
        {
            Console.Write("Enter query string: ");
            string input = Console.ReadLine();
            
            return input;

        }
    }
}
