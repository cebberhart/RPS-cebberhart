using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorLab13
{
    class Rocky : Player
    {
        //constructor
        public Rocky()
        {
            Name = "Rocky";
            
        }
        //override
        public override RPSEnum GetRPS()
        {
            
            return RPSEnum.Rock;
        }
    }
}
