using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorLab13
{
    class UserPlayer : Player
    {
        public UserPlayer()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();


        }
        //Constructor
        //have the user select R P or S
        //anything else ask for valid value
        public override RPSEnum GetRPS()
        {
            Console.WriteLine("Please select rock paper or scissors (r, p, or s)");
            string answer = Console.ReadLine();
            

            switch (answer)
            {
                case "rock":
                    return RPSEnum.Rock;
                case "r":
                    return RPSEnum.Rock;
                case "paper":
                    return RPSEnum.Paper;
                case "p":
                    return RPSEnum.Paper;
                case "scissors":
                    return RPSEnum.Scissors;
                case "s":
                    return RPSEnum.Scissors;
                default: 
                    Console.WriteLine("PLease enter correct thingy");
                    return GetRPS();

            }
        }
    }
}
