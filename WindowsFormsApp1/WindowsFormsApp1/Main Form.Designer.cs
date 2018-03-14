namespace WindowsFormsApp1
{
    partial class Main_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.database1Diefstal = new WindowsFormsApp1.Database1Diefstal();
            this.diefstalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diefstalTableAdapter = new WindowsFormsApp1.Database1DiefstalTableAdapters.DiefstalTableAdapter();
            this.diefstalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.FrontLeftPanel = new System.Windows.Forms.Panel();
            this.DiefstalButton = new System.Windows.Forms.Button();
            this.LetselButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AreaSearchbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActivePanel = new System.Windows.Forms.Panel();
            this.LetselPanel = new System.Windows.Forms.Panel();
            this.DiefstalPanel = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart6 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1Diefstal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diefstalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diefstalBindingSource1)).BeginInit();
            this.FrontLeftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.LetselPanel.SuspendLayout();
            this.DiefstalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // database1Diefstal
            // 
            this.database1Diefstal.DataSetName = "Database1Diefstal";
            this.database1Diefstal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diefstalBindingSource
            // 
            this.diefstalBindingSource.DataMember = "Diefstal";
            this.diefstalBindingSource.DataSource = this.database1Diefstal;
            // 
            // diefstalTableAdapter
            // 
            this.diefstalTableAdapter.ClearBeforeFill = true;
            // 
            // diefstalBindingSource1
            // 
            this.diefstalBindingSource1.DataMember = "Diefstal";
            this.diefstalBindingSource1.DataSource = this.database1Diefstal;
            // 
            // FrontLeftPanel
            // 
            this.FrontLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.FrontLeftPanel.Controls.Add(this.DiefstalButton);
            this.FrontLeftPanel.Controls.Add(this.LetselButton);
            this.FrontLeftPanel.Controls.Add(this.label1);
            this.FrontLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FrontLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.FrontLeftPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FrontLeftPanel.Name = "FrontLeftPanel";
            this.FrontLeftPanel.Size = new System.Drawing.Size(220, 862);
            this.FrontLeftPanel.TabIndex = 5;
            // 
            // DiefstalButton
            // 
            this.DiefstalButton.FlatAppearance.BorderSize = 0;
            this.DiefstalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.DiefstalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiefstalButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiefstalButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.DiefstalButton.Image = ((System.Drawing.Image)(resources.GetObject("DiefstalButton.Image")));
            this.DiefstalButton.Location = new System.Drawing.Point(0, 354);
            this.DiefstalButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DiefstalButton.Name = "DiefstalButton";
            this.DiefstalButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DiefstalButton.Size = new System.Drawing.Size(216, 158);
            this.DiefstalButton.TabIndex = 2;
            this.DiefstalButton.Text = "Diefstal";
            this.DiefstalButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DiefstalButton.UseVisualStyleBackColor = false;
            this.DiefstalButton.Click += new System.EventHandler(this.DiefstalButton_Click);
            // 
            // LetselButton
            // 
            this.LetselButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LetselButton.FlatAppearance.BorderSize = 0;
            this.LetselButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.LetselButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LetselButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LetselButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.LetselButton.Image = ((System.Drawing.Image)(resources.GetObject("LetselButton.Image")));
            this.LetselButton.Location = new System.Drawing.Point(-2, 155);
            this.LetselButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LetselButton.Name = "LetselButton";
            this.LetselButton.Size = new System.Drawing.Size(220, 158);
            this.LetselButton.TabIndex = 1;
            this.LetselButton.Text = "Letsel";
            this.LetselButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LetselButton.UseVisualStyleBackColor = true;
            this.LetselButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "TDFNR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AreaSearchbox
            // 
            this.AreaSearchbox.AutoCompleteCustomSource.AddRange(new string[] {
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
            "Barneveld                     ",
            "Bedum                         ",
            "Beek                          ",
            "Beemster                      ",
            "Beesel                        ",
            "Bellingwedde                  ",
            "Berg en Dal                   ",
            "Bergeijk                      ",
            "Bergen (L.)                   ",
            "Bergen (NH.)                  ",
            "Bergen op Zoom                ",
            "Berkelland                    ",
            "Bernheze                      ",
            "Best                          ",
            "Beuningen                     ",
            "Beverwijk                     ",
            "het Bildt                     ",
            "De Bilt                       ",
            "Binnenmaas                    ",
            "Bladel                        ",
            "Blaricum                      ",
            "Bloemendaal                   ",
            "Bodegraven-Reeuwijk           ",
            "Boekel                        ",
            "Ten Boer                      ",
            "Borger-Odoorn                 ",
            "Borne                         ",
            "Borsele                       ",
            "Boxmeer                       ",
            "Boxtel                        ",
            "Breda                         ",
            "Brielle                       ",
            "Bronckhorst                   ",
            "Brummen                       ",
            "Brunssum                      ",
            "Bunnik                        ",
            "Bunschoten                    ",
            "Buren                         ",
            "Capelle aan den IJssel        ",
            "Castricum                     ",
            "Coevorden                     ",
            "Cranendonck                   ",
            "Cromstrijen                   ",
            "Cuijk                         ",
            "Culemborg                     ",
            "Dalfsen                       ",
            "Dantumadiel                   ",
            "Delft                         ",
            "Delfzijl                      ",
            "Deurne                        ",
            "Deventer                      ",
            "Diemen                        ",
            "Dinkelland                    ",
            "Doesburg                      ",
            "Doetinchem                    ",
            "Dongen                        ",
            "Dongeradeel                   ",
            "Dordrecht                     ",
            "Drechterland                  ",
            "Drimmelen                     ",
            "Dronten                       ",
            "Druten                        ",
            "Duiven                        ",
            "Echt-Susteren                 ",
            "Edam-Volendam                 ",
            "Ede                           ",
            "Eemnes                        ",
            "Eemsmond                      ",
            "Eersel                        ",
            "Eijsden-Margraten             ",
            "Eindhoven                     ",
            "Elburg                        ",
            "Emmen                         ",
            "Enkhuizen                     ",
            "Enschede                      ",
            "Epe                           ",
            "Ermelo                        ",
            "Etten-Leur                    ",
            "Ferwerderadiel                ",
            "Franekeradeel                 ",
            "De Fryske Marren              ",
            "Geertruidenberg               ",
            "Geldermalsen                  ",
            "Geldrop-Mierlo                ",
            "Gemert-Bakel                  ",
            "Gennep                        ",
            "Giessenlanden                 ",
            "Gilze en Rijen                ",
            "Goeree-Overflakkee            ",
            "Goes                          ",
            "Goirle                        ",
            "Gooise Meren                  ",
            "Gorinchem                     ",
            "Gouda                         ",
            "Grave                         ",
            "\'s-Gravenhage                 ",
            "Groningen                     ",
            "Grootegast                    ",
            "Gulpen-Wittem                 ",
            "Haaksbergen                   ",
            "Haaren                        ",
            "Haarlem                       ",
            "Haarlemmerliede en Spaarnwoude",
            "Haarlemmermeer                ",
            "Halderberge                   ",
            "Hardenberg                    ",
            "Harderwijk                    ",
            "Hardinxveld-Giessendam        ",
            "Haren                         ",
            "Harlingen                     ",
            "Hattem                        ",
            "Heemskerk                     ",
            "Heemstede                     ",
            "Heerde                        ",
            "Heerenveen                    ",
            "Heerhugowaard                 ",
            "Heerlen                       ",
            "Heeze-Leende                  ",
            "Heiloo                        ",
            "Den Helder                    ",
            "Hellendoorn                   ",
            "Hellevoetsluis                ",
            "Helmond                       ",
            "Hendrik-Ido-Ambacht           ",
            "Hengelo                       ",
            "\'s-Hertogenbosch              ",
            "Heumen                        ",
            "Heusden                       ",
            "Hillegom                      ",
            "Hilvarenbeek                  ",
            "Hilversum                     ",
            "Hof van Twente                ",
            "Hollands Kroon                ",
            "Hoogeveen                     ",
            "Hoogezand-Sappemeer           ",
            "Hoorn                         ",
            "Horst aan de Maas             ",
            "Houten                        ",
            "Huizen                        ",
            "Hulst                         ",
            "IJsselstein                   ",
            "Kaag en Braassem              ",
            "Kampen                        ",
            "Kapelle                       ",
            "Katwijk                       ",
            "Kerkrade                      ",
            "Koggenland                    ",
            "Kollumerland en Nieuwkruisland",
            "Korendijk                     ",
            "Krimpen aan den IJssel        ",
            "Krimpenerwaard                ",
            "Laarbeek                      ",
            "Landerd                       ",
            "Landgraaf                     ",
            "Landsmeer                     ",
            "Langedijk                     ",
            "Lansingerland                 ",
            "Laren                         ",
            "Leek                          ",
            "Leerdam                       ",
            "Leeuwarden                    ",
            "Leeuwarderadeel               ",
            "Leiden                        ",
            "Leiderdorp                    ",
            "Leidschendam-Voorburg         ",
            "Lelystad                      ",
            "Leudal                        ",
            "Leusden                       ",
            "Lingewaal                     ",
            "Lingewaard                    ",
            "Lisse                         ",
            "Littenseradiel                ",
            "Lochem                        ",
            "Loon op Zand                  ",
            "Lopik                         ",
            "Loppersum                     ",
            "Losser                        ",
            "Maasdriel                     ",
            "Maasgouw                      ",
            "Maassluis                     ",
            "Maastricht                    ",
            "De Marne                      ",
            "Marum                         ",
            "Medemblik                     ",
            "Meerssen                      ",
            "Menameradiel                  ",
            "Menterwolde                   ",
            "Meppel                        ",
            "Middelburg                    ",
            "Midden-Delfland               ",
            "Midden-Drenthe                ",
            "Mill en Sint Hubert           ",
            "Moerdijk                      ",
            "Molenwaard                    ",
            "Montferland                   ",
            "Montfoort                     ",
            "Mook en Middelaar             ",
            "Neder-Betuwe                  ",
            "Nederweert                    ",
            "Neerijnen                     ",
            "Nieuwegein                    ",
            "Nieuwkoop                     ",
            "Nijkerk                       ",
            "Nijmegen                      ",
            "Nissewaard                    ",
            "Noord-Beveland                ",
            "Noordenveld                   ",
            "Noordoostpolder               ",
            "Noordwijk                     ",
            "Noordwijkerhout               ",
            "Nuenen, Gerwen en Nederwetten ",
            "Nunspeet                      ",
            "Nuth                          ",
            "Oegstgeest                    ",
            "Oirschot                      ",
            "Oisterwijk                    ",
            "Oldambt                       ",
            "Oldebroek                     ",
            "Oldenzaal                     ",
            "Olst-Wijhe                    ",
            "Ommen                         ",
            "Onderbanken                   ",
            "Oost Gelre                    ",
            "Oosterhout                    ",
            "Ooststellingwerf              ",
            "Oostzaan                      ",
            "Opmeer                        ",
            "Opsterland                    ",
            "Oss                           ",
            "Oud-Beijerland                ",
            "Oude IJsselstreek             ",
            "Ouder-Amstel                  ",
            "Oudewater                     ",
            "Overbetuwe                    ",
            "Papendrecht                   ",
            "Peel en Maas                  ",
            "Pekela                        ",
            "Pijnacker-Nootdorp            ",
            "Purmerend                     ",
            "Putten                        ",
            "Raalte                        ",
            "Reimerswaal                   ",
            "Renkum                        ",
            "Renswoude                     ",
            "Reusel-De Mierden             ",
            "Rheden                        ",
            "Rhenen                        ",
            "Ridderkerk                    ",
            "Rijnwaarden                   ",
            "Rijssen-Holten                ",
            "Rijswijk                      ",
            "Roerdalen                     ",
            "Roermond                      ",
            "De Ronde Venen                ",
            "Roosendaal                    ",
            "Rotterdam                     ",
            "Rozendaal                     ",
            "Rucphen                       ",
            "Schagen                       ",
            "Scherpenzeel                  ",
            "Schiedam                      ",
            "Schiermonnikoog               ",
            "Schijndel                     ",
            "Schinnen                      ",
            "Schouwen-Duiveland            ",
            "Simpelveld                    ",
            "Sint Anthonis                 ",
            "Sint-Michielsgestel           ",
            "Sint-Oedenrode                ",
            "Sittard-Geleen                ",
            "Sliedrecht                    ",
            "Slochteren                    ",
            "Sluis                         ",
            "Smallingerland                ",
            "Soest                         ",
            "Someren                       ",
            "Son en Breugel                ",
            "Stadskanaal                   ",
            "Staphorst                     ",
            "Stede Broec                   ",
            "Steenbergen                   ",
            "Steenwijkerland               ",
            "Stein                         ",
            "Stichtse Vecht                ",
            "Strijen                       ",
            "Súdwest-Fryslân               ",
            "Terneuzen                     ",
            "Terschelling                  ",
            "Texel                         ",
            "Teylingen                     ",
            "Tholen                        ",
            "Tiel                          ",
            "Tilburg                       ",
            "Tubbergen                     ",
            "Twenterand                    ",
            "Tynaarlo                      ",
            "Tytsjerksteradiel             ",
            "Uden                          ",
            "Uitgeest                      ",
            "Uithoorn                      ",
            "Urk                           ",
            "Utrecht                       ",
            "Utrechtse Heuvelrug           ",
            "Vaals                         ",
            "Valkenburg aan de Geul        ",
            "Valkenswaard                  ",
            "Veendam                       ",
            "Veenendaal                    ",
            "Veere                         ",
            "Veghel                        ",
            "Veldhoven                     ",
            "Velsen                        ",
            "Venlo                         ",
            "Venray                        ",
            "Vianen                        ",
            "Vlaardingen                   ",
            "Vlagtwedde                    ",
            "Vlieland                      ",
            "Vlissingen                    ",
            "Voerendaal                    ",
            "Voorschoten                   ",
            "Voorst                        ",
            "Vught                         ",
            "Waalre                        ",
            "Waalwijk                      ",
            "Waddinxveen                   ",
            "Wageningen                    ",
            "Wassenaar                     ",
            "Waterland                     ",
            "Weert                         ",
            "Weesp                         ",
            "Werkendam                     ",
            "West Maas en Waal             ",
            "Westerveld                    ",
            "Westervoort                   ",
            "Westland                      ",
            "Weststellingwerf              ",
            "Westvoorne                    ",
            "Wierden                       ",
            "Wijchen                       ",
            "Wijdemeren                    ",
            "Wijk bij Duurstede            ",
            "Winsum                        ",
            "Winterswijk                   ",
            "Woensdrecht                   ",
            "Woerden                       ",
            "De Wolden                     ",
            "Wormerland                    ",
            "Woudenberg                    ",
            "Woudrichem                    ",
            "Zaanstad                      ",
            "Zaltbommel                    ",
            "Zandvoort                     ",
            "Zederik                       ",
            "Zeewolde                      ",
            "Zeist                         ",
            "Zevenaar                      ",
            "Zoetermeer                    ",
            "Zoeterwoude                   ",
            "Zuidhorn                      ",
            "Zuidplas                      ",
            "Zundert                       ",
            "Zutphen                       ",
            "Zwartewaterland               ",
            "Zwijndrecht                   ",
            "Zwolle                        ",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.AreaSearchbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.AreaSearchbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.AreaSearchbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AreaSearchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AreaSearchbox.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaSearchbox.ForeColor = System.Drawing.Color.Black;
            this.AreaSearchbox.Location = new System.Drawing.Point(30, 26);
            this.AreaSearchbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AreaSearchbox.Name = "AreaSearchbox";
            this.AreaSearchbox.Size = new System.Drawing.Size(1218, 64);
            this.AreaSearchbox.TabIndex = 0;
            this.AreaSearchbox.Text = "Voer plaatsnaam in...";
            this.AreaSearchbox.UseWaitCursor = true;
            this.AreaSearchbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.AreaSearchbox.Enter += new System.EventHandler(this.AreaSearchbox_Enter);
            this.AreaSearchbox.Leave += new System.EventHandler(this.AreaSearchbox_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AreaSearchbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1506, 123);
            this.panel1.TabIndex = 11;
            // 
            // ActivePanel
            // 
            this.ActivePanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ActivePanel.Location = new System.Drawing.Point(220, 165);
            this.ActivePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ActivePanel.Name = "ActivePanel";
            this.ActivePanel.Size = new System.Drawing.Size(23, 144);
            this.ActivePanel.TabIndex = 12;
            // 
            // LetselPanel
            // 
            this.LetselPanel.Controls.Add(this.DiefstalPanel);
            this.LetselPanel.Location = new System.Drawing.Point(251, 128);
            this.LetselPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LetselPanel.Name = "LetselPanel";
            this.LetselPanel.Size = new System.Drawing.Size(1576, 734);
            this.LetselPanel.TabIndex = 13;
            // 
            // DiefstalPanel
            // 
            this.DiefstalPanel.Controls.Add(this.label2);
            this.DiefstalPanel.Controls.Add(this.chart1);
            this.DiefstalPanel.Controls.Add(this.chart6);
            this.DiefstalPanel.Controls.Add(this.chart5);
            this.DiefstalPanel.Controls.Add(this.chart4);
            this.DiefstalPanel.Controls.Add(this.chart3);
            this.DiefstalPanel.Controls.Add(this.chart2);
            this.DiefstalPanel.Location = new System.Drawing.Point(0, 2);
            this.DiefstalPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DiefstalPanel.Name = "DiefstalPanel";
            this.DiefstalPanel.Size = new System.Drawing.Size(1576, 734);
            this.DiefstalPanel.TabIndex = 14;
            this.DiefstalPanel.Visible = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(19, 14);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(443, 316);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // chart6
            // 
            chartArea2.Name = "ChartArea1";
            this.chart6.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart6.Legends.Add(legend2);
            this.chart6.Location = new System.Drawing.Point(1056, 404);
            this.chart6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart6.Name = "chart6";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart6.Series.Add(series2);
            this.chart6.Size = new System.Drawing.Size(443, 316);
            this.chart6.TabIndex = 11;
            this.chart6.Text = "chart6";
            // 
            // chart5
            // 
            chartArea3.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart5.Legends.Add(legend3);
            this.chart5.Location = new System.Drawing.Point(533, 404);
            this.chart5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart5.Name = "chart5";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart5.Series.Add(series3);
            this.chart5.Size = new System.Drawing.Size(443, 316);
            this.chart5.TabIndex = 10;
            this.chart5.Text = "chart5";
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(19, 404);
            this.chart4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(443, 316);
            this.chart4.TabIndex = 9;
            this.chart4.Text = "chart4";
            // 
            // chart3
            // 
            chartArea5.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart3.Legends.Add(legend5);
            this.chart3.Location = new System.Drawing.Point(1056, 14);
            this.chart3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart3.Name = "chart3";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 2;
            this.chart3.Series.Add(series5);
            this.chart3.Size = new System.Drawing.Size(443, 316);
            this.chart3.TabIndex = 8;
            this.chart3.Text = "chart3";
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(533, 14);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(443, 316);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1726, 862);
            this.Controls.Add(this.LetselPanel);
            this.Controls.Add(this.ActivePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FrontLeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1Diefstal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diefstalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diefstalBindingSource1)).EndInit();
            this.FrontLeftPanel.ResumeLayout(false);
            this.FrontLeftPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LetselPanel.ResumeLayout(false);
            this.DiefstalPanel.ResumeLayout(false);
            this.DiefstalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Database1Diefstal database1Diefstal;
        private System.Windows.Forms.BindingSource diefstalBindingSource;
        private Database1DiefstalTableAdapters.DiefstalTableAdapter diefstalTableAdapter;
        private System.Windows.Forms.BindingSource diefstalBindingSource1;
        private System.Windows.Forms.Panel FrontLeftPanel;
        private System.Windows.Forms.TextBox AreaSearchbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DiefstalButton;
        private System.Windows.Forms.Panel ActivePanel;
        private System.Windows.Forms.Button LetselButton;
        private System.Windows.Forms.Panel LetselPanel;
        private System.Windows.Forms.Panel DiefstalPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
    }
}