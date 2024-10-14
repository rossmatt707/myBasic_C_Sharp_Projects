using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneProject
{
    internal class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            cardOne.Face = "Two";
            cardOne.Suit = "Hearts";
            Cards.Add(cardOne);
        }
        public List<Card> Cards { get; set; }
    }
}
