using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Domain;

namespace Test.Data
{
    class TestProgramDatabaseContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        // I really don't like how this course has you do this, because it's obviously a bad idea
        // to hard code the connection string _here_ of all places.
        // TODO: How would we normally handle setting up the database context?
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Derp.sdf");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
