using System;
using System.Collections.Generic;
using System.IO;

namespace AdvancedPortfolio03A
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            /* Trivia Game Method A
             * Purpose: Play a trivia game from a three value CSV list
             *
             * Process(es): Read in CSV values from File IO, populate list,
             * display question prompts one at a time, validate player answer, compare player
             * answer to correct answer, award point value for correctly answered question,
             * show correct answer if incorrect answer given, give total score when game over
             * 
             * Input(s): Questions list, Player answer 
             *
             * Output(s): Question from list, validation, points for question, correct answer
             *
             * Author: Celia Nicholls
             * Last date modified: 20.04.20
             */

            List<Trivia> filmTrivia = new List<Trivia>();
            List<string> Questions = new List<string>();
            List<string> Answers = new List<string>();
            List<int> Points = new List<int>();

            ReadandLoadTrivia(filmTrivia);
            SplitColumnsToLists(filmTrivia, Questions, Answers, Points);

            int questionTotal = 0;
            int questionsWon = 0;
            int questionsLost = 0;
            int pointsTotal = 0;

            for (int tally = 0; tally < Questions.Count; tally++)
            {
                Console.WriteLine($"{Questions[tally]}");
                string playerEntry = GetValidAnswer();
                bool answer = AnswerVerification(Answers[tally], playerEntry);

                if (answer == true)
                {
                    questionsWon++;
                    questionTotal++;
                    pointsTotal+= Points[tally];
                    Console.WriteLine($"Correct! {Points[tally]} points awarded, for a total of {pointsTotal} points.\n");
                }
                else
                {
                    questionsLost++;
                    questionTotal++;
                    Console.WriteLine($"Incorrect! The right answer was {Answers[tally]}. You have {pointsTotal} points.\n");
                }
            }

            Console.WriteLine($"Out of {questionTotal} you got {questionsWon} correct and {questionsLost} incorrect for a total of {pointsTotal}.\n");
            Console.WriteLine("Goodbye and thank you for playing the film trivia game.");
            Console.ReadKey();
        }



        static string GetValidAnswer()
        /* Gets the player input answer and verifies for correct entries*/
        {
            bool validFlag = false;
            string playerEntry = "";

            while (validFlag == false)
            {
                Console.WriteLine("Please enter your answer (T or F):\t");
                playerEntry = Console.ReadLine();

                switch (playerEntry.ToUpper())
                {

                    case "T":
                        {
                            validFlag = true;
                            break;
                        }
                    case "F":
                        {
                            validFlag = true;
                            break;
                        }
                    default:
                        {
                            validFlag = false;
                            Console.WriteLine($"Error: must enter 'T' or 'F'.");
                            break;
                        }

                }
            }
            
            return playerEntry;
        }


        static bool AnswerVerification(string answer, string playerEntry)
            /* Check the player-entered answer against listed answer */
        {
            bool questionAnswered = false;

            if (playerEntry == answer)
            {
                questionAnswered = true;
            }

            return questionAnswered;
        }


        static void SplitColumnsToLists(List<Trivia> filmTrivia, List<string> Questions, List<string> Answers, List<string> Points)
            /* Sort the CSV into three separate lists*/
        {
            for (int counter = 0; counter < filmTrivia.Count; counter++)
            {
                Questions.Add(filmTrivia[counter].Question);
                Answers.Add(filmTrivia[counter].Answer);
                Points.Add(filmTrivia[counter].Points);
            }
        }


        static void ReadandLoadTrivia(List<Trivia> filmTrivia)
            /* Read in the CSV and create a list from the info, populate filmTrivia list instance */
        {
            string Full_Path_File_Name = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GitHub\\2020-jan-coreportfolio-celianux\\AdvancedPortfolio3-Celia\\trivia.txt";
            string readValue = "";
            StreamReader reader = null;
            Trivia populateInfo = null;
            int column = 0;

            try
            {
                reader = new StreamReader(Full_Path_File_Name);
                readValue = reader.ReadLine();
                while (readValue != null)
                {
                    column = 0;
                    populateInfo = new Trivia();
                    foreach (string item in readValue.Split(','))
                    {
                        switch (column)
                        {
                            case 0:
                                {
                                    populateInfo.Question = item;
                                    break;
                                }
                            case 1:
                                {
                                    populateInfo.Answer = item;
                                    break;
                                }
                            default:
                                {
                                    populateInfo.Points = int.Parse(item);
                                    break;
                                }
                        }
                        column++;
                    }
                    filmTrivia.Add(populateInfo);
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
