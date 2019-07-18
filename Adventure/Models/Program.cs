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
        WriteLine("-------------");
        WriteLine("----Thank----");
        WriteLine("-------------");
        Game myGame = new Game(userName);
        WriteLine($"{myGame.Name} Meet your Pup: ");
        myGame.drawPup();
        WriteLine("");
       if(myGame.AskYesNo("Do you want to start the game?"))
       {
           WriteLine("yay lets start");
           if(myGame.AskYesNo("Should Pup look outside?"))
           {
               myGame.GoOutside();
           }
       }
       else
       {
           WriteLine("ok bye");
       }
        

        
        
    }

}