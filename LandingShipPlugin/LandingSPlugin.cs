using oop_lab3;
using oop_lab3.BattleShips;
using System;
using System.IO;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingShipPlugin
{
    public class LandingSPlugin:IPlugin
    {
        public string NameOfShipType { get { return "LandingShip"; } }
        public Type ShipType { get { return typeof(LandingShip); } }
        public string NameOfBuilderType { get { return "LandingShipBuilder"; } }
        public Type BuilderType { get { return typeof(LandingShipBuilder); } }
        public void Deserialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(@"F:\Учеба\repository\oop_lab3\oop_lab3\bin\Debug\PluginedShip.dat", FileMode.OpenOrCreate))
            {
                BindingList<LandingShip> deserilizelist = (BindingList<LandingShip>)formatter.Deserialize(fs);
                foreach (var bo in deserilizelist)
                {
                    unknownList.Add(bo);
                }
            }
        }
        public void Serialize() 
        {
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("PluginedShip.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, unknownList);
                unknownList.Clear();
            }
        }
        public BindingList<IPluginedType> UnknownList 
        { 
            get 
            {
                BindingList<IPluginedType> lst = new BindingList<IPluginedType>();
                foreach(LandingShip l in unknownList)
                {
                    lst.Add(l);
                }
                return lst; 
            } 
            set 
            {
                BindingList<IPluginedType> lst = new BindingList<IPluginedType>();
                lst=value;
                foreach (IPluginedType l in lst)
                {
                    unknownList.Add((LandingShip)l);
                }
            } 
        }
        public static BindingList<LandingShip> unknownList;
        public void NewList() 
        {
            unknownList = new BindingList<LandingShip>();
        }
    }
}
