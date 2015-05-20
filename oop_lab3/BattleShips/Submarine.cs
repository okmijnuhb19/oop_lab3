using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3.BattleShips
{
    public class Submarine:BattleShip
    {
        public int TorpedoTubes { get; set; }
        public int TorpedoInTubes { get; set; }
        public int TorpedoSpeed { get; set; }
        public override BattleShipBuilder FactoryMethod()
        {
            return new SubmarineBuilder();
        }
    }
}
