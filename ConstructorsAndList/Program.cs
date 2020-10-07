using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassAndObjects;
using Microsoft.Win32;

namespace ConstructorsAndList
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {




            

            /*
             * List<T> is a instance class
             * the class will hold different data from a second List<T>
             * 
             */

            List<Assessment> StudentList = new List<Assessment>();


            // default assessment constructor

            Assessment defaultItem = new Assessment();

            defaultItem.FirstName = "Don";
            defaultItem.LastName = "Welch";
            defaultItem.AssessmentName = "default";
            defaultItem.Mark = 100.0;

            StudentList.Add(defaultItem);

            //greedie constructor

            Assessment greedieItem = new Assessment("bob", "Harry", "greedie", 35.6, "greed never pays");

            StudentList.Add(greedieItem);

            foreach(Assessment item in StudentList)
            {


            }

        }

        static void ReadandLoadList(List<Assessment> StudentList)
        {
            StreamReader reader = null;

            string Full_Path_File_Name = "";

            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;

            string readValue = "";
            int column = 0;

            Assessment theInstance = null;


            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readValue = reader.ReadLine();

                while (readValue != null)
                {
                    column = 0;

                    theInstance = new Assessment();

                    foreach (string item in readValue.Split(','))
                    {

                        switch (column)
                        {
                            case 0:
                                {
                                    int firstlastspace = item.IndexOf(' ');
                                    theInstance.FirstName = item.Substring(0, firstlastspace)
                                        theInstance.LastName = item.Substring(firstlastspace + 1);


                                    break;
                                }

                            case 1:
                                {
                                    theInstance.AssessmentName = item;
                                    break;
                                }
                            case 2:
                                {
                                    theInstance.Mark = double.Parse(item);
                                    break;
                                }
                            default:
                                {
                                    theInstance.Comment = item;
                                    break;
                                }




                        }

                    }

                    Console.WriteLine($" File line {column} has a value of {readValue}\n");

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

        }

    }
}
