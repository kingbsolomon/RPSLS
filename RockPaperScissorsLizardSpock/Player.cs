using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    abstract class Player
    {
        public string playerChoice;
        public int numWins;

        public List<string> gestures = new List<string>() { "Rock", "Paper",
        "Scissors", "Lizard", "Spock"};


        public Player() { }

        public abstract void PlayerGesture(Player player);
    }
}
