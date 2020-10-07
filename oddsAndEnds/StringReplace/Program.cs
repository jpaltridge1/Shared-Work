using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
             *  .Replace() will replace any occurance of the old character with the replacement char
             *  .Replace() returns its wor as a string
             *  you need ti recieve the string on an assignment statement
             *  
             * 
             * 
             */

            string mystring = "CPSC1012 Fundemental Programing";
            
            string inputString = "";
            
            char newchar;
            char oldchar;

            do
            {
                inputString = GetString("Get Character you wish to replace");
               
                if (!inputString.Equals("-1"))
                {

                    Console.WriteLine($" Your old string is {mystring}");
                    oldchar = char.Parse(inputString);
                    inputString = GetString("get new character you wish to use in the replacement");
                    newchar = char.Parse(inputString);
                    mystring = mystring.Replace(oldchar, newchar);
                    Console.WriteLine($"You new string is {mystring}");

                }

            } while (!inputString.Equals("-1"));

           
            Console.ReadKey();


        }

        private static string GetString(string prompt)
        {
            Console.Write($"{prompt} : ");
            string input = Console.ReadLine();

            return input;

        }



    }
}

