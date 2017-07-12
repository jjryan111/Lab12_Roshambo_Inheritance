using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_RockPaperScissors
{
    public class Input
    {
        public Input() { }

        public string ynInput()
        // Gets a y or n.
        {
            string input = "";
            bool invalid = true;
            while (invalid)
            {
                Console.Write("\n\nAnother throw? (y/n): ");
                input = Console.ReadLine();
                input = input.ToLower();
                if (input == "y" || input == "n")
                {
                    invalid = false;
                }
                else
                {
                    Console.WriteLine("\nPlease enter y or n.");
                }
            }
            return input;
        }

        public int GetInput(string question, string error, int bottomNum, int topNum)
        {
            bool validInput = false;
            int exitNum = 0;
            while (!validInput)
            {
                Console.Write(question);
                bool inp = int.TryParse(Console.ReadLine(), out exitNum);
                if (!inp || exitNum <= bottomNum || exitNum > topNum)
                {
                    Console.WriteLine(error);
                }
                else
                {
                    validInput = true;
                }
            }
            return exitNum;
        }
        public string GetInput(string question, string error)
        {
            bool validInput = false;
            string output = "";
            while (!validInput)
            {
                Console.Write(question);
                output = Console.ReadLine();
                if (output == "")
                {
                    Console.WriteLine(error);
                }
                else
                {
                    validInput = true;
                }
            }
            return output;
        }
    }
}
