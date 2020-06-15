using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    abstract class Player
    {
        public Gesture playerChoice;
        public int numWins;
        public string playerName;
        public List<Gesture> gestures;

        public Player()
        {
            gestures = new List<Gesture>()
            {
                new Gesture("Rock",new List<string>() { "Paper", "Scissors" } ),
                new Gesture("Paper",new List<string>() { "Scissors", "Lizard" } ),
                new Gesture("Scissors",new List<string>() { "Rock", "Spock" } ),
                new Gesture("Lizard",new List<string>() { "Rock", "Scissors" } ),
                new Gesture("Spock", new List<string>(){"Paper","Lizard"})
            };
        }
        
        public abstract void PlayerName();
        public abstract void PlayerGesture();
    }
}
