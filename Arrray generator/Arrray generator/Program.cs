using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrray_generator
{
    class Program
    {
        public static int[] lottoMaxSixNumbers = new int[6];
        public static Random rand1 = new Random();
        public static int[] workingArray = new int[6];

        static void Main(string[] args)
        {
            

            
            lottoMaxSixNumbers = Number_Generator();
            workingArray = Sort_Lotto_Numbers(lottoMaxSixNumbers);
            lottoMaxSixNumbers = workingArray;

            for (int count = 0; count < 6; count++)
            {
                Console.WriteLine($"Number {count} of 6: {lottoMaxSixNumbers[count]} ");

            }


        }


        static int[] Number_Generator()
        {

            int[] lottoMaxSixNumbers1 = new int[6];
            for (int i = 0; i < 6; i++)
            {
                lottoMaxSixNumbers1[i] = rand1.Next(1, 50);

                for (int counter = i - 1; counter >= 0; counter--)
                {
                    if (lottoMaxSixNumbers1[i] == lottoMaxSixNumbers1[counter])
                    {
                        lottoMaxSixNumbers1[i] = rand1.Next(1, 50);
                    }
                }

            }

            return lottoMaxSixNumbers1;
        }



        static int[] Sort_Lotto_Numbers(int[] lottoMaxSixNumbers)
        {
            int[] workingArray1 = new int[6];
            int index = 0;
            
            foreach (var item in lottoMaxSixNumbers)
            {

                workingArray1[index] = item;
                index++;
            }

            Array.Sort<int>(workingArray1, new Comparison<int>((x, y) => x.CompareTo(y)));

            return workingArray1;

        }

       


       
        
    }
}

