using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3.BattleShips
{
    public class CriserBuilder:BattleShipBuilder
    {
        public override void Build(IShipsItems shipItems) 
        {
            Cruiser cruiser = new Cruiser();
            cruiser.AirDefenceCaleber = shipItems.Adcaliber;
            cruiser.AirDefenceGuns = shipItems.Adgun;
            cruiser.CannonInTowers = shipItems.Cannon;
            cruiser.Country = shipItems.Ship_country;
            cruiser.Grew = shipItems.Ship_crew;
            cruiser.MainCaliber = shipItems.Mcaliber;
            cruiser.Scouts = shipItems.Aero_s_number;
            cruiser.ScoutsModel = shipItems.Aero_s_model;
            cruiser.ShipName = shipItems.Ship_name;
            cruiser.ShipSeries = shipItems.Ship_series;
            cruiser.ShipSpeed = shipItems.Ship_speed;
            cruiser.Tonnage = shipItems.Ship_tonnage;
            cruiser.TorpedoInTubes = shipItems.Torpedo_intube;
            cruiser.TorpedoSpeed = shipItems.Torpedo_speed;
            cruiser.TorpedoTubes = shipItems.Torpedo_tube;
            cruiser.Towers = shipItems.Towers;
            Lists.cruiserList.Add(cruiser);
            return;
        }
    }
}
