namespace oop_lab3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cruiserButton = new System.Windows.Forms.Button();
            this.destroyerButton = new System.Windows.Forms.Button();
            this.battleWagonButton = new System.Windows.Forms.Button();
            this.aerocarrierButton = new System.Windows.Forms.Button();
            this.submarineButton = new System.Windows.Forms.Button();
            this.battleBoatButton = new System.Windows.Forms.Button();
            this.saveShipButton = new System.Windows.Forms.Button();
            this.loadShipButton = new System.Windows.Forms.Button();
            this.shipName = new System.Windows.Forms.TextBox();
            this.shipSeries = new System.Windows.Forms.TextBox();
            this.quanityOfTower = new System.Windows.Forms.NumericUpDown();
            this.quanityOfCannonInTower = new System.Windows.Forms.NumericUpDown();
            this.quanityOfAirdefenceGun = new System.Windows.Forms.NumericUpDown();
            this.crew = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.quanityOfTorpedoTube = new System.Windows.Forms.NumericUpDown();
            this.torpedosInTube = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numberOfScout = new System.Windows.Forms.NumericUpDown();
            this.scoutsModel = new System.Windows.Forms.TextBox();
            this.numberOfTorpedoPlane = new System.Windows.Forms.NumericUpDown();
            this.numberOfBomber = new System.Windows.Forms.NumericUpDown();
            this.numberOfFighter = new System.Windows.Forms.NumericUpDown();
            this.torpedoPlaneModel = new System.Windows.Forms.TextBox();
            this.bombersModel = new System.Windows.Forms.TextBox();
            this.fightersModel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.addToList = new System.Windows.Forms.Button();
            this.listedCruisers = new System.Windows.Forms.ListBox();
            this.listedLineShips = new System.Windows.Forms.ListBox();
            this.listedSubmarine = new System.Windows.Forms.ListBox();
            this.listedAeroCarrier = new System.Windows.Forms.ListBox();
            this.listedDestroyer = new System.Windows.Forms.ListBox();
            this.listedBoat = new System.Windows.Forms.ListBox();
            this.mainCaliber = new System.Windows.Forms.NumericUpDown();
            this.airDefenceCaliber = new System.Windows.Forms.NumericUpDown();
            this.shipSpeed = new System.Windows.Forms.NumericUpDown();
            this.shipTonnage = new System.Windows.Forms.NumericUpDown();
            this.SpeedOfTorpedos = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quanityOfTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanityOfCannonInTower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanityOfAirdefenceGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanityOfTorpedoTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torpedosInTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfScout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTorpedoPlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfBomber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfFighter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCaliber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airDefenceCaliber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipTonnage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedOfTorpedos)).BeginInit();
            this.SuspendLayout();
            // 
            // cruiserButton
            // 
            this.cruiserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cruiserButton.Location = new System.Drawing.Point(12, 440);
            this.cruiserButton.Name = "cruiserButton";
            this.cruiserButton.Size = new System.Drawing.Size(75, 23);
            this.cruiserButton.TabIndex = 1;
            this.cruiserButton.Text = "Cruiser";
            this.cruiserButton.UseVisualStyleBackColor = true;
            this.cruiserButton.Click += new System.EventHandler(this.cruiserButton_Click);
            // 
            // destroyerButton
            // 
            this.destroyerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.destroyerButton.Location = new System.Drawing.Point(93, 440);
            this.destroyerButton.Name = "destroyerButton";
            this.destroyerButton.Size = new System.Drawing.Size(75, 23);
            this.destroyerButton.TabIndex = 2;
            this.destroyerButton.Text = "Destroyer";
            this.destroyerButton.UseVisualStyleBackColor = true;
            this.destroyerButton.Click += new System.EventHandler(this.destroyerButton_Click);
            // 
            // battleWagonButton
            // 
            this.battleWagonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.battleWagonButton.Location = new System.Drawing.Point(174, 440);
            this.battleWagonButton.Name = "battleWagonButton";
            this.battleWagonButton.Size = new System.Drawing.Size(75, 23);
            this.battleWagonButton.TabIndex = 3;
            this.battleWagonButton.Text = "Linkor";
            this.battleWagonButton.UseVisualStyleBackColor = true;
            this.battleWagonButton.Click += new System.EventHandler(this.battleWagonButton_Click);
            // 
            // aerocarrierButton
            // 
            this.aerocarrierButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aerocarrierButton.Location = new System.Drawing.Point(255, 440);
            this.aerocarrierButton.Name = "aerocarrierButton";
            this.aerocarrierButton.Size = new System.Drawing.Size(75, 23);
            this.aerocarrierButton.TabIndex = 4;
            this.aerocarrierButton.Text = "AeroCarrier";
            this.aerocarrierButton.UseVisualStyleBackColor = true;
            this.aerocarrierButton.Click += new System.EventHandler(this.aerocarrierButton_Click);
            // 
            // submarineButton
            // 
            this.submarineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.submarineButton.Location = new System.Drawing.Point(336, 440);
            this.submarineButton.Name = "submarineButton";
            this.submarineButton.Size = new System.Drawing.Size(75, 23);
            this.submarineButton.TabIndex = 5;
            this.submarineButton.Text = "Submarine";
            this.submarineButton.UseVisualStyleBackColor = true;
            this.submarineButton.Click += new System.EventHandler(this.submarineButton_Click);
            // 
            // battleBoatButton
            // 
            this.battleBoatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.battleBoatButton.Location = new System.Drawing.Point(417, 440);
            this.battleBoatButton.Name = "battleBoatButton";
            this.battleBoatButton.Size = new System.Drawing.Size(75, 23);
            this.battleBoatButton.TabIndex = 6;
            this.battleBoatButton.Text = "Boat";
            this.battleBoatButton.UseVisualStyleBackColor = true;
            this.battleBoatButton.Click += new System.EventHandler(this.battleBoatButton_Click);
            // 
            // saveShipButton
            // 
            this.saveShipButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveShipButton.Location = new System.Drawing.Point(460, 411);
            this.saveShipButton.Name = "saveShipButton";
            this.saveShipButton.Size = new System.Drawing.Size(75, 23);
            this.saveShipButton.TabIndex = 8;
            this.saveShipButton.Text = "Save";
            this.saveShipButton.UseVisualStyleBackColor = true;
            // 
            // loadShipButton
            // 
            this.loadShipButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadShipButton.Location = new System.Drawing.Point(541, 411);
            this.loadShipButton.Name = "loadShipButton";
            this.loadShipButton.Size = new System.Drawing.Size(75, 23);
            this.loadShipButton.TabIndex = 9;
            this.loadShipButton.Text = "Load";
            this.loadShipButton.UseVisualStyleBackColor = true;
            // 
            // shipName
            // 
            this.shipName.Location = new System.Drawing.Point(81, 12);
            this.shipName.Name = "shipName";
            this.shipName.Size = new System.Drawing.Size(132, 20);
            this.shipName.TabIndex = 10;
            // 
            // shipSeries
            // 
            this.shipSeries.Location = new System.Drawing.Point(81, 41);
            this.shipSeries.Name = "shipSeries";
            this.shipSeries.Size = new System.Drawing.Size(132, 20);
            this.shipSeries.TabIndex = 11;
            // 
            // quanityOfTower
            // 
            this.quanityOfTower.Location = new System.Drawing.Point(81, 90);
            this.quanityOfTower.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.quanityOfTower.Name = "quanityOfTower";
            this.quanityOfTower.Size = new System.Drawing.Size(38, 20);
            this.quanityOfTower.TabIndex = 13;
            // 
            // quanityOfCannonInTower
            // 
            this.quanityOfCannonInTower.Location = new System.Drawing.Point(175, 90);
            this.quanityOfCannonInTower.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.quanityOfCannonInTower.Name = "quanityOfCannonInTower";
            this.quanityOfCannonInTower.Size = new System.Drawing.Size(38, 20);
            this.quanityOfCannonInTower.TabIndex = 14;
            this.quanityOfCannonInTower.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // quanityOfAirdefenceGun
            // 
            this.quanityOfAirdefenceGun.Location = new System.Drawing.Point(83, 144);
            this.quanityOfAirdefenceGun.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.quanityOfAirdefenceGun.Name = "quanityOfAirdefenceGun";
            this.quanityOfAirdefenceGun.Size = new System.Drawing.Size(38, 20);
            this.quanityOfAirdefenceGun.TabIndex = 16;
            // 
            // crew
            // 
            this.crew.Location = new System.Drawing.Point(81, 170);
            this.crew.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.crew.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.crew.Name = "crew";
            this.crew.Size = new System.Drawing.Size(60, 20);
            this.crew.TabIndex = 18;
            this.crew.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Series";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tonnage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Towers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cannons";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Main Caliber";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-7, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "AirDefenesGuns";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Caliber";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Crew";
            // 
            // quanityOfTorpedoTube
            // 
            this.quanityOfTorpedoTube.Location = new System.Drawing.Point(81, 196);
            this.quanityOfTorpedoTube.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.quanityOfTorpedoTube.Name = "quanityOfTorpedoTube";
            this.quanityOfTorpedoTube.Size = new System.Drawing.Size(38, 20);
            this.quanityOfTorpedoTube.TabIndex = 28;
            // 
            // torpedosInTube
            // 
            this.torpedosInTube.Location = new System.Drawing.Point(175, 196);
            this.torpedosInTube.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.torpedosInTube.Name = "torpedosInTube";
            this.torpedosInTube.Size = new System.Drawing.Size(38, 20);
            this.torpedosInTube.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "TorpedoTubes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Torpedos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-1, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Torpedo\'s Speed";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Ship\'s Speed";
            // 
            // numberOfScout
            // 
            this.numberOfScout.Location = new System.Drawing.Point(81, 274);
            this.numberOfScout.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfScout.Name = "numberOfScout";
            this.numberOfScout.Size = new System.Drawing.Size(38, 20);
            this.numberOfScout.TabIndex = 36;
            this.numberOfScout.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // scoutsModel
            // 
            this.scoutsModel.Location = new System.Drawing.Point(125, 274);
            this.scoutsModel.Name = "scoutsModel";
            this.scoutsModel.Size = new System.Drawing.Size(132, 20);
            this.scoutsModel.TabIndex = 37;
            // 
            // numberOfTorpedoPlane
            // 
            this.numberOfTorpedoPlane.Location = new System.Drawing.Point(81, 300);
            this.numberOfTorpedoPlane.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numberOfTorpedoPlane.Name = "numberOfTorpedoPlane";
            this.numberOfTorpedoPlane.Size = new System.Drawing.Size(38, 20);
            this.numberOfTorpedoPlane.TabIndex = 38;
            // 
            // numberOfBomber
            // 
            this.numberOfBomber.Location = new System.Drawing.Point(81, 326);
            this.numberOfBomber.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numberOfBomber.Name = "numberOfBomber";
            this.numberOfBomber.Size = new System.Drawing.Size(38, 20);
            this.numberOfBomber.TabIndex = 39;
            // 
            // numberOfFighter
            // 
            this.numberOfFighter.Location = new System.Drawing.Point(81, 352);
            this.numberOfFighter.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numberOfFighter.Name = "numberOfFighter";
            this.numberOfFighter.Size = new System.Drawing.Size(38, 20);
            this.numberOfFighter.TabIndex = 40;
            // 
            // torpedoPlaneModel
            // 
            this.torpedoPlaneModel.Location = new System.Drawing.Point(125, 300);
            this.torpedoPlaneModel.Name = "torpedoPlaneModel";
            this.torpedoPlaneModel.Size = new System.Drawing.Size(132, 20);
            this.torpedoPlaneModel.TabIndex = 41;
            // 
            // bombersModel
            // 
            this.bombersModel.Location = new System.Drawing.Point(125, 325);
            this.bombersModel.Name = "bombersModel";
            this.bombersModel.Size = new System.Drawing.Size(132, 20);
            this.bombersModel.TabIndex = 42;
            // 
            // fightersModel
            // 
            this.fightersModel.Location = new System.Drawing.Point(125, 352);
            this.fightersModel.Name = "fightersModel";
            this.fightersModel.Size = new System.Drawing.Size(132, 20);
            this.fightersModel.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Scouts";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(-1, 302);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Torpedo Planes";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 328);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Bombers";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 355);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = "Fighters";
            // 
            // countryBox
            // 
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Location = new System.Drawing.Point(81, 378);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(176, 21);
            this.countryBox.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 381);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 49;
            this.label18.Text = "Country";
            // 
            // addToList
            // 
            this.addToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addToList.Location = new System.Drawing.Point(182, 405);
            this.addToList.Name = "addToList";
            this.addToList.Size = new System.Drawing.Size(75, 23);
            this.addToList.TabIndex = 50;
            this.addToList.Text = "Add to list";
            this.addToList.UseVisualStyleBackColor = true;
            this.addToList.Click += new System.EventHandler(this.addToList_Click);
            // 
            // listedCruisers
            // 
            this.listedCruisers.FormattingEnabled = true;
            this.listedCruisers.Location = new System.Drawing.Point(336, 10);
            this.listedCruisers.Name = "listedCruisers";
            this.listedCruisers.Size = new System.Drawing.Size(120, 95);
            this.listedCruisers.TabIndex = 51;
            // 
            // listedLineShips
            // 
            this.listedLineShips.FormattingEnabled = true;
            this.listedLineShips.Location = new System.Drawing.Point(336, 121);
            this.listedLineShips.Name = "listedLineShips";
            this.listedLineShips.Size = new System.Drawing.Size(120, 95);
            this.listedLineShips.TabIndex = 52;
            // 
            // listedSubmarine
            // 
            this.listedSubmarine.FormattingEnabled = true;
            this.listedSubmarine.Location = new System.Drawing.Point(336, 225);
            this.listedSubmarine.Name = "listedSubmarine";
            this.listedSubmarine.Size = new System.Drawing.Size(120, 95);
            this.listedSubmarine.TabIndex = 53;
            // 
            // listedAeroCarrier
            // 
            this.listedAeroCarrier.FormattingEnabled = true;
            this.listedAeroCarrier.Location = new System.Drawing.Point(709, 10);
            this.listedAeroCarrier.Name = "listedAeroCarrier";
            this.listedAeroCarrier.Size = new System.Drawing.Size(120, 95);
            this.listedAeroCarrier.TabIndex = 54;
            // 
            // listedDestroyer
            // 
            this.listedDestroyer.FormattingEnabled = true;
            this.listedDestroyer.Location = new System.Drawing.Point(709, 121);
            this.listedDestroyer.Name = "listedDestroyer";
            this.listedDestroyer.Size = new System.Drawing.Size(120, 95);
            this.listedDestroyer.TabIndex = 55;
            // 
            // listedBoat
            // 
            this.listedBoat.FormattingEnabled = true;
            this.listedBoat.Location = new System.Drawing.Point(709, 225);
            this.listedBoat.Name = "listedBoat";
            this.listedBoat.Size = new System.Drawing.Size(120, 95);
            this.listedBoat.TabIndex = 56;
            // 
            // mainCaliber
            // 
            this.mainCaliber.Location = new System.Drawing.Point(83, 118);
            this.mainCaliber.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.mainCaliber.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.mainCaliber.Name = "mainCaliber";
            this.mainCaliber.Size = new System.Drawing.Size(78, 20);
            this.mainCaliber.TabIndex = 57;
            this.mainCaliber.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // airDefenceCaliber
            // 
            this.airDefenceCaliber.Location = new System.Drawing.Point(167, 144);
            this.airDefenceCaliber.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.airDefenceCaliber.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.airDefenceCaliber.Name = "airDefenceCaliber";
            this.airDefenceCaliber.Size = new System.Drawing.Size(46, 20);
            this.airDefenceCaliber.TabIndex = 58;
            this.airDefenceCaliber.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // shipSpeed
            // 
            this.shipSpeed.Location = new System.Drawing.Point(81, 248);
            this.shipSpeed.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.shipSpeed.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.shipSpeed.Name = "shipSpeed";
            this.shipSpeed.Size = new System.Drawing.Size(132, 20);
            this.shipSpeed.TabIndex = 59;
            this.shipSpeed.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // shipTonnage
            // 
            this.shipTonnage.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.shipTonnage.Location = new System.Drawing.Point(81, 67);
            this.shipTonnage.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.shipTonnage.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.shipTonnage.Name = "shipTonnage";
            this.shipTonnage.Size = new System.Drawing.Size(132, 20);
            this.shipTonnage.TabIndex = 60;
            this.shipTonnage.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // SpeedOfTorpedos
            // 
            this.SpeedOfTorpedos.Location = new System.Drawing.Point(93, 222);
            this.SpeedOfTorpedos.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SpeedOfTorpedos.Name = "SpeedOfTorpedos";
            this.SpeedOfTorpedos.Size = new System.Drawing.Size(120, 20);
            this.SpeedOfTorpedos.TabIndex = 61;
            this.SpeedOfTorpedos.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 477);
            this.Controls.Add(this.SpeedOfTorpedos);
            this.Controls.Add(this.shipTonnage);
            this.Controls.Add(this.shipSpeed);
            this.Controls.Add(this.airDefenceCaliber);
            this.Controls.Add(this.mainCaliber);
            this.Controls.Add(this.listedBoat);
            this.Controls.Add(this.listedDestroyer);
            this.Controls.Add(this.listedAeroCarrier);
            this.Controls.Add(this.listedSubmarine);
            this.Controls.Add(this.listedLineShips);
            this.Controls.Add(this.listedCruisers);
            this.Controls.Add(this.addToList);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.fightersModel);
            this.Controls.Add(this.bombersModel);
            this.Controls.Add(this.torpedoPlaneModel);
            this.Controls.Add(this.numberOfFighter);
            this.Controls.Add(this.numberOfBomber);
            this.Controls.Add(this.numberOfTorpedoPlane);
            this.Controls.Add(this.scoutsModel);
            this.Controls.Add(this.numberOfScout);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.torpedosInTube);
            this.Controls.Add(this.quanityOfTorpedoTube);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crew);
            this.Controls.Add(this.quanityOfAirdefenceGun);
            this.Controls.Add(this.quanityOfCannonInTower);
            this.Controls.Add(this.quanityOfTower);
            this.Controls.Add(this.shipSeries);
            this.Controls.Add(this.shipName);
            this.Controls.Add(this.loadShipButton);
            this.Controls.Add(this.saveShipButton);
            this.Controls.Add(this.battleBoatButton);
            this.Controls.Add(this.submarineButton);
            this.Controls.Add(this.aerocarrierButton);
            this.Controls.Add(this.battleWagonButton);
            this.Controls.Add(this.destroyerButton);
            this.Controls.Add(this.cruiserButton);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanityOfTower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanityOfCannonInTower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanityOfAirdefenceGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanityOfTorpedoTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torpedosInTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfScout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTorpedoPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfBomber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfFighter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCaliber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airDefenceCaliber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipTonnage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedOfTorpedos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cruiserButton;
        private System.Windows.Forms.Button destroyerButton;
        private System.Windows.Forms.Button battleWagonButton;
        private System.Windows.Forms.Button aerocarrierButton;
        private System.Windows.Forms.Button submarineButton;
        private System.Windows.Forms.Button battleBoatButton;
        private System.Windows.Forms.Button saveShipButton;
        private System.Windows.Forms.Button loadShipButton;
        private System.Windows.Forms.TextBox shipName;
        private System.Windows.Forms.TextBox shipSeries;
        private System.Windows.Forms.NumericUpDown quanityOfTower;
        private System.Windows.Forms.NumericUpDown quanityOfCannonInTower;
        private System.Windows.Forms.NumericUpDown quanityOfAirdefenceGun;
        private System.Windows.Forms.NumericUpDown crew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown quanityOfTorpedoTube;
        private System.Windows.Forms.NumericUpDown torpedosInTube;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numberOfScout;
        private System.Windows.Forms.TextBox scoutsModel;
        private System.Windows.Forms.NumericUpDown numberOfTorpedoPlane;
        private System.Windows.Forms.NumericUpDown numberOfBomber;
        private System.Windows.Forms.NumericUpDown numberOfFighter;
        private System.Windows.Forms.TextBox torpedoPlaneModel;
        private System.Windows.Forms.TextBox bombersModel;
        private System.Windows.Forms.TextBox fightersModel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button addToList;
        private System.Windows.Forms.ListBox listedCruisers;
        private System.Windows.Forms.ListBox listedLineShips;
        private System.Windows.Forms.ListBox listedSubmarine;
        private System.Windows.Forms.ListBox listedAeroCarrier;
        private System.Windows.Forms.ListBox listedDestroyer;
        private System.Windows.Forms.ListBox listedBoat;
        private System.Windows.Forms.NumericUpDown mainCaliber;
        private System.Windows.Forms.NumericUpDown airDefenceCaliber;
        private System.Windows.Forms.NumericUpDown shipSpeed;
        private System.Windows.Forms.NumericUpDown shipTonnage;
        private System.Windows.Forms.NumericUpDown SpeedOfTorpedos;
    }
}

