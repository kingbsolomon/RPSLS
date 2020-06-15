using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    class Gesture
    {
       
        public List<string> losesTo;
        public string type;

        public Gesture(string type, List<string> losesTo)
        {
            this.type = type;
            this.losesTo = losesTo;
        }

       
    }
}
