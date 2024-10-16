using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create list of ten employees
            List<Employee> employees = new List<Employee>
            {
                new Employee() { ID = 1, FirstName = "John", LastName = "Cakes" },
                new Employee() { ID = 2, FirstName = "Joe", LastName = "Bakes" },
                new Employee() { ID = 3, FirstName = "Cole", LastName = "Rakes" },
                new Employee() { ID = 4, FirstName = "Joe", LastName = "Smith" },
                new Employee() { ID = 5, FirstName = "Max", LastName = "Martin" },
                new Employee() { ID = 6, FirstName = "Matt", LastName = "Most" },
                new Employee() { ID = 7, FirstName = "Joe", LastName = "Chicago" },
                new Employee() { ID = 8, FirstName = "Jimmy", LastName = "Slims" },
                new Employee() { ID = 9, FirstName = "Randy", LastName = "Roads" },
                new Employee() { ID = 10, FirstName = "Penny", LastName = "Pincher" }
            };

            // Foreach loop
            List<Employee> JoeList = new List<Employee>();

            foreach (Employee employee in employees) // Loop through employees list
            {
                if (employee.FirstName == "Joe") // Check if employee is Joe
                {
                    JoeList.Add(employee); // Add Joe to JoeList if true
                }
            }

            Console.WriteLine("List of Joe's:");// Print JoeList
            foreach (var joe in JoeList) // Loop through JoeList
            {
                Console.WriteLine($"ID: {joe.ID} | Name: {joe.FirstName} {joe.LastName}"); // Print Joe's ID and Name
            }

            // Joe Lambda expression
            List<Employee> JoeListLambda = employees.Where(x => x.FirstName == "Joe").ToList(); // Use Lambda to filter Joe's from employees list

            Console.WriteLine("\nList of Joe's using Lambda:"); // Print JoeListLambda
            foreach (var joe in JoeListLambda) // Loop through JoeListLambda
            {
                Console.WriteLine($"ID: {joe.ID} | Name: {joe.FirstName} {joe.LastName}"); // Print Joe's ID and Name
            }

            List<Employee> IDList = employees.Where(x => x.ID > 5).ToList(); // Use Lambda to filter employees with ID greater than 5
            
            Console.WriteLine("\nList of employees with ID greater than 5 using Lambda:"); // Print IDList
            foreach (var employee in IDList) // Loop through IDList
            {
                Console.WriteLine($"ID: {employee.ID} | Name: {employee.FirstName} {employee.LastName}"); // Print employee's ID and Name
            }

        }
    }
}
