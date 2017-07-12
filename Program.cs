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
            Console.WriteLine("Champ"); //inherits GenerateRoshambo method
            Console.WriteLine("");
            string input = (Console.ReadLine()); // input = opponent
            Console.WriteLine($"Your opponent is {input}");
            Console.WriteLine("");
            Console.WriteLine("Let's begin!");
            Console.WriteLine("Please enter (rock), (paper), or (scissors):");
            string choice = (Console.ReadLine()); //choice = user throw 
            choice = choice.ToLower();
            
        }
    }           // do I have to create variables here?
                //Tommy t = new Tommy() ?

    abstract class Player                               // stores name and roshambo value
    {
        public abstract string GenerateRoshambo         // is this object created in another class? 
        {
            return //write method
        }

    }
    class Tommy : Player                                //player that returns rock only
    {
        public override string GenerateRoshambo
        {
            if (input == Tommy)
    
            return: rock                                // make rock equal to value 1 
    }

}
class Randy : Player
{
    public override string GenerateRoshambo
    {
            return                                      //random  - write method for random object
        }
}
class Champ : Player
{
                                                        //will inherit GenerateRoshambo
}
