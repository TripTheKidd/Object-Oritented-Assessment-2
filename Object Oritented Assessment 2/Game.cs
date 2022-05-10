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
        private int Score;
        public Game()
        {
            //Initialize anything that we need to
            Score = 0;
        }

        public void Start()
        {
            //Method that starts the game running
            Title = "Three or More";
            WriteLine("Three or More");

            WriteLine("Press any key to exit...");
            ReadKey();
        }

        private void PlayRound()
        {
            //Method that runs one round
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