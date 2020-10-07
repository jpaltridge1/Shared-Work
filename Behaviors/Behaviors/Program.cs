using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaviors
{
    class Program
    {
        static void Main(string[] args)
        {

            Window[] myWindows = new Window [10];
            Window theInstance = null;

            try
            {
                theInstance = new Window();
                theInstance.Model = "2 pane gas filled";
                int logicalsize = 0;

                myWindows[logicalsize] = theInstance;
                logicalsize++;

                theInstance = new Window("single pane plexi-glass", 2.1, 1.0);
                myWindows[logicalsize] = theInstance;
                logicalsize++;

                theInstance = new Window();
                theInstance.Model = "2 pane tinted";
                theInstance.Height = 1.75;
                theInstance.Width = 3.2;
                myWindows[logicalsize] = theInstance;
                logicalsize++;

                for (int i = 0; i < logicalsize; i++)
                {

                    Console.WriteLine(myWindows[i].ToString());
                    Console.WriteLine("\n\n Behaviours\n");
                    Console.WriteLine($"Area: {myWindows[i].Perimeter()}");
                    Console.WriteLine($"Perimeter: {myWindows[i].Perimeter()}");
                    Console.WriteLine($"Estimate: {myWindows[i].Estimate(14.95,2)}\n\n");

                }

                // bad width
                theInstance = new Window();
                theInstance.Model = "2 pane tinted";
                theInstance.Height = 1.75;
                theInstance.Width = -3.2;
                myWindows[logicalsize] = theInstance;
                logicalsize++;
                Console.WriteLine(myWindows[logicalsize - 1].ToString());


            }

            catch(Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");

            }


        }
    }
}
