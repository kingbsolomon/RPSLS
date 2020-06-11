using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class AI : Player
    {
        public Random random = new Random();

        public override void PlayerGesture(Player player)
        {
            player.playerChoice = gestures[random.Next(0, gestures.Count)];
        }
    }
}
