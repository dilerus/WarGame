using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    interface ICard   //Interface
    {
        void AddToDeck(List<Card> CardDeck, Card ACard);
    }
    public class Card_template : ICard
    {
        public void AddToDeck(List<Card> CardDeck, Card ACard)   //Adding Card object to deck
        {
            CardDeck.Add(ACard);
        }
        public int Value { get; set; }  // Vaule - Queen = 12, King = 13 etc.
        public string Code { get; set; }  // H2 - Hearts 2, CQ - Clubs Queen, SJ - Spades Jack, DK - Diamond King
    }
    public class Card : Card_template
    {
        
    }
}
