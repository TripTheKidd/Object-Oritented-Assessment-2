using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object_Oritented_Assessment_2;
using static System.Console;

namespace Object_Oritented_Assessment_2
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
                //Player playerTest = new Player();
                Clear();
                WriteLine("Let's get started then!");
                Player1();
                Player2();
                //playerTest.Gamers();
                Player1Round();
                //WriteLine(playerTest.Player11);
                //Player1Name = playerTest.Player11;
                //Player2Name = playerTest.Player21;
                //WriteLine(Player1Name);
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

            List<int> Player1Results = new List<int>(); 

            WriteLine($"Would you like to roll? If no then the game will exit(yes/no)");
            string Response = ReadLine().Trim().ToLower();
            if (Response == "yes")
            {
                WriteLine("Rolling...");
                System.Threading.Thread.Sleep(1000);

                int P1roll1 = DiceRoll.Next(1, 7);
                Player1Results.Append(P1roll1);
                int P1roll2 = DiceRoll.Next(1, 7);
                Player1Results.Append(P1roll2);
                int P1roll3 = DiceRoll.Next(1, 7);
                Player1Results.Append(P1roll3);
                int P1roll4 = DiceRoll.Next(1, 7);
                Player1Results.Append(P1roll4);
                int P1roll5 = DiceRoll.Next(1, 7);
                Player1Results.Append(P1roll5);
                WriteLine($"You rolled {P1roll1} {P1roll2} {P1roll3} {P1roll4} {P1roll5}");

                
                Player.Gamer1();
                WriteLine()




                WriteLine(P1Score);




                WriteLine("Press any key to continue...");
                ReadKey();
                Player2Round();
            }
            else if (Response == "no")
            {
                WriteLine("Nice playing with you!");
            }
            else
            {
                WriteLine($"You entered '{Response}'. That's not valid. Try again with 'yes' or 'no'.");
            }

            


        }

        private void Player2Round()
        {
            //Method that runs one round
            Clear();

            WriteLine("Would you like to roll {Player2}? If no then the game will exit(yes/no)");
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


                

                WriteLine(P2Score);




                WriteLine("Press any key to continue...");
                ReadKey();
                Player1Round();
            }
            else if (Response == "no")
            {
                WriteLine("Nice playing with you!");
            }

            else
            {
                WriteLine($"You entered '{Response}'. That's not valid. Try again with 'yes' or 'no'.");
            }


            

        }

        private void Win()
        {
            //Method that increments the score and lets the player know they won
            WriteLine("{} wins!");
            AskToPlayAgain();
        }

        private void Lose()
        {
            //Method that lets the player know they won
            WriteLine("Sorry :( {}");
            AskToPlayAgain();
        }

        private void AskToPlayAgain()
        {
            //Method that asks the player if they want to play again
        }

        private void Exit()
        {
            //Method that Exits the Game
            WriteLine("See you next time!");
            ReadKey();
        }
    }
}