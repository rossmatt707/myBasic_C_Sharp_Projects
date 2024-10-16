using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission8Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.FirstName = "B";
            employee.LastName = "Rad";
            employee.Id = 1;
            employee.Things = new List<string> { "Badge", "Uniform", "Whole Milk" };

            Employee<int> employee2 = new Employee<int>();
            employee2.FirstName = "Dog";
            employee2.LastName = "Bountyhunter";
            employee2.Id = 2;
            employee2.Things = new List<int> { 1, 2, 3 };

            Console.WriteLine($"{employee.FirstName} {employee.LastName}: Employee #{employee.Id}");
            Console.WriteLine($"The company items in {employee.FirstName}'s possession are:");
            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine($"\n{employee2.FirstName} {employee2.LastName}: Employee #{employee2.Id}");
            Console.WriteLine($"The company integers in {employee2.FirstName}'s possession are:");
            for (int i = 0; i < employee2.Things.Count; i++)
            {
                int thing = employee2.Things[i];
                Console.WriteLine(thing);
            }
        }

        
    }
}
