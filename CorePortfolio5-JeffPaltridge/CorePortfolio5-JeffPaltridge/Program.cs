using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePortfolio5_JeffPaltridge
{
    class Program
    {

       
        static bool exitLoopBool = false;
        static string menuChoiceInput = "";
        static bool validMenuSelectionBool = true;
        public static int extraNumber = 0;
        public static int bonusNumber = 0;
        public static int winningCount = 0;
        public static int extraWinningCount = 0;
        public static int[] SevenNum = new int[7];
        public static Random rnd = new Random();
        public static int[] workingArray = new int[7];
        public static int bonusCount = 0;
        public static int playerExtraNumber = 0;

        static void Main(string[] args)
        {
            /*
               Purpose:   Play lotto max game 		 

               Input:    menu choice, pick numbers,  		

               Process(es):    	

               Output:     		

               Author:           	Jeff Paltridge
               Last modified:    	2020.03.31

            */




            New_Random_Numbers();
           playerExtraNumber = New_Extra_Number();
            Main_Menu();

            Console.WriteLine("Thanks for playing!");

        }//eom

       

        static void Main_Menu()// used to call the menu display and menu selection receives validation of exit command from menu selection method
        {

            Menu_Display();

            while (exitLoopBool == false)
            {

                if (validMenuSelectionBool == false)
                {
                    Console.Clear();
                    Console.WriteLine($"You have entered an INVALID selection of {menuChoiceInput} . Please enter one of the following menu options! ");
                    Console.WriteLine();
                    Menu_Display();
                }

                validMenuSelectionBool = Menu_Selection();

            }//eow main menu
        }//end of method  Main_Menu



        static void Menu_Display() //prints the menu screen
        {
            Console.WriteLine("|------------------------------------------------|");
            Console.WriteLine("|              CPSC1012 Lotto Centre             |");
            Console.WriteLine("|------------------------------------------------|");
            Console.WriteLine("| 1. Change Player's Lotto MAX Numbers           |");
            Console.WriteLine("| 2. Change Player's Lotto Extra Numbers         |");
            Console.WriteLine("| 3. Play Lotto MAX                              |");
            Console.WriteLine("| 0. Exit Program                                |");
            Console.WriteLine("|------------------------------------------------|");
            Console.WriteLine();

        }// End of method Menu_Display


        static void Change_Players_MAX_Numbers()// allows player to manually enter numbers (with verification), or select a verified random set
        {
            string selectionString = "";
            bool changeNumberSelectionExitBool = false;

            Console.WriteLine($"Your current Lotto Max numbers are: {SevenNum[0]}, {SevenNum[1]}, {SevenNum[2]}, {SevenNum[3]}, {SevenNum[4]}, {SevenNum[5]}");
            while (changeNumberSelectionExitBool == false)
            {
                Console.Write("would you like to (G)enerate or (E)nter your numbers? (G/E): ");
                selectionString = Console.ReadLine();

                switch(selectionString.ToUpper())
                {

                    case "G":
                        {

                            New_Random_Numbers();
                            Console.WriteLine($"Your New Lotto Max numbers are: {SevenNum[0]}, {SevenNum[1]}, {SevenNum[2]}, {SevenNum[3]}, {SevenNum[4]}, {SevenNum[5]}, {SevenNum[6]} ");
                            changeNumberSelectionExitBool = true;
                            break;
                        }

                    case "E":
                        {
                            Player_Selected_LottoMax();
                            

                            Console.WriteLine($"Your New Lotto Max numbers are: {SevenNum[0]}, {SevenNum[1]}, {SevenNum[2]}, {SevenNum[3]}, {SevenNum[4]}, {SevenNum[5]}, {SevenNum[6]} ");
                            changeNumberSelectionExitBool = true;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine(" Invaild selection please try G or E .");
                            break;
                        }
                }
  
            }            

        }//end of method Change_Players_MAX_Numbers

        static void Player_Selected_LottoMax()// takes user input and creates an array that is tested to make sure all numbers are unique before passing them out
        {

            bool playerSelectionExitBool = false;
            string num1, num2, num3, num4, num5, num6, num7;
            int number1 = 0, number2 = 0, number3 = 0, number4 = 0, number5 = 0, number6 = 0, number7 = 0;

            int[] PlayerSelectedNumbers = new int[7];
            
            while (playerSelectionExitBool == false)
            {
                
                Console.Write("Enter number #1: ");
                num1 = Console.ReadLine();
                int.TryParse(num1, out number1);
                PlayerSelectedNumbers[0] = number1;
                Console.Write("Enter number #2: ");
                num2 = Console.ReadLine();
                int.TryParse(num2, out number2);
                PlayerSelectedNumbers[1] = number2;
                Console.Write("Enter number #3: ");
                num3 = Console.ReadLine();
                int.TryParse(num3, out number3);
                PlayerSelectedNumbers[2] = number3;
                Console.Write("Enter number #4: ");
                num4 = Console.ReadLine();
                int.TryParse(num4, out number4);
                PlayerSelectedNumbers[3] = number4;
                Console.Write("Enter number #5: ");
                num5 = Console.ReadLine();
                int.TryParse(num5, out number5);
                PlayerSelectedNumbers[4] = number5;
                Console.Write("Enter number #6: ");
                num6 = Console.ReadLine();
                int.TryParse(num6, out number6);
                PlayerSelectedNumbers[5] = number6;
                Console.Write("Enter number #7: ");
                num7 = Console.ReadLine();
                int.TryParse(num7, out number7);
                PlayerSelectedNumbers[6] = number7;

                if (number1 == number2 && number1 <= 50 || number1 == number3 && number1 <= 50 || number1 ==number4 && number1 <= 50 || number1 == number5 && number1 <= 50 || number1 == number6 && number1 <= 50 || number1 ==number7 && number1 <= 50)
                {
                    Console.WriteLine("Your have enter a duplicate number please retry!");
                    playerSelectionExitBool = false;
                }

                else if (number2 == number3 && number1 <= 50 || number2 == number4 && number1 <= 50 || number2 == number5 && number1 <= 50 || number2 == number6 && number1 <= 50 || number2 == number7 && number1 <= 50)
                {
                    Console.WriteLine("Your have enter a duplicate number please retry!");
                    playerSelectionExitBool = false;

                }


                else if (number3 == number4 && number1 <= 50 || number3 == number5 && number1 <= 50 || number3 == number6 && number1 <= 50 || number3 == number7 && number1 <= 50)
                {
                    Console.WriteLine("Your have enter a duplicate number please retry!");
                    playerSelectionExitBool = false;

                }


                else if (number4 == number5 && number1 <= 50 || number4 == number6 && number1 <= 50 || number4 == number7 && number1 <= 50)
                {
                    Console.WriteLine("Your have enter a duplicate number please retry!");
                    playerSelectionExitBool = false;

                }

                else if (number5 == number6 && number1 <= 50 || number5 == number7 && number1 <= 50)
                {
                    Console.WriteLine("Your have enter a duplicate number please retry!");
                    playerSelectionExitBool = false;

                }

                else if (number6 == number7 && number1 < 50)
                {
                    Console.WriteLine("Your have enter a duplicate number please retry!");
                    playerSelectionExitBool = false;

                }

                else
                {
                    SevenNum = PlayerSelectedNumbers;
                    playerSelectionExitBool = true;
                }

                workingArray = Sort_Lotto_Numbers(SevenNum);
                SevenNum = workingArray;

            }
        }


        static void Change_Players_EXTRA_Numbers()// allows player to create a valid random number for the extra 
        {
            

            Console.WriteLine($"Your current Extra number was: {playerExtraNumber} ");
            playerExtraNumber = New_Extra_Number();
            Console.WriteLine($"Your new extra number is: {playerExtraNumber} ");

        }// end of method Change_Players_Extra_Numbers


        static void Play_Lotto_MAX() // checks to see if numbers are choosen for lotto max and extra if not calls other methods to generate, generates "drawn" verified random numbers
        {
            int[] DrawNumbers = new int[7];
            String lottoMaxPrizePayout;
            string lottoExtraPrizePayout;
            int extraDrawNumbers = 0;

            DrawNumbers = Number_Generator();
            bonusNumber = Bonus_Number_Random(DrawNumbers);
            extraDrawNumbers = New_Extra_Number();
            workingArray = Sort_Lotto_Numbers(DrawNumbers);
            DrawNumbers = workingArray;

            Console.WriteLine("The draw has Started!");
            Console.WriteLine($"Your Lotto Max numbers are: {SevenNum[0]}, {SevenNum[1]}, {SevenNum[2]}, {SevenNum[3]}, {SevenNum[4]}, {SevenNum[5]}, {SevenNum[6]} ");
            Console.WriteLine($"Your Lotto EXTRA number is: {playerExtraNumber}");
            Console.WriteLine();
            Console.WriteLine($"The Lotto Max winning numbers are: {DrawNumbers[0]}, {DrawNumbers[1]}, {DrawNumbers[2]}, {DrawNumbers[3]}, {DrawNumbers[4]}, {DrawNumbers[5]}, {DrawNumbers[6]}   (Bonus: {bonusNumber})");
            Console.WriteLine($"The Winning Lotto EXTRA number is: {extraDrawNumbers}");
            
            winningCount = Check_LottoMax(SevenNum, DrawNumbers, bonusNumber);
            lottoMaxPrizePayout = LottoMax_Prize_Payout(winningCount);
            Console.WriteLine($"Your Lotto Max Prize: {lottoMaxPrizePayout}");
            extraWinningCount = Extra_Winning_Total(extraDrawNumbers, playerExtraNumber);
            lottoExtraPrizePayout = Extra_Prize_Payout(extraWinningCount);
            Console.WriteLine($"Your Lotto EXTRA Prize: {lottoExtraPrizePayout}");


        }//end of Method Play_Lotto_MAX

        

        private static int Bonus_Number_Random(int[] drawNumbers)// creates a bonus number and check to make sure that number has not been drawn
        {
            int bonusNum = 0;

            bonusNum = rnd.Next(1, 50);

            for (int counter = 0; counter < 7; counter++)
            {
                if (bonusNum == drawNumbers[counter])
                {
                    bonusNum = rnd.Next(1, 50);
                    counter = 0;
                }
            }
 
            return bonusNum;
        }

        private static int Check_LottoMax(int[] sevenNum, int[] drawNumbers, int bonusNumber)//checks the players numbers and bonus against the drawn numbers and counts matches sending count outto play lotto max method
        {
            int winningNumberCounter = 0;
            bonusCount = 0;

            foreach (var draw in drawNumbers)
            {

                foreach (var pick in sevenNum)
                {
                    if (pick == draw)
                    {
                        winningNumberCounter++;
                    }
                }
            }

            for (int i = 0; i <7; i++)
            {
                if (sevenNum[i] == bonusNumber)
                {
                    bonusCount++;
                }
            }

            if (bonusCount == 1)
            {
                Console.WriteLine($"Your Lotto Max Match: {winningNumberCounter} / 7 + Bonus");
            }

            else
            {
                Console.WriteLine($"Your Lotto Max Match: {winningNumberCounter} / 7 ");
            }    
                
                
                return winningNumberCounter;
        }

        static string LottoMax_Prize_Payout(int winningCount)// takes the bonus number count and winnging counts and works through prise structure outputing prize string
        {
            string prize = "";
            if (winningCount == 7)
            {
                prize = "Win or share Jackpot of at least $10 Million or 87.25% of Pools Fund!";
            }
            else if (winningCount == 6 && bonusCount == 1)
            {
                prize = "Share 2.5% of Pools Fund";
            }

            else if (winningCount == 6)
            {
                prize = "Share 2.5% of Pools Fund";
            }
            else if (winningCount == 5 && bonusCount == 1)
            {
                prize = "Share 1.5% of Pools Fund";
            }

            else if (winningCount == 5)
            {
                prize = "Share 3.5% of Pools Fund";
            }
            else if (winningCount == 4 && bonusCount == 1)
            {
                prize = "Share 2.75% of Pools Fund";
            }
            else if (winningCount == 4)
            {
                prize = "$20";
            }
            else if (winningCount == 3 && bonusCount == 1)
            {
                prize = "$20";
            }

            else if (winningCount == 3)
            {
                prize = "Free Play";
            }
            else
            {
                prize = "$0";
            }


            return prize;
        }

        private static int Extra_Winning_Total(int extraDrawNumbers , int playerExtraNumber)
        {
            int extraMatches = 0;
            string playerNumString;
            string drawNumString;
            char[] playerArray = new char[7];
            char[] drawArray= new char[7];

            playerNumString = playerExtraNumber.ToString();
            drawNumString = extraDrawNumbers.ToString();
            playerArray = playerNumString.ToCharArray();
            drawArray = drawNumString.ToCharArray();



            if (playerArray[6] == drawArray[6])
            {
                extraMatches++;

                if (playerArray[5] == drawArray[5])
                {
                    extraMatches++;

                    if (playerArray[4] == drawArray[4])
                    {
                        extraMatches++;

                        if (playerArray[3] == drawArray[3])
                        {
                            extraMatches++;

                            if (playerArray[2] == drawArray[2])
                            {
                                extraMatches++;

                                if (playerArray[1] == drawArray[1])
                                {
                                    extraMatches++;

                                    if (playerArray[0] == drawArray[0])
                                    {
                                        extraMatches++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            
            return extraMatches;
        }

        static string Extra_Prize_Payout(int extraWinningCount)
        {
            String extraPrize = "";
            
            if(extraWinningCount == 1)
            {
                extraPrize = "$2";
            }
            else if (extraWinningCount == 2)
            {
                extraPrize = "$10";
            }

            else if (extraWinningCount == 3)
            {
                extraPrize = "$50";
            }

            else if (extraWinningCount == 4)
            {
                extraPrize = "$100";
            }

            else if (extraWinningCount == 5)
            {
                extraPrize = "$1,000";
            }
            else if (extraWinningCount == 6)
            {
                extraPrize = "$100,000";
            }

            else if (extraWinningCount == 7)
            {
                extraPrize = "$250,000";
            }

            else
            {
                extraPrize = "$0";
            }

            return extraPrize;
        }


        static void New_Random_Numbers()// generates and sorts an array of 7 random numbers
        {
            SevenNum = Number_Generator();
            workingArray = Sort_Lotto_Numbers(SevenNum);
            SevenNum = workingArray;
        }


        static int[] Number_Generator()// creates the array of 7 unique numbers
        {

            int[] lottoMaxSevenNum1 = new int[7];
            for (int i = 0; i < 7; i++)
            {
                lottoMaxSevenNum1[i] = rnd.Next(1, 50);

                for (int counter = i - 1; counter >= 0; counter--)
                {
                    if (lottoMaxSevenNum1[i] == lottoMaxSevenNum1[counter])
                    {
                        lottoMaxSevenNum1[i] = rnd.Next(1, 50);
                    }
                }
            }

            return lottoMaxSevenNum1;
        }

        static int[] Sort_Lotto_Numbers(int[] SevenNum)// sorts the array in acending order
        {
            int[] workingArray1 = new int[7];
            int index = 0;

            foreach (var item in SevenNum)
            {

                workingArray1[index] = item;
                index++;
            }

            Array.Sort<int>(workingArray1, new Comparison<int>((x, y) => x.CompareTo(y)));

            return workingArray1;

        }
        public static int New_Extra_Number()
        {
            return extraNumber = rnd.Next(1000000, 10000000);
        }
        

        static bool Menu_Selection() //validates the menu selection and returns a value to exit loop
        {
            Console.Write("Enter your menu number choice : ");
            menuChoiceInput = Console.ReadLine();

            switch (menuChoiceInput)
            {
                case "1":
                    {
                        Change_Players_MAX_Numbers();
                        validMenuSelectionBool = true;

                        break;
                    }

                case "2":
                    {
                        Change_Players_EXTRA_Numbers();
                        validMenuSelectionBool = true;

                        break;
                    }
                case "3":
                    {
                        Play_Lotto_MAX();
                        validMenuSelectionBool = true;

                        break;
                    }

                case "0":
                    {
                        validMenuSelectionBool = true;
                        exitLoopBool = true;

                        break;
                    }

                default:
                    {
                        validMenuSelectionBool = false;
                        exitLoopBool = false;

                        break;
                    }

            }//eos

            return validMenuSelectionBool;

        }// end of method Menu_Selection


    }//eoc

}

