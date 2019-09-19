using System;

namespace Console_Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            mainMenu();
            Console.ReadKey();
        }

        static void runGame()
        {
            Board game = new Board();
            game.CreatePieces();
            game.UpdateDraw();
        }

        static void mainMenu()
        {
            Console.Out.WriteLine("Console Chess MAIN MENU\n");
            Console.Out.WriteLine("Please select a menu option:");
            Console.Out.WriteLine("1. Start new game. | 2. Exit.");
            switch (Console.ReadLine())
            {
                case "1":
                    runGame();
                    break;
                case "2":
                    Console.Clear();
                    Console.Out.WriteLine("Good bye.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    mainMenu();
                    break;
            }
        }
    }
}
