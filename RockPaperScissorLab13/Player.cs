using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorLab13
{
    abstract class Player
    {
        //properties
        public string Name { get; set; }
        public RPSEnum RPS { get; set; }
        
        //constrcutor
        public abstract RPSEnum GetRPS();

        
    }
}
