using oop_lab3;
using oop_lab3.BattleShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingShipPlugin
{
    [Serializable]
    public class LandingShip: BattleShip,IPluginedType
    {
        public override BattleShipBuilder FactoryMethod()
        {
            return new LandingShipBuilder();
        }
    }
}
