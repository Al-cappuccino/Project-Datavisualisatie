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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfDeath)).BeginInit();
            this.SuspendLayout();
            // 
            // gemeenteTextBox
            // 
            this.gemeenteTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "aa en hunze",
            "aalburg",
            "aalsmeer",
            "aalten",
            "achtkarspelen",
            "alblasserdam",
            "albrandswaard",
            "alkmaar",
            "almelo",
            "almere",
            "alphen aan den rijn",
            "alphen-chaam",
            "ameland",
            "amersfoort",
            "amstelveen",
            "amsterdam",
            "apeldoorn",
            "appingedam",
            "arnhem",
            "assen",
            "asten",
            "baarle-nassau",
            "baarn",
            "barendrecht",
            "barneveld",
            "bedum",
            "beek",
            "beemster",
            "beesel",
            "bellingwedde",
            "berg en dal",
            "bergeijk",
            "bergen (l.)",
            "bergen (nh.)",
            "bergen op zoom",
            "berkelland",
            "bernheze",
            "best",
            "beuningen",
            "beverwijk",
            "het bildt",
            "de bilt",
            "binnenmaas",
            "bladel",
            "blaricum",
            "bloemendaal",
            "bodegraven-reeuwijk",
            "boekel",
            "ten boer",
            "borger-odoorn",
            "borne",
            "borsele",
            "boxmeer",
            "boxtel",
            "breda",
            "brielle",
            "bronckhorst",
            "brummen",
            "brunssum",
            "bunnik",
            "bunschoten",
            "buren",
            "capelle aan den ijssel",
            "castricum",
            "coevorden",
            "cranendonck",
            "cromstrijen",
            "cuijk",
            "culemborg",
            "dalfsen",
            "dantumadiel",
            "delft",
            "delfzijl",
            "deurne",
            "deventer",
            "diemen",
            "dinkelland",
            "doesburg",
            "doetinchem",
            "dongen",
            "dongeradeel",
            "dordrecht",
            "drechterland",
            "drimmelen",
            "dronten",
            "druten",
            "duiven",
            "echt-susteren",
            "edam-volendam",
            "ede",
            "eemnes",
            "eemsmond",
            "eersel",
            "eijsden-margraten",
            "eindhoven",
            "elburg",
            "emmen",
            "enkhuizen",
            "enschede",
            "epe",
            "ermelo",
            "etten-leur",
            "ferwerderadiel",
            "franekeradeel",
            "de fryske marren",
            "geertruidenberg",
            "geldermalsen",
            "geldrop-mierlo",
            "gemert-bakel",
            "gennep",
            "giessenlanden",
            "gilze en rijen",
            "goeree-overflakkee",
            "goes",
            "goirle",
            "gooise meren",
            "gorinchem",
            "gouda",
            "grave",
            "den haag",
            "groningen gemeente",
            "grootegast",
            "gulpen-wittem",
            "haaksbergen",
            "haaren",
            "haarlem",
            "haarlemmerliede en spaarnwoude",
            "haarlemmermeer",
            "halderberge",
            "hardenberg",
            "harderwijk",
            "hardinxveld-giessendam",
            "haren",
            "harlingen",
            "hattem",
            "heemskerk",
            "heemstede",
            "heerde",
            "heerenveen",
            "heerhugowaard",
            "heerlen",
            "heeze-leende",
            "heiloo",
            "den helder",
            "hellendoorn",
            "hellevoetsluis",
            "helmond",
            "hendrik-ido-ambacht",
            "hengelo",
            "den bosch",
            "heumen",
            "heusden",
            "hillegom",
            "hilvarenbeek",
            "hilversum",
            "hof van twente",
            "hollands kroon",
            "hoogeveen",
            "hoogezand-sappemeer",
            "hoorn",
            "horst aan de maas",
            "houten",
            "huizen",
            "hulst",
            "ijsselstein",
            "kaag en braassem",
            "kampen",
            "kapelle",
            "katwijk",
            "kerkrade",
            "koggenland",
            "kollumerland en nieuwkruisland",
            "korendijk",
            "krimpen aan den ijssel",
            "krimpenerwaard",
            "laarbeek",
            "landerd",
            "landgraaf",
            "landsmeer",
            "langedijk",
            "lansingerland",
            "laren",
            "leek",
            "leerdam",
            "leeuwarden",
            "leeuwarderadeel",
            "leiden",
            "leiderdorp",
            "leidschendam-voorburg",
            "lelystad",
            "leudal",
            "leusden",
            "lingewaal",
            "lingewaard",
            "lisse",
            "littenseradiel",
            "lochem",
            "loon op zand",
            "lopik",
            "loppersum",
            "losser",
            "maasdriel",
            "maasgouw",
            "maassluis",
            "maastricht",
            "de marne",
            "marum",
            "medemblik",
            "meerssen",
            "menameradiel",
            "menterwolde",
            "meppel",
            "middelburg",
            "midden-delfland",
            "midden-drenthe",
            "mill en sint hubert",
            "moerdijk",
            "molenwaard",
            "montferland",
            "montfoort",
            "mook en middelaar",
            "neder-betuwe",
            "nederweert",
            "neerijnen",
            "nieuwegein",
            "nieuwkoop",
            "nijkerk",
            "nijmegen",
            "nissewaard",
            "noord-beveland",
            "noordenveld",
            "noordoostpolder",
            "noordwijk",
            "noordwijkerhout",
            "nuenen, gerwen en nederwetten",
            "nunspeet",
            "nuth",
            "oegstgeest",
            "oirschot",
            "oisterwijk",
            "oldambt",
            "oldebroek",
            "oldenzaal",
            "olst-wijhe",
            "ommen",
            "onderbanken",
            "oost gelre",
            "oosterhout",
            "ooststellingwerf",
            "oostzaan",
            "opmeer",
            "opsterland",
            "oss",
            "oud-beijerland",
            "oude ijsselstreek",
            "ouder-amstel",
            "oudewater",
            "overbetuwe",
            "papendrecht",
            "peel en maas",
            "pekela",
            "pijnacker-nootdorp",
            "purmerend",
            "putten",
            "raalte",
            "reimerswaal",
            "renkum",
            "renswoude",
            "reusel-de mierden",
            "rheden",
            "rhenen",
            "ridderkerk",
            "rijnwaarden",
            "rijssen-holten",
            "rijswijk",
            "roerdalen",
            "roermond",
            "de ronde venen",
            "roosendaal",
            "rotterdam",
            "rozendaal",
            "rucphen",
            "schagen",
            "scherpenzeel",
            "schiedam",
            "schiermonnikoog",
            "schijndel",
            "schinnen",
            "schouwen-duiveland",
            "simpelveld",
            "sint anthonis",
            "sint-michielsgestel",
            "sint-oedenrode",
            "sittard-geleen",
            "sliedrecht",
            "slochteren",
            "sluis",
            "smallingerland",
            "soest",
            "someren",
            "son en breugel",
            "stadskanaal",
            "staphorst",
            "stede broec",
            "steenbergen",
            "steenwijkerland",
            "stein",
            "stichtse vecht",
            "strijen",
            "súdwest-fryslân",
            "terneuzen",
            "terschelling",
            "texel",
            "teylingen",
            "tholen",
            "tiel",
            "tilburg",
            "tubbergen",
            "twenterand",
            "tynaarlo",
            "tytsjerksteradiel",
            "uden",
            "uitgeest",
            "uithoorn",
            "urk",
            "utrecht gemeente",
            "utrechtse heuvelrug",
            "vaals",
            "valkenburg aan de geul",
            "valkenswaard",
            "veendam",
            "veenendaal",
            "veere",
            "veghel",
            "veldhoven",
            "velsen",
            "venlo",
            "venray",
            "vianen",
            "vlaardingen",
            "vlagtwedde",
            "vlieland",
            "vlissingen",
            "voerendaal",
            "voorschoten",
            "voorst",
            "vught",
            "waalre",
            "waalwijk",
            "waddinxveen",
            "wageningen",
            "wassenaar",
            "waterland",
            "weert",
            "weesp",
            "werkendam",
            "west maas en waal",
            "westerveld",
            "westervoort",
            "westland",
            "weststellingwerf",
            "westvoorne",
            "wierden",
            "wijchen",
            "wijdemeren",
            "wijk bij duurstede",
            "winsum",
            "winterswijk",
            "woensdrecht",
            "woerden",
            "de wolden",
            "wormerland",
            "woudenberg",
            "woudrichem",
            "zaanstad",
            "zaltbommel",
            "zandvoort",
            "zederik",
            "zeewolde",
            "zeist",
            "zevenaar",
            "zoetermeer",
            "zoeterwoude",
            "zuidhorn",
            "zuidplas",
            "zundert",
            "zutphen",
            "zwartewaterland",
            "zwijndrecht",
            "zwolle",
            "drenthe",
            "noord-brabant",
            "noord-holland",
            "gelderland",
            "friesland",
            "zuid-holland",
            "overijssel",
            "flevoland",
            "groningen",
            "zeeland",
            "limburg",
            "utrecht"});
            this.gemeenteTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.gemeenteTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.gemeenteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gemeenteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gemeenteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.gemeenteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gemeenteTextBox.ForeColor = System.Drawing.Color.White;
            this.gemeenteTextBox.Location = new System.Drawing.Point(16, 13);
            this.gemeenteTextBox.Name = "gemeenteTextBox";
            this.gemeenteTextBox.Size = new System.Drawing.Size(734, 49);
            this.gemeenteTextBox.TabIndex = 7;
            this.gemeenteTextBox.Text = "voer plaatsnaam in...";
            this.gemeenteTextBox.Click += new System.EventHandler(this.gemeenteTextBox_Click);
            this.gemeenteTextBox.TextChanged += new System.EventHandler(this.gemeenteTextBox_TextChanged);
            // 
            // submitGemeenteInputBtn
            // 
            this.submitGemeenteInputBtn.Location = new System.Drawing.Point(767, 13);
            this.submitGemeenteInputBtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitGemeenteInputBtn.Name = "submitGemeenteInputBtn";
            this.submitGemeenteInputBtn.Size = new System.Drawing.Size(96, 49);
            this.submitGemeenteInputBtn.TabIndex = 8;
            this.submitGemeenteInputBtn.Text = "Ga";
            this.submitGemeenteInputBtn.UseVisualStyleBackColor = true;
            this.submitGemeenteInputBtn.Click += new System.EventHandler(this.addGemeenteButton_Click);
            // 
            // selectGemeenteComboBox
            // 
            this.selectGemeenteComboBox.FormattingEnabled = true;
            this.selectGemeenteComboBox.Location = new System.Drawing.Point(18, 82);
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
            this.dataChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IntervalOffset = 1D;
            chartArea2.Name = "ChartArea1";
            this.dataChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.dataChart.Legends.Add(legend2);
            this.dataChart.Location = new System.Drawing.Point(16, 247);
            this.dataChart.Name = "dataChart";
            this.dataChart.Size = new System.Drawing.Size(1092, 515);
            this.dataChart.TabIndex = 20;
            this.dataChart.Text = "chart1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(388, 84);
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
            this.checkBox2.Location = new System.Drawing.Point(388, 107);
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
            this.checkBox3.Location = new System.Drawing.Point(388, 130);
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
            this.comboBox1.Location = new System.Drawing.Point(18, 116);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 82);
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
            this.comboBox2.Location = new System.Drawing.Point(687, 220);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Verander chart: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 116);
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
            this.comboBox3.Location = new System.Drawing.Point(18, 152);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(197, 21);
            this.comboBox3.TabIndex = 33;
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(18, 190);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(197, 21);
            this.comboBox4.TabIndex = 35;
            this.comboBox4.Visible = false;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 21);
            this.button3.TabIndex = 34;
            this.button3.Text = "Vergelijken";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(884, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 187);
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
            this.ImageOfDeath.Location = new System.Drawing.Point(0, 2);
            this.ImageOfDeath.Margin = new System.Windows.Forms.Padding(2);
            this.ImageOfDeath.Name = "ImageOfDeath";
            this.ImageOfDeath.Size = new System.Drawing.Size(1163, 795);
            this.ImageOfDeath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageOfDeath.TabIndex = 40;
            this.ImageOfDeath.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(990, 727);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 23);
            this.button5.TabIndex = 42;
            this.button5.Text = "Resultaat Opslaan";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Letsel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button5);
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
            this.Name = "Letsel";
            this.Size = new System.Drawing.Size(1163, 798);
            this.Load += new System.EventHandler(this.Letsel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfDeath)).EndInit();
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
        private Timer timer1;
        private Button button5;
    }
}
