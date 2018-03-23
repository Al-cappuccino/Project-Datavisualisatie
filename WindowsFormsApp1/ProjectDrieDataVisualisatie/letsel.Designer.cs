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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.gemeenteTextBox = new System.Windows.Forms.TextBox();
            this.submitGemeenteInputBtn = new System.Windows.Forms.Button();
            this.selectGemeenteComboBox = new System.Windows.Forms.ComboBox();
            this.dataSelectionCheckBox = new System.Windows.Forms.CheckedListBox();
            this.renderGraphsButton = new System.Windows.Forms.Button();
            this.dataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            // dataSelectionCheckBox
            // 
            this.dataSelectionCheckBox.FormattingEnabled = true;
            this.dataSelectionCheckBox.Items.AddRange(new object[] {
            "HIC_geweldsmisdrijven",
            "Mishandeling",
            "Openlijk_Geweld"});
            this.dataSelectionCheckBox.Location = new System.Drawing.Point(16, 139);
            this.dataSelectionCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.dataSelectionCheckBox.Name = "dataSelectionCheckBox";
            this.dataSelectionCheckBox.Size = new System.Drawing.Size(197, 184);
            this.dataSelectionCheckBox.TabIndex = 16;
            this.dataSelectionCheckBox.SelectedIndexChanged += new System.EventHandler(this.dataSelectionCheckBox_SelectedIndexChanged);
            this.dataSelectionCheckBox.ItemCheck += new ItemCheckEventHandler(this.dataSelectionCheckBox_ItemCheck);
            // 
            // renderGraphsButton
            // 
            this.renderGraphsButton.Location = new System.Drawing.Point(829, 97);
            this.renderGraphsButton.Name = "renderGraphsButton";
            this.renderGraphsButton.Size = new System.Drawing.Size(173, 23);
            this.renderGraphsButton.TabIndex = 19;
            this.renderGraphsButton.Text = "Render Graphs";
            this.renderGraphsButton.UseVisualStyleBackColor = true;
            this.renderGraphsButton.Click += new System.EventHandler(this.renderGraphsButton_Click);
            // 
            // dataChart
            // 
            this.dataChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.Name = "ChartArea1";
            this.dataChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.dataChart.Legends.Add(legend2);
            this.dataChart.Location = new System.Drawing.Point(340, 285);
            this.dataChart.Name = "dataChart";
            this.dataChart.Size = new System.Drawing.Size(674, 300);
            this.dataChart.TabIndex = 20;
            this.dataChart.Text = "chart1";
            // 
            // Letsel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataChart);
            this.Controls.Add(this.renderGraphsButton);
            this.Controls.Add(this.dataSelectionCheckBox);
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
        private System.Windows.Forms.CheckedListBox dataSelectionCheckBox;
        private System.Windows.Forms.Button renderGraphsButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart dataChart;
    }
}
