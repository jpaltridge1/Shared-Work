using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * need using System.IO
             * need location a) absolute path b) special directory c) FileOpenDialog
             * 
             * StreamWriter to handle the outgoing data
             * 
             * 
             * by default files are replaced
             * you can add a parameter  to the streamwriter that indicates appending or not if the file does not exist it will be created
             * 
             * append: false overwrites the file
             * 
             */

            StreamWriter writer = new StreamWriter($"c:\\work\\outputfile.txt", append: false);
            writer.WriteLine("don welch, CPSC1012, 68");
            writer.Close();


        }
    }
}
