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
    }
    
}










//Deck deck = new Deck();

//int count = deck.Cards.Count(x => x.Face == Face.Ace);

//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

//List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

//int sum = numberList.Where(x => x > 20).Sum();
//Console.WriteLine(sum);

//foreach (Card card in newList)
//{
//    Console.WriteLine(card.Face + " of " + card.Suit);
//}