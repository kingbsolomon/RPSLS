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

        public List<Player> players = new List<Player>();

        public string gameType;

        public Player playerOne;
        public Player playerTwo;

        public Random random = new Random();

        //Methods
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
                        players.Add(playerOne = new Human());
                        players.Add(playerTwo = new Human());
                        gameSelected = true;
                        break;

                    case "2":
                        players.Add(playerOne = new Human());
                        players.Add(playerTwo = new AI());
                        gameSelected = true;
                        break;

                    default:
                        Console.WriteLine("Please Enter a valid selection");
                        userInput = Console.ReadLine();
                        break;
                }
            }
        }

        public void RunGame()
        {
            while (players[0].numWins < 3 && players[1].numWins < 3)
            {
                Battle();
            }
        }

        public void Battle()
        {
            PlayerChoice(players[0]);
            PlayerChoice(players[1]);
        }

        public void PlayerChoice(Player player)
        {
           
            if (player is Player) 
            {
                Console.WriteLine("Please Select:");
                Console.WriteLine("1: {0}", gestures[0]);
                Console.WriteLine("2: {0}", gestures[1]);
                Console.WriteLine("3: {0}", gestures[2]);
                Console.WriteLine("4: {0}", gestures[3]);
                Console.WriteLine("5: {0}", gestures[4]);

                string readEntry = Console.ReadLine();

                switch (readEntry)
                {
                    case "1":
                        player.playerChoice = gestures[0];
                        break;

                    case "2":
                        player.playerChoice = gestures[1];
                        break;

                    case "3":
                        player.playerChoice = gestures[2];
                        break;

                    case "4":
                        player.playerChoice = gestures[3];
                        break;

                    case "5":
                        player.playerChoice = gestures[4];
                        break;

                    default:
                        Console.WriteLine("Please Enter a Valid Choice");
                        readEntry = Console.ReadLine();
                        break;
                }
            }

            if(player is AI)
            {
                player.playerChoice = gestures[random.Next(0, gestures.Count)];
            }

        }

    }
}
