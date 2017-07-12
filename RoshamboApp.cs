using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    public class RoshamboApp
    {
        public RoshamboApp() { }
        public Player GetPlayer()
        {
            Input n = new Input();
            int playerNum = n.GetInput("Which opponent? choose 1 for Rocky or 2 for Bob:", "Please choose 1 or 2: ", 0, 2);
            Player opponent = new Player2("n");
            if (playerNum == 1)
            {
                opponent = new Player2("Rocky");
            }
            else
            {
                opponent = new Player3("Bob");
            }
            return opponent;
        }

        public string GetThrow(Player opponent)
        {
            string thisThrow = opponent.Roshambo();
            return thisThrow;
        }

        public int WhoWins(string player1Throw, string player2Throw)
        {
            if (player1Throw == player2Throw)
            {
                return 0;
            }
            else if (player1Throw == "Rock" && player2Throw == "Paper")
            {
                return 2;
            }
            else if (player1Throw == "Rock" && player2Throw == "Scissors")
            {
                return 1;
            }
            else if (player1Throw == "Scissors" && player2Throw == "Rock")
            {
                return 2;
            }
            else if (player1Throw == "Scissors" && player2Throw == "Paper")
            {
                return 1;
            }
            else if (player1Throw == "Paper" && player2Throw == "Scissors")
            {
                return 2;
            }
            else if (player1Throw == "Paper" && player2Throw == "Rock")
            {
                return 1;
            }
            else
            {
                return 3;
            }
        }
        public string PlayGame(RoshamboApp game, Player you, Player opponent)
        {
            string result = "";
            string myThrow = you.Roshambo();
            Console.WriteLine(you.name + " threw " + myThrow);
            string opThrow = opponent.Roshambo();
            Console.WriteLine(opponent.name + " threw " + opThrow);
            int winner = game.WhoWins(myThrow, opThrow);
            result = game.PrintResult(you, opponent, winner);
            return result;
        }
        public string PrintResult(Player you, Player opponent, int winner)
        {
            if (winner == 0)
            {
                Console.WriteLine("There was a tie.");
                return "Tie";
            }
            else if (winner == 1)
            {
                Console.WriteLine(you.name + " wins!");
                return you.name;
            }
            else
            {
                Console.WriteLine(opponent.name + " wins.");
                return opponent.name;
            }
        }
        public void PrintOutcomes(List<string> outcomes, Player you, Player opponent)
        {
            int youcounter = 0;
            int opcounter = 0;
            int tiecounter = 0;
            foreach (String i in outcomes)
            {
                if (i == you.name)
                {
                    youcounter++;
                }
                else if (i == opponent.name)
                {
                    opcounter++;
                }
                else
                {
                    tiecounter++;
                }
            }

            Console.WriteLine(you.name + " won " + youcounter + " throws.");
            Console.WriteLine(opponent.name + " won " + opcounter + " throws");
            Console.WriteLine("There were " + tiecounter + " ties.");

        }
    }
}
