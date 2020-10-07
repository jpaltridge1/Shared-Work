using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialSearchFind
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            

            string Full_Path_File_Name = "";
            string readValue = "";
            int logicalsize = 0;
            int physicalsize = 25;
            int[] myArray = new int[25];

            StreamReader reader = null;

            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;
            

            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readValue = reader.ReadLine();

                while (readValue != null && logicalsize < physicalsize)
                {

                    
                    readValue = reader.ReadLine();
                   
                    logicalsize++;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                reader.Close();
            }

            Console.WriteLine($"The number of elements in the array is {logicalsize}");
            for(int loopcounter = 0; loopcounter < myArray.Length; loopcounter++)
            {

                Console.WriteLine($"At array index {loopcounter} there is a value of {myArray[loopcounter]}");

            }



            Console.Write($"Enter a number:\t");
            int searcharg = int.Parse(Console.ReadLine());

            bool found = false;
            int searchindex = 0;

            while(searchindex < myArray.Length && !found)
            {
                if (myArray[searchindex] == searcharg)
                {
                    found = true;
                }

                else
                {
                    searchindex++;
                }
            }

            if(found)
            {
                Console.WriteLine($"{searcharg} was Found! at index {searchindex}");

            }

            else
            {
                Console.WriteLine($"{searcharg} was NOT found! in the {logicalsize} array elements.");
            }

            searchindex = 0;
            int foundcount = 0;
            found = false;

            while (searchindex < myArray.Length )
            {
                if (myArray[searchindex] == searcharg)
                {
                    found = true;
                    foundcount++;
                    searchindex++;
                }

            }

            if (found)
            {
                Console.WriteLine($"{foundcount} items of {searcharg} were located in the array");

            }

            else
            {
                Console.WriteLine($"{searcharg} was NOT found! in the {logicalsize} array elements.");
            }


        }

        


    }
}
