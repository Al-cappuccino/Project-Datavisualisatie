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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).BeginInit();
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
            "\'s-Gravenhage",
            "Groningen",
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
            "\'s-Hertogenbosch",
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
            "Utrecht",
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
            "Zwolle"});
            this.gemeenteTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.gemeenteTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.gemeenteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gemeenteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gemeenteTextBox.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gemeenteTextBox.ForeColor = System.Drawing.Color.White;
            this.gemeenteTextBox.Location = new System.Drawing.Point(16, 15);
            this.gemeenteTextBox.Name = "gemeenteTextBox";
            this.gemeenteTextBox.Size = new System.Drawing.Size(594, 53);
            this.gemeenteTextBox.TabIndex = 7;
            this.gemeenteTextBox.Text = "Voer plaatsnaam in...";
            this.gemeenteTextBox.Click += new System.EventHandler(this.gemeenteTextBox_Click);
            this.gemeenteTextBox.TextChanged += new System.EventHandler(this.gemeenteTextBox_TextChanged);
            // 
            // submitGemeenteInputBtn
            // 
            this.submitGemeenteInputBtn.Location = new System.Drawing.Point(625, 15);
            this.submitGemeenteInputBtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitGemeenteInputBtn.Name = "submitGemeenteInputBtn";
            this.submitGemeenteInputBtn.Size = new System.Drawing.Size(96, 53);
            this.submitGemeenteInputBtn.TabIndex = 8;
            this.submitGemeenteInputBtn.Text = "Ga";
            this.submitGemeenteInputBtn.UseVisualStyleBackColor = true;
            this.submitGemeenteInputBtn.Click += new System.EventHandler(this.addGemeenteButton_Click);
            // 
            // selectGemeenteComboBox
            // 
            this.selectGemeenteComboBox.FormattingEnabled = true;
            this.selectGemeenteComboBox.Location = new System.Drawing.Point(16, 114);
            this.selectGemeenteComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectGemeenteComboBox.Name = "selectGemeenteComboBox";
            this.selectGemeenteComboBox.Size = new System.Drawing.Size(197, 21);
            this.selectGemeenteComboBox.TabIndex = 15;
            this.selectGemeenteComboBox.SelectedIndexChanged += new System.EventHandler(this.selectGemeenteComboBox_SelectedIndexChanged);
            // 
            // dataChart
            // 
            this.dataChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea4.Name = "ChartArea1";
            this.dataChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.dataChart.Legends.Add(legend4);
            this.dataChart.Location = new System.Drawing.Point(16, 417);
            this.dataChart.Name = "dataChart";
            this.dataChart.Size = new System.Drawing.Size(674, 300);
            this.dataChart.TabIndex = 20;
            this.dataChart.Text = "chart1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(16, 140);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 17);
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
            this.checkBox2.Location = new System.Drawing.Point(16, 163);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(88, 17);
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
            this.checkBox3.Location = new System.Drawing.Point(16, 186);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(106, 17);
            this.checkBox3.TabIndex = 23;
            this.checkBox3.Text = "Openlijk_Geweld";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(319, 114);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 21);
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
            "gestapelde kolom"});
            this.comboBox2.Location = new System.Drawing.Point(569, 390);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Verander chart: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 21);
            this.button2.TabIndex = 32;
            this.button2.Text = "Vergelijken";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(622, 114);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(197, 21);
            this.comboBox3.TabIndex = 33;
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Letsel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "Letsel";
            this.Size = new System.Drawing.Size(1159, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).EndInit();
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
    }
}
