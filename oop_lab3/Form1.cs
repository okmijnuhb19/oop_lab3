using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace oop_lab3
{    
    public interface IShipsItems 
    {
        string Ship_name { get; }
        string Ship_series { get; }
        int Ship_tonnage { get; }
        int Towers { get; }
        int Cannon { get; }
        int Mcaliber { get; }
        int Adgun { get; }
        int Adcaliber { get; }
        int Ship_crew { get; }
        int Torpedo_tube { get; }
        int Torpedo_intube { get; }
        int Torpedo_speed { get; }
        int Ship_speed { get; }
        int Aero_s_number { get; }
        int Aero_f_number { get; }
        int Aero_b_number { get; }
        int Aero_t_number { get; }
        string Aero_s_model { get; }
        string Aero_f_model { get; }
        string Aero_b_model { get; }
        string Aero_t_model { get; }
        string Ship_country { get; }
    }

    public partial class Form1 : Form,IShipsItems
    {
        BattleShips.BattleShip bs;
        IPlugin plug;
        static Type shipType;
        public Form1()
        {
            InitializeComponent();
            pluginedShipButton.Hide();
            listedUnknownShips.Hide();
            serializeUnknowm.Hide();
            deserialiseUnknown.Hide();
            Lists.cruiserList = new BindingList<BattleShips.Cruiser>();
            Lists.submarineList = new BindingList<BattleShips.Submarine>();
            Lists.lineShipList = new BindingList<BattleShips.BattleWagon>();
            Lists.aerocarrierList = new BindingList<BattleShips.AeroCarrier>();
            Lists.destroyerList = new BindingList<BattleShips.Destroyer>();
            Lists.boatList = new BindingList<BattleShips.Boat>();
            listedAeroCarrier.DataSource = Lists.aerocarrierList;
            listedAeroCarrier.DisplayMember = "ShipName";
            listedBoat.DataSource = Lists.boatList;
            listedBoat.DisplayMember = "ShipName";
            listedCruisers.DataSource = Lists.cruiserList;
            listedCruisers.DisplayMember = "ShipName";
            listedDestroyer.DataSource = Lists.destroyerList;
            listedDestroyer.DisplayMember = "ShipName";
            listedLineShips.DataSource = Lists.lineShipList;
            listedLineShips.DisplayMember = "ShipName";
            listedSubmarine.DataSource = Lists.submarineList;
            listedSubmarine.DisplayMember = "ShipName";
            listedAeroCarrier.DoubleClick += listedAeroCarrier_DoubleClick;
            listedBoat.DoubleClick += listedBoat_DoubleClick;
            listedLineShips.DoubleClick += listedLineShips_DoubleClick;
            listedDestroyer.DoubleClick += listedDestroyer_DoubleClick;
            listedSubmarine.DoubleClick += listedSubmarine_DoubleClick;
            listedCruisers.DoubleClick += listedCruisers_DoubleClick;
            listedUnknownShips.DoubleClick += listedUnknownShips_DoubleClick;
        }

        void listedUnknownShips_DoubleClick(object sender, EventArgs e)
        {
            pluginedShipButton_Click(this, EventArgs.Empty);
            var ac = (IPluginedType)shipType.GetConstructor(Type.EmptyTypes).Invoke(new Object[0]);
            ac = plug.UnknownList[listedUnknownShips.SelectedIndex];
            shipName.Text = ac.ShipName;
            shipSeries.Text = ac.ShipSeries;
            shipTonnage.Value = ac.Tonnage;
            quanityOfAirdefenceGun.Value = ac.AirDefenceGuns;
            airDefenceCaliber.Value = ac.AirDefenceCaleber;
            crew.Value = ac.Grew;
            shipSpeed.Value = ac.ShipSpeed;
            countryBox.Text = ac.Country;
            plug.UnknownList.RemoveAt(listedBoat.SelectedIndex);
            listedUnknownShips.Refresh();
        }
        void listedCruisers_DoubleClick(object sender, EventArgs e)
        {
            cruiserButton_Click(this, EventArgs.Empty);
            BattleShips.Cruiser ac = Lists.cruiserList[listedCruisers.SelectedIndex];
            shipName.Text = ac.ShipName;
            shipSeries.Text = ac.ShipSeries;
            shipTonnage.Value = ac.Tonnage;
            quanityOfAirdefenceGun.Value = ac.AirDefenceGuns;
            airDefenceCaliber.Value = ac.AirDefenceCaleber;
            crew.Value = ac.Grew;
            shipSpeed.Value = ac.ShipSpeed;
            countryBox.Text = ac.Country;
            quanityOfTower.Value = ac.Towers;
            quanityOfCannonInTower.Value = ac.CannonInTowers;
            mainCaliber.Value = ac.MainCaliber;
            torpedosInTube.Value = ac.TorpedoInTubes;
            quanityOfTorpedoTube.Value = ac.TorpedoTubes;
            SpeedOfTorpedos.Value = ac.TorpedoSpeed;
            scoutsModel.Text = ac.ScoutsModel;
            numberOfScout.Value = ac.Scouts;
            Lists.cruiserList.RemoveAt(listedCruisers.SelectedIndex);
        }
        void listedSubmarine_DoubleClick(object sender, EventArgs e)
        {
            submarineButton_Click(this, EventArgs.Empty);
            BattleShips.Submarine ac = Lists.submarineList[listedSubmarine.SelectedIndex];
            shipName.Text = ac.ShipName;
            shipSeries.Text = ac.ShipSeries;
            shipTonnage.Value = ac.Tonnage;
            quanityOfAirdefenceGun.Value = ac.AirDefenceGuns;
            airDefenceCaliber.Value = ac.AirDefenceCaleber;
            crew.Value = ac.Grew;
            shipSpeed.Value = ac.ShipSpeed;
            countryBox.Text = ac.Country;
            torpedosInTube.Value = ac.TorpedoInTubes;
            quanityOfTorpedoTube.Value = ac.TorpedoTubes;
            SpeedOfTorpedos.Value = ac.TorpedoSpeed;
            Lists.submarineList.RemoveAt(listedSubmarine.SelectedIndex);
        }
        void listedDestroyer_DoubleClick(object sender, EventArgs e)
        {
            destroyerButton_Click(this, EventArgs.Empty);
            BattleShips.Destroyer ac = Lists.destroyerList[listedDestroyer.SelectedIndex];
            shipName.Text = ac.ShipName;
            shipSeries.Text = ac.ShipSeries;
            shipTonnage.Value = ac.Tonnage;
            quanityOfAirdefenceGun.Value = ac.AirDefenceGuns;
            airDefenceCaliber.Value = ac.AirDefenceCaleber;
            crew.Value = ac.Grew;
            shipSpeed.Value = ac.ShipSpeed;
            countryBox.Text = ac.Country;
            quanityOfTower.Value = ac.Towers;
            quanityOfCannonInTower.Value = ac.CannonInTowers;
            mainCaliber.Value = ac.MainCaliber;
            torpedosInTube.Value = ac.TorpedoInTubes;
            quanityOfTorpedoTube.Value = ac.TorpedoTubes;
            SpeedOfTorpedos.Value = ac.TorpedoSpeed;
            Lists.destroyerList.RemoveAt(listedDestroyer.SelectedIndex);
        }
        void listedLineShips_DoubleClick(object sender, EventArgs e)
        {
            battleWagonButton_Click(this, EventArgs.Empty);
            BattleShips.BattleWagon ac = Lists.lineShipList[listedLineShips.SelectedIndex];
            shipName.Text = ac.ShipName;
            shipSeries.Text = ac.ShipSeries;
            shipTonnage.Value = ac.Tonnage;
            quanityOfAirdefenceGun.Value = ac.AirDefenceGuns;
            airDefenceCaliber.Value = ac.AirDefenceCaleber;
            crew.Value = ac.Grew;
            shipSpeed.Value = ac.ShipSpeed;
            countryBox.Text = ac.Country;
            quanityOfTower.Value = ac.Towers;
            quanityOfCannonInTower.Value = ac.CannonInTowers;
            mainCaliber.Value = ac.MainCaliber;
            Lists.lineShipList.RemoveAt(listedLineShips.SelectedIndex);
        }
        void listedBoat_DoubleClick(object sender, EventArgs e)
        {
            battleBoatButton_Click(this, EventArgs.Empty);
            BattleShips.Boat ac = Lists.boatList[listedBoat.SelectedIndex];
            shipName.Text = ac.ShipName;
            shipSeries.Text = ac.ShipSeries;
            shipTonnage.Value = ac.Tonnage;
            quanityOfAirdefenceGun.Value = ac.AirDefenceGuns;
            airDefenceCaliber.Value = ac.AirDefenceCaleber;
            crew.Value = ac.Grew;
            shipSpeed.Value = ac.ShipSpeed;
            countryBox.Text = ac.Country;
            Lists.boatList.RemoveAt(listedBoat.SelectedIndex);
        }
        void listedAeroCarrier_DoubleClick(object sender, EventArgs e)
        {
            aerocarrierButton_Click(this,EventArgs.Empty);
            BattleShips.AeroCarrier ac =Lists.aerocarrierList[listedAeroCarrier.SelectedIndex];
            shipName.Text = ac.ShipName;
            shipSeries.Text = ac.ShipSeries;
            shipTonnage.Value = ac.Tonnage;
            quanityOfAirdefenceGun.Value = ac.AirDefenceGuns;
            airDefenceCaliber.Value = ac.AirDefenceCaleber;
            crew.Value = ac.Grew;
            shipSpeed.Value = ac.ShipSpeed;
            numberOfBomber.Value = ac.Bombers;
            numberOfFighter.Value = ac.Fighters;
            numberOfTorpedoPlane.Value = ac.TorpedoPlanes;
            torpedoPlaneModel.Text = ac.TorpedoPlanesModel;
            bombersModel.Text = ac.BomberModel;
            fightersModel.Text = ac.FighterModel;
            countryBox.Text = ac.Country;
            Lists.aerocarrierList.RemoveAt(listedAeroCarrier.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numberOfFighter.Hide();
            fightersModel.Hide();
            numberOfScout.Show();
            scoutsModel.Show();
            numberOfBomber.Hide();
            bombersModel.Hide();
            torpedoPlaneModel.Hide();
            numberOfTorpedoPlane.Hide();
            quanityOfTower.Show();
            quanityOfCannonInTower.Show();
            quanityOfTorpedoTube.Show();
            torpedosInTube.Show();
            mainCaliber.Show();
            SpeedOfTorpedos.Show();
        }
        private void cruiserButton_Click(object sender, EventArgs e)
        {
            numberOfFighter.Hide();
            fightersModel.Hide();
            numberOfScout.Show();
            scoutsModel.Show();
            numberOfBomber.Hide();
            bombersModel.Hide();
            torpedoPlaneModel.Hide();
            numberOfTorpedoPlane.Hide();
            quanityOfTower.Show();
            quanityOfCannonInTower.Show();
            quanityOfTorpedoTube.Show();
            torpedosInTube.Show();
            mainCaliber.Show();
            SpeedOfTorpedos.Show();
            Clear();
            bs = new BattleShips.Cruiser();                     
        }
        private void submarineButton_Click(object sender, EventArgs e)
        {
            numberOfFighter.Hide();
            fightersModel.Hide();
            numberOfScout.Hide();
            scoutsModel.Hide();
            numberOfBomber.Hide();
            bombersModel.Hide();
            torpedoPlaneModel.Hide();
            numberOfTorpedoPlane.Hide();
            quanityOfTower.Hide();
            quanityOfCannonInTower.Hide();
            quanityOfTorpedoTube.Show();
            torpedosInTube.Show();
            mainCaliber.Show();
            SpeedOfTorpedos.Show();
            Clear();
            bs = new BattleShips.Submarine();
        }
        private void aerocarrierButton_Click(object sender, EventArgs e)
        {
            fightersModel.Show();
            numberOfFighter.Show();
            numberOfScout.Hide();
            scoutsModel.Hide();
            numberOfBomber.Show();
            bombersModel.Show();
            torpedoPlaneModel.Show();
            numberOfTorpedoPlane.Show();
            quanityOfTower.Hide();
            quanityOfCannonInTower.Hide();
            quanityOfTorpedoTube.Hide();
            torpedosInTube.Hide();
            SpeedOfTorpedos.Hide();
            mainCaliber.Hide();
            Clear();
            bs = new BattleShips.AeroCarrier();
        }
        private void battleWagonButton_Click(object sender, EventArgs e)
        {
            numberOfFighter.Hide();
            fightersModel.Hide();
            numberOfScout.Hide();
            scoutsModel.Hide();
            numberOfBomber.Hide();
            bombersModel.Hide();
            torpedoPlaneModel.Hide();
            numberOfTorpedoPlane.Hide();
            quanityOfTower.Show();
            quanityOfCannonInTower.Show();
            quanityOfTorpedoTube.Hide();
            torpedosInTube.Hide();
            mainCaliber.Show();
            SpeedOfTorpedos.Hide();
            Clear();
            bs = new BattleShips.BattleWagon();
        }
        private void destroyerButton_Click(object sender, EventArgs e)
        {
            numberOfFighter.Hide();
            fightersModel.Hide();
            numberOfScout.Hide();
            scoutsModel.Hide();
            numberOfBomber.Hide();
            bombersModel.Hide();
            torpedoPlaneModel.Hide();
            numberOfTorpedoPlane.Hide();
            quanityOfTower.Show();
            quanityOfCannonInTower.Show();
            quanityOfTorpedoTube.Show();
            torpedosInTube.Show();
            mainCaliber.Show();
            SpeedOfTorpedos.Show();
            Clear();
            bs = new BattleShips.Destroyer();
        }
        private void battleBoatButton_Click(object sender, EventArgs e)
        {
            numberOfFighter.Hide();
            fightersModel.Hide();
            numberOfScout.Hide();
            scoutsModel.Hide();
            numberOfBomber.Hide();
            bombersModel.Hide();
            torpedoPlaneModel.Hide();
            numberOfTorpedoPlane.Hide();
            quanityOfTower.Hide();
            quanityOfCannonInTower.Hide();
            quanityOfTorpedoTube.Hide();
            torpedosInTube.Hide();
            mainCaliber.Hide();
            SpeedOfTorpedos.Hide();
            Clear();
            bs = new BattleShips.Boat();
        }
        public void Clear() 
        {
            shipName.Text = "";
            shipSeries.Text = "";
            quanityOfTower.Value = 0;
            quanityOfCannonInTower.Value = 0;
            quanityOfAirdefenceGun.Value = 0;
            crew.Value = 20;
            quanityOfTorpedoTube.Value = 0;
            torpedosInTube.Value = 0;
            numberOfScout.Value = 0;
            numberOfBomber.Value = 0;
            numberOfFighter.Value = 0;
            numberOfTorpedoPlane.Value = 0;
            scoutsModel.Text = "";
            fightersModel.Text = "";
            bombersModel.Text = "";
            torpedoPlaneModel.Text = "";
        }

        private void addToList_Click(object sender, EventArgs e)
        {
            var s = bs;
            var builder=s.FactoryMethod();
            builder.Build(this);
            listedUnknownShips.Refresh();
            
        }
        
        #region IShipItems
        public string Ship_name { get { return shipName.Text; } }
        public string Ship_series { get { return shipSeries.Text; } }
        public int Ship_tonnage { get { return (int)shipTonnage.Value; } }
        public int Towers { get { return (int)quanityOfTower.Value; } }
        public int Cannon { get { return (int)quanityOfCannonInTower.Value; } }
        public int Mcaliber { get { return (int)mainCaliber.Value; } }
        public int Adgun { get { return (int)quanityOfAirdefenceGun.Value; } }
        public int Adcaliber { get { return (int)airDefenceCaliber.Value; } }
        public int Ship_crew { get { return (int)crew.Value; } }
        public int Torpedo_tube { get { return (int)quanityOfTorpedoTube.Value; } }
        public int Torpedo_intube { get {return (int)torpedosInTube.Value;} }
        public int Torpedo_speed { get {return (int)SpeedOfTorpedos.Value;} }
        public int Ship_speed { get { return (int)shipSpeed.Value; } }
        public int Aero_s_number { get { return (int)numberOfScout.Value; } }
        public int Aero_f_number { get { return (int)numberOfFighter.Value; } }
        public int Aero_b_number { get { return (int)numberOfBomber.Value; } }
        public int Aero_t_number { get { return (int)numberOfTorpedoPlane.Value; } }
        public string Aero_s_model { get { return scoutsModel.Text; } }
        public string Aero_f_model { get { return fightersModel.Text; } }
        public string Aero_b_model { get { return bombersModel.Text; } }
        public string Aero_t_model { get { return torpedoPlaneModel.Text; } }
        public string Ship_country { get { return countryBox.Text; } }
        #endregion
        #region Serializaton
        private void serializeButton_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("Cruisers.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs,Lists.cruiserList);
                Lists.cruiserList.Clear();
                MessageBox.Show("Объекты типа Cruiser сериализованы!","Сообщение!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void DeserializeCruiser_Click(object sender, EventArgs e)
        {
            listedCruisers.BeginUpdate();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Cruisers.dat", FileMode.OpenOrCreate))
            {
                BindingList<BattleShips.Cruiser> deserilizelist= (BindingList<BattleShips.Cruiser>)formatter.Deserialize(fs);
                foreach (BattleShips.Cruiser cr in deserilizelist) 
                {
                    Lists.cruiserList.Add(cr);
                }
               
                MessageBox.Show("Объекты типа Cruiser десериализованы!", "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            listedCruisers.EndUpdate();
        }
        private void deserializeLineShip_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("LineShip.dat", FileMode.OpenOrCreate))
            {
                BindingList<BattleShips.BattleWagon> deserilizelist = (BindingList<BattleShips.BattleWagon>)formatter.Deserialize(fs);
                foreach (BattleShips.BattleWagon bw in deserilizelist)
                {
                    Lists.lineShipList.Add(bw);
                }
                MessageBox.Show("Объекты типа BattleWagon десериализованы!", "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void serializeLineShip_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("LineShip.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Lists.lineShipList);
                Lists.lineShipList.Clear();
                MessageBox.Show("Объекты типа BattleWagon сериализованы!", "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void deserialiseSubmarine_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Submarine.dat", FileMode.OpenOrCreate))
            {
                BindingList<BattleShips.Submarine> deserilizelist = (BindingList<BattleShips.Submarine>)formatter.Deserialize(fs);
                foreach (BattleShips.Submarine sm in deserilizelist)
                {
                    Lists.submarineList.Add(sm);
                }
                MessageBox.Show("Объекты типа Submarine десериализованы!", "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void serialiseSubmarine_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("Submarine.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Lists.submarineList);
                Lists.submarineList.Clear();
                MessageBox.Show("Объекты типа Submarine сериализованы!", "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void deserialiseCarrier_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("AeroCarrier.dat", FileMode.OpenOrCreate))
            {
                BindingList<BattleShips.AeroCarrier> deserilizelist = (BindingList<BattleShips.AeroCarrier>)formatter.Deserialize(fs);
                foreach (BattleShips.AeroCarrier ac in deserilizelist)
                {
                    Lists.aerocarrierList.Add(ac);
                }
                MessageBox.Show("Объекты типа AeroCarrier десериализованы!", "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void serialiseCarrier_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("AeroCarrier.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Lists.aerocarrierList);
                Lists.aerocarrierList.Clear();
                MessageBox.Show("Объекты типа AeroCarrier сериализованы!", "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void deserializeDestroyer_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Destroyer.dat", FileMode.OpenOrCreate))
            {
                BindingList<BattleShips.Destroyer> deserilizelist = (BindingList<BattleShips.Destroyer>)formatter.Deserialize(fs);
                foreach (BattleShips.Destroyer ds in deserilizelist)
                {
                    Lists.destroyerList.Add(ds);
                }
                MessageBox.Show("Объекты типа Destroyer десериализованы!", "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void serializeDestroyer_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("Destroyer.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Lists.destroyerList);
                Lists.destroyerList.Clear();
                MessageBox.Show("Объекты типа Desrtoyer сериализованы!", "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void deserialiseBoat_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Boat.dat", FileMode.OpenOrCreate))
            {
                BindingList<BattleShips.Boat> deserilizelist = (BindingList<BattleShips.Boat>)formatter.Deserialize(fs);
                foreach (BattleShips.Boat bo in deserilizelist)
                {
                    Lists.boatList.Add(bo);
                }
                MessageBox.Show("Объекты типа Boat десериализованы!", "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void serializeBoat_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("Boat.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Lists.boatList);
                Lists.boatList.Clear();
                MessageBox.Show("Объекты типа Boat сериализованы!", "Сообщение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void addPlugin_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter =
                "plugins (*.DLL)|*.DLL";

            // Allow the user to select multiple images. 
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Dll Browser";
            this.openFileDialog1.InitialDirectory = @"F:\Учеба\repository\oop_lab3\LandingShipPlugin\bin\Debug";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String dllPath in openFileDialog1.FileNames)
                {
                    var pluginAssembly = Assembly.LoadFrom(dllPath);

                    foreach (Type type in pluginAssembly.GetExportedTypes())
                    {
                        if (type.GetInterfaces().Contains(typeof(IPlugin)))
                        {
                            var plugin = (IPlugin)type.GetConstructor(Type.EmptyTypes).Invoke(new Object[0]);
                            plug = plugin;
                            shipType = plugin.ShipType;
                            var ship = plugin.ShipType.GetConstructor(Type.EmptyTypes).Invoke(new Object[0]);
                            plugin.NewList();
                            listedUnknownShips.DataSource =plug.UnknownList;
                            listedUnknownShips.DisplayMember = "ShipName";
            
                            listedUnknownShips.Show();
                            serializeUnknowm.Show();
                            deserialiseUnknown.Show();
                            pluginedShipButton.Show();
                        }
                    }
                }
            }
        }

        private void pluginedShipButton_Click(object sender, EventArgs e)
        {
            numberOfFighter.Hide();
            fightersModel.Hide();
            numberOfScout.Hide();
            scoutsModel.Hide();
            numberOfBomber.Hide();
            bombersModel.Hide();
            torpedoPlaneModel.Hide();
            numberOfTorpedoPlane.Hide();
            quanityOfTower.Hide();
            quanityOfCannonInTower.Hide();
            quanityOfTorpedoTube.Hide();
            torpedosInTube.Hide();
            mainCaliber.Hide();
            SpeedOfTorpedos.Hide();
            Clear();             
            var tmp=shipType.GetConstructor(Type.EmptyTypes).Invoke(new Object[0]);
            bs =(BattleShips.BattleShip)tmp;
        }

        private void deserialiseUnknown_Click(object sender, EventArgs e)
        {
            plug.Deserialize();

        }

        private void serializeUnknowm_Click(object sender, EventArgs e)
        {
            plug.Serialize();
        }
    }
}
