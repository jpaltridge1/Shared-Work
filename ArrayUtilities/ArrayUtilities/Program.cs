using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUtilities
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            int[] driverArray = new int[25];
            int[] tempArray = new int[25];
            int logicalsize = ReadandLoadArray(driverArray, 25);


            LoadWorkingArray(driverArray, tempArray);
            SortAscending(tempArray, logicalsize);
            SortDecending(tempArray, logicalsize);
            FindElement(tempArray, logicalsize);

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


        static void LoadWorkingArray(int[] originalArray, int[] workingArray)
        {
            int index = 0;

            //foreach is a pretest while, it starts with the first item in your collection (array)
            //item is an instance of the collection (array element) the coding block {....} use the  "item" to use the current instance of the collection
            // the loop automatically moves to the next item in your collection, the loop auto stops after the last item in your collection
            //the loop processes the whole collection start to end


            foreach(var item in originalArray)
            {
                workingArray[index] = item;


            }




        }

        static void FindElement(int[] theArray, int logicalsize, int elementArg)
        {
            Console.WriteLine("\n\n Array: Find Element\n");
            DisplayArray(theArray, logicalsize);

            // .IndexOf(array, searchvalue) searches the entire array
            // . IndexOf (array, searchvalue, start index, number of elements


            int foundindex = Array.IndexOf(theArray, elementArg, 0, logicalsize);
            if (foundindex < 0)
            {
                //not found
                Console.WriteLine();

            }

            else
            {


            }
        }
        static void DisplayArray(int[] theArray, int logicalsize)
        {
            Console.WriteLine($"Current values in the array, size {logicalsize}");
            string msg = "";
            for (int i = 0; i < logicalsize; i++)
            {
                msg += theArray[i] + ", ";
            }

            msg = msg.Substring(0, msg.Length - 2);
            Console.WriteLine(msg);



        }
        
        static void SortAscending(int[] theArray, int logicalsize)
        {
            Console.WriteLine("\n\n Array: Sort Ascending\n");
            DisplayArray(theArray, logicalsize);
            Array.Sort(theArray, 0, logicalsize);
            DisplayArray(theArray, logicalsize);

        }

        static void SortDecending(int[] theArray, int logicalsize)
        {
            Console.WriteLine("\n\n Array: Sort Ascending\n");
            DisplayArray(theArray, logicalsize);


            //<datatype> identifies the datatype that is being used
            //new creates an instance of a class called comparison<T>()
            // to respresent any 2 items in your collection (your array) use a placeholder (x,y)
            //  => read as "do the following for x,y"
            // x.Compareto(y) : assending sort is x is less than y
            // y.Compareto(x) : descending sort is y is less than x

            Array.Sort<int>(theArray, new Comparison<int>((x, y) => x.CompareTo(y)));


        }
    }
}
