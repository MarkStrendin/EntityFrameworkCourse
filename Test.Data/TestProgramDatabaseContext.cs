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
    }
}
