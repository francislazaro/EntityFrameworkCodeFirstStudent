using System.Data.Entity;

namespace EntityFrameworkCodeFirstStudent
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
