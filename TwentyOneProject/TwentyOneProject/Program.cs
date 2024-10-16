﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOneProject
{
    internal class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to play a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }
    }
    
}




//string text = "Here is some text.";
//File.WriteAllText(@"D:\Basic_C#_Programs\TwentyOneProject\TwentyOneProject\log.txt", text);
//File.ReadAllText(@"D:\Basic_C#_Programs\TwentyOneProject\TwentyOneProject\log.txt");





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




//DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
//DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

//TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;
