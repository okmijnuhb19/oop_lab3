using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3.BattleShips
{
    public class SubmarineBuilder:BattleShipBuilder
    {
        public override void Build(IShipsItems shipItems)
        {
            Submarine submarine = new Submarine();
            submarine.AirDefenceCaleber = shipItems.Adcaliber;
            submarine.AirDefenceGuns = shipItems.Adgun;
            submarine.Country = shipItems.Ship_country;
            submarine.Grew = shipItems.Ship_crew;
            submarine.ShipName = shipItems.Ship_name;
            submarine.ShipSeries = shipItems.Ship_series;
            submarine.ShipSpeed = shipItems.Ship_speed;
            submarine.Tonnage = shipItems.Ship_tonnage;
            submarine.TorpedoInTubes = shipItems.Torpedo_intube;
            submarine.TorpedoSpeed = shipItems.Torpedo_speed;
            submarine.TorpedoTubes = shipItems.Torpedo_tube;
            Lists.submarineList.Add(submarine);
        }
    }
}
