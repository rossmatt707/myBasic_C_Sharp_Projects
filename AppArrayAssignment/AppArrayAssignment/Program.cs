using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define check1 for the first while loop
            bool check1 = false;
            // define string array
            string[] stringArray1 = { "My", "Name", "Is", "Teddy", "And", "I", "Like", "Jujubes" };
            // while loop to check if the input is a number between 0 and 7
            while (check1 == false)
            {
                // ask the user to enter a number between 0 and 7
                Console.WriteLine("Please enter a number between 0 and 7: ");
                // read the input
                string input1 = Console.ReadLine();
                // check if the input is empty
                if (string.IsNullOrWhiteSpace(input1))
                {
                    // if the input is empty, ask the user to try again
                    Console.WriteLine("Input can\'t be empty. Please try again.");
                    // continue the loop
                    continue;
                }
                // convert the input to an integer
                int inputInt = Convert.ToInt32(input1);
                // check if the input is an integer
                if (int.TryParse(input1, out inputInt))
                {
                    // check if the input is between 0 and 7
                    if (inputInt >= 0 && inputInt <= 7)
                    {
                        // print the string at the index of the input
                        Console.WriteLine(stringArray1[inputInt]);
                        // wait for the user to press enter
                        Console.ReadLine();
                        // break the loop
                        break;
                    }
                }
                else
                {
                    // if the input is not an integer, ask the user to try again
                    Console.WriteLine("Again... Please enter a number between 0 and 7");
                }
            }


            // Pretty much the same as the first while loop with int in array instead of strings
            bool check2 = false;
            int[] numArray = { 8, 16, 24, 32, 40, 48, 56 };

            while (check2 == false) 
            {
                Console.WriteLine("Please enter a number between 0 and 6: ");
                string input2 = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input2))
                {
                    Console.WriteLine("Input can\'t be empty. Please try again.");
                    continue;
                }
                int inputInt2 = Convert.ToInt32(input2);
                if (int.TryParse(input2, out inputInt2))
                {
                    if (inputInt2 >= 0 && inputInt2 <= 7)
                    {
                        Console.WriteLine(stringArray1[inputInt2]);
                        Console.ReadLine();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Again... Please enter a number between 0 and 6");
                }
            }
            // End of second array

            // Same structure as first two but using a list instead of an array
            bool check3 = false;
            List<string> stringList = new List<string> { "You", "Can\'t", "Handle", "The", "Truth!" };

            while (check3 == false)
            {
                Console.WriteLine("Please enter a number between 0 and 4: ");
                string input3 = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input3))
                {
                    Console.WriteLine("Input can\'t be empty. Please try again.");
                    continue;
                }
                int inputInt3 = Convert.ToInt32(input3);
                if (int.TryParse(input3, out inputInt3))
                {
                    if (inputInt3 >= 0 && inputInt3 <= 7)
                    {
                        Console.WriteLine(stringList[inputInt3]);
                        Console.ReadLine();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Again... Please enter a number between 0 and 4");
                }  
            }
            // End of list
        }
    }
}











//using System;
//using System.Collections.Generic;

//namespace ArraysAndListsVideo
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            List<int> intList = new List<int>();
//            intList.Add("Hello");
//            intList.Add("Jesse");
//            intList.Remove("Jesse");

//            Console.WriteLine(intList[0]);
//            Console.ReadLine();

//            byte[] byteArray = new byte[5000];
//int[] numArray = new int[5];
//numArray[0] = 5;
//numArray[1] = 2;
//numArray[2] = 10;
//numArray[3] = 200;
//numArray[4] = 500;

//int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

//int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

//numArray2[5] = 650;

//Console.WriteLine(numArray2[5]);
//Console.ReadLine();
//        }
//    }
//}
