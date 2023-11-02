using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Station
{
    class Station
    {
        public string Name { get; set; }
        public int StockVariety { get; set; }
        public int FuelStock { get; set; }
        public int FuelPrice { get; set; }
        public List<Ware> StationStock { get; set; }

        Random random = new Random();

        //Generates list of wares based off of StockVariety
        public Station()
        {
            Name = "Station";
            GenerateRandomStats(random);

            StationStock = new List<Ware>();

            for (int i = 0; i < StockVariety; i++)
            {
                int randomID = random.Next(100, 110 + 1);
                ContainsWare(randomID);
                while (isThere)
                {
                    randomID = random.Next(100, 110 + 1);
                    ContainsWare(randomID);
                }
                StationStock.Add(new Ware(randomID, random.Next(50, 500)));
                StationStock[i].CurrentValue = random.Next(StationStock[i].LowPrice, StationStock[i].HighPrice);
            }
        }

        //Checks to see if ware already exists in station list
        public bool isThere;
        public void ContainsWare(int id)
        {
            foreach(Ware ware in StationStock)
            {
                if (ware.ID.Equals(id))
                {
                    isThere =  true;
                    break;
                }
                else
                {
                    isThere =  false;
                }
            }
        }

        //Applies random stats to new station
        protected virtual void GenerateRandomStats(Random basedRNG)
        {
            StockVariety = basedRNG.Next(3, 9);
            FuelStock = basedRNG.Next(200, 3000);
        }
    }
}
