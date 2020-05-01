using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Domain
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<StudentContact> Students { get; set; }


    }
}
