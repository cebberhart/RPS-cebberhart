using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorLab13
{
    class RPSApp
    {

        public UserPlayer Player { get; set; } = new UserPlayer();
        public int Draws { get; set; } = 0;

        //ew leave this property blank. we want the user to selct who to play

        public Player Oppenent { get; set; }
        public RPSApp()
        {
            //once we have randa replace this line with code that
            //lets use use the rng
            while (true)
            {
                Console.WriteLine("Who would you like to battlre?");
            }
        }

        public void Play()
        {
            RPSEnum playerOne = Player.GetRPS();
            RPSEnum playerTwo = Opponent.GetRPS();

            

            if(playerOne == playerTwo)
            {
                Console.WriteLine("draw");
               
            }
            else if(playerOne == RPSEnum.Rock)
            {
                if(playerTwo == RPSEnum.Paper)
                {
                    playerOne = false;
                }
                else if(playerTwo == RPSEnum.Scissors)
                {
                    playerOneWins = true;
                }
            }
            else if(playerOne == RPSEnum.Paper)
            {

            }
            else if(playerOne == RPSEnum.Scissors)
            {

            }
            else
            {

            }
        }
    }
}
