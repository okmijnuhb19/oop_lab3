using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3.BattleShips
{
    [Serializable]
    public class Boat:BattleShip
    {
        public override BattleShipBuilder FactoryMethod()
        {
            return new BoatBuilder();
        }
    }
}
