using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables1
{
    class Program
    {
        static void Main(string[] args)
        {
            //is a single line comment
            /* is a block 
             * line comment 
             * group 
             * finishing with */

            //C sharp is a "strongly typed"  language
            //     Character types: string("); Char(") Whole numerical tpes: interger and many others
            //     Floating numerical type: decimal(28 - 29), Double(15 - 16), Float logical type: Boolean
            // Declare Variables within Main
            //general grammer (syntax) for delcaring a variable is 
            //   Accesstype datatype variablename [= value];
            //special case: within a static class the accessstype is not required
            // start lower case camo , Important item start Capitals
            //by default numerical variables are set to 0

            decimal myWeight, myHeight;
            decimal BMI = 0.0m;
            
            //constant unchanging values are declared using the const syntax

            const decimal ImperialBMI = 703;

            // assign a value to a variable
            //this statement is reffeered to as an "assignment" Statement
            //date moves from right to left on an assignment statement
            // on the left side of the equal sign will be the receiving storage area
            // on the rioght side of the = sign will be the data you wish to store
            // numerical numbers need to match the variable type
            //intergers have no decimal places
            //dounbles are the default but may explicitly be type using a d
            //decimal require to be explicitly typed using a m
            // you cannot change the value of a const variable 

            myWeight = 110;
            myHeight = 1.75m;

            //math calulations follow the aceepted rules of arithmetic
            // -assignment
            // () execute within
            // * / %
            // + -

            BMI = myWeight / (myHeight * myHeight);
            Console.WriteLine("According to your metric Weight and Height your BMI is {0:0.0}", BMI);
            Console.WriteLine("According to your metric weight of {0:0.0} and Height of {0:0.0} your BMI is {0:0.0}", myWeight, myHeight, BMI);

            // imperial calulation
            myWeight = 242.5m;
            myHeight = 69.0m;
            BMI = (myWeight * ImperialBMI) / (myHeight * myHeight);

            Console.WriteLine ($"According to your Imperial weight of {myWeight:0.00} and Height of {myHeight:0.00} your BMI is {BMI:0.00}");


        }
    }
}
