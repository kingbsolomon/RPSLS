using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    abstract class Player
    {
        public string playerChoice;
        public int numWins;


        public Player()
        {
        }

        public abstract void PlayerGesture();
    }
}
