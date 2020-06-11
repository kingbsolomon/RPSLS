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

        //Methods

        public void GameWelcome()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("The rules are simple!");
            Console.WriteLine("{0} {1} {2}", gestures[0], actions[0],gestures[2]); // Rock rushes scissors
            Console.WriteLine("{0} {1} {2}", gestures[2], actions[1],gestures[1]); //Scissors cuts paper
            Console.WriteLine("{0} {1} {2}", gestures[1],actions[2],gestures[0]); //Paper covers rock
            Console.WriteLine("{0} {1} {2}", gestures[0], actions[0],gestures[3]);//Rock crushes Lizard
            Console.WriteLine("{0} {1} {2}", gestures[3],actions[3],gestures[4]);//Lizard poisons Spock
            Console.WriteLine("{0} {1} {2}", gestures[4],actions[4],gestures[2]);//Spock smash Scissors
            Console.WriteLine("{0} {1} {2}", gestures[2],actions[5],gestures[3]);//scissors decapitates lizard
            Console.WriteLine("{0} {1} {2}", gestures[3],actions[6],gestures[1]);//Lizard eats paper
            Console.WriteLine("{0} {1} {2}", gestures[1],actions[7],gestures[4]);//Paper disproves Spock
            Console.WriteLine("{0} {1} {2}", gestures[4], actions[8],gestures[0]);//Spock vaporizes Rock
            
            Console.WriteLine("Press Enter to Continue:");
            Console.ReadLine();
            Console.Clear();
        }
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
            GameType();
            while (players[0].numWins < 3 && players[1].numWins < 3)
            {
                Battle();
            }
        }

        public void Battle()
        {
            playerOne.PlayerGesture(players[0]);
            playerTwo.PlayerGesture(players[1]);

            if (players[0].playerChoice ==
                players[1].playerChoice)
            {
                Console.WriteLine("There was a tie!");
                Battle();
            }
        }

        public void CheckWinner()
        {
            switch (playerOne.playerChoice)
            {
                case "Rock":
                    switch (playerTwo.playerChoice)
                    {
                        case "Scissors":
                            Console.WriteLine("{0} {1} {2}", gestures[0], actions[0], gestures[2]);
                            playerOne.numWins++;
                            break;

                        case "Paper":
                            Console.WriteLine("{0} {1} {2}", gestures[1], actions[2], gestures[0]);
                            playerTwo.numWins++;
                            break;

                        case "Lizard":
                            Console.WriteLine("{0} {1} {2}", gestures[0], actions[0], gestures[3]);
                            playerOne.numWins++;
                            break;

                        case""
                    }


            }
        }

    }
}

/*
            Console.WriteLine("{0} {1} {2}", gestures[0], actions[0],gestures[2]); // Rock rushes scissors
            Console.WriteLine("{0} {1} {2}", gestures[2], actions[1],gestures[1]); //Scissors cuts paper
            Console.WriteLine("{0} {1} {2}", gestures[1],actions[2],gestures[0]); //Paper covers rock
            Console.WriteLine("{0} {1} {2}", gestures[0], actions[0],gestures[3]);//Rock crushes Lizard
            Console.WriteLine("{0} {1} {2}", gestures[3],actions[3],gestures[4]);//Lizard poisons Spock
            Console.WriteLine("{0} {1} {2}", gestures[4],actions[4],gestures[2]);//Spock smash Scissors
            Console.WriteLine("{0} {1} {2}", gestures[2],actions[5],gestures[3]);//scissors decapitates lizard
            Console.WriteLine("{0} {1} {2}", gestures[3],actions[6],gestures[1]);//Lizard eats paper
            Console.WriteLine("{0} {1} {2}", gestures[1],actions[7],gestures[4]);//Paper disproves Spock
            Console.WriteLine("{0} {1} {2}", gestures[4], actions[8],gestures[0]);//Spock vaporizes Rock*/
