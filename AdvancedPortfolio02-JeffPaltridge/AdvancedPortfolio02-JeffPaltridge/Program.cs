using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedPortfolio02_JeffPaltridge
{
    class Program
    {
        static void Main(string[] args)
        /*
         * Purpose: Play a game of tic tac toe
         * 
         * Input: pick a square by row and column , play again prompt 
         * 
         * Process(es):  console write/read, multi dimensional arrays, for loops , do loop; while loops, methods, foreach, if/else, switch
         * 
         * Output:  prompt for row and column , reprompt if not valid or already selected,  displays  if the game as won by X or O or f it was a tie, display game board with updated selection,  
         * 
         * Author:  Jeff Paltridge
         * 
         * Last modified:   2020.04.12
         * 
         */

        {
            char[,] playAreaArray = new char[3, 3];
            Game_Main(playAreaArray);

        }

        public static void Game_Main(char[,] playAreaArray)
        /* purpose : handles the bulk of the methods replay loop
         * input: bringsin the multidimensional array playAreaArray
         * output: one console writeline, method output is void 
         */              
        {
            bool playAgainBool = true;

            Load_Play_Array(playAreaArray);

            do
            {
                Start_Screen();
                Game_Play(playAreaArray);
                playAgainBool = Play_Again();
                playAreaArray = new char[3, 3];
                Load_Play_Array(playAreaArray);
            } while (playAgainBool == true);

            Console.WriteLine("Good-Bye and thanks for playing.");
        }

        private static void Load_Play_Array(char[,] playAreaArray)
        /* purpose: loads the array with blank characters
         * input : playAreaArray;
         * output : void
         */
        {
            for (int count = 0; count < 2; count++)
            {
                for (int count2 = 0; count2 < 2; count2++)
                {
                    playAreaArray[count, count2] = ' ';
                }
            }
        }
        private static void Start_Screen()
        /* purpose: creates the title screen
         * input: None
         * output: console.writelines to make title screen, method is void output
         */
        {
            Console.Clear();
            Console.WriteLine($"********************");
            Console.WriteLine($"* Tic-Tac-Toe Game *");
            Console.WriteLine($"********************");
            Console.WriteLine();
        }
        public static void Game_Play(char[,] playAreaArray)
        /* purpose: handles the method for the spot selection, game board generation method, checks the win conditions, and handles the while loop for getting selections
         * input: brings in the playAreaArray, also gets win condition info from Win_Check method, 
         * output: console.Writelines to tell won won or if game was a tie, method is void
         */

        {
            string winCheckBoolString = "";
            char playerChar = ' ';
            bool winCheckBool = false;
            Game_Board(playAreaArray);
            while (winCheckBool == false)
            { 
                Player_X_Choice(playAreaArray);
                Game_Board(playAreaArray);
                playerChar = 'X';
                winCheckBoolString = Win_Check(playAreaArray, playerChar);
                switch(winCheckBoolString.ToUpper())
                {
                    case "TRUE":
                        {
                            Console.WriteLine($"Player {playerChar} wins!");
                            winCheckBool = true;
                            break;
                        }

                    case "TIE":
                        {
                            Console.WriteLine("The game was a tie!");
                            winCheckBool = true;
                            break;
                        }

                    default:
                        {
                            winCheckBool = false;
                            break;
                        }
                }
                if (winCheckBool == false)
                {
                    Player_O_Choice(playAreaArray);
                    Game_Board(playAreaArray);
                    playerChar = 'O';
                    winCheckBoolString = Win_Check(playAreaArray, playerChar);
                    switch (winCheckBoolString.ToUpper())
                    {
                        case "TRUE":
                            {
                                Console.WriteLine($"Player {playerChar} wins!");
                                winCheckBool = true;
                                break;
                            }

                        case "TIE":
                            {
                                Console.WriteLine("The game was a tie!");
                                winCheckBool = true;
                                break;
                            }

                        default:
                            {
                                winCheckBool = false;
                                break;
                            }
                    }
                }
            }
            winCheckBool = false;
        }
        private static void Game_Board(char[,] playAreaArray)
        /* Purpose: Draws the game board using information in the multi-dimensional array
         * input: playAreaArray
         * output: consolewriteline to draw game board with players selections on it
         */

        {
            Console.WriteLine("-------------");
            Console.WriteLine($"| {playAreaArray[0, 0]} | {playAreaArray[0, 1]} | {playAreaArray[0, 2]} |");
            Console.WriteLine("-------------");
            Console.WriteLine($"| {playAreaArray[1, 0]} | {playAreaArray[1, 1]} | {playAreaArray[1, 2]} |");
            Console.WriteLine("-------------");
            Console.WriteLine($"| {playAreaArray[2, 0]} | {playAreaArray[2, 1]} | {playAreaArray[2, 2]} |");
            Console.WriteLine("-------------");
        }
        public static void Player_X_Choice(char[,] playAreaArray)
        /* purpose: Gets validated selection of space 
         * input: playAreaArray
         * output: method is void 
         */
        {
            string playerString = "Player X";
            bool validSelectionBool = false;

            while(validSelectionBool == false)
            {
                validSelectionBool = Get_Column_Row(playAreaArray, playerString);
            }
        }
        public static void Player_O_Choice(char[,] playAreaArray)
        /* purpose: Gets validated selection of space 
         * input: playAreaArray
         * output: method is void 
         */
        {
            string playerString = "Player O";
            bool validSelectionBool = false;

            while (validSelectionBool == false)
            {
                validSelectionBool = Get_Column_Row(playAreaArray, playerString);
            }
        }
        public static bool Get_Column_Row(char[,] playAreaArray, string playerString)
        /* purpose: to get player selection and validate the selections a vaild location and has not been used already
         * input: playAreaArray, playerString(for current player), reads in string for row and column
         * output: sends a bool back to player_X_Choice or player_O_Choice on if it was a valid selection, if selection is valid it writes playerChar to the multidimensional array at choosen location
         */
        {    
            string rowInput = "";
            string columnInput = "";
            int row = 0;
            int column = 0;
            bool validRowSelectionBool = false;
            bool validColumnSelectionBool = false;
            bool validSelectionBool = false;
            char playerChar = ' ';

            if (playerString == "Player X")
            {
                playerChar = 'X';
            }

            else
            {
                playerChar = 'O';
            }

            while(validSelectionBool == false)
            {

                while (validRowSelectionBool == false)
                {
                    Console.Write($"Enter cell row for {playerString} : (T)op, (M)iddle or (B)ottom: ");
                    rowInput = Console.ReadLine();

                    switch (rowInput.ToUpper())
                    {
                        case "T":
                            {
                                row = 0;
                                validRowSelectionBool = true;
                                break;
                            }

                        case "M":
                            {
                                row = 1;
                                validRowSelectionBool = true;
                                break;
                            }
                        case "B":
                            {
                                row = 2;
                                validRowSelectionBool = true;
                                break;
                            }

                        default:
                            {
                                Console.WriteLine($"{rowInput} is not a valid selection please try T, M or B");
                                validRowSelectionBool = false;
                                break;
                            }
                    }
                }

                while (validColumnSelectionBool == false)
                {
                    Console.Write($"Enter cell column for {playerString} : (L)eft, (C)enter or (R)ight: ");
                    columnInput = Console.ReadLine();

                    switch (columnInput.ToUpper())
                    {
                        case "L":
                            {
                                column = 0;
                                validColumnSelectionBool = true;
                                break;
                            }

                        case "C":
                            {
                                column = 1;
                                validColumnSelectionBool = true;
                                break;
                            }
                        case "R":
                            {
                                column = 2;
                                validColumnSelectionBool = true;
                                break;
                            }

                        default:
                            {
                                Console.WriteLine($"{rowInput} is not a valid selection please try L, C or R");
                                validColumnSelectionBool = false;
                                break;
                            }
                    }
                }

                if (playAreaArray[row, column] != 'X' && playAreaArray[row, column] != 'O')
                {
                    validSelectionBool = true;
                    playAreaArray[row, column] = playerChar;
                }

                else
                {
                    Console.WriteLine($"Row {rowInput.ToUpper()} and Column {columnInput.ToUpper()} is already taken please try again.");
                    validSelectionBool = false;
                    validRowSelectionBool = false;
                    validColumnSelectionBool = false;
                }
            } 
            return validSelectionBool;
        }    
        private static string Win_Check(char[,] playAreaArray, char playerChar)
        /* purpose: Checks to see if the game is won,  a tie or continues
         * input: playerChar (either X or O) , and playAreaArray
         * output: sends a string with true false or tie back to Game_Play method 
         */

        {
            string winCheckBoolString = "";
            int counter3 = 0;

            if (playAreaArray[0, 0] == playerChar && playAreaArray[0, 1] == playerChar && playAreaArray[0, 2] == playerChar)
            {
                winCheckBoolString = "true";
            }

            else if (playAreaArray[1,0] == playerChar&& playAreaArray[1, 1]== playerChar && playAreaArray[1, 2] == playerChar)
            {
                winCheckBoolString = "true";
            }
            else if (playAreaArray[2,0] == playerChar && playAreaArray[2, 1]== playerChar && playAreaArray[2, 2] == playerChar)
            {
                winCheckBoolString = "true";
            }

            else if (playAreaArray[0,0] == playerChar && playAreaArray[1,0]== playerChar && playAreaArray[2,0] == playerChar)
            {
                winCheckBoolString = "true";
            }
            else if (playAreaArray[0,1] == playerChar && playAreaArray[1,1] == playerChar && playAreaArray[2,1] == playerChar)
            {
                winCheckBoolString = "true";
            }

            else if (playAreaArray[0,2] == playerChar && playAreaArray[1,2] == playerChar && playAreaArray[2,2] == playerChar)
            {
                winCheckBoolString = "true";
            }
            else if (playAreaArray[0,0] == playerChar && playAreaArray[1,1] == playerChar && playAreaArray[2,2]== playerChar)
            {
                winCheckBoolString = "true";
            }

            else if (playAreaArray[2,0] == playerChar && playAreaArray[1,1] == playerChar && playAreaArray[0,2] == playerChar)
            {
                winCheckBoolString = "true";
            }
     
            else
            {
                winCheckBoolString = "false";
            }

            foreach (var item in playAreaArray)
            {
                if (item == 'X' || item == 'O')
                {
                    counter3++;
                }
            }
            if (counter3 == 9)
            {
                winCheckBoolString = "tie";
            }

            return winCheckBoolString;
        }
        private static bool Play_Again()
        /* Purpose: Checks to see if the players want to play again
         * input: Console.Readline to get players choice
         * output: console.Writeline to prompt for y or no ,after validating the input it sends a bool to Game_Main method that will either stop the loop or restart it. 
         */

        {
            bool playAgain = false;
            bool validSelection = false;
            string playAgainInput = "";
            do
            {
                Console.Write("Would you like to play again? (Y or N): ");
                playAgainInput = Console.ReadLine();

                switch (playAgainInput.ToUpper())
                {
                    case "Y":
                        {
                            validSelection = true;
                            playAgain = true;
                            break;
                        }

                    case "N":
                        {
                            validSelection = true;
                            playAgain = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine($"{playAgainInput} is an invalid selection please try either Y or N .");
                            validSelection = false;
                            break;
                        }
                }
            } while (validSelection == false);

            return playAgain;
        } 
    }
}
