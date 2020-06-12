using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class Human: Player
    {

        public override void PlayerGesture(Player player)
        {
            Console.WriteLine("{0}, Please Select:", playerName);
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
    }
}
