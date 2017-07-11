using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    class RoshamboApp
    {
        public Input n = new Input();
        string name = n.GetInput("Enter your name: ", "That's not a name!");
        int playerNum = n.GetInput("Which opponent? choose 1 for Bob or 2 for Rocky:", "Please choose 1 or 2: ", 0, 2);
        
    }
}
