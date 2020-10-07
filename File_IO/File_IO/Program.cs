using Microsoft.Win32;//required for the open file dialog
using System;
using System.Collections.Generic;
using System.IO;//required to do file I/O
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{


    
    class Program
    {
        // this is required for your code when using OpenFile Dialog

        [STAThread]

        static void Main(string[] args)
        {
            StreamReader reader = null;

            /*
             * 
             * thefile will always be in the same location
             * you can prompt for the file name
             * 
             * location
             * setup the path name
             * 
             * 
             * I will assume that the required file will always be found at the root of the course class repository
             * 
             * use methods  within the software to access the general special folders of your windows file system documents/download/desktop/pictures/music/ ect
             * 
             * this getfolderpath will return c:\\Users\xxxx\the special folder name
             * 
             * for the following  statement c:\\users\jpaltridge1\documents
             * 
             */



            //string FolderPath = @"c:\users\jpaltridge1\documents\github\2020-jan-coreportfolio-jpaltridge1\";


            //string specialpathname = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // you must add any addition path structure to get to the specific folder within the special folder
            //***********************************




            // string FolderPath = specialpathname + @"\github\2020-jan-coreportfolio-jpaltridge1\";


            string Full_Path_File_Name = "";


            //Console.Write("Enter the File Name (myfile.txt) : ");
            // String FileName = Console.ReadLine();

            //Full_Path_File_Name = FolderPath + FileName;




            /*
             *
             *setup for reading a file
             * a string variable is required to recieve the data from the file
             * the sting will be filled with one row from your file on each file read.
             * 
             * 
             * use a variable to count the rows in the file (this is optional)
             * 
             * 
             */

            /*add the .net Framework class that contains the code that will do the read of the file.
            // the require  IO class for the reading is StreamReader located in namespace System.IO
            //to attach the reader to the file, you will need to pass the full path file name (full qualified file name) as 
            // an argument to the class while it is being created
            // the reader is ofter refered to an instance of the class
            // the instance is physicaly created when the new command is used in conjunction with the class name.
            *
            *if your line that was read is null, you have reached the end of file (eof)
            *
            */

            /* is there a way to browse for a file?
             * 
             * yes you can call the OpenFileDialog
             * this is the dialog open you see on your system when you go browsing for a file within an application
             * 
             * 
             *  
             * 
             * 
             */

            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;


                                 
            string readValue = "";
            int counter = 0;


            //include what is refered to as "User Friendly error handling"
            // this is your try/catch/finally structure
            //the finally protion is only needed if you need to close a connection to a data scource

            try
            {    // in the try is the code ytou will attempt to execute if an error happens durning the exectution of the code
                 //


                reader = new StreamReader(Full_Path_File_Name);
                readValue = reader.ReadLine();

                while (readValue != null)
                {
                    counter++;
                    Console.WriteLine($" File line {counter} has a value of {readValue}\n");

                    readValue = reader.ReadLine();


                }
            }
            catch(Exception ex)
            {
                //.Message hold the error that occured durning the processing of the code in your try{....}
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {

                //this is used if you need to close a data source such as a data source such as a open file
                reader.Close(); 

            }


            Console.ReadKey();


            /*
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
                
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {

                
                reader.Close();
            }
            */
        }
    }
}
