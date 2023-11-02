using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Station
{
    public class Player
    {

        public long PlayerMoney { get; set; }
        public int PlayerLevel { get; set; }
        public long PlayerScore { get; set; }
        public long TotalPurchased { get; set; }
        public long TotalSold { get; set; }
        public int EQTotalPurchased { get; set; }
        public int TotalJumps { get; set; }

        public Player()
        {
            PlayerMoney = 500;
            //PlayerMoney = 300000; //TESTING
            PlayerLevel = 1;
            PlayerScore = 0;
            TotalPurchased = 0;
            TotalSold = 0;
            EQTotalPurchased = 0;
            TotalJumps = 0;
        }
    }
}
