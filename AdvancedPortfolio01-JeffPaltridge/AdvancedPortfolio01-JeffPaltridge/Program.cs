using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedPortfolio01_JeffPaltridge
{
    class Program
    {
        [STAThread]

        static void Main(string[] args)
        {   /*
               Purpose:   Play a game of hangman 		 

               Input: open file, read file into an array, pick a letter, play again prompt     		

               Process(es):  write/read, arrays, for loops ,while loops, methods, foreach, if/else, switch, random, methods, file IO, parse, tostring, tochararray, try/catch    	

               Output:  prompt for letter, reprompt if not valid or already selected, blank string for word, output of chars in word as they are guessed, win or loss with amount of failed guesses   	

               Author:           	Jeff Paltridge
               Last modified:    	2020.04.08

            */

            string randomWord = "";
            bool continueGame = true;  
            string[] wordArray = new string[10];
   
            while (continueGame == true)
            {
                int selectionChoice = Topic_Selector();
                int logicalsize = ReadandLoadArray(wordArray, 10, selectionChoice);
                string topicString = Topic_Selection_String(selectionChoice);
                Start_of_Game();
                randomWord = Random_Word_Picker(wordArray, logicalsize, topicString);
                Game_Main(randomWord);
                continueGame = Continue_Prompt();
            }

            Console.WriteLine("Good-Bye and thanks for playing my hangman game");
        }

        private static string Topic_Selection_String(int selectionChoice)// takes the topic selection intput number an creates and outputs a string for the name of the topic
        {
            string topicString = "";

            if (selectionChoice == 1)
            {
                topicString = "Alberta Cities";
            }

            else if (selectionChoice == 2)
            {
                topicString = "Car Makers";
            }

            else if (selectionChoice == 3)
            {
                topicString = "Hockey Teams";
            }

            return topicString;
        }

        public static int Topic_Selector()// asks user if they want to select a topic or have a randomly selected topic if the wanted selected send to  selection menu method  and waits for int return
            // or creates a random int to send back to selection choice
        {
            int selection = 0;
            string selectionInput = "";
            Random selectionRan = new Random();


            while (selection == 0)
            {
                Console.Write("Would you like to (S)elect a topic or have a (R)andom one choosen? : ");
                selectionInput = Console.ReadLine();

                switch(selectionInput.ToUpper())
                {
                    case "S":
                        {
                            selection = Selection_Menu();
                            break;
                        }

                    case "R":
                        {
                            selection = (selectionRan.Next(3) +1);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid selection please use either S or R .");
                            break;
                        }
                }
            }

            return selection;
        }

        private static int Selection_Menu()// asks for input and assigns int to send back to topic selector that then send back to selection choince int 
        {
            int userSelection = 0;
            string selectionInput = "";

            while (userSelection == 0)
            {
                Console.Write("Please select one: (A)lberta Cities ; (C)ar Makers ; (H)ockey Teams : ");
                selectionInput = Console.ReadLine();

                switch (selectionInput.ToUpper())
                {
                    case "A":
                        {
                            userSelection = 1;    
                            break;
                        }

                    case "C":
                        {
                            userSelection = 2;
                            break;
                        }

                    case "H":
                        {
                            userSelection = 3;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid selection please use either A , C or H .");
                            userSelection = 0;
                            break;
                        }
                }
            }
            return userSelection;
        }

        private static void Start_of_Game()//clears the screen and displays the name of the game title
        {
            Console.Clear();
            Console.WriteLine("|----------------------------------------|");
            Console.WriteLine("|          CPSC1012 Hangman Game         |");
            Console.WriteLine("|----------------------------------------|");
            Console.WriteLine();
        }

        private static void Game_Main(string randomWord)//core of the program input of randomword array.
        {
            int wrongGuessCounter = 0;
            int playerGuessCounter = 0;
            char playerGuess = ' ';
            string playerString = "";
            bool letterinWord = false;
            bool playerWin = false;
            bool playerLose = false;
            char[] wordArray = new char[randomWord.Length];
            char[] playerArray = new char[randomWord.Length];
            char[] playerGuessArray = new char[50];
  
            wordArray = Word_Array_Creator(randomWord);
            playerString = Hidden_String_Generator(randomWord);
            playerArray = Player_Array_Creator(playerString);
  
            while (playerWin == false && playerLose == false)
            {  
                playerGuess = Player_Guess_Input(playerString, playerGuessArray, playerGuessCounter, wordArray, randomWord);
                playerGuessCounter++;

                letterinWord = Check_For_Guess_In_Word(wordArray, playerGuess, playerArray);

                if (letterinWord == true)
                {
                    playerString = Display_String_Modifier(playerString, playerArray);
                    playerWin = Check_For_WIN(playerString, randomWord, wrongGuessCounter);
                }

                else
                {
                    Console.WriteLine($"{playerGuess} is not in the word.");
                    wrongGuessCounter++;
                    playerLose = Check_For_Loss(wrongGuessCounter, randomWord);
                }

            }
        }

        private static string Random_Word_Picker(string[] wordArray, int logicalsize, string topicString)//gets a random word from file sends in to game main method
        {
            string randomWord = "";
            int indexCount = 0;
            Random wordRandom = new Random();
            indexCount = wordRandom.Next(0, logicalsize);
            randomWord = wordArray[indexCount];
            Console.WriteLine($"I have picked a random word on {topicString}.");
            Console.WriteLine("Your task is to guess the correct word."); 
            return randomWord;
        }

        private static string Hidden_String_Generator(string randomWord) //takes the random word and makes a blanked out string and returns that string to game main method
        {
            string playerstring = "";
            for (int i =0; i < randomWord.Length; i++)
            {
                playerstring += "*";
            }
            return playerstring;
        }

        private static char Player_Guess_Input(string playerString, char[] playerGuessArray, int playerGuessCounter, char[] wordArray, string randomWord)// gets a letter from player
        {
            bool notPreviouslyGuessed = false;
            bool testForLetter;
            string playerGuessInput = "";
            bool validSelection = false;
            char playerGuess =' ';

            while (validSelection == false)
            {
                Console.Write($"(Guess) Enter a letter in the word: {playerString} : ");
                playerGuessInput = Console.ReadLine();
                try
                {
                    playerGuess = char.Parse(playerGuessInput);
                    testForLetter = Char.IsLetter(playerGuess);
 
                    if (testForLetter == true)
                    {
                        notPreviouslyGuessed = Player_Previous_Guess_Check(playerGuess, playerGuessArray, wordArray, randomWord);

                        if (notPreviouslyGuessed == true)
                        {
                            validSelection = true;
                        }

                        else
                        {
                            Console.WriteLine($"The letter {playerGuess} has already been choosen please try again!");
                            validSelection = false;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invaild selection please try again!.");
                        validSelection = false;
                    }
                }

                catch
                {
                    Console.WriteLine("Invaild selection please try again!.");
                    validSelection = false;
                }
            }
          
            playerGuessArray = Guess_Add_to_Array(playerGuessArray, playerGuess, playerGuessCounter);
            playerGuessCounter++;

            return playerGuess;
        }
      
        private static bool Player_Previous_Guess_Check(char playerGuess, char[] playerGuessArray, char[] wordArray, string randomWord)// checks the current guess verus other previous guesses
        {
            bool newGuessVerification = false;
            int checkCounter = 0;

            foreach (var letter in playerGuessArray)
            {
                if (letter == playerGuess)
                {
                    checkCounter++;
                }
            }

            if (checkCounter == 0)
            {
                newGuessVerification = true;
            }

            return newGuessVerification;
        }
        private static char[] Guess_Add_to_Array(char[] playerGuessArray, char playerGuess, int playerGuessCounter)// takes the recent valid guess as input and adds it to an array and outputs that array to player guess input
        {
            char[] tempGuessArray = new char[50];
            tempGuessArray = playerGuessArray;
            tempGuessArray[playerGuessCounter] = playerGuess;
            return tempGuessArray;
        }

        private static char[] Player_Array_Creator(string playerString)// takes the playerstring and creates an array that it returns back to game main method
        {
            char[] playerArray = new char[playerString.Length];
            playerArray = playerString.ToCharArray();
            return playerArray;
        }

        private static char[] Word_Array_Creator(string randomWord) // takes the randomword string and creates an array that is returned back to the game main method
        {
            char[] wordArray = new char[randomWord.Length];
            wordArray = randomWord.ToCharArray();
            return wordArray;
        }

        private static bool Check_For_Guess_In_Word(char[] WordArray, char playerGuess, char[] playerArray)// gets the player guess from the player guess input method and the word and player array checks if the letter is in the word and sends a bool back to player guess input method
        {
            bool letterinword = false;
            int index = 0;

            foreach(var letter in WordArray)
            {
                if (letter == playerGuess)
                {
                    playerArray[index] = playerGuess;
                    letterinword = true;
                }

                index++;
            }
             return letterinword;
        }

        private static string Display_String_Modifier(string playerString, char[] playerArray)// gets the playerArray and playerString from game main method creates a new string from the array and returns it to game main method
        {
            string playerstring = "" ;
            int index = 0;
            
            foreach(var item in playerArray)
            {
                playerstring += playerArray[index];
                index++;
            }
            return playerstring;
        }

        static int ReadandLoadArray(string[] wordArray, int physicalsize, int selectionChoice) // reads from local file and writes to an array sends back logical size of the new array
        {
            int logicalsize = 0;
            string RootPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GitHub\\2020-jan-coreportfolio-jpaltridge1\\AdvancedPortfolio01-JeffPaltridge\\Topics\\";
            string Full_Path_File_Name = "";
            string choice1 = "AlbertaCities.txt";
            string choice2 = "CarMakers.txt";
            string choice3 = "HockeyTeams.txt";
            string readValue = "";
            StreamReader reader = null;

          if(selectionChoice == 1)
            {
                Full_Path_File_Name = RootPath + choice1;
                Console.WriteLine(Full_Path_File_Name);
            }
          else if (selectionChoice == 2)
            {
                Full_Path_File_Name = RootPath + choice2;
            }

          else if (selectionChoice == 3)
            {
                Full_Path_File_Name = RootPath + choice3;
            }
            
            
            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readValue = reader.ReadLine();
                while (readValue != null && logicalsize < physicalsize)
                {
                    wordArray[logicalsize] = readValue;
                    logicalsize++;
                    readValue = reader.ReadLine();
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
            return logicalsize;
        }
        private static bool Check_For_WIN(string playerstring, string randomWord, int wrongGuessCounter) //compares the player revealed word to the random word to see to player won
        {
            bool playerWin = false;

            if (playerstring.ToUpper() == randomWord.ToUpper())
            {
                playerWin = true;
            }

            if (playerWin == true)
            {
                Console.WriteLine($"The word is {randomWord}. You missed {wrongGuessCounter} times. You WIN!");
            }
            return playerWin;
        }

        private static bool Check_For_Loss(int wrongGuessCounter, string randomWord)// gets the wrongguesscounter from the game main method checks to see if the guesses have been used and sends back a bool
        {
            bool playerlose = false;
            int maxGuess = 7;
           
            if (wrongGuessCounter == maxGuess)
            {
                playerlose = true;
            }

            if (playerlose == true)
            {
                Console.WriteLine($"The word is {randomWord}. You missed {wrongGuessCounter} times. You LOSE!");
            }
            return playerlose;
        }

        private static bool Continue_Prompt()// prompts user if they want to play again verifies valid selection and sends a bool back to the game main method
        {
            bool validEntry = false;
            bool userPrompt = true;
            string userInput = "";

            while (validEntry == false)
            {
                Console.Write("Do you want to guess another word? Enter Y or N : ");
                userInput = Console.ReadLine();

                switch (userInput.ToUpper())
                {
                    case "Y":
                        {
                            validEntry = true;
                            userPrompt = true;
                            break;
                        }

                    case "N":
                        {
                            validEntry = true;
                            userPrompt = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("You have entered an invalid selection! Please retry.");
                            validEntry = false;
                            break;
                        }
                }
            }
            return userPrompt;
        }
    }
}
