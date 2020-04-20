using AdvancedPortfolio03A;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedPortfolio03B
{
    class Program
    {
        [STAThread]

        static void Main(string[] args)
        {
            /* Purpose: Trivia Game (single list)
            *  
            *  Process: Methods, lists, objects, file io, switch, foreach loop, while loop
            *  
            *  Author:Jeff Paltridge
            *  
            *  Last Date modified: 2020/04/19
            * 
            */

            List<Trivia> triviaQuest = new List<Trivia>();
                        
            ReadandLoadList(triviaQuest);
            Play_Game(triviaQuest);
            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();

        }

        private static void Play_Game(List<Trivia> triviaQuest)
        /* Purpose: Main game play
         * Processes: if/else, foreach, read/write
         * Input: List triviaQuest of type Trivia
         * Output: Writeline, list values
        */

        {
            int correctAnswer = 0;
            int incorrectAnswer = 0;
            int totalQuestions = 0;
            int playerScore = 0;
            foreach (Trivia item in triviaQuest)
            {

                Console.WriteLine($"{item.Question}");
                string pAnswer = Player_Answer();
                bool answer = Check_Answer(item.Answer, pAnswer);
                if (answer == true)
                {
                    totalQuestions++;
                    correctAnswer++;
                    playerScore = playerScore+item.Score;
                    Console.WriteLine($"You are Correct! You have won {item.Score} points. Giving you a total of {playerScore}.");
                    Console.WriteLine();
                }
                else 
                {
                    totalQuestions++;
                    incorrectAnswer++;
                    Console.WriteLine($"Your answer was Incorrect! The correct answer was {item.Answer} . Your current score is {playerScore}.");
                    Console.WriteLine();
                }
            }

            Console.WriteLine($"You answered a total of {totalQuestions} and you got {correctAnswer} correct and {incorrectAnswer} wrong. Your total score is {playerScore}.");
            Console.WriteLine();
          
        }

        private static bool Check_Answer(string answer, string pAnswer)
        /* Purpose: Compares player answer to the answer from the file
         * Processes: if/else
         * Input: player answer and answer from list
         * Ouput: Sends a true/false bool to Play_Game method
        */
        {
            bool correctAnswer = false;
    
            if (answer.ToLower() == pAnswer)
            {
                correctAnswer = true;
            }
            
            return correctAnswer;
        }

        private static string Player_Answer()
        /* Purpose: gets the player's answer and converts it to lower case
         * Processes: write/read, uses ToLower method
         * Input: player answer via Console.ReadLine
         * Output: lowercase string sent back to Play_Game method
        */
        {
            string pAnswer = "";
            string pAnswerString = "";
          
            Console.Write("Enter your answer for the above question: ");
            pAnswerString = Console.ReadLine();
            pAnswer = pAnswerString.ToLower();
            
            return pAnswer;
        }

        static void ReadandLoadList(List<Trivia> triviaQuest)
        /* Purpose: to read info from csv file and create a list
         * Processes: File IO, foreach loop, switch, list, try/catch, while loop
         * Input: List triviaQuest of type Trivia, file from same directory as program
         * Output: Populated TriviaQuest list
         */
        {
            string Full_Path_File_Name = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GitHub\\2020-jan-coreportfolio-jpaltridge1\\AdvancedPortfolio03-JeffPaltridge\\trivia.txt";
            string readValue = "";
            StreamReader reader = null;
            Trivia readInFileInfo = null;
            int column = 0;

            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readValue = reader.ReadLine();
                while (readValue != null)
                {
                    column = 0;
                    readInFileInfo = new Trivia();
                    foreach (string item in readValue.Split(','))
                    {
                        switch (column)
                        {
                            case 0:
                                {
                                    readInFileInfo.Question = item;
                                    break;
                                }
                            case 1:
                                {
                                    readInFileInfo.Answer = item;
                                    break;
                                }

                            default:
                                {
                                    readInFileInfo.Score = int.Parse(item);
                                    break;
                                }
                        }
                        column++;
                    }
                    triviaQuest.Add(readInFileInfo);
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
        }
    }
}
