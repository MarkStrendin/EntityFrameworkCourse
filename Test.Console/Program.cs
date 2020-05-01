using Microsoft.EntityFrameworkCore;
using System;
using Test.Data;
using Test.Domain;

namespace Test.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertStudent();
            System.Console.WriteLine("Done!");
        }

        private static void InsertStudent()
        {
            Contact con = new Contact
            {
                FirstName = "Harvey",
                LastName = "Birdman"
            };

            Student stu = new Student
            {
                FirstName = "John",
                LastName = "Smith",                
            };

            var optionsBuilder = new DbContextOptionsBuilder<TestProgramDatabaseContext>();
            optionsBuilder.UseSqlite("Data Source=derp.sdf");

            using (var context = new TestProgramDatabaseContext(optionsBuilder.Options))
            {
                context.Add(stu);
                context.Add(con);
                context.SaveChanges();
            }

        }
    }
}
