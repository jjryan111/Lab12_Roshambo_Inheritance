using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesNo = "y";
            Input n = new Input();
            string name = n.GetInput("Enter your name: ", "That's not a name!");
            Player1 you = new Player1(name);
            RoshamboApp game = new RoshamboApp();
            Player opponent = game.GetPlayer();
            List<string> outcomes = new List<string>();
            while (yesNo == "y")
            {
                string outcome = game.PlayGame(game, you, opponent);
                outcomes.Add(outcome);
                yesNo = n.ynInput();
            }
            game.PrintOutcomes(outcomes, you, opponent);
        }
    }
}
