using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class Human: Player
    {
        public override void PlayerName()
        {
            Console.WriteLine("Please Enter Player Name: ");
            playerName = Console.ReadLine(); 
        }
        public override void PlayerGesture()
        {
            bool gestureChosen = false;

            while(gestureChosen == false)
            {
                Console.WriteLine("{0}, Please Select One: ",playerName);
                for(int i = 0; i < gestures.Count; i++)
                {
                    Console.WriteLine($"{i}) {gestures[i].type}");
                }
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        playerChoice = gestures[0];
                        gestureChosen = true;
                        break;
                    case "1":
                        playerChoice = gestures[1];
                        gestureChosen = true;
                        break;
                    case "2":
                        playerChoice = gestures[2];
                        gestureChosen = true;
                        break;
                    case "3":
                        playerChoice = gestures[3];
                        gestureChosen = true;
                        break;
                    case "4":
                        playerChoice = gestures[4];
                        gestureChosen = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option..");
                        gestureChosen = false;
                        break;
                }
            }
        }
    }
}
