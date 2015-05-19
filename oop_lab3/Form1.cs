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

namespace oop_lab3
{    
    public interface IForm1
    {
        
    }

    public interface IShipsItems 
    {
        BindingList<BattleShips.Cruiser> cruiserList;
        BindingList<BattleShips.Submarine> submarineList;
        BindingList<BattleShips.BattleWagon> lineShipList;
        BindingList<BattleShips.AeroCarrier> aerocarrierList;
        BindingList<BattleShips.Destroyer> destroyerList;
        BindingList<BattleShips.Boat> boatList;
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

    public partial class Form1 : Form,IForm1,IShipsItems
    {
        public BindingList<BattleShips.Cruiser> cruiserList;
        public BindingList<BattleShips.Submarine> submarineList;
        public BindingList<BattleShips.BattleWagon> lineShipList;
        public BindingList<BattleShips.AeroCarrier> aerocarrierList;
        public BindingList<BattleShips.Destroyer> destroyerList;
        public BindingList<BattleShips.Boat> boatList;
        BattleShips.BattleShip bs;
        public Form1()
        {
            InitializeComponent();
            addToList.Click+=addToList_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

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
            var bs = new BattleShips.Submarine();
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
            var bs = new BattleShips.AeroCarrier();
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
            var bs = new BattleShips.BattleWagon();
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
            var bs = new BattleShips.Destroyer();
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
            var bs = new BattleShips.Boat();
        }
        public void Clear() 
        {
            shipName.Text = "";
            shipSeries.Text = "";
            shipTonnage.Text = "";
            quanityOfTower.Value = 0;
            quanityOfCannonInTower.Value = 0;
            mainCaliber.Text = "";
            quanityOfAirdefenceGun.Value = 0;
            airDefenceCaliber.Text = "";
            crew.Value = 20;
            quanityOfTorpedoTube.Value = 0;
            torpedosInTube.Value = 0;
            SpeedOfTorpedos.Text = "";
            shipSpeed.Text = "";
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
            var s=bs;
            var builder=s.FactoryMethod();
            builder.Build(new Form1());
            
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
    }
}
