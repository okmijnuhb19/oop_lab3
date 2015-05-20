using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3.BattleShips
{
    public class DestroyerBuilder:BattleShipBuilder
    {
        public override void Build(IShipsItems shipItems)
        {
            Destroyer destroyer = new Destroyer();
            destroyer.AirDefenceCaleber = shipItems.Adcaliber;
            destroyer.AirDefenceGuns = shipItems.Adgun;
            destroyer.CannonInTowers = shipItems.Cannon;
            destroyer.Country = shipItems.Ship_country;
            destroyer.Grew = shipItems.Ship_crew;
            destroyer.MainCaliber = shipItems.Mcaliber;
            destroyer.ShipName = shipItems.Ship_name;
            destroyer.ShipSeries = shipItems.Ship_series;
            destroyer.ShipSpeed = shipItems.Ship_speed;
            destroyer.Tonnage = shipItems.Ship_tonnage;
            destroyer.TorpedoInTubes = shipItems.Torpedo_intube;
            destroyer.TorpedoSpeed = shipItems.Torpedo_speed;
            destroyer.TorpedoTubes = shipItems.Torpedo_tube;
            destroyer.Towers = shipItems.Towers;
            Lists.destroyerList.Add(destroyer);
        }
    }
}
