using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            //keeps the window open
            Console.ReadKey();
        }
        static void Hangman()
        {
            //ask for users name
            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();
            //greet user and give instructions
            Console.WriteLine("Hello. Correctly guess the letters or word you win. Guess incorrectly and you will lose.");
            bool playing = true;
            while (playing == true)
            {
                //choose a radom word from list
                List<string> items = ("baseball", "tennisball", "basketball", "bowlingball");
                Random rng = new Random();
                int randomeNum = rng.Next();
                int input = int.Parse(Console.ReadLine)
            }
        }
    }
}
