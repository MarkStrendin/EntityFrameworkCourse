using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Domain
{
    public class StudentContact
    {
        public int StudentId { get; set; }
        public int ContactId { get; set; }
        public Student Student { get; set; }
        public Contact Contact { get; set; }
    }
}
