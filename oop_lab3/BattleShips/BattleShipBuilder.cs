using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3.BattleShips
{
    abstract class BattleShipBuilder
    {
        abstract public void Build(IShipsItems shipItems);
    }
}
