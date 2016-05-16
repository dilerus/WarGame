using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WarGame
{
    class Program
    {
        public static void war()
        {
            
           // Console.WriteLine(zmienne.num);
            Random rand = new Random();

            bool Debug = false;

            List<Card> PlayerCards = new List<Card>();
            List<Card> ComputerCards = new List<Card>();
            List<Card> DrawDeck = new List<Card>();
            List<Card> Deck = new List<Card>();


            Card H2 = new Card();
            H2.Value = 2;
            H2.Code = "H2";
            Deck.Add(H2);

            Card H3 = new Card();
            H3.Value = 3;
            H3.Code = "H3";
            Deck.Add(H3);

            Card H4 = new Card();
            H4.Value = 4;
            H4.Code = "H4";
            Deck.Add(H4);

            Card H5 = new Card();
            H5.Value = 5;
            H5.Code = "H5";
            Deck.Add(H5);

            Card H6 = new Card();
            H6.Value = 6;
            H6.Code = "H6";
            Deck.Add(H6);

            Card H7 = new Card();
            H7.Value = 7;
            H7.Code = "H7";
            Deck.Add(H7);

            Card H8 = new Card();
            H8.Value = 8;
            H8.Code = "H8";
            Deck.Add(H8);

            Card H9 = new Card();
            H9.Value = 9;
            H9.Code = "H9";
            Deck.Add(H9);

            Card H10 = new Card();
            H10.Value = 10;
            H10.Code = "H10";
            Deck.Add(H10);

            Card HJ = new Card();
            HJ.Value = 11;
            HJ.Code = "HJ";
            Deck.Add(HJ);

            Card HQ = new Card();
            HQ.Value = 12;
            HQ.Code = "HQ";
            Deck.Add(HQ);

            Card HK = new Card();
            HK.Value = 13;
            HK.Code = "HK";
            Deck.Add(HK);

            Card HA = new Card();
            HA.Value = 14;
            HA.Code = "HA";
            Deck.Add(HA);




            Card D2 = new Card();
            D2.Value = 2;
            D2.Code = "D2";
            Deck.Add(D2);

            Card D3 = new Card();
            D3.Value = 3;
            D3.Code = "D3";
            Deck.Add(D3);

            Card D4 = new Card();
            D4.Value = 4;
            D4.Code = "D4";
            Deck.Add(D4);

            Card D5 = new Card();
            D5.Value = 5;
            D5.Code = "D5";
            Deck.Add(D5);

            Card D6 = new Card();
            D6.Value = 6;
            D6.Code = "D6";
            Deck.Add(D6);

            Card D7 = new Card();
            D7.Value = 7;
            D7.Code = "D7";
            Deck.Add(D7);

            Card D8 = new Card();
            D8.Value = 8;
            D8.Code = "D8";
            Deck.Add(D8);

            Card D9 = new Card();
            D9.Value = 9;
            D9.Code = "D9";
            Deck.Add(D9);

            Card D10 = new Card();
            D10.Value = 10;
            D10.Code = "D10";
            Deck.Add(D10);

            Card DJ = new Card();
            DJ.Value = 11;
            DJ.Code = "DJ";
            Deck.Add(DJ);

            Card DQ = new Card();
            DQ.Value = 12;
            DQ.Code = "DQ";
            Deck.Add(DQ);

            Card DK = new Card();
            DK.Value = 13;
            DK.Code = "DK";
            Deck.Add(DK);

            Card DA = new Card();
            DA.Value = 14;
            DA.Code = "DA";
            Deck.Add(DA);




            Card C2 = new Card();
            C2.Value = 2;
            C2.Code = "C2";
            Deck.Add(C2);

            Card C3 = new Card();
            C3.Value = 3;
            C3.Code = "C3";
            Deck.Add(C3);

            Card C4 = new Card();
            C4.Value = 4;
            C4.Code = "C4";
            Deck.Add(C4);

            Card C5 = new Card();
            C5.Value = 5;
            C5.Code = "C5";
            Deck.Add(C5);

            Card C6 = new Card();
            C6.Value = 6;
            C6.Code = "C6";
            Deck.Add(C6);

            Card C7 = new Card();
            C7.Value = 7;
            C7.Code = "C7";
            Deck.Add(C7);

            Card C8 = new Card();
            C8.Value = 8;
            C8.Code = "C8";
            Deck.Add(C8);

            Card C9 = new Card();
            C9.Value = 9;
            C9.Code = "C9";
            Deck.Add(C9);

            Card C10 = new Card();
            C10.Value = 10;
            C10.Code = "C10";
            Deck.Add(C10);

            Card CJ = new Card();
            CJ.Value = 11;
            CJ.Code = "CJ";
            Deck.Add(CJ);

            Card CQ = new Card();
            CQ.Value = 12;
            CQ.Code = "CQ";
            Deck.Add(CQ);

            Card CK = new Card();
            CK.Value = 13;
            CK.Code = "CK";
            Deck.Add(CK);

            Card CA = new Card();
            CA.Value = 14;
            CA.Code = "CA";
            Deck.Add(CA);




            Card S2 = new Card();
            S2.Value = 2;
            S2.Code = "S2";
            Deck.Add(S2);

            Card S3 = new Card();
            S3.Value = 3;
            S3.Code = "S3";
            Deck.Add(S3);

            Card S4 = new Card();
            S4.Value = 4;
            S4.Code = "S4";
            Deck.Add(S4);

            Card S5 = new Card();
            S5.Value = 5;
            S5.Code = "S5";
            Deck.Add(S5);

            Card S6 = new Card();
            S6.Value = 6;
            S6.Code = "S6";
            Deck.Add(S6);

            Card S7 = new Card();
            S7.Value = 7;
            S7.Code = "S7";
            Deck.Add(S7);

            Card S8 = new Card();
            S8.Value = 8;
            S8.Code = "S8";
            Deck.Add(S8);

            Card S9 = new Card();
            S9.Value = 9;
            S9.Code = "S9";
            Deck.Add(S9);

            Card S10 = new Card();
            S10.Value = 10;
            S10.Code = "S10";
            Deck.Add(S10);

            Card SJ = new Card();
            SJ.Value = 11;
            SJ.Code = "SJ";
            Deck.Add(SJ);

            Card SQ = new Card();
            SQ.Value = 12;
            SQ.Code = "SQ";
            Deck.Add(SQ);

            Card SK = new Card();
            SK.Value = 13;
            SK.Code = "SK";
            Deck.Add(SK);

            Card SA = new Card();
            SA.Value = 14;
            SA.Code = "SA";
            Deck.Add(SA);




            Random ran = new Random();
            int SteringVar = Deck.Count;
            for (int i = 0; i < SteringVar; i++)
            {
                int g = ran.Next(Deck.Count);
                if (PlayerCards.Count < ComputerCards.Count)
                {
                    PlayerCards.Add(Deck[g]);
                }
                else
                {
                    ComputerCards.Add(Deck[g]);
                }
                Deck.Remove(Deck[g]);
            }


            // List<Card> PlayerCards = new List<Card>();
            //ListingCards();
            string OutPC = "";
            string OutCC = "";
            string OutDD = "";

            foreach (Card PC in PlayerCards)
            {
                OutPC = OutPC + " " + PC.Code;
            }

            foreach (Card CC in ComputerCards)
            {
                OutCC = OutCC + " " + CC.Code;
            }

             Console.WriteLine("INITIAL CARD SETUP\nPlayer Cards: " + OutPC + "\nComputer Cards: " + OutCC + "\nOverall number of Player Cards: " + PlayerCards.Count + "\nOverall number of Computer Cards: " + ComputerCards.Count + "\n\n[Press Any Key]");
            if (zmienne.num == 0) Console.ReadKey();


            int Hands = 0;
            double Pwins = 0;
            double Cwins = 0;
            double Draws = 0;
            int DrawNumber = 0;
            int CCrand = 0;
            int PCrand = 0;
            int DrawCCrand = 0;
            int DrawPCrand = 0;
            int DrawCount;

            //for (int i = 0; i < 100; i++)
            while ((PlayerCards.Count > 0) && (ComputerCards.Count > 0))
            {
                if (PlayerCards.Count == 0) break;
                if (ComputerCards.Count == 0) break;
                Hands++;

                if (DrawNumber > 0)
                {
                    if (Debug == true) Console.WriteLine("DrawNumber = " + DrawNumber);
                    DrawCCrand = rand.Next(ComputerCards.Count);
                    DrawPCrand = rand.Next(PlayerCards.Count);
                    if (Debug == true) Console.WriteLine("Because of Draw, Player is risking " + PlayerCards[DrawPCrand].Code + " card and Computer is risking " + ComputerCards[DrawCCrand].Code);
                    DrawDeck.Add(ComputerCards[DrawCCrand]);
                    if (Debug == true) Console.WriteLine("Adding " + ComputerCards[DrawCCrand].Code + " to DrawDeck");
                    DrawDeck.Add(PlayerCards[DrawPCrand]);
                    if (Debug == true) Console.WriteLine("Adding " + PlayerCards[DrawPCrand].Code + " to DrawDeck");
                    ComputerCards.Remove(ComputerCards[DrawCCrand]);
                    PlayerCards.Remove(PlayerCards[DrawPCrand]);
                }

                if (PlayerCards.Count == 0) break;
                if (ComputerCards.Count == 0) break;

                CCrand = rand.Next(ComputerCards.Count);
                PCrand = rand.Next(PlayerCards.Count);

                if (PlayerCards[PCrand].Value > ComputerCards[CCrand].Value)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Player Card: " + PlayerCards[PCrand].Code + "(value " + PlayerCards[PCrand].Value + ") wins with Computer Card: " + ComputerCards[CCrand].Code + "(value " + ComputerCards[CCrand].Value + ")");
                    Console.ResetColor();
                    PlayerCards.Add(ComputerCards[CCrand]);
                    ComputerCards.Remove(ComputerCards[CCrand]);
                    if (DrawNumber > 0)
                    {
                        DrawCount = DrawDeck.Count;
                        for (int i = 0; i < DrawCount; i++)
                        {
                            if (Debug == true) Console.WriteLine("Adding do PlayerCards: " + DrawDeck[i].Code);
                            PlayerCards.Add(DrawDeck[i]);

                        }
                        for (int i = DrawCount - 1; i >= 0; i--)
                        {
                            if (Debug == true) Console.WriteLine("Removing from DrawDeck: " + DrawDeck[i].Code);
                            DrawDeck.Remove(DrawDeck[i]);
                        }
                        DrawNumber = 0;
                    }

                    Pwins++;
                }
                else if (PlayerCards[PCrand].Value == ComputerCards[CCrand].Value)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Player Card: " + PlayerCards[PCrand].Code + "(value " + PlayerCards[PCrand].Value + ") drawed with Computer Card: " + ComputerCards[CCrand].Code + "(value " + ComputerCards[CCrand].Value + ")");
                    Console.ResetColor();
                    if (Debug == true) Console.WriteLine("Adding do DrawDeck: " + PlayerCards[PCrand].Code);
                    if (Debug == true) Console.WriteLine("Adding do DrawDeck: " + ComputerCards[CCrand].Code);
                    DrawDeck.Add(PlayerCards[PCrand]);
                    DrawDeck.Add(ComputerCards[CCrand]);
                    PlayerCards.Remove(PlayerCards[PCrand]);
                    ComputerCards.Remove(ComputerCards[CCrand]);
                    DrawNumber++;
                    Draws++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Player Card: " + PlayerCards[PCrand].Code + "(value " + PlayerCards[PCrand].Value + ") looses with Computer Card: " + ComputerCards[CCrand].Code + "(value " + ComputerCards[CCrand].Value + ")");
                    Console.ResetColor();
                    ComputerCards.Add(PlayerCards[PCrand]);

                    if (DrawNumber > 0)
                    {
                        DrawCount = DrawDeck.Count;
                        for (int i = 0; i < DrawCount; i++)
                        {
                            if (Debug == true) Console.WriteLine("Adding do ComputerCards: " + DrawDeck[i].Code);
                            ComputerCards.Add(DrawDeck[i]);
                        }
                        for (int i = DrawCount - 1; i >= 0; i--)
                        {
                            if (Debug == true) Console.WriteLine("Removing from DrawDeck: " + DrawDeck[i].Code);
                            DrawDeck.Remove(DrawDeck[i]);
                        }
                        DrawNumber = 0;
                    }
                    PlayerCards.Remove(PlayerCards[PCrand]);
                    Cwins++;
                }

                OutPC = "";
                OutCC = "";
                OutDD = "";
                foreach (Card PC in PlayerCards)
                {
                    OutPC = OutPC + " " + PC.Code;
                }

                foreach (Card CC in ComputerCards)
                {
                    OutCC = OutCC + " " + CC.Code;
                }

                foreach (Card DD in DrawDeck)
                {
                    OutDD = OutDD + " " + DD.Code;
                }
                if (Debug == true) Console.WriteLine("Player Cards: " + OutPC + ", TOTAL: " + PlayerCards.Count + "\nComputer Cards: " + OutCC + ", TOTAL: " + ComputerCards.Count + "\nDraw Deck: " + OutDD + ", Total: " + DrawDeck.Count + "\n\n");

            }


            OutPC = "";
            OutCC = "";
            OutDD = "";
            foreach (Card PC in PlayerCards)
            {
                OutPC = OutPC + " " + PC.Code;
            }

            foreach (Card CC in ComputerCards)
            {
                OutCC = OutCC + " " + CC.Code;
            }


            string Winner = "";
            Console.WriteLine("\n");

            if (PlayerCards.Count == 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Winner = "Computer";
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Winner = "Player  ";
            }

            double PwinRate = Pwins / (Hands) * 100;
            double CwinRate = Cwins / (Hands) * 100;
            double DrawRate = Draws / (Hands) * 100;


            Console.WriteLine("WINNER: " + Winner);
            Console.ResetColor();
            if (Debug == true) Console.WriteLine("\nPlayer Cards: " + OutPC + ", TOTAL: " + PlayerCards.Count + "\nComputer Cards: " + OutCC + ", TOTAL: " + ComputerCards.Count + "\nDraw Deck: " + DrawDeck.Count);
            Console.WriteLine("\nSTATISTICS: \nNumber of hands played: " + Hands + "\nHands Won by Player: " + Pwins + ", Player Win rate: " + Math.Round(PwinRate, 2) + "%\nHands Won by Computer: " + Cwins + ", Computer Win rate: " + Math.Round(CwinRate, 2) + "%,\nDraws: " + Draws + ", Draw rate: " + Math.Round(DrawRate, 2) + "%");
            string SHands = Hands.ToString();
            zmienne.ScoreTab[zmienne.iter, 0] = SHands;
            zmienne.ScoreTab[zmienne.iter, 1] = Winner;
            string SPwins = Pwins.ToString();
            zmienne.ScoreTab[zmienne.iter, 2] = SPwins;
            string SCwins = Cwins.ToString();
            zmienne.ScoreTab[zmienne.iter, 3] = SCwins;
            string SDraws = Draws.ToString();
            zmienne.ScoreTab[zmienne.iter, 4] = SDraws;
        }

        public static class zmienne
        {
            public static int num = 0;
            public static int iter = 0;
            public static string[,] ScoreTab = new string[100,5];
        }

        public static void Main(string[] args)
        {
            
            int select = 0;
            
            do
            { // Glowna petla

                Menu.Menu_display();  //Wyswietal pozycje menu

               // Console.WriteLine("++++" + select);
                try
                {
                    select = int.Parse(Console.ReadLine()); //wybór w menu
                    Console.Clear(); // reset ekranu dla nowego menu
                }

                catch
                {
                    Console.WriteLine("Please select number!");
                    select = 9;
                } // sprawdza, czy użyliśmy cyfro do wyboru w menu


               // Console.WriteLine("-------"+select);



                switch (select) // sterowanie menu
                {
                    case 1:
                        war();
                        Menu.kont();
                        Console.Clear();
                        break;



                    case 2: //Dodawanie numeru 
                         
                        Console.WriteLine("How many games do you want to simulate?");
                                               
                        try
                        {
                           zmienne.num = int.Parse(Console.ReadLine());
                           // Console.Clear();
                        }
                        catch
                        {
                            Console.WriteLine("Please give number");
                            //select = 9;
                        }

                        
                        for (zmienne.iter = 0; zmienne.iter < zmienne.num; zmienne.iter++)
                        {
                            war();
                            //Console.WriteLine(zmienne.ScoreTab[0, 2]);
                        }

                        // foreach (string item in zmienne.ScoreTab)
                        //{

                        //}

                        Console.Clear();
                        Console.WriteLine("Played hands  |  Winner    |  Hands won by Player  |  Hands won by Computer  |  Draws\n------------------------------------------------------------------------------------------");
                        for (int i = 0; i < zmienne.num; i++)
                        {
                            //Console.WriteLine(item);
                           if (zmienne.ScoreTab[i,1] == "Computer") Console.BackgroundColor = ConsoleColor.DarkRed;
                           else Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(zmienne.ScoreTab[i, 0]+"           |  " +zmienne.ScoreTab[i, 1] + "  |    " + zmienne.ScoreTab[i, 2] + "                  |  " + zmienne.ScoreTab[i, 3] + "                     | " + zmienne.ScoreTab[i, 4]);
                            Console.ResetColor();
                            // Console.WriteLine(zmienne.ScoreTab[i, 3]);
                        }
                       

                        Menu.kont();
                        Console.Clear();
                        break;

                    case 0:
                       // Console.WriteLine("Naciśnij dowolny przycisk, aby zakończyć działanie programu...");
                        //Console.ReadKey();
                        break; // koniec dodawania numeru


                    case 9: // wykrycie błędu
                        Console.WriteLine("");
                        Console.WriteLine("Błąd podczas wpisywania wartości...");
                         Menu.kont();
                        Console.ReadKey();
                        break; //koniec wykrycia błędu

                    default:
                        Console.WriteLine("Brak wybranej opcji");
                        Console.ReadKey();
                        break;
                }



            }

            while (select != 0); // koniec głowniej petli




































































































            // Console.WriteLine("======= WAR GAME =======\n\nINITIAL SETUP\nPlayer Cards: " + OutPC + "\nComputer Cards: " + OutCC + "\nOverall number of Player Cards: " + PlayerCards.Count + "\nOverall number of Computer Cards: " + ComputerCards.Count + "\n\nSTART? [Press Any Key]");
            //   Console.ReadKey();

            //  Console.WriteLine("\n\nGAME LOG:");
            



           



            //Console.WriteLine(PlayerCards[1]);
        }

        public void ListingCards()
        {

            //Console.ReadKey();
        }


    }
}
