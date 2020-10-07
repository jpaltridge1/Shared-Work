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
            string[] nameArray = new string[25];
            int[] driverArray = new int[25];
            int logicalsize = ReadandLoadArray(driverArray, 25, nameArray);
            int sum = 0;
            


            for (int index = 0; index < logicalsize; index++)
            {
                sum += driverArray[index];
            }


            if (logicalsize > 0)
            {
                //string name = "bob";
                Console.WriteLine($"Quiz Total: {logicalsize}");
                Console.WriteLine();
                Console.WriteLine($"Student Name\t\t Mark");
                Console.WriteLine($"____________\t\t ____");
                Console.WriteLine();

                int index = 0;

                while (index < logicalsize)
                {
                    Console.Write($"{nameArray[index],-15}");
                    Console.WriteLine($"{driverArray[index]}".PadLeft(14));
                    index++;

                }

                Console.WriteLine();
                Find_High_And_Low(driverArray, logicalsize);


                Console.WriteLine();
                Console.WriteLine($"The average of the {logicalsize} numbers is {(double)sum / (double)logicalsize:0.0}%.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"You have no numbers to calculate an average.");
                Console.WriteLine();
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
            Console.WriteLine($"The higest mark is {highest} and the lowest mark is {lowest}.");

        }

        static int ReadandLoadArray(int[] myArray, int physicalsize, string[] nameArray)
        {

            int logicalsize = 0;

            string Full_Path_File_Name = "";
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;
            string readRecord = "";
            StreamReader reader = null;

            int recordDataColumn = 0; 
            // recordDataColumn will be a counter indicating which column on the currently read record we are dealing with
            // on the record which column of data will be separated by a comma (,)  candykane, 44 (for a 2 column ) or candy. kane, 44 (3 column)

            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readRecord = reader.ReadLine();

                while (readRecord != null && logicalsize < physicalsize)
                {
                    // the record is a string , the data on the string is separated by a comma
                    //you can use the string class method called  .Split(delimiter) 
                    // the delimiter is  the character used to separate the data values
                    // .Split(',') returns an array of strings
                    // new pre-test loop : foreach()
                    // syntax: foreach(datatype placeholdername in collection)   datatype can be a strongly delacared datatype (int,double, ect) or use declaration of var
                    //a var datatype is resolved at execution time  // place holder is your variable name  that you will use in your code to reference the current occurrance
                    //of the data you are processing //  "in" is a keyword  // the collection is your original data collection
                    // this method will a ) check if there is any need to process the loop b) automatically moves to the next occurance in the collection 
                    //c) automatically stops when it reaches the end of the collection d) this will process an unknown number of items (starts at the begining and goes to the end)

                    foreach (var item in readRecord.Split(','))
                    {

                        if (recordDataColumn == 0)
                        {
                            nameArray[logicalsize] = item;

                        }

                        else
                        {
                            myArray[logicalsize] = int.Parse(item);

                        }

                        recordDataColumn = 1;

                    }

                    logicalsize++;
                    recordDataColumn = 0;

                    readRecord = reader.ReadLine();

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
