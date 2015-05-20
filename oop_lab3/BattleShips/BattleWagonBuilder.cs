using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3.BattleShips
{
    public class BattleWagonBuilder:BattleShipBuilder
    {
        public override void Build(IShipsItems shipItems)
        {
            BattleWagon battleWagon = new BattleWagon();
            battleWagon.AirDefenceCaleber = shipItems.Adcaliber;
            battleWagon.AirDefenceGuns = shipItems.Adgun;
            battleWagon.CannonInTowers = shipItems.Cannon;
            battleWagon.Country = shipItems.Ship_country;
            battleWagon.Grew = shipItems.Ship_crew;
            battleWagon.MainCaliber = shipItems.Mcaliber;
            battleWagon.ShipName = shipItems.Ship_name;
            battleWagon.ShipSeries = shipItems.Ship_series;
            battleWagon.ShipSpeed = shipItems.Ship_speed;
            battleWagon.Tonnage = shipItems.Ship_tonnage;
            battleWagon.Towers = shipItems.Towers;
            Lists.lineShipList.Add(battleWagon);
        }
    }
}
