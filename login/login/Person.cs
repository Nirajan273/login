using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace login
{


    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public String Password { get; set; }
    }
}
