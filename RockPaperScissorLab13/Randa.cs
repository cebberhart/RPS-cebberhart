using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorLab13
{
    class Randa : Player
    {
        public Randa()
        {
            Name = "Randa";
        }
        public override RPSEnum GetRPS()
        {
            Random rng = new Random();

            int pick = rng.Next(0. 3);

            switch (pick)
            {
                case 0:
                    return RPSEnum.Rock;
                case 1:
                    return RPSEnum.Paper;
                case 2:
                    return RPSEnum.Scissors;
                default:
                    return RPSEnum.Rock;

            }
        }
    }
}
