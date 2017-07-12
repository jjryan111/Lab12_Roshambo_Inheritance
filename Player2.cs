using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{

    public class Player2 : Player
    {
        public Player2 (string name)
        {
            this.name = name;
        }

        public override string Roshambo()
        {
            return "Rock";
        }
    }

}
