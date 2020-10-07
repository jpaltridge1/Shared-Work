using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] arr2d = new int[5, 3];

            for(int r = 0; r < 5; r++)
            {
                arr2d[r, 0] = 1;

            }

            for (int r = 0; r < 5; r++)
            {
                arr2d[r, 1] = r;

            }

            for(int r = 0; r<5; r++)
            {
                arr2d[r, 2] = arr2d[r, 0] + arr2d[r, 1];
                
            }


            for (int r= 0; r<5; r++)
            {
                for(int c =0; c<3; c++)
                {
                    Console.Write($"{arr2d[r, c],10} ");

                }

                Console.WriteLine("");


            }


        }







    }
}
