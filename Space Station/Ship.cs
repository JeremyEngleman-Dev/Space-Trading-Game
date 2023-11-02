using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Station
{
    public class Ship
    {
        Random random = new Random();

        //Ship features
        public string ShipName { get; set; }
        public int FuelBurn { get; set; }
        public int FuelMax { get; set; }
        public int FuelCurrent { get; set; }
        public int CargoMax { get; set; }
        public int CargoCurrent { get; set; }
        public int CrewSlot { get; set; }
        public int ShipID { get; set; }
        public int ShipPrice { get; set; }
        public int EQFuelLevel { get; set; }
        public double EQFuelRate { get; set; }
        public int EQFuelCost { get; set; }
        public int EQFuelAdjust { get; set; }
        public int EQFuelMaxLevel { get; set; }
        public int EQCargoLevel { get; set; }
        public double EQCargoRate { get; set; }
        public int EQCargoCost { get; set; }
        public int EQCargoAdjust { get; set; }
        public int EQCargoMaxLevel { get; set; }
        public int EQEngineLevel { get; set; }
        public double EQEngineRate { get; set; }
        public int EQEngineCost { get; set; }
        public int EQEngineAdjust { get; set; }
        public int EQEngineMaxLevel { get; set; }

        public List<Ware> ShipHull;
        public List<Ship> ShipList;
        //public List<Crew> CrewRoster;

        //Ship naming:  [name]-[model]
        public Ship(int id)
        {
            switch (id)
            {
                //Small Ships
                case 100:
                    NewShip("Fli-F80", 0, 5000, 100);
                    ShipFuel(100, 10);
                    ShipCargo(200);
                    EQFuel(0, 1.4, 100, 100, 10);
                    EQCargo(0, 1.4, 100, 100, 10);
                    EQEngine(0, 2.25, 7500, 1, 9);
                    break;
                case 101:
                    NewShip("Bug-B33", 0, 17500, 101);
                    ShipFuel(150, 12);
                    ShipCargo(300);
                    EQFuel(0, 1.4, 200, 110, 10);
                    EQCargo(0, 1.4, 200, 110, 10);
                    EQEngine(0, 2.75, 14000, 1, 9);
                    break;

                //Medium Ships
                case 200:
                    NewShip("Rahn-R701", 1, 336580, 200);
                    ShipFuel(800, 55);
                    ShipCargo(1000);
                    EQFuel(0, 1.4, 12000, 500, 12);
                    EQCargo(0, 1.4, 14000, 500, 12);
                    EQEngine(0, 2.25, 48000, 3, 10);
                    break;
                case 201:
                    NewShip("Powl-P492", 1, 378659, 201);
                    ShipFuel(1100, 65);
                    ShipCargo(1200);
                    EQFuel(0, 1.4, 14000, 500, 12);
                    EQCargo(0, 1.4, 15000, 500, 12);
                    EQEngine(0, 2.25, 52000, 3, 10);
                    break;

                //Large Ships
                case 300:
                    NewShip("Xtal-X701", 3, 12378548, 300);
                    ShipFuel(11500, 155);
                    ShipCargo(11500);
                    EQFuel(0, 1.4, 58000, 2000, 15);
                    EQCargo(0, 1.4, 62000, 2000, 15);
                    EQEngine(0, 2.25, 225000, 10, 10);
                    break;
                case 301:
                    NewShip("Yuri-Y938", 3, 16402988, 301);
                    ShipFuel(13500, 178);
                    ShipCargo(13500);
                    EQFuel(0, 1.4, 64000, 2000, 15);
                    EQCargo(0, 1.4, 69000, 2000, 15);
                    EQEngine(0, 2.25, 322000, 10, 10);
                    break;
            }
        }

        void NewShip(string name, int crew, int price, int id)
        {
            ShipName = name;
            CrewSlot = crew;
            ShipPrice = price;
            ShipID = id;
        }

        void ShipCargo(int cargo)
        {
            CargoCurrent = 0;
            CargoMax = cargo;
            ShipHull = new List<Ware>();
        }

        void ShipFuel(int fuel, int burn)
        {
            FuelMax = fuel;
            FuelCurrent = FuelMax;
            FuelBurn = burn;
        }

        void EQFuel(int fuellevel, double fuelrate, int fuelcost, int adjust, int max)
        {
            EQFuelLevel = fuellevel;
            EQFuelRate = fuelrate;
            EQFuelCost = fuelcost;
            EQFuelAdjust = adjust;
            EQFuelMaxLevel = max;
        }

        void EQCargo(int cargolevel, double cargorate, int cargocost, int adjust, int max)
        {
            EQCargoLevel = cargolevel;
            EQCargoRate = cargorate;
            EQCargoCost = cargocost;
            EQCargoAdjust = adjust;
            EQCargoMaxLevel = max;
        }

        void EQEngine(int enginelevel, double enginerate, int enginecost, int adjust, int max)
        {
            EQEngineLevel = enginelevel;
            EQEngineRate = enginerate;
            EQEngineCost = enginecost;
            EQEngineAdjust = adjust;
            EQEngineMaxLevel = max;
        }
    }
}
