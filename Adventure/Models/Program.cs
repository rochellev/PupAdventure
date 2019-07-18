using System;
using static System.Console;
using GameSpace;

class Program
{
    private static void Main()
    {
        WriteLine("( ˘ ³˘)❤ PupAdventure Time ( ˘ ³˘)❤ ");
        //WriteLine("         (っ◔◡◔)っ ♥");

        WriteLine("What is your name?");
        string userName = ReadLine();
        WriteLine("--------------------");
        Game myGame = new Game();
        myGame.Name = userName;
        WriteLine($"{myGame.Name} Meet your Pup: ");
        myGame.drawPup();
        

        
        
    }

}