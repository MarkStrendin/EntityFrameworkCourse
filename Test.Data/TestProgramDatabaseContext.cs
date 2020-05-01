using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Domain;

namespace Test.Data
{
    public class TestProgramDatabaseContext : DbContext
    {
        public TestProgramDatabaseContext(DbContextOptions<TestProgramDatabaseContext> options) 
            : base(options)
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}
