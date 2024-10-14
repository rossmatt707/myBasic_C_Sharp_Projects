using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleAppSixPart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part One through Three

            // creates boolean variable for loop control
            bool looper1 = false;
            // creates a while loop that will run until stopped
            while (looper1 == false)
            {
                // Create an array of adjectives
                string[] Adjectives = { "Glorious", "Inciteful", "Wholesome", "Paltry", "Forgiving" };
                // Ask the user for their favorite thing
                Console.WriteLine("What is your favorite thing in the world? ");
                // Store the user's input in a variable
                string favoriteThing = Console.ReadLine();

                // Loop through the array of adjectives
                for (int i = 0; i < Adjectives.Length; i++)
                {
                    // Print out the adjective and the user's favorite thing
                    Console.WriteLine(Adjectives[i] + " " + favoriteThing);
                    // Pause the program for half a second
                    Thread.Sleep(500);
                }
                // adding this ends loop after list is done iterating/appending. This stop the infinite loop.
                looper1 = true;
            }

            // Create a variable to store the count
            int count = 0;
            // Create an array of verbs
            string[] Verbs = { "Fast", "Slow", "Espensive", "Cheap", "Incredible" };
            // Ask the user for their favorite activity
            Console.WriteLine("What is your favorite activity to do in the world? ");
            // Store the user's input in a variable
            string favoriteActivity = Console.ReadLine();
            // Loop through the array of verbs
            while (count <= Verbs.Length - 1)
            {
                // Print out the verb and the user's favorite activity
                Console.WriteLine(Verbs[count] + " " + favoriteActivity);
                // Increment the count
                count++;
                // Pause the program for half a second
                Thread.Sleep(500);
            }
            // End of Part One through Three


            // Part Four
            // Create a list of animal strings
            List<string> zooAnimals = new List<string>
            {
                "Cat",
                "Dog",
                "Bird",
                "Fish",
                "Hamster",
                "Snake",
                "Penguin",
                "Elephant",
                "Giraffe",
                "Lion",
                "Tiger",
                "Bear",
                "Zebra",
                "Kangaroo",
                "Rhinoceros",
                "Leopard",
                "Panda",
                "Cheetah",
                "Chimpanzee",
                "Crocodile",
                "Flamingo",
                "Gorilla",
                "Hippo",
                "Koala",
                "Lemur",
                "Meerkat",
                "Ostrich",
                "Peacock",
                "Polar Bear",
                "Raccoon",
                "Red Panda",
                "Sloth",
                "Wolf"
            };
            // Ask the user for their favorite animal
            Console.WriteLine("Enter an animal to search for in our zoo: ");
            // Store the user's input in a variable
            string searchAnimal = Console.ReadLine();
            // Create a boolean variable to store whether the animal was found
            bool matched = false;

            // Loop through the list of animals
            while (matched == false)
            {
                // Check if the user's animal is in the list
                for (int i = 0; i < zooAnimals.Count; i++)
                {
                    // If the animal is found, print out the index
                    if (zooAnimals[i].Equals(searchAnimal, StringComparison.OrdinalIgnoreCase))
                    {
                        // Print out the index of the animal with an additional message.
                        Console.WriteLine("We found your animal! It\'s at index " + i + " in or zoo!");
                        // Set the boolean variable to true and break out of the loop
                        matched = true;
                    }
                }
                // If the animal is not found, ask the user to try again
                if (matched == false)
                {
                    // Print out a message to the user to try again
                    Console.WriteLine("We could not find your animal in our zoo. Please try again.");
                    searchAnimal = Console.ReadLine();
                }
            }
            // Print out a message to the user after finding animal and exiting loop
            Console.WriteLine("\nThanks for visiting the San Diego zoo!");
            Console.ReadLine();



            // Part Five
            // Create a list of animal strings
            List<string> zooAnimals2 = new List<string>
            {
                "Cat", "Dog", "Bird", "Cat", "Fish", "Hippo", "Snake", "Hamster", "Dog", "Snake",
                "Penguin", "Elephant", "Chimpanzee", "Giraffe", "Fish", "Lion", "Cheetah", "Tiger",
                "Penguin", "Bear", "Zebra", "Kangaroo", "Rhinoceros", "Leopard", "Elephant", "Polar Bear",
                "Hamster", "Bird", "Panda", "Cheetah", "Chimpanzee", "Crocodile", "Flamingo", "Gorilla",
                "Meerkat", "Wolf", "Bear", "Zebra", "Flamingo", "Hippo", "Hamster", "Gorilla", "Koala",
                "Lemur", "Meerkat", "Rhinoceros", "Ostrich", "Peacock", "Polar Bear", "Raccoon", "Red Panda",
                "Tiger", "Sloth", "Wolf", "Panda", "Koala", "Lemur", "Meerkat", "Ostrich", "Peacock", "Polar Bear",
            };
            // Ask the user for their favorite animal
            Console.WriteLine("Enter an animal to search for in our zoo: ");
            // Store the user's input in a variable
            string searchAnimal2 = Console.ReadLine();
            // Create a boolean variable to store whether the animal was found
            bool matched2 = false;
            // Create a list to store the found creatures
            List<int> foundCreatures = new List<int>();
            // Loop through the list of animals
            while (matched2 == false)
            {
                // Check if the user's animal is in the list
                for (int i = 0; i < zooAnimals2.Count; i++)
                {
                    // If the animal is found, print out the index. Ignoring case sensitivity.
                    if (zooAnimals2[i].Equals(searchAnimal2, StringComparison.OrdinalIgnoreCase))
                    {
                        // Add the index to the list of found creatures
                        foundCreatures.Add(i);
                        // Set the boolean variable to true and break out of the loop
                        matched2 = true;
                    }
                }

                if (matched2)
                {

                    // Prints out the animal(s) that was found
                    Console.WriteLine($"We found your animal '{searchAnimal2}' in our zoo at the following indices:");
                    // Loop through the list of found creatures
                    foreach (int creature in foundCreatures)
                    {
                        // Print out the index of the animal(s) found
                        Console.WriteLine(creature);
                    }
                }
                else
                {
                    // Print out a message to the user to try again
                    Console.WriteLine("We could not find your animal in our zoo. Please try again.");
                    searchAnimal2 = Console.ReadLine();
                }
            }
            // Print out a message to the user after finding animal and exiting loop
            Console.WriteLine("\nThanks for visiting the Sacramento zoo!");
            Console.ReadLine();




            // Part Six
            // Create a list of animal strings
            List<string> zooAnimals3 = new List<string>
            {
                "Cat", "Dog", "Bird", "Cat", "Fish", "Hippo", "Snake", "Hamster", "Dog", "Snake",
                "Penguin", "Elephant", "Chimpanzee", "Giraffe", "Fish", "Lion", "Cheetah", "Tiger",
                "Penguin", "Bear", "Zebra", "Kangaroo", "Rhinoceros", "Leopard", "Elephant", "Polar Bear",
                "Hamster", "Bird", "Panda", "Cheetah", "Chimpanzee", "Crocodile", "Flamingo", "Gorilla",
                "Meerkat", "Wolf", "Bear", "Zebra", "Flamingo", "Hippo", "Hamster", "Gorilla", "Koala",
                "Lemur", "Meerkat", "Rhinoceros", "Ostrich", "Peacock", "Polar Bear", "Raccoon", "Red Panda",
                "Tiger", "Sloth", "Wolf", "Panda", "Koala", "Lemur", "Meerkat", "Ostrich", "Peacock", "Polar Bear",
            };

            // Create a hash set to store the duplicate animals
            HashSet<string> duplicateAnimals = new HashSet<string>();

            //  Loop through the list of animals
            foreach (string animals3 in zooAnimals3)
            {
                // Check if the animal is a duplicate
                if (duplicateAnimals.Contains(animals3))
                {
                    // Print out the duplicate animal
                    Console.WriteLine($"The animal '{animals3}' is a duplicate in our zoo.");
                    // Pause the program for 200 milliseconds
                    Thread.Sleep(200);
                }
                // If the animal is not a duplicate
                else
                {
                    //  Print out the original animal
                    Console.WriteLine($"The animal '{animals3}' is the original in or zoo.");
                    // Add the animal to the hash set
                    duplicateAnimals.Add(animals3);
                    // Pause the program for 200 milliseconds
                    Thread.Sleep(200);
                }
            }
            Console.ReadLine();
            Console.WriteLine("Thanks for visiting the Detroit zoo!");
        }
    }
}
