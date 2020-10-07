using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayquestion4
{
    class Program
    {

        [STAThread]

        static void Main(string[] args)
        {

            int[] driverArray = new int[25];
            int logicalsize = ReadandLoadArray(driverArray, 25);
            int sum = 0;
            

            for (int index = 0; index < logicalsize; index++)
            {
                sum += driverArray[index];
            }
            if (logicalsize > 0)
            {
                string name = "bob";
                Console.WriteLine($"Quiz Total: {logicalsize}");
                Console.WriteLine($"Student     Mark");
                Console.WriteLine($"_______     ____");

                int index = 0;

                while (index < logicalsize)
                {
                    Console.Write($"{name,-7}");
                    Console.WriteLine($"{driverArray[index]}".PadLeft(8));
                    index++;
                    
                }

                Find_High_And_Low(driverArray, logicalsize);



               Console.WriteLine($"The average of the {logicalsize} numbers is {(double)sum / (double)logicalsize:0.0}%.");
            }
            else
            {
                Console.WriteLine($"You have no numbers to calculate an average.");
            }
        }

        private static void Find_High_And_Low(int[] myArray, int logicalsize)
        {

            int highest = 0;
            int lowest = 100;

            int index = 0;

            while (index < logicalsize)
            {
                if (highest < myArray[index])
                {
                    highest = myArray[index];
                }

                if (lowest > myArray[index])
                {
                    lowest = myArray[index];
                }

                index++;
            }
            
        }

        static int ReadandLoadArray(int[] myArray, int physicalsize)
        {
            
            int logicalsize = 0;

            string Full_Path_File_Name = "";
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;
            string readValue = "";
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readValue = reader.ReadLine();
                while (readValue != null && logicalsize < physicalsize)
                {
                    myArray[logicalsize] = int.Parse(readValue);
                    logicalsize++;
                    
                    readValue = reader.ReadLine();
                }
            } //eof try
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return logicalsize;



        }
    }
}
