using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    class Menu
    {
        public static void Menu_display()   //Displaying Menu
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("======= WAR GAME =======\n");
            Console.ResetColor();
            Console.WriteLine("Welcome to War Game simulator. Here you can make simulations for 2-player card game called War Game.");
            Console.WriteLine("Rules are simple. Deck is divided randomly between two players, then each player draw one card.");
            Console.WriteLine("Superior card wins and takes looser's card to the winner's deck.");
            Console.WriteLine("Game continues until one player is left without cards.\n");
            Console.WriteLine("OPTIONS:");
            Console.WriteLine("1: Play 1 Game");
            Console.WriteLine("2: Play many Games");
            if (Program.variables.Debug == false) Console.WriteLine("3: Debug mode [OFF]"); else Console.WriteLine("3: Debug mode [ON]");
            Console.WriteLine("0: Exit\n");
        }
        public static void Cont()  //Press any key to continue
        {
            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
        }

        public static void Case1()
        {
            Program.War();
            Menu.Cont();
            Console.Clear();
        }

        public static void Case2()
        {
            Program.variables.Pwins = Program.variables.Cwins = 0;
            for (Program.variables.iter = 0; Program.variables.iter < Program.variables.num; Program.variables.iter++) Program.War();
            Program.variables.iter = 0;
            Console.Clear();
            Console.WriteLine("Played hands  |  Winner        |  Hands won by Player  |  Hands won by Computer  |  Draws");
            Console.WriteLine("\n------------------------------------------------------------------------------------------");
            for (int i = 0; i < Program.variables.num; i++)
            {
                if (Program.variables.ScoreTab[i, 1] == "Computer") Console.BackgroundColor = ConsoleColor.DarkRed;
                else Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(Program.variables.ScoreTab[i, 0] + "              " + Program.variables.ScoreTab[i, 1] + "         " 
                    + Program.variables.ScoreTab[i, 2] + "                     " + Program.variables.ScoreTab[i, 3] + "                       " 
                    + Program.variables.ScoreTab[i, 4]);
                Console.ResetColor();
            }
            Console.WriteLine("\nSTATISTICS:\nPlayer wins: " + Program.variables.Pwins + ", Computer wins: " + Program.variables.Cwins);
            Menu.Cont();
            Console.Clear();
        }

        public static void Case3()
        {
            string Deb;
            Console.WriteLine("Debug mode is a special mode which gives you detailed information about state of the game.");
            if (Program.variables.Debug == false)
                Console.WriteLine("Debug mode is [OFF]. Do you want to change it?\nPress 'y' to change Debug Mode to [ON]");
            else
                Console.WriteLine("Debug mode is [ON]. Do you want to change it?\nPress 'y' to change Debug Mode to [OFF]");
            Deb = Console.ReadLine();
            if (Deb == "y") if (Program.variables.Debug == false) Program.variables.Debug = true; else Program.variables.Debug = false;
        }
    }
}
