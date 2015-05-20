using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3.BattleShips
{
    public class AeroCarrierBuilder:BattleShipBuilder
    {
        public override void Build(IShipsItems shipItems)
        {
            AeroCarrier aerocarrier = new AeroCarrier();
            aerocarrier.AirDefenceCaleber = shipItems.Adcaliber;
            aerocarrier.AirDefenceGuns = shipItems.Adgun;
            aerocarrier.BomberModel = shipItems.Aero_b_model;
            aerocarrier.Bombers = shipItems.Aero_b_number;
            aerocarrier.Country = shipItems.Ship_country;
            aerocarrier.FighterModel = shipItems.Aero_f_model;
            aerocarrier.Fighters = shipItems.Aero_f_number;
            aerocarrier.Grew = shipItems.Ship_crew;
            aerocarrier.ShipName = shipItems.Ship_name;
            aerocarrier.ShipSeries = shipItems.Ship_series;
            aerocarrier.ShipSpeed = shipItems.Ship_speed;
            aerocarrier.Tonnage = shipItems.Ship_tonnage;
            aerocarrier.TorpedoPlanes = shipItems.Aero_t_number;
            aerocarrier.TorpedoPlanesModel = shipItems.Aero_t_model;
            Lists.aerocarrierList.Add(aerocarrier);
        }
    }
}
