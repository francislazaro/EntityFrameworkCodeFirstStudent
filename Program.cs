using System;
using System.Data.Entity;

namespace CodeFirstStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                var student = new Student { StudentName = "John Doe" };
                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student saved!");
                Console.ReadLine();
            }
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
