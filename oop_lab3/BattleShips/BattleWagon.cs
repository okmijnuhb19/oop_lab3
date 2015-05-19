using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3.BattleShips
{
    class BattleWagon: BattleShip
    {
        public int Towers { get; set; }
        public int CannonInTowers { get; set; }
        public int MainCaliber { get; set; }
        public override BattleShipBuilder FactoryMethod()
        {
            return new BattleWagonBuilder();
        }
    }
}
