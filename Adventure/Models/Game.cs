using System;
using static System.Console;
using Characters;

namespace GameSpace
{
    public class Game
    {
        private string name;
        public string Name { get; set; }
        private Pup pup = new Pup();
        public Game()
        {
            name = "Sir";
            Name = name;
        }
        public Game(string userName)
        {
            name = userName;
            Name = name;
        }
        
        public bool CheckYes(string str)
        {
            if (str == "y" || str == "Y" || str == "yes" || str == "Yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // return true for yes
        public bool AskYesNo(string question)
        {
            WriteLine($"{question}");
            return CheckYes(Console.ReadLine());
        }

        public void drawPup()
        {
            WriteLine("      /^ ^\\");
            WriteLine("     / 0 0 \\");
            WriteLine("     V\\ Y /V");
            WriteLine("    / - \\");
            WriteLine("   /    |");
            WriteLine("   V__) ||");
        }

        public void GoOutside()
        {
            WriteLine("Pup is outside!");
            WriteLine("≧◔◡◔≦");
            // pup state! outside or some shit
        }



    }
}