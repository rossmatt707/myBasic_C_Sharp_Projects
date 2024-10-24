using System.Data.Entity;

namespace FinalChallenge_545
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDatabase")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
