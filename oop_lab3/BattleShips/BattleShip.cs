using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3.BattleShips
{
    [Serializable]
    public abstract class BattleShip
    {
        public string ShipName { get; set; }
        public string ShipSeries { get; set; }
        public int Tonnage { get; set; }
        public int Grew { get; set; }
        public string Country { get; set; }
        public int ShipSpeed { get; set; }
        public int AirDefenceGuns { get; set; }
        public int AirDefenceCaleber { get; set; }
        public abstract BattleShipBuilder FactoryMethod();
    }
}
