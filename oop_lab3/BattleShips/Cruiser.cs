using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3.BattleShips
{
    class Cruiser:BattleShip
    {
        public int Towers { get; set; }
        public int CannonInTowers { get; set; }
        public int MainCaliber { get; set; }
        public int Scouts { get; set; }
        public string ScoutsModel { get; set; }
        public int TorpedoTubes { get; set; }
        public int TorpedoInTubes { get; set; }
        public int TorpedoSpeed { get; set; }
        public override BattleShipBuilder FactoryMethod() { return new CriserBuilder(); }
    }
}
