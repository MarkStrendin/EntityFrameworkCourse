﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public List<StudentContact> Contacts { get; set; }
    }
}
