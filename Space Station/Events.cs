using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Station
{
    public class Events
    {
        public int ID { get; set; }
        public int Jumps { get; set; }

        public Events(int id, int jumps)
        {
            ID = id;
            Jumps = jumps;
        }
    }
}
