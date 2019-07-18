using System;
using static System.Console;

namespace GameSpace
{
    public class Game
    {
        private string name;
        public string Name { get; set; }
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
       public void drawPup()
        {
            WriteLine("      /^ ^\\");
            WriteLine("     / 0 0 \\");
            WriteLine("     V\\ Y /V");
            WriteLine("    / - \\");
            WriteLine("   /    |");
            WriteLine("   V__) ||");
        }

    }
}