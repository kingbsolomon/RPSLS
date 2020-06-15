using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class AI : Player
    {
        public Random random;

        public AI()
        {
            random = new Random();
        }

        public override void PlayerName()
        {
            playerName = "Android 13";
        }

        public override void PlayerGesture()
        {
            int randomNumber = random.Next(0, gestures.Count);
            playerChoice = gestures[randomNumber];
        }
    }
}
