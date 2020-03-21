using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePortfolio04_JeffPaltridge
{
    class Program
    {

       
        public static Random rnd = new Random();

        static void Main(string[] args)
        {

            /*
                Purpose:    		Unicorn  racing game 

                Input:      		track size, continue prompt, custom unicorn string , prompt for custom unicorn

                Process(es):    	switch, for loop, do loop , while loop, methods, if/esle , read/write, parse, random number generator

                Output:     		shows unicorns moving down the track, outputs who won or if it was a tie, give game statistics when you are finished playing, shows the die rolls, prompts for play again and 
                                    customizing unicorn.
            
                Author:           	Jeff Paltridge
                Last modified:    	2020.03.18
            */


            int playerDice = 0;
            int npcDice = 0;
            int diceRoll = 0;
            int trackTotal = 0;
            int playerPadNumber = 3;
            int npcPadNumber = 3;
            int trackPadNumber = 3;
            int playerWinsCounter = 0;
            int npcWinsCounter = 0;
            int tiesCounter = 0;
            string trackBlankPadString = "";
            string drawPlayerString = "";
            string drawNPCString = "*";
            bool exitGameBool = false;


            while (exitGameBool == false)
            {
                Console.WriteLine("Welcome to the Unicorn Racing Game!");
                Console.WriteLine();

                drawPlayerString = Unicorn_Creator();
                trackTotal = GetVailidPositiveInterger();

                do
                {
                    Console.Clear();
                    if (playerDice != 0 && npcDice != 0)
                    {
                        Console.WriteLine($"You moved {playerDice} positions.");
                        Console.WriteLine($"Computer moved {npcDice} positions.");
                        Console.WriteLine();
                        playerPadNumber += playerDice;
                        npcPadNumber += npcDice;
                    }
                   
                    DrawTrack(trackTotal, trackPadNumber, trackBlankPadString);
                    DrawCharacters(drawPlayerString, drawNPCString, playerPadNumber, npcPadNumber);
                    DrawTrack(trackTotal, trackPadNumber, trackBlankPadString);
                    Console.WriteLine();

                    if ((playerPadNumber - 3) >= trackTotal && (npcPadNumber -3) < trackTotal)
                    {
                        Console.Clear();
                        Console.WriteLine(" You are the Winner!");
                        Console.WriteLine();
                        playerWinsCounter += 1;
                    }

                    else if ((npcPadNumber - 3) >= trackTotal && (playerPadNumber - 3) < trackTotal)
                    {
                        Console.Clear();
                        Console.WriteLine("Computer Wins!");
                        Console.WriteLine();
                        npcWinsCounter += 1;
                    }

                    else if ((playerPadNumber-3) >= trackTotal && (npcPadNumber -3) >= trackTotal)
                    {
                        Console.Clear();
                        Console.WriteLine("The race was a Tie!");
                        Console.WriteLine();
                        tiesCounter += 1;
                    }

                    else
                    {
                        Console.WriteLine("Press Enter to Roll.");
                        Console.ReadKey();
                    }

                    diceRoll = GenerateRandomDieValue();
                    playerDice = diceRoll;


                    diceRoll = GenerateRandomDieValue();
                    npcDice = diceRoll;


                } while ((playerPadNumber -3) <= trackTotal && (npcPadNumber -3) <= trackTotal);



                exitGameBool = GetValidCharacter();
                playerDice = 0;
                npcDice = 0;
                diceRoll = 0;
                trackTotal = 0;
                playerPadNumber = 3;
                npcPadNumber = 3;

            }
            Console.Clear();
            Console.WriteLine($"You Won {playerWinsCounter} games.");
            Console.WriteLine($"You Lost {npcWinsCounter} games.");
            Console.WriteLine($"You Tied {tiesCounter} games.");
            Console.WriteLine();
            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();         
        }

        private static string Unicorn_Creator()
        {
            string customUnicorn = "";
            string creationChoice = "";
            bool validSelection = false;
            bool iconLengthValid = false;

            while (validSelection == false)
            {
                Console.Write("Would you like to create a custom 3 character Unicorn? (Y)es or (N)o : ");
                creationChoice = Console.ReadLine();
                Console.WriteLine();

                switch (creationChoice.ToUpper())
                {
                    case "Y":
                        {
                            while (iconLengthValid == false)
                            {
                                Console.WriteLine();
                                Console.Write("Please enter 3 chars for your custom Unicorn (last character can not be a space) (eg. ==> ): ");
                                creationChoice = Console.ReadLine();
                                
                                if (creationChoice.Length == 3 && !creationChoice.EndsWith(" "))
                                {
                                    Console.WriteLine();
                                    customUnicorn = creationChoice;
                                    iconLengthValid = true;
                                }

                                else
                                {
                                    Console.WriteLine("Invaild size for custom Unicorn or it ends with a space!");
                                    Console.WriteLine();
                                    iconLengthValid = false;
                                }

                            }

                            validSelection = true;
                            break;
                        }

                    case "N":
                        {
                            customUnicorn = "==>";
                            validSelection = true;
                                                        
                            break; 
                        }

                    default:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Error: Must enter 'Y' or 'N' !");
                            Console.WriteLine();
                            validSelection = false;

                            break;
                        }
                }
            }

            return customUnicorn;
        }

        private static int GetVailidPositiveInterger()
        {
            string trackLengthInput = "";
            int trackLength = 0;
            bool trackLengthExit = false;

            do
            {
                Console.Write("Enter the length of the track: ");
                trackLengthInput = Console.ReadLine();
                int.TryParse(trackLengthInput, out trackLength);

                if  (trackLength > 0 && trackLength < 300)
                {
                    trackLengthExit = true;
                }

                else
                {
                    Console.WriteLine("Error: must provide an integer > 0 and less than 300.");
                    trackLengthExit = false;
                }

            } while (trackLengthExit == false);

            return trackLength;
        }


        private static string DrawTrack(int trackTotal, int trackPadNumber, string trackBlankPadString )
        {
            string totalTrackString = "";
            string drawTrackString = "";
            
            for (int loopCounter = 0; loopCounter < trackTotal; loopCounter++)
            {
                totalTrackString += "=";
            }

            drawTrackString = totalTrackString;
            Console.WriteLine($"{trackBlankPadString.PadLeft(trackPadNumber)}{drawTrackString}");

            return totalTrackString;
        }


        private static void DrawCharacters(string drawPlayerString, string drawNPCString, int playerPadNumber, int npcPadNumber)
        {
            Console.WriteLine();
            Console.WriteLine($"{drawPlayerString.PadLeft(playerPadNumber)}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"{drawNPCString.PadLeft(npcPadNumber)}");
            Console.WriteLine();
            Console.WriteLine();

            return;
        }


        public static int GenerateRandomDieValue()
        {

            return rnd.Next(1, 7);
          
        }
        

        private static bool GetValidCharacter()
        {
            bool endGameBool = false;
            string playAgainInput = "";
            bool vaildSelection = false;

            while (vaildSelection == false)
            {

                Console.Write("Would you like to play again? (Y)es or (N)o : ");
                playAgainInput = Console.ReadLine();

                switch (playAgainInput.ToUpper())
                {
                    case "Y":
                        {

                            endGameBool = false;
                            vaildSelection = true;

                            break;
                        }

                    case "N":
                        {

                            endGameBool = true;
                            vaildSelection = true;

                            break;
                        }

                    default:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Error: Must enter 'Y' or 'N' !");
                            Console.WriteLine();
                            vaildSelection = false;

                            break;
                        }
                }
            }
            return endGameBool;
        }
        
    }
}
