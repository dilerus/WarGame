using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    class Menu
    {
        public static void Menu_display()
        {
            Console.Clear();
            Console.BackgroundColor= ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("======= WAR GAME =======\n");
            Console.ResetColor();
            Console.WriteLine("Welcome to War Game simulator. Here you can make simulations for 2-player card game called War Game. ");
            Console.WriteLine("Rules are simple. Deck is divided randomly between two players, then each player draw one card.\nSuperior card wins and takes looser's card to the winners deck.");
            Console.WriteLine("Game continues until one player is left without cards.\n");
            Console.WriteLine("OPTIONS:");
            Console.WriteLine("1: Play 1 Game");
            Console.WriteLine("2: Play many Games");
            Console.WriteLine("0: Exit\n");
        }
        public static void kont()
        {
            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
