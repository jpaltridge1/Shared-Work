using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1array
{
    class Program
    {
        static void Main(string[] args)

        {
            
            int[] driverArray = new int[25];
            int logicalsize = ReadandLoadArray(driverArray, 25);
            int sum = 0;
            
            for(int index = 0; index < logicalsize;index++)
            {
                sum += driverArray[index];
            }
            if (logicalsize >0)
            {
                Console.WriteLine($" the average of the {logicalsize} numbers is {(double)sum / (double)logicalsize}");
            }

            else
            {
                Console.WriteLine($"You have no numbers to calulate an anverage.");
            }

           


        }

        static int ReadandLoadArray(int[] myArray, int physicalsize)
        {

            


            StreamReader reader = null;

            string Full_Path_File_Name = "";

            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;

            string readValue = "";
            int counter = 0;

            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readValue = reader.ReadLine();

                while (readValue != null)
                {
                    counter++;
                    Console.WriteLine($" File line {counter} has a value of {readValue}\n");

                    readValue = reader.ReadLine();
                }

            }
            catch (Exception ex)
            {
                //.Message hold the error that occured durning the processing of the code in your try{....}
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {


                throw new NotImplementedException();
            }

        }



       
    }
}
