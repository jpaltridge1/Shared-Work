using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    class Program
    {
        //if delcared outside of the method add the keyword static in front of your declaration
        //if delcared outside of a method But within the class Then the variable is known to ALL Methods Without having to pass
        //the value as a parameter

            //static Random rnd = new Random();

        static void Main(string[] args)
        {
            /*
             * random is a datatype of class (object)
             * random is just the definition of the object (describes the object)
             * randon is NOT a pyshical instance of the object us the keyword new
             * new is used by any object to create an instance of that object
             * To identify the object instance datatype, add the class name after the keyword new
             * random is a datatype
             * rnd is the variable name of the object instance
             * new is the command keyword to create an object instance
             * Random() is the type of object instance new is to create
             * 
             * 
             * 
             */

            Random rnd = new Random();

            int[] myArray = new int[10];

            for(int i=0; i <10; i++)
            {
                myArray[i] = rnd.Next(1, 100);
                Console.WriteLine($"index {i} has a value of {myArray[i]}");
            }


            /*
             * what is the higest random number generated and what is the lowest random number generated
             */

            int highest = 0;
            int lowest = 100;

            int loopCounter = 0;

            while(loopCounter <10)
            {
                if (highest < myArray[loopCounter])
                {
                    highest = myArray[loopCounter];
                }

                if (lowest > myArray[loopCounter])
                {
                    lowest = myArray[loopCounter];
                }

                loopCounter++;
            }

            Console.WriteLine($"Highest Value is {highest} ");
            Console.WriteLine($"Lowest Value is {lowest} ");




        }
    }
}
