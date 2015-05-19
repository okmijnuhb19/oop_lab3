using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3.BattleShips
{
    class BoatBuilder:BattleShipBuilder
    {
        public override void Build(IShipsItems shipItems)
        {
            Boat boat = new Boat();
            boat.AirDefenceCaleber = shipItems.Adcaliber;
            boat.AirDefenceGuns = shipItems.Adgun;
            boat.Country = shipItems.Ship_country;
            boat.Grew = shipItems.Ship_crew;
            boat.ShipName = shipItems.Ship_name;
            boat.ShipSeries = shipItems.Ship_series;
            boat.ShipSpeed = shipItems.Ship_speed;
            boat.Tonnage = shipItems.Ship_tonnage;
            shipItems.boatList.Add(boat);
        }
    }
}
