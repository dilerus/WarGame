using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    public class DeckCreation
    {
        public static void OneCardCreation(string Cod, int Val, Card Card, List<Card> Dec)
        {
            Card.Value = Val;
            Card.Code = Cod;
            Card.AddToDeck(Dec, Card);
        }
        public static void HeartsCreation(List<Card> Deck)
        {
            Card H2 = new Card();
            Card H3 = new Card();
            Card H4 = new Card();
            Card H5 = new Card();
            Card H6 = new Card();
            Card H7 = new Card();
            Card H8 = new Card();
            Card H9 = new Card();
            Card H10 = new Card();
            Card HJ = new Card();
            Card HQ = new Card();
            Card HK = new Card();
            Card HA = new Card();
            OneCardCreation("H2", 2, H2, Deck);
            OneCardCreation("H3", 3, H3, Deck);
            OneCardCreation("H4", 4, H4, Deck);
            OneCardCreation("H5", 5, H5, Deck);
            OneCardCreation("H6", 6, H6, Deck);
            OneCardCreation("H7", 7, H7, Deck);
            OneCardCreation("H8", 8, H8, Deck);
            OneCardCreation("H9", 9, H9, Deck);
            OneCardCreation("H10", 10, H10, Deck);
            OneCardCreation("HJ", 11, HJ, Deck);
            OneCardCreation("HQ", 12, HQ, Deck);
            OneCardCreation("HK", 13, HK, Deck);
            OneCardCreation("HA", 14, HA, Deck);
        }
        public static void DiamondsCreation(List<Card> Deck)
        {
            Card D2 = new Card();
            Card D3 = new Card();
            Card D4 = new Card();
            Card D5 = new Card();
            Card D6 = new Card();
            Card D7 = new Card();
            Card D8 = new Card();
            Card D9 = new Card();
            Card D10 = new Card();
            Card DJ = new Card();
            Card DQ = new Card();
            Card DK = new Card();
            Card DA = new Card();
            Card HA = new Card();
            OneCardCreation("D2", 2, D2, Deck);
            OneCardCreation("D3", 3, D3, Deck);
            OneCardCreation("D4", 4, D4, Deck);
            OneCardCreation("D5", 5, D5, Deck);
            OneCardCreation("D6", 6, D6, Deck);
            OneCardCreation("D7", 7, D7, Deck);
            OneCardCreation("D8", 8, D8, Deck);
            OneCardCreation("D9", 9, D9, Deck);
            OneCardCreation("D10", 10, D10, Deck);
            OneCardCreation("DJ", 11, DJ, Deck);
            OneCardCreation("DQ", 12, DQ, Deck);
            OneCardCreation("DK", 13, DK, Deck);
            OneCardCreation("DA", 14, DA, Deck);
        }
        public static void ClubsCreation(List<Card> Deck)
        {
            Card C2 = new Card();
            Card C3 = new Card();
            Card C4 = new Card();
            Card C5 = new Card();
            Card C6 = new Card();
            Card C7 = new Card();
            Card C8 = new Card();
            Card C9 = new Card();
            Card C10 = new Card();
            Card CJ = new Card();
            Card CQ = new Card();
            Card CK = new Card();
            Card CA = new Card();
            OneCardCreation("C2", 2, C2, Deck);
            OneCardCreation("C3", 3, C3, Deck);
            OneCardCreation("C4", 4, C4, Deck);
            OneCardCreation("C5", 5, C5, Deck);
            OneCardCreation("C6", 6, C6, Deck);
            OneCardCreation("C7", 7, C7, Deck);
            OneCardCreation("C8", 8, C8, Deck);
            OneCardCreation("C9", 9, C9, Deck);
            OneCardCreation("C10", 10, C10, Deck);
            OneCardCreation("CJ", 11, CJ, Deck);
            OneCardCreation("CQ", 12, CQ, Deck);
            OneCardCreation("CK", 13, CK, Deck);
            OneCardCreation("CA", 14, CA, Deck);
        }
        public static void SpadesCreation(List<Card> Deck)
        {
            Card S2 = new Card();
            Card S3 = new Card();
            Card S4 = new Card();
            Card S5 = new Card();
            Card S6 = new Card();
            Card S7 = new Card();
            Card S8 = new Card();
            Card S9 = new Card();
            Card S10 = new Card();
            Card SJ = new Card();
            Card SQ = new Card();
            Card SK = new Card();
            Card SA = new Card();
            OneCardCreation("S2", 2, S2, Deck);
            OneCardCreation("S3", 3, S3, Deck);
            OneCardCreation("S4", 4, S4, Deck);
            OneCardCreation("S5", 5, S5, Deck);
            OneCardCreation("S6", 6, S6, Deck);
            OneCardCreation("S7", 7, S7, Deck);
            OneCardCreation("S8", 8, S8, Deck);
            OneCardCreation("S9", 9, S9, Deck);
            OneCardCreation("S10", 10, S10, Deck);
            OneCardCreation("SJ", 11, SJ, Deck);
            OneCardCreation("SQ", 12, SQ, Deck);
            OneCardCreation("SK", 13, SK, Deck);
            OneCardCreation("SA", 14, SA, Deck);
        }
        public static void CardDistribution(List<Card> Deck, List<Card> ComputerCards, List<Card> PlayerCards, Random ran)
        {
            int SteringVar = Deck.Count;
            Program.variables.PlayerValue = 0;
            Program.variables.ComputerValue = 0;

            for (int i = 0; i < SteringVar; i++)
            {
                int g = ran.Next(Deck.Count);
                if (PlayerCards.Count < ComputerCards.Count)
                {
                   Program.variables.PlayerValue += Deck[g].Value;
                    PlayerCards.Add(Deck[g]);
                }
                else
                {
                    Program.variables.ComputerValue += Deck[g].Value;
                    ComputerCards.Add(Deck[g]);
                }
                Deck.Remove(Deck[g]);
            }
        }
    }
}
