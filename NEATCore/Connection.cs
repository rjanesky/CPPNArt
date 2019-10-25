using System;
using System.Collections.Generic;
using System.Text;

namespace NEATCore
{
    public class Connection
    {
        protected static int innovation_counter = -1;

        public int Input { get; set; }
        public int Output { get; set; }

        public double Weight { get; set; }

        public bool Enabled { get; set; }

        public int Innovation { get; }

        public Connection ()
        {
            Innovation = ++Connection.innovation_counter;
        }
    }
}
