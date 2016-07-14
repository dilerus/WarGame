using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public class Game
    {
        public static void Draw(int DrawCCrand, int DrawPCrand, int DrawNumber, List<Card> DrawDeck, List<Card> ComputerCards, List<Card> PlayerCards, Random rand)
        {
            if (Program.variables.Debug == true) Console.WriteLine("DrawNumber = " + DrawNumber);
            DrawCCrand = rand.Next(ComputerCards.Count);
            DrawPCrand = rand.Next(PlayerCards.Count);
            if (Program.variables.Debug == true) Console.WriteLine("Because of Draw, Player is risking " + PlayerCards[DrawPCrand].Code + 
                " card and Computer is risking " + ComputerCards[DrawCCrand].Code);
            DrawDeck.Add(ComputerCards[DrawCCrand]);
            if (Program.variables.Debug == true) Console.WriteLine("Adding " + ComputerCards[DrawCCrand].Code + " to DrawDeck");
            DrawDeck.Add(PlayerCards[DrawPCrand]);
            if (Program.variables.Debug == true) Console.WriteLine("Adding " + PlayerCards[DrawPCrand].Code + " to DrawDeck");
            ComputerCards.Remove(ComputerCards[DrawCCrand]);
            PlayerCards.Remove(PlayerCards[DrawPCrand]);
        }

        public static void BattleWin(int PCrand, int CCrand, int DrawCount, ref int DrawNumber, ref double Pwins, List<Card> DrawDeck,
            List<Card> ComputerCards, List<Card> PlayerCards)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Player Card: " + PlayerCards[PCrand].Code + "(value " + PlayerCards[PCrand].Value + ") wins with Computer Card: " + 
                ComputerCards[CCrand].Code + "(value " + ComputerCards[CCrand].Value + ")");
            Console.ResetColor();
            PlayerCards.Add(ComputerCards[CCrand]);
            ComputerCards.Remove(ComputerCards[CCrand]);
            if (DrawNumber > 0)
            {
                DrawCount = DrawDeck.Count;
                for (int i = 0; i < DrawCount; i++)
                {
                    if (Program.variables.Debug == true) Console.WriteLine("Adding do PlayerCards: " + DrawDeck[i].Code);
                    PlayerCards.Add(DrawDeck[i]);
                }
                for (int i = DrawCount - 1; i >= 0; i--)
                {
                    if (Program.variables.Debug == true) Console.WriteLine("Removing from DrawDeck: " + DrawDeck[i].Code);
                    DrawDeck.Remove(DrawDeck[i]);
                }
                DrawNumber = 0;
            }
            Pwins++;
        }

        public static void BattleDraw(int PCrand, int CCrand, ref int DrawNumber, ref double Draws, List<Card> DrawDeck, List<Card> ComputerCards, List<Card> PlayerCards)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Player Card: " + PlayerCards[PCrand].Code + "(value " + PlayerCards[PCrand].Value + ") drawed with Computer Card: " +
                ComputerCards[CCrand].Code + "(value " + ComputerCards[CCrand].Value + ")");
            Console.ResetColor();
            if (Program.variables.Debug == true)
            {
                Console.WriteLine("Adding do DrawDeck: " + PlayerCards[PCrand].Code);
                Console.WriteLine("Adding do DrawDeck: " + ComputerCards[CCrand].Code);
            }
            DrawDeck.Add(PlayerCards[PCrand]);
            DrawDeck.Add(ComputerCards[CCrand]);
            PlayerCards.Remove(PlayerCards[PCrand]);
            ComputerCards.Remove(ComputerCards[CCrand]);
            DrawNumber++;
            Draws++;
        }

        public static void BattleLoose(int PCrand, int CCrand, ref int DrawNumber, int DrawCount, ref double Cwins, List<Card> DrawDeck, 
            List<Card> ComputerCards, List<Card> PlayerCards)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Player Card: " + PlayerCards[PCrand].Code + "(value " + PlayerCards[PCrand].Value + ") looses with Computer Card: " +
                ComputerCards[CCrand].Code + "(value " + ComputerCards[CCrand].Value + ")");
            Console.ResetColor();
            ComputerCards.Add(PlayerCards[PCrand]);

            if (DrawNumber > 0)
            {
                DrawCount = DrawDeck.Count;
                for (int i = 0; i < DrawCount; i++)
                {
                    if (Program.variables.Debug == true) Console.WriteLine("Adding do ComputerCards: " + DrawDeck[i].Code);
                    ComputerCards.Add(DrawDeck[i]);
                }
                for (int i = DrawCount - 1; i >= 0; i--)
                {
                    if (Program.variables.Debug == true) Console.WriteLine("Removing from DrawDeck: " + DrawDeck[i].Code);
                    DrawDeck.Remove(DrawDeck[i]);
                }
                DrawNumber = 0;
            }
            PlayerCards.Remove(PlayerCards[PCrand]);
            Cwins++;
        }

        public static void WinnerDeclaration(ref string Winner, ref double PwinRate, ref double CwinRate, ref double DrawRate, ref double Pwins, 
            ref double Cwins, ref double Draws, ref int Hands, List<Card> PlayerCards)
        {
            int Win = 0;
            if (PlayerCards.Count == 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Win = (int)Program.variables.Winner.Computer;
                Program.variables.Cwins++;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Win = (int)Program.variables.Winner.Player;
                Program.variables.Pwins++;
            }
            if (Win == 1) Winner = "Computer";
            if (Win == 2) Winner = "Player  ";
            PwinRate = Pwins / (Hands) * 100;
            CwinRate = Cwins / (Hands) * 100;
            DrawRate = Draws / (Hands) * 100;
            Console.WriteLine("\nWINNER: " + Winner);
            Console.ResetColor();
        }

        public static void Statistics(ref string OutPC, ref string OutCC, ref string Winner, ref double PwinRate, ref double CwinRate, ref double DrawRate, 
            ref double Pwins, ref double Cwins, ref double Draws, ref int Hands, List<Card> PlayerCards, List<Card> ComputerCards, List<Card> DrawDeck)
        {
            if (Program.variables.Debug == true) Console.WriteLine("\nPlayer Cards: " + OutPC + ", TOTAL: " + PlayerCards.Count
       + "\nComputer Cards: " + OutCC + ", TOTAL: " + ComputerCards.Count + "\nDraw Deck: " + DrawDeck.Count);
            Console.WriteLine("\nSTATISTICS: \nNumber of hands played: " + Hands + "\nHands Won by Player: " + Pwins
                + ", Player Win rate: " + Math.Round(PwinRate, 2) + "%\nHands Won by Computer: " + Cwins + ", Computer Win rate: "
                + Math.Round(CwinRate, 2) + "%,\nDraws: " + Draws + ", Draw rate: " + Math.Round(DrawRate, 2) + "%");
            Console.WriteLine("Initial value of a Player cards: " + Program.variables.PlayerValue + ", computer cards: "+ Program.variables.ComputerValue+".");
            if (Program.variables.PlayerValue > Program.variables.ComputerValue && Winner == "Player  ") Console.WriteLine("Won higher card value configuration");
            else if (Program.variables.ComputerValue > Program.variables.PlayerValue && Winner == "Computer") Console.WriteLine("Won higher card value configuration");
            else Console.WriteLine("Won lower card value configuration");

            string SHands = Program.ChangeType(Hands);
            string SPwins = Program.ChangeType(Pwins);
            string SCwins = Program.ChangeType(Cwins);
            string SDraws = Program.ChangeType(Draws);
            Program.variables.ScoreTab[Program.variables.iter, 0] = SHands;
            Program.variables.ScoreTab[Program.variables.iter, 1] = Winner;
            Program.variables.ScoreTab[Program.variables.iter, 2] = SPwins;
            Program.variables.ScoreTab[Program.variables.iter, 3] = SCwins;
            Program.variables.ScoreTab[Program.variables.iter, 4] = SDraws;
        }
    }
}
