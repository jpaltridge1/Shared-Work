using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchIf_marinerStars
{
    class Program
    {
        static void Main(string[] args)
        {
            string levelInput;
            int starLevel;
            string msg = "";

            Console.Write("Please enter the star level of Customer: ");
            levelInput = Console.ReadLine();
            starLevel = int.Parse(levelInput);

            if (starLevel < 1)
            {
                msg = "Welcome to Holland America Cruise. You have yet to earn special benefits!";

            }

            else if (starLevel < 2)
            {
                msg = "You can receive and of the 1-Star benefits of the Mariner program";
            }

            else if (starLevel < 3)
            {
                msg = "You can receive and of the 2-Star benefits of the Mariner program";
            }

            else if (starLevel < 4)
            {
                msg = "You can receive and of the 3-Star benefits of the Mariner program";

            }

            else if (starLevel < 5)
            {

                msg = "You can receive and of the 4-Star benefits of the Mariner program";
            }

            else 
            {
                msg = "You can receive and of the 5-Star benefits of the Mariner program";
            }

            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
