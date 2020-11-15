using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace login
{


    public class Script
    {
        [PrimaryKey, AutoIncrement]
        public int ChatID { get; set; }
        public string ChatName{ get; set; }
        public string ChatDialog { get; set; }
       
    }
}
