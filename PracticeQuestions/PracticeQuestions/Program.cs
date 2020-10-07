using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1

            //string inputNumber, answer;
            //double number1;

            //Console.Write("Enter the Number: ");
            //inputNumber = Console.ReadLine();

            //number1 = double.Parse(inputNumber);

            //if (number1 > 0)
            //{
            //    answer = "p";
            //}
            //else if (number1 < 0)
            //{
            //    answer = "n";
            //}

            //else
            //{
            //    answer = "z";
            //}

            //switch (answer)
            //{
            //    case "p":
            //        {
            //            Console.WriteLine($"The Number {number1} is Positive!");
            //        }
            //        break;

            //    case "n":
            //        {
            //            Console.WriteLine($"The Number {number1} is Negative!");
            //        }
            //        break;

            //    case "z":
            //        {
            //            Console.WriteLine($"The Number {number1} is Zero!");
            //        }
            //        break;

            //}//eos

            //Console.ReadKey();

            ////End Question 1

            ////Question 2

            //string ageInput;
            //String ageAnswer = "default";
            //double age1;
            //const double child = 0.00;
            //const double student = 9.80;
            //const double adult = 11.35;
            //const double senior = 10.00;

            //Console.Write("Please Enter Customer Age: ");
            //ageInput = Console.ReadLine();
            //age1 = double.Parse(ageInput);

            //if (age1 >= 0 && age1 <= 6)
            //{
            //    ageAnswer = "c";
            //}

            //else if (age1 > 6 && age1 <= 17)
            //{
            //    ageAnswer = "s";
            //}

            //else if (age1 > 17 && age1 <= 54)
            //{
            //    ageAnswer = "a";
            //}

            //else if (age1 > 54)
            //{
            //    ageAnswer = "senior";
            //}

            //else
            //{
            //    Console.WriteLine("Invaild Age Entered!");
            //}

            //switch (ageAnswer)

            //{
            //    case "c":
            //        {
            //            Console.WriteLine($"The Admission Price will be ${child: 0.00}.");
            //        }
            //        break;

            //    case "s":
            //        {
            //            Console.WriteLine($"The Admission Price will be ${student: 0.00}.");
            //        }
            //        break;

            //    case "a":
            //        {
            //            Console.WriteLine($"The Admission Price will be ${adult: 0.00}.");
            //        }
            //        break;

            //    case "senior":
            //        {
            //            Console.WriteLine($"The Admission Price will be ${senior: 0.00}.");
            //        }
            //        break;
            //}//eos

            //Console.ReadKey();

            ////End Question 2

            ////Question 3

            //string studentName, markInput;
            //string grade = "Blank";
            //double mark;

            //Console.Write("Please Enter Student Name: ");
            //studentName = Console.ReadLine();

            //Console.Write($"Please Enter the Mark for {studentName}: ");
            //markInput = Console.ReadLine();
            //mark = double.Parse(markInput);

            //if (mark >= 90 && mark <= 100)
            //{
            //    grade = "A";
            //}

            //else if (mark >= 80 && mark <= 89)
            //{
            //    grade = "B";
            //}

            //else if (mark >= 70 && mark <= 79)
            //{
            //    grade = "C";
            //}

            //else if (mark >= 50 && mark <= 69)
            //{
            //    grade = "D";
            //}

            //else if (mark >= 0 && mark <= 49)
            //{
            //    grade = "F";
            //}

            //else
            //{
            //    grade = "Invaild";
            //}

            //switch (grade)
            //{
            //    case "A":
            //        {
            //            Console.WriteLine($"The student {studentName} has a grade of {grade}.");
            //        }
            //        break;

            //    case "B":
            //        {
            //            Console.WriteLine($"The student {studentName} has a grade of {grade}.");
            //        }
            //        break;

            //    case "C":
            //        {
            //            Console.WriteLine($"The student {studentName} has a grade of {grade}.");
            //        }
            //        break;

            //    case "D":
            //        {
            //            Console.WriteLine($"The student {studentName} has a grade of {grade}.");
            //        }
            //        break;

            //    case "F":
            //        {
            //            Console.WriteLine($"The student {studentName} has a grade of {grade}.");
            //        }
            //        break;

            //    case "Invaild":
            //        {
            //            Console.WriteLine("You have entered an Invaid Mark!");
            //        }
            //        break;
            //}//eos

            //Console.ReadKey();

            //// End of Question 3


            ////Question 4

            //string incomeInput, taxBracket;
            //double income, taxOwed;

            //const double BRACKET1 = 0.05;
            //const double BRACKET2 = 0.07;
            //const double BRACKET3 = 0.09;
            //const double LOW = 0;
            //const double FIFTY = 50000;
            //const double HUNDRED = 100000;
            //const double LOWFLAT = 0;
            //const double MEDFLAT = 2500;
            //const double UPPERFLAT = 6500;
            //taxOwed = 0.00;

            //Console.Write("Enter Income: ");
            //incomeInput = Console.ReadLine();
            //income = double.Parse(incomeInput);

            //if (income >= LOW && income <= FIFTY)
            //{
            //    taxBracket = "Low";
            //}

            //else if (income > FIFTY && income < HUNDRED)
            //{
            //    taxBracket = "Middle";
            //}

            //else if (income > HUNDRED)
            //{
            //    taxBracket = "Upper";
            //}

            //else
            //{
            //    taxBracket = "Invalid";
            //}

            //switch (taxBracket)
            //{
            //    case "Low":
            //        {
            //            taxOwed = income * BRACKET1;
            //        }
            //        break;

            //    case "Middle":
            //        {
            //            taxOwed = income * BRACKET2;
            //        }
            //        break;

            //    case "Upper":
            //        {
            //            taxOwed = income * BRACKET3 + ;
            //        }
            //        break;

            //}//eos

            //Console.WriteLine($"The tax owed on the amount of ${income:0.00} is {taxOwed:c}");

            //Console.ReadKey();

            //End Question 4

            /* You can use a # sign as a digit placeholder in your format
             * the # sign is used as a " if digit space need , use it"
             * {earnings:$#,##0.00}
             */
            //using column aligned output
            //the syntax for formatting {variable,columsize:formatstring}
            //variable is data to output
            //column size is the number of character spacing to be used for the column
            //positive columnsize is right aligned
            //negative columnsize is left aligned
            //formatstring is your string format

            double Earnings = 50000;
            double taxAmount;
            taxAmount = (Earnings * 0.07);

            Console.WriteLine("taxable income \t Calculation");

            Console.WriteLine("up to $50,000\t $0 + 5 % on amount of $0");
            Console.WriteLine("up to $100,000\t $2500 + 7 % Tax on amount over $50,000");
            Console.WriteLine("over $100,000\t $6500 + 9 % Tax on amount over $100,000");
            Console.WriteLine("{0,15} {1,13}", "Earnings:", "Taxes:");
            Console.WriteLine($"{Earnings,15:$#,###.00} {taxAmount,13:c}");
        }
    }
}
