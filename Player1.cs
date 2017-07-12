using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    public class Player1 : Player
    {
        public Player1 (string name)
        {
            this.name = name;
        }
        public override string Roshambo()
        {
            Input n = new Input();
            int myThrow = n.GetInput("1) Rock 2) Paper 3) Scissors? ","Please choose 1, 2 or 3. ", 0, 3);
            switch (myThrow)
            {
                case 1:
                    return "Rock";
                    
                case 2:
                    return "Paper";
                    
                case 3:
                    return "Scissors";
                    
                default:
                    return "Bad throw";
                    
            }
        }
    }
}
