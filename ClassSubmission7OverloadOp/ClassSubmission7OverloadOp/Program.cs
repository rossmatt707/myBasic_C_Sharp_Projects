using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission7OverloadOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(); // Create a new employee object
            employee1.id = 1; // Set the ID of the employee
            employee1.FirstName = "John"; // Set the first name of the employee
            employee1.LastName = "Doe"; // Set the last name of the employee

            Employee employee2 = new Employee(); // Create a new employee object
            employee2.id = 2; // Set the ID of the employee
            employee2.FirstName = "Jane"; // Set the first name of the employee
            employee2.LastName = "Doe"; // Set the last name of the employee

            // Compare the two employee objects using the overloaded equality operator
            Console.WriteLine($"do {employee1.FirstName} and {employee2.FirstName} have the same ID? " + (employee1 == employee2));
            // Compare the two employee objects using the overloaded inequality operator
            Console.WriteLine($"do {employee1.FirstName} and {employee2.FirstName} have different IDs? " + (employee1 != employee2));
            Console.ReadLine();
        }
    }
}



//For reference

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TwentyOneProject
//{
//    internal class Program
//    {

//        static void Main(string[] args)
//        {

//            Game game = new TwentyOneGame();
//            game.Players = new List<Player>();
//            Player player = new Player();
//            player.Name = "Jesse";
//            game += player;
//            game -= player;

//            Deck deck = new Deck();
//            deck.Shuffle(3);

//            foreach (Card card in deck.Cards)
//            {
//                Console.WriteLine(card.Face + " of " + card.Suit);
//            }
//            Console.WriteLine(deck.Cards.Count);
//            Console.ReadLine();
//        }

//    }
//}
