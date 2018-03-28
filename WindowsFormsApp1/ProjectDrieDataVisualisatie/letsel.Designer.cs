using System.Windows.Forms;

namespace ProjectDrieDataVisualisatie
{
    partial class Letsel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Letsel));
            this.gemeenteTextBox = new System.Windows.Forms.TextBox();
            this.submitGemeenteInputBtn = new System.Windows.Forms.Button();
            this.selectGemeenteComboBox = new System.Windows.Forms.ComboBox();
            this.dataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ImageOfDeath = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfDeath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // gemeenteTextBox
            // 
            this.gemeenteTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Aa en Hunze",
            "Aalburg",
            "Aalsmeer",
            "Aalten",
            "Achtkarspelen",
            "Alblasserdam",
            "Albrandswaard",
            "Alkmaar",
            "Almelo",
            "Almere",
            "Alphen aan den Rijn",
            "Alphen-Chaam",
            "Ameland",
            "Amersfoort",
            "Amstelveen",
            "Amsterdam",
            "Apeldoorn",
            "Appingedam",
            "Arnhem",
            "Assen",
            "Asten",
            "Baarle-Nassau",
            "Baarn",
            "Barendrecht",
            "Barneveld",
            "Bedum",
            "Beek",
            "Beemster",
            "Beesel",
            "Bellingwedde",
            "Berg en Dal",
            "Bergeijk",
            "Bergen (L.)",
            "Bergen (NH.)",
            "Bergen op Zoom",
            "Berkelland",
            "Bernheze",
            "Best",
            "Beuningen",
            "Beverwijk",
            "het Bildt",
            "De Bilt",
            "Binnenmaas",
            "Bladel",
            "Blaricum",
            "Bloemendaal",
            "Bodegraven-Reeuwijk",
            "Boekel",
            "Ten Boer",
            "Borger-Odoorn",
            "Borne",
            "Borsele",
            "Boxmeer",
            "Boxtel",
            "Breda",
            "Brielle",
            "Bronckhorst",
            "Brummen",
            "Brunssum",
            "Bunnik",
            "Bunschoten",
            "Buren",
            "Capelle aan den IJssel",
            "Castricum",
            "Coevorden",
            "Cranendonck",
            "Cromstrijen",
            "Cuijk",
            "Culemborg",
            "Dalfsen",
            "Dantumadiel",
            "Delft",
            "Delfzijl",
            "Deurne",
            "Deventer",
            "Diemen",
            "Dinkelland",
            "Doesburg",
            "Doetinchem",
            "Dongen",
            "Dongeradeel",
            "Dordrecht",
            "Drechterland",
            "Drimmelen",
            "Dronten",
            "Druten",
            "Duiven",
            "Echt-Susteren",
            "Edam-Volendam",
            "Ede",
            "Eemnes",
            "Eemsmond",
            "Eersel",
            "Eijsden-Margraten",
            "Eindhoven",
            "Elburg",
            "Emmen",
            "Enkhuizen",
            "Enschede",
            "Epe",
            "Ermelo",
            "Etten-Leur",
            "Ferwerderadiel",
            "Franekeradeel",
            "De Fryske Marren",
            "Geertruidenberg",
            "Geldermalsen",
            "Geldrop-Mierlo",
            "Gemert-Bakel",
            "Gennep",
            "Giessenlanden",
            "Gilze en Rijen",
            "Goeree-Overflakkee",
            "Goes",
            "Goirle",
            "Gooise Meren",
            "Gorinchem",
            "Gouda",
            "Grave",
            "Den Haag",
            "Groningen gemeente",
            "Grootegast",
            "Gulpen-Wittem",
            "Haaksbergen",
            "Haaren",
            "Haarlem",
            "Haarlemmerliede en Spaarnwoude",
            "Haarlemmermeer",
            "Halderberge",
            "Hardenberg",
            "Harderwijk",
            "Hardinxveld-Giessendam",
            "Haren",
            "Harlingen",
            "Hattem",
            "Heemskerk",
            "Heemstede",
            "Heerde",
            "Heerenveen",
            "Heerhugowaard",
            "Heerlen",
            "Heeze-Leende",
            "Heiloo",
            "Den Helder",
            "Hellendoorn",
            "Hellevoetsluis",
            "Helmond",
            "Hendrik-Ido-Ambacht",
            "Hengelo",
            "Den Bosch",
            "Heumen",
            "Heusden",
            "Hillegom",
            "Hilvarenbeek",
            "Hilversum",
            "Hof van Twente",
            "Hollands Kroon",
            "Hoogeveen",
            "Hoogezand-Sappemeer",
            "Hoorn",
            "Horst aan de Maas",
            "Houten",
            "Huizen",
            "Hulst",
            "IJsselstein",
            "Kaag en Braassem",
            "Kampen",
            "Kapelle",
            "Katwijk",
            "Kerkrade",
            "Koggenland",
            "Kollumerland en Nieuwkruisland",
            "Korendijk",
            "Krimpen aan den IJssel",
            "Krimpenerwaard",
            "Laarbeek",
            "Landerd",
            "Landgraaf",
            "Landsmeer",
            "Langedijk",
            "Lansingerland",
            "Laren",
            "Leek",
            "Leerdam",
            "Leeuwarden",
            "Leeuwarderadeel",
            "Leiden",
            "Leiderdorp",
            "Leidschendam-Voorburg",
            "Lelystad",
            "Leudal",
            "Leusden",
            "Lingewaal",
            "Lingewaard",
            "Lisse",
            "Littenseradiel",
            "Lochem",
            "Loon op Zand",
            "Lopik",
            "Loppersum",
            "Losser",
            "Maasdriel",
            "Maasgouw",
            "Maassluis",
            "Maastricht",
            "De Marne",
            "Marum",
            "Medemblik",
            "Meerssen",
            "Menameradiel",
            "Menterwolde",
            "Meppel",
            "Middelburg",
            "Midden-Delfland",
            "Midden-Drenthe",
            "Mill en Sint Hubert",
            "Moerdijk",
            "Molenwaard",
            "Montferland",
            "Montfoort",
            "Mook en Middelaar",
            "Neder-Betuwe",
            "Nederweert",
            "Neerijnen",
            "Nieuwegein",
            "Nieuwkoop",
            "Nijkerk",
            "Nijmegen",
            "Nissewaard",
            "Noord-Beveland",
            "Noordenveld",
            "Noordoostpolder",
            "Noordwijk",
            "Noordwijkerhout",
            "Nuenen, Gerwen en Nederwetten",
            "Nunspeet",
            "Nuth",
            "Oegstgeest",
            "Oirschot",
            "Oisterwijk",
            "Oldambt",
            "Oldebroek",
            "Oldenzaal",
            "Olst-Wijhe",
            "Ommen",
            "Onderbanken",
            "Oost Gelre",
            "Oosterhout",
            "Ooststellingwerf",
            "Oostzaan",
            "Opmeer",
            "Opsterland",
            "Oss",
            "Oud-Beijerland",
            "Oude IJsselstreek",
            "Ouder-Amstel",
            "Oudewater",
            "Overbetuwe",
            "Papendrecht",
            "Peel en Maas",
            "Pekela",
            "Pijnacker-Nootdorp",
            "Purmerend",
            "Putten",
            "Raalte",
            "Reimerswaal",
            "Renkum",
            "Renswoude",
            "Reusel-De Mierden",
            "Rheden",
            "Rhenen",
            "Ridderkerk",
            "Rijnwaarden",
            "Rijssen-Holten",
            "Rijswijk",
            "Roerdalen",
            "Roermond",
            "De Ronde Venen",
            "Roosendaal",
            "Rotterdam",
            "Rozendaal",
            "Rucphen",
            "Schagen",
            "Scherpenzeel",
            "Schiedam",
            "Schiermonnikoog",
            "Schijndel",
            "Schinnen",
            "Schouwen-Duiveland",
            "Simpelveld",
            "Sint Anthonis",
            "Sint-Michielsgestel",
            "Sint-Oedenrode",
            "Sittard-Geleen",
            "Sliedrecht",
            "Slochteren",
            "Sluis",
            "Smallingerland",
            "Soest",
            "Someren",
            "Son en Breugel",
            "Stadskanaal",
            "Staphorst",
            "Stede Broec",
            "Steenbergen",
            "Steenwijkerland",
            "Stein",
            "Stichtse Vecht",
            "Strijen",
            "Súdwest-Fryslân",
            "Terneuzen",
            "Terschelling",
            "Texel",
            "Teylingen",
            "Tholen",
            "Tiel",
            "Tilburg",
            "Tubbergen",
            "Twenterand",
            "Tynaarlo",
            "Tytsjerksteradiel",
            "Uden",
            "Uitgeest",
            "Uithoorn",
            "Urk",
            "Utrecht gemeente",
            "Utrechtse Heuvelrug",
            "Vaals",
            "Valkenburg aan de Geul",
            "Valkenswaard",
            "Veendam",
            "Veenendaal",
            "Veere",
            "Veghel",
            "Veldhoven",
            "Velsen",
            "Venlo",
            "Venray",
            "Vianen",
            "Vlaardingen",
            "Vlagtwedde",
            "Vlieland",
            "Vlissingen",
            "Voerendaal",
            "Voorschoten",
            "Voorst",
            "Vught",
            "Waalre",
            "Waalwijk",
            "Waddinxveen",
            "Wageningen",
            "Wassenaar",
            "Waterland",
            "Weert",
            "Weesp",
            "Werkendam",
            "West Maas en Waal",
            "Westerveld",
            "Westervoort",
            "Westland",
            "Weststellingwerf",
            "Westvoorne",
            "Wierden",
            "Wijchen",
            "Wijdemeren",
            "Wijk bij Duurstede",
            "Winsum",
            "Winterswijk",
            "Woensdrecht",
            "Woerden",
            "De Wolden",
            "Wormerland",
            "Woudenberg",
            "Woudrichem",
            "Zaanstad",
            "Zaltbommel",
            "Zandvoort",
            "Zederik",
            "Zeewolde",
            "Zeist",
            "Zevenaar",
            "Zoetermeer",
            "Zoeterwoude",
            "Zuidhorn",
            "Zuidplas",
            "Zundert",
            "Zutphen",
            "Zwartewaterland",
            "Zwijndrecht",
            "Zwolle",
            "Drenthe",
            "Noord-Brabant",
            "Noord-Holland",
            "Gelderland",
            "Friesland",
            "Zuid-Holland",
            "Overijssel",
            "Flevoland",
            "Groningen",
            "Zeeland",
            "Limburg",
            "Utrecht"});
            this.gemeenteTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.gemeenteTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.gemeenteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gemeenteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gemeenteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.gemeenteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gemeenteTextBox.ForeColor = System.Drawing.Color.White;
            this.gemeenteTextBox.Location = new System.Drawing.Point(21, 16);
            this.gemeenteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gemeenteTextBox.Name = "gemeenteTextBox";
            this.gemeenteTextBox.Size = new System.Drawing.Size(978, 60);
            this.gemeenteTextBox.TabIndex = 7;
            this.gemeenteTextBox.Text = "voer plaatsnaam in...";
            this.gemeenteTextBox.Click += new System.EventHandler(this.gemeenteTextBox_Click);
            this.gemeenteTextBox.TextChanged += new System.EventHandler(this.gemeenteTextBox_TextChanged);
            // 
            // submitGemeenteInputBtn
            // 
            this.submitGemeenteInputBtn.Location = new System.Drawing.Point(1023, 16);
            this.submitGemeenteInputBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitGemeenteInputBtn.Name = "submitGemeenteInputBtn";
            this.submitGemeenteInputBtn.Size = new System.Drawing.Size(128, 60);
            this.submitGemeenteInputBtn.TabIndex = 8;
            this.submitGemeenteInputBtn.Text = "Ga";
            this.submitGemeenteInputBtn.UseVisualStyleBackColor = true;
            this.submitGemeenteInputBtn.Click += new System.EventHandler(this.addGemeenteButton_Click);
            // 
            // selectGemeenteComboBox
            // 
            this.selectGemeenteComboBox.FormattingEnabled = true;
            this.selectGemeenteComboBox.Location = new System.Drawing.Point(24, 101);
            this.selectGemeenteComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectGemeenteComboBox.Name = "selectGemeenteComboBox";
            this.selectGemeenteComboBox.Size = new System.Drawing.Size(261, 24);
            this.selectGemeenteComboBox.TabIndex = 15;
            this.selectGemeenteComboBox.SelectedIndexChanged += new System.EventHandler(this.selectGemeenteComboBox_SelectedIndexChanged);
            // 
            // dataChart
            // 
            this.dataChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea8.AxisX.Interval = 1D;
            chartArea8.AxisX.IntervalOffset = 1D;
            chartArea8.Name = "ChartArea1";
            this.dataChart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.dataChart.Legends.Add(legend8);
            this.dataChart.Location = new System.Drawing.Point(21, 304);
            this.dataChart.Margin = new System.Windows.Forms.Padding(4);
            this.dataChart.Name = "dataChart";
            this.dataChart.Size = new System.Drawing.Size(1456, 634);
            this.dataChart.TabIndex = 20;
            this.dataChart.Text = "chart1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(517, 103);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(174, 21);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "HIC_geweldsmisdrijven";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(517, 132);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(113, 21);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "Mishandeling";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(517, 160);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(136, 21);
            this.checkBox3.TabIndex = 23;
            this.checkBox3.Text = "Openlijk_Geweld";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 143);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 24);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 26);
            this.button1.TabIndex = 29;
            this.button1.Text = "Vergelijken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "kolomdiagram",
            "gestapelde kolom",
            "Piechart Beta"});
            this.comboBox2.Location = new System.Drawing.Point(916, 271);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(797, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Verander chart: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 143);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 26);
            this.button2.TabIndex = 32;
            this.button2.Text = "Vergelijken";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(24, 187);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(261, 24);
            this.comboBox3.TabIndex = 33;
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(24, 234);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(261, 24);
            this.comboBox4.TabIndex = 35;
            this.comboBox4.Visible = false;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(293, 186);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 26);
            this.button3.TabIndex = 34;
            this.button3.Text = "Vergelijken";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1179, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Nederland 1.png");
            this.imageList1.Images.SetKeyName(1, "Zuid-Holland2.png");
            this.imageList1.Images.SetKeyName(2, "Zeeland3.png");
            this.imageList1.Images.SetKeyName(3, "Noord-Holland4.png");
            this.imageList1.Images.SetKeyName(4, "Utrecht5.png");
            this.imageList1.Images.SetKeyName(5, "Flevoland6.png");
            this.imageList1.Images.SetKeyName(6, "Gelderland7.png");
            this.imageList1.Images.SetKeyName(7, "Limburg8.png");
            this.imageList1.Images.SetKeyName(8, "Overijssel9.png");
            this.imageList1.Images.SetKeyName(9, "Noord-Brabant10.png");
            this.imageList1.Images.SetKeyName(10, "Friesland11.png");
            this.imageList1.Images.SetKeyName(11, "Groningen12.png");
            this.imageList1.Images.SetKeyName(12, "Drenthe13.png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ImageOfDeath
            // 
            this.ImageOfDeath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ImageOfDeath.Location = new System.Drawing.Point(0, 0);
            this.ImageOfDeath.Name = "ImageOfDeath";
            this.ImageOfDeath.Size = new System.Drawing.Size(1551, 982);
            this.ImageOfDeath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageOfDeath.TabIndex = 40;
            this.ImageOfDeath.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1548, 1024);
            this.axWindowsMediaPlayer1.TabIndex = 41;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // Letsel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataChart);
            this.Controls.Add(this.selectGemeenteComboBox);
            this.Controls.Add(this.submitGemeenteInputBtn);
            this.Controls.Add(this.gemeenteTextBox);
            this.Controls.Add(this.ImageOfDeath);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Letsel";
            this.Size = new System.Drawing.Size(1551, 982);
            this.Load += new System.EventHandler(this.Letsel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfDeath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gemeenteTextBox;
        private System.Windows.Forms.Button submitGemeenteInputBtn;
        private System.Windows.Forms.ComboBox selectGemeenteComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart dataChart;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private ComboBox comboBox1;
        private Button button1;
        private ComboBox comboBox2;
        private Label label1;
        private Button button2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button button3;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private OpenFileDialog openFileDialog1;
        private ImageList imageList2;
        private PictureBox ImageOfDeath;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Timer timer1;
    }
}
