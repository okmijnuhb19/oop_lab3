using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab3
{
    public interface IPlugin
    {
        BindingList<IPluginedType> UnknownList { get; set; }
        string NameOfShipType { get; }
        Type ShipType { get; }
        string NameOfBuilderType { get; }
        Type BuilderType { get; }
        void Deserialize();
        void Serialize();
        void NewList();
    }
}
