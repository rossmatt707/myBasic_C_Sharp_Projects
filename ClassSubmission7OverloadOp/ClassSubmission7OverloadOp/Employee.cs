using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission7OverloadOp
{
    internal class Employee
    {
        public int id { get; set; } // This is the unique identifier for the employee
        public string FirstName { get; set; } // This is the first name of the employee
        public string LastName { get; set; } // This is the last name of the employee

        public static bool operator ==(Employee employee1, Employee employee2) // This is the overloaded equality operator
        {
            if (ReferenceEquals(employee1, employee2)) // If the two objects are the same object, return true
                return true;


            if (employee1 is null || employee2 is null) // If either object is null, return false
                return false;

            return employee1.id == employee2.id; // If the IDs are the same, return true
        }

        public static bool operator !=(Employee employee1, Employee employee2) // This is the overloaded inequality operator
        {
            return employee1.id != employee2.id; // If the IDs are different, return true
        }

        public override bool Equals(object obj) // This is the overridden Equals method
        {
            return this.id == ((Employee)obj).id; // If the IDs are the same, return true
        }

        public override int GetHashCode() // This is the overridden GetHashCode method
        {
            return this.id; // Return the ID
        }
    }
}



// For reference
//public static Game operator +(Game game, Player player)
//{
//    game.Players.Add(player);
//    return game;
//}
//public static Game operator -(Game game, Player player)
//{
//    game.Players.Remove(player);
//    return game;
//}