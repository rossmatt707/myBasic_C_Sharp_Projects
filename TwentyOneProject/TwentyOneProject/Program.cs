using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneProject
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card Card in deck.Cards)
            {
                Console.WriteLine(Card.Face + " of " + Card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

    }
}
