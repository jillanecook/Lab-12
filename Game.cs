using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{   


    class Game
    {



        Random random = new Random();

        public void Play()
        {
            string input = (Console.ReadLine()); // input = opponent
            Console.WriteLine($"Your opponent is {input}");
            Console.WriteLine("");
            Console.WriteLine("Let's begin!");
            
            

            string human = userInput();
            string computer = GetRoshambo();

            Console.WriteLine("Your throw: " +  ToText(human));
            Console.WriteLine(input+"'s throw: " + ToText(computer));

            Winner(human, computer);
            Console.ReadLine();
        }

        private string userInput ()
        {
            Console.WriteLine("Choose an option R, P, S : ");
            string choice = Console.ReadLine();

            if (choice == "R")
            {
                return "R";
            }
            else if (choice == "P")
            {
                return "P";
            }
            else
            {
                return "S";
            }
        }
        private void Winner (string human, string computer)
        {

            
            if ((human == "P") && (computer == "R") || (human == "R" && computer == "S") || (human == "S" && computer == "R"))
            {
                Console.WriteLine("You are the winner!");
            }
            else if (human == computer)
            {
                Console.WriteLine("It is a tie!");
            }
            else
            {
                Console.WriteLine("Your opponent wins!"); 
            }
        }


        private string GetRoshambo()
        {
            int number = random.Next(1, 4);
            if (number == 1)
            {
                return "R";
            }
            else if (number == 2)
            {
                return "P";
            }
            else
            {
                return "S";
            }
        }
        private string ToText(string choice)
        {
            if (choice == "R")
            {
                return "Rock";
            }
            else if (choice == "P")
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }

    }
}
