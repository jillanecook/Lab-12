using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Play Roshambo!");
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine(); //name = user 
            Console.WriteLine($"Welcome, {name}. Please select one of the followng opponents:");
            Console.WriteLine("");
            Console.WriteLine("Tommy"); //rock
            Console.WriteLine("Randy"); // random
            Console.WriteLine("Champ");


            Game game = new Game();

            game.Play();
        }
    }
    abstract class Player
    {
}
}



        













