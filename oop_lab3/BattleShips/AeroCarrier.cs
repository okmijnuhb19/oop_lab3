using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3.BattleShips
{
    [Serializable]
    public class AeroCarrier:BattleShip
    {
        public int Fighters { get; set; }
        public string FighterModel { get; set; }
        public int Bombers { get; set; }
        public string BomberModel { get; set; }
        public int TorpedoPlanes { get; set; }
        public string TorpedoPlanesModel { get; set; }
        public override BattleShipBuilder FactoryMethod()
        {
            return new AeroCarrierBuilder();
        }
    }
}
