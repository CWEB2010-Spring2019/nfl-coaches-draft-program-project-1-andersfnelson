using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class Player
    {
        public double DraftCost { get; set; }
        public string PlayerName { get; set; }
        public string PlayerSchool { get; set; }
        public string PlayerPosition { get; set; }

        //How to ensure that this is between 1 and 5?  Is this important?
        public int DraftChoice { get; set; }
    }
}
