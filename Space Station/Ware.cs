using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Station
{
    public class Ware
    {
        public string Name { get; set; }
        public int? Volume { get; set; }
        public int? CurrentValue { get; set; }
        public int? ID { get; set; }
        public int? Amount { get; set; }
        public int? Purchased { get; set; }
        public int? meanPurchased { get; set; }
        public int LowPrice { get; set; }
        public int HighPrice { get; set; }

        Random random = new Random();

        public Ware(int itemID, int amount)
        {
            switch (itemID)
            {
                case 100:
                    NewWare("Mechanical Parts", 28, 445, 1648, amount, 100);
                    break;
                case 101:
                    NewWare("Basic Engine", 40, 105, 785, amount, 101);
                    break;
                case 102:
                    NewWare("Food", 2, 6, 15,amount, 102);
                    break;
                case 103:
                    NewWare("Medical Supplies", 5, 55, 358, amount, 103);
                    break;
                case 104:
                    NewWare("Raw Metal Ore", 35, 430, 1200, amount, 104);
                    break;
                case 105:
                    NewWare("Refined Metal", 82, 1100, 2500, amount, 105);
                    break;
                case 106:
                    NewWare("Electronic Components", 12, 152, 556, amount, 106);
                    break;
                case 107:
                    NewWare("Wiring", 4, 10, 75, amount, 107);
                    break;
                case 108:
                    NewWare("General Goods", 2, 5, 45, amount, 108);
                    break;
                case 109:
                    NewWare("Luxury Items", 18, 125, 850, amount, 109);
                    break;
                case 110:
                    NewWare("Coal", 15, 95, 520, amount, 110);
                    break;
                default:
                    NewWare("Junk", 5, 15, 30, amount, 999);
                    break;
            }
        }

        public void NewWare(string name, int volume, int lowValue, int highValue, int amount, int id)
        {
            Name = name;
            Volume = volume;

            //CurrentValue = random.Next((int)lowValue, (int)highValue);
            LowPrice = lowValue;
            HighPrice = highValue;
            Amount = amount;
            ID = id;
            meanPurchased = 0;
            Purchased = 0;
        }
    }
}
