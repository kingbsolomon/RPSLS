using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {

        //member variables
        public List<string> welcomeGestures;
        public List<string> actions;
        public string gameType;
        public Player playerOne;
        public Player playerTwo;

        //Methods

        public Game()
        {
            welcomeGestures = new List<string>() { "Rock", "Paper","Scissors", "Lizard", "Spock"};
            actions = new List<string>() { "crushes", "cuts", "covers","poisons", "smashes", "decapitates", "eats", "disproves", "vaporizes"};
        }

        public void GameWelcome()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("The rules are simple!");
            Console.WriteLine("{0} {1} {2}", welcomeGestures[0],actions[0], welcomeGestures[2]); // Rock rushes scissors
            Console.WriteLine("{0} {1} {2}", welcomeGestures[2],actions[1], welcomeGestures[1]); //Scissors cuts paper
            Console.WriteLine("{0} {1} {2}", welcomeGestures[1],actions[2], welcomeGestures[0]); //Paper covers rock
            Console.WriteLine("{0} {1} {2}", welcomeGestures[0],actions[0], welcomeGestures[3]);//Rock crushes Lizard
            Console.WriteLine("{0} {1} {2}", welcomeGestures[3],actions[3], welcomeGestures[4]);//Lizard poisons Spock
            Console.WriteLine("{0} {1} {2}", welcomeGestures[4],actions[4], welcomeGestures[2]);//Spock smash Scissors
            Console.WriteLine("{0} {1} {2}", welcomeGestures[2],actions[5], welcomeGestures[3]);//scissors decapitates lizard
            Console.WriteLine("{0} {1} {2}", welcomeGestures[3],actions[6], welcomeGestures[1]);//Lizard eats paper
            Console.WriteLine("{0} {1} {2}", welcomeGestures[1],actions[7], welcomeGestures[4]);//Paper disproves Spock
            Console.WriteLine("{0} {1} {2}", welcomeGestures[4],actions[8], welcomeGestures[0]);//Spock vaporizes Rock
            Console.WriteLine("");
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
                        playerOne = new Human();
                        playerOne.PlayerName();
                        playerTwo = new Human();
                        playerTwo.PlayerName();
                        gameSelected = true;
                        Console.Clear();
                        break;

                    case "2":
                        playerOne = new Human();
                        playerOne.PlayerName();
                        playerTwo = new AI();
                        playerTwo.PlayerName();
                        gameSelected = true;
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Please Enter a valid selection");
                        userInput = Console.ReadLine();
                        break;
                }
            }
        }

        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play again? y or n");
            string playAgain = Console.ReadLine();

            if (playAgain == "y")
            {
                Console.Clear();
                RunGame();
            }
            else
            {
                Console.WriteLine("Thank you for playing!!!");
                Console.ReadLine();
            }

        }
        public void RunGame()
        {
            string select = GameType();
            GameSelector(select);
            while (playerOne.numWins < 3 && playerTwo.numWins < 3)
            {
                Battle();
            }

            if(playerOne.numWins > playerTwo.numWins)
            {
                Console.WriteLine("{0} WINS!!", playerOne.playerName);
                PlayAgain();
            }
            else
            {
                Console.WriteLine("{0} WINS!!", playerTwo.playerName);
                PlayAgain();
            }
        }

        public void Battle()
        {


            playerOne.PlayerGesture();
             playerTwo.PlayerGesture();
            
            if (playerOne.playerChoice.type ==
                playerTwo.playerChoice.type)
            {
                Console.WriteLine("{0}:{1}\t{2}:{3}", playerOne.playerName, playerOne.playerChoice.type, playerTwo.playerName, playerTwo.playerChoice.type);
                Console.WriteLine("There was a tie!");
                Battle();
            }
            else if (playerOne.playerChoice.losesTo.Contains(playerTwo.playerChoice.type))
            {
                Console.WriteLine("{0}:{1}\t{2}:{3}", playerOne.playerName, playerOne.playerChoice.type, playerTwo.playerName, playerTwo.playerChoice.type);
                Console.WriteLine("{0} Wins This Match\n",playerTwo.playerName);
                playerTwo.numWins++;
            }
            else
            {
                Console.WriteLine("{0}:{1}\t{2}:{3}", playerOne.playerName, playerOne.playerChoice.type, playerTwo.playerName, playerTwo.playerChoice.type);
                Console.WriteLine("{0} Wins This Match\n", playerOne.playerName);
                playerOne.numWins++;
            }
        }
    }
}


