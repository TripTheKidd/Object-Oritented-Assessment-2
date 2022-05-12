using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Object_Oriented_Assessment_2
{
    class Game
    {
        private string GameName;
        private int P1Score;
        private int P2Score;
        private Random DiceRoll;
        public Game()
        {
            //Initialize anything that we need to
            P1Score = 0;
            P2Score = 0;
            DiceRoll = new Random();
            GameName = "Three or More";
        }

        public void Start()
        {
            //Method that starts the game running
            Title = "GameName";
            WriteLine($"=== {GameName} ===");
            WriteLine("\nLet's play a game of dice");
            WriteLine("\nInstructions:");
            WriteLine("\t>Players take turns rolling five dice for 10 rounds.");
            WriteLine("\t>Whoever rolls three-of-a-kind or better gets points.");
            WriteLine("\t>If a player only has two-of-a-kind they may re-throw the remaining dice.");
            WriteLine("\t>If no matching numbers are rolled after two rolls then a player scores 0.");
            WriteLine("\t>The first player to 60 points is the winner");
            WriteLine("\n___________________________________________________________________________");
            WriteLine("\nScoring");
            WriteLine("\t>3-of-a-kind: 3 points");
            WriteLine("\t>4-of-a-kind: 6 points");
            WriteLine("\t>5-of-a-kind: 12 points");
            WriteLine("\nReady to play? (yes/no)");
            WriteLine("\n");

            string playResponse = ReadLine().Trim().ToLower();
            if (playResponse == "yes")
            {
                WriteLine("Let's get started then!");
                Player1Round();
            }
            else
            {
                WriteLine("See you next time!");
            }

            WriteLine("Press any key to exit...");
            ReadKey();
            
        }

        private void Player1Round()
        {
            //Method that runs one round
            Clear();

            WriteLine("Would you like to Roll? If no then the game will exit(yes/no)");
            string Response = ReadLine().Trim().ToLower();
            if (Response == "yes")
            {
                WriteLine("Rolling...");
                System.Threading.Thread.Sleep(1000);

                int P1roll1 = DiceRoll.Next(1, 7);
                int P1roll2 = DiceRoll.Next(1, 7);
                int P1roll3 = DiceRoll.Next(1, 7);
                int P1roll4 = DiceRoll.Next(1, 7);
                int P1roll5 = DiceRoll.Next(1, 7);
                WriteLine($"You rolled {P1roll1} {P1roll2} {P1roll3} {P1roll4} {P1roll5}");

                if (P1roll1 == P1roll2 && P1roll2 == P1roll3 && P1roll3 == P1roll4 && P1roll4 == P1roll5)
                {
                    P1Score += 12;
                }

                else if (P1roll1 == P1roll2 && P1roll2 == P1roll3 && P1roll3 == P1roll4)
                {
                    P1Score += 6;
                }

                else if (P1roll1 == P1roll2 && P1roll2 == P1roll3)
                {
                    P1Score += 3;
                }
                
                else
                {
                    P1Score += 1;
                }



                WriteLine(P1Score);




                //WriteLine("Press any key to continue...");
                //ReadKey();
                Player2Round();
            }
            else
            {
                WriteLine("Nice playing with you!");
            }
            
            


        }

        private void Player2Round()
        {
            //Method that runs one round
            Clear();

            WriteLine("Would you like to Roll2? If no then the game will exit(yes/no)");
            string Response = ReadLine().Trim().ToLower();
            if (Response == "yes")
            {
                WriteLine("Rolling...");
                System.Threading.Thread.Sleep(1000);

                int P2roll1 = DiceRoll.Next(1, 7);
                int P2roll2 = DiceRoll.Next(1, 7);
                int P2roll3 = DiceRoll.Next(1, 7);
                int P2roll4 = DiceRoll.Next(1, 7);
                int P2roll5 = DiceRoll.Next(1, 7);
                WriteLine($"You rolled {P2roll1} {P2roll2} {P2roll3} {P2roll4} {P2roll5}");

                if (P2roll1 == P2roll2 && P2roll2 == P2roll3 && P2roll3 == P2roll4 && P2roll4 == P2roll5)
                {
                    P2Score += 12;
                }

                else if (P2roll1 == P2roll2 && P2roll2 == P2roll3 && P2roll3 == P2roll4)
                {
                    P2Score += 6;
                }

                else if (P2roll1 == P2roll2 && P2roll2 == P2roll3)
                {
                    P2Score += 3;
                }

                else
                {
                    P2Score += 1;
                }



                WriteLine(P2Score);




                //WriteLine("Press any key to continue...");
                //ReadKey();
                Player1Round();
            }
            else
            {
                WriteLine("Nice playing with you!");
            }




        }

        private void Win()
        {
            //Method that increments the score and lets the player know they won
        }

        private void Lose()
        {
            //Method that lets the player know they won
        }

        private void AskToPlayAgain()
        {
            //Method that asks the player if they want to play again
        }

        private void Exit()
        {
            //Method that Exits the Game
        }
    }
}