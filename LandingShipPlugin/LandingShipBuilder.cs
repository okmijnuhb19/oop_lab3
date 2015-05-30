using oop_lab3;
using oop_lab3.BattleShips;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingShipPlugin
{
    public class LandingShipBuilder:BattleShipBuilder
    {

        public override void Build(IShipsItems shipItems)
        {
            LandingShip landingShip = new LandingShip();
            landingShip.AirDefenceCaleber = shipItems.Adcaliber;
            landingShip.AirDefenceGuns = shipItems.Adgun;
            landingShip.Country = shipItems.Ship_country;
            landingShip.Grew = shipItems.Ship_crew;
            landingShip.ShipName = shipItems.Ship_name;
            landingShip.ShipSeries = shipItems.Ship_series;
            landingShip.ShipSpeed = shipItems.Ship_speed;
            landingShip.Tonnage = shipItems.Ship_tonnage;
            LandingSPlugin.unknownList.Add(landingShip);
        }
    }
}
