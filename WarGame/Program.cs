using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            loop();
        }
        private static void loop() //main loop to steer menu
        {
            int select = 0;
            do
            { // Main loop
                Menu.Menu_display();  //Menu display
                try
                {
                    select = ChangeType(Console.ReadLine());
                }
                catch
                {
                    select = 9;
                } // checks if provided variable is number
                switch (select)
                {
                    case 1:
                        Menu.Case1();
                        break;
                    case 2:
                        variables.num = 0;
                        Console.WriteLine("How many games do you want to simulate? (1-100)");
                        try
                        {
                            variables.num = ChangeType(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Please give number.");
                            Console.ReadKey();
                            break;
                        }
                        if (variables.num < 1 || variables.num > 100)
                        {
                            Console.WriteLine("Please give number from 1 to 100.");
                            Console.ReadKey();
                            break;
                        }
                        Menu.Case2();
                        break;
                    case 3:
                        Menu.Case3();
                        break;
                    case 0:
                        break;
                    case 9: //error handling
                        Console.WriteLine("\nERROR! Please select number!");
                        Menu.Cont();
                        break;
                    default:
                        Console.WriteLine("No available option");
                        Console.ReadKey();
                        break;
                }
            }
            while (select != 0);
        }
        public static class variables  //some variables used in other methods
        {
            public static int num = 0;
            public static int iter = 0;
            public static string[,] ScoreTab = new string[100, 5];
            public static int Pwins = 0;
            public static int Cwins = 0;
            public static int PlayerValue = 0;
            public static int ComputerValue = 0;
            public enum Winner
            { Computer = 1, Player = 2 };
            public static bool Debug = false;
        }
        public static void War()       //Single War method
        {
            string OutCC, OutPC, OutDD, Winner;
            OutCC = OutPC = OutDD = Winner = "";
            double Pwins, Cwins, Draws;
            Pwins = Cwins = Draws = 0;
            int Hands, DrawNumber, CCrand, PCrand, DrawCCrand, DrawPCrand, DrawCount;
            Hands = DrawNumber = CCrand = PCrand = DrawCCrand = DrawPCrand = DrawCount = 0;
            Random rand = new Random();
            Random ran = new Random();
            List<Card> PlayerCards = new List<Card>();
            List<Card> ComputerCards = new List<Card>();
            List<Card> DrawDeck = new List<Card>();
            List<Card> Deck = new List<Card>();
            DeckCreation.HeartsCreation(Deck);
            DeckCreation.DiamondsCreation(Deck);
            DeckCreation.ClubsCreation(Deck);
            DeckCreation.SpadesCreation(Deck);
            DeckCreation.CardDistribution(Deck, ComputerCards, PlayerCards, ran);
            foreach (Card PC in PlayerCards) OutPC = OutPC + " " + PC.Code;
            foreach (Card CC in ComputerCards) OutCC = OutCC + " " + CC.Code;
            Console.WriteLine("INITIAL CARD SETUP\nPlayer Cards: " + OutPC + "\nComputer Cards: " + OutCC
                + "\nOverall number of Player Cards: " + PlayerCards.Count + "\nOverall number of Computer Cards: "
                + ComputerCards.Count + "\nPlayer card value: "+ variables.PlayerValue + ", Copmuter cards value: "+ variables.ComputerValue + "\n[Press Any Key]");
            if (variables.num == 0) Console.ReadKey();
            while ((PlayerCards.Count > 0) && (ComputerCards.Count > 0))
            {
                if ((PlayerCards.Count == 0) || (ComputerCards.Count == 0)) break;
                Hands++;
                if (DrawNumber > 0) Game.Draw(DrawCCrand, DrawPCrand, DrawNumber, DrawDeck, ComputerCards, PlayerCards, rand);
                if ((PlayerCards.Count == 0) || (ComputerCards.Count == 0)) break;
                CCrand = rand.Next(ComputerCards.Count);
                PCrand = rand.Next(PlayerCards.Count);
                if (PlayerCards[PCrand].Value > ComputerCards[CCrand].Value)
                    Game.BattleWin(PCrand, CCrand, DrawCount, ref DrawNumber, ref Pwins, DrawDeck, ComputerCards, PlayerCards);
                else if (PlayerCards[PCrand].Value == ComputerCards[CCrand].Value)
                    Game.BattleDraw(PCrand, CCrand, ref DrawNumber, ref Draws, DrawDeck, ComputerCards, PlayerCards);
                else
                    Game.BattleLoose(PCrand, CCrand, ref DrawNumber, DrawCount, ref Cwins, DrawDeck, ComputerCards, PlayerCards);
                if (variables.Debug == true)
                {
                    OutPC = OutCC = OutDD = "";
                    foreach (Card PC in PlayerCards) OutPC = OutPC + " " + PC.Code;
                    foreach (Card CC in ComputerCards) OutCC = OutCC + " " + CC.Code;
                    foreach (Card DD in DrawDeck) OutDD = OutDD + " " + DD.Code;
                    Console.WriteLine("Player Cards: " + OutPC + ", TOTAL: " + PlayerCards.Count + "\nComputer Cards: "
                       + OutCC + ", TOTAL: " + ComputerCards.Count + "\nDraw Deck: " + OutDD + ", Total: " + DrawDeck.Count + "\n\n");
                }
            }
            OutPC = OutCC = OutDD = "";
            foreach (Card PC in PlayerCards) OutPC = OutPC + " " + PC.Code;
            foreach (Card CC in ComputerCards) OutCC = OutCC + " " + CC.Code;
            double PwinRate, CwinRate, DrawRate;
            PwinRate = CwinRate = DrawRate = 0;
            Game.WinnerDeclaration(ref Winner, ref PwinRate, ref CwinRate, ref DrawRate, ref Pwins, 
                ref Cwins, ref Draws, ref Hands, PlayerCards);
            Game.Statistics(ref OutPC, ref OutCC, ref Winner, ref PwinRate, ref CwinRate, ref DrawRate, ref Pwins, ref Cwins, 
                ref Draws, ref Hands, PlayerCards, ComputerCards, DrawDeck);
        }
        public static string ChangeType(int x)    //Polymorphism
        {
            return x.ToString();
        }
        public static string ChangeType(double x) //Polymorphism
        {
            return x.ToString();
        }
        public static int ChangeType(string x)    //Polymorphism
        {
            return int.Parse(x);
        }
    }
}