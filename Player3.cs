using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    public class Player3 : Player
    {
        Player3(
            string name)
        {
            this.name = name;
        }

        public override string Roshambo()
        {
            Random newThrow = new Random();
            int myThrow = newThrow.Next(1, 3);
            switch (myThrow)
            {
                case 1:
                    return "Rock";

                case 2:
                    return "Scissors";

                case 3:
                    return "Paper";

                default:
                    return "Bad throw";

            }

        }

    }
}
