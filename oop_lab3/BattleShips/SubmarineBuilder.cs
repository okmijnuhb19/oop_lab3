using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3.BattleShips
{
    class SubmarineBuilder:BattleShipBuilder
    {
        public override BattleShip Build(IShipsItems shipItems)
        {
            return new Submarine();
        }
    }
}
