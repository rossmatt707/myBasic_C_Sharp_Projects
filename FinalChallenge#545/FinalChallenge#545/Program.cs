using FinalChallenge_545;
using System;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new StudentContext())
        {
            var student = new Student
            {
                StudentName = "Jimmy Dean",
                Course = "Sausage King 101",
                Age = 95
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student has been added to the database.");
        }
    }
}
