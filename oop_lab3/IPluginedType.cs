using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3
{
    public interface IPluginedType
    {
         string ShipName { get; set; }
         string ShipSeries { get; set; }
         int Tonnage { get; set; }
         int Grew { get; set; }
         string Country { get; set; }
         int ShipSpeed { get; set; }
         int AirDefenceGuns { get; set; }
         int AirDefenceCaleber { get; set; }
    }
}
