using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {

        //member variables
        public List<string> gestures = new List<string>() { "Rock", "Paper",
        "Scissors", "Lizard", "Spock"};

        public List<string> actions = new List<string>() { "crushes", "cuts", "covers",
        "poisons", "smashes", "decapitates", "eats", "disproves", "vaporizes"};

        public string gameType = "";

        public Player playerOne;
        public Player playerTwo;
        public AI playerTwoAI;

        public string GameType()
        {
            Console.WriteLine("Which type of game would you like?");
            Console.WriteLine("1: Player vs. Player");
            Console.WriteLine("2: Player vs Computer");
            gameType = Console.ReadLine();
            GameSelector(gameType);
            return gameType;
        }

        public void GameSelector(string userInput)
        {
            bool gameSelected = false;

            while (gameSelected == false)
            {
                switch (userInput)
                {
                    case "1":
                        playerOne = new Player();
                        playerTwo = new Player();
                        gameSelected = true;
                        break;

                    case "2":
                        playerOne = new Player();
                        playerTwoAI = new AI();
                        gameSelected = true;
                        break;

                    default:
                        Console.WriteLine("Please Enter a valid selection");
                        userInput = Console.ReadLine();
                        break;
                        
                }
            }
        }

        /*public void PlayerChoice()
        {
            Console.WriteLine("Please Select:");
            Console.WriteLine("1: Rock");
            Console.WriteLine("2: Paper");
            Console.WriteLine("3: Scissors");
            Console.WriteLine("4: Lizard");
            Console.WriteLine("5: Spock");

            switch (playerChoice)
            {
                case "1":
                    this.playerChoice =
            }

        }*/

    }
}
