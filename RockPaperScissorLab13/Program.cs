using System;

namespace RockPaperScissorLab13
{
    class Program
    {
        static void Main(string[] args)
        {
            UserPlayer p = new UserPlayer();
            RPSEnum result = p.GetRPS();
            Console.WriteLine(result);

            Rocky r = new Rocky();
            Console.WriteLine($"Rocky: {r.GetRPS()}");

            RPSApp app = new RPSApp();
            while (true)
            {
                Randa r = new Randa();
                Console.WriteLine(r.GetRPS());
                Console.WriteLine();
            }
            RPSApp app2 = new RPSApp();
            while (true)
            {

            }

        }
    }
}
