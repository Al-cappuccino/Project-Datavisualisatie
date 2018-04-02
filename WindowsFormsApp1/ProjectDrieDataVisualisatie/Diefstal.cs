using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectDrieDataVisualisatie
{
    public partial class Diefstal : UserControl
    {
        private static Diefstal _Instance;

        public static Diefstal Instance
        {
            get
            {
                if(_Instance == null)
                   _Instance = new Diefstal();
                return _Instance;
            }
        }

        SqlConnection connection;
        string conString;

        public Diefstal()
        {
            InitializeComponent();
            conString = ConfigurationManager.ConnectionStrings["ProjectDrieDataVisualisatie.Properties.Settings.Database1ConnectionString"].ConnectionString;
            dataSelectionCheckBox.SetItemChecked(0, true);
        }

        private void gemeenteTextbox_Click(object sender, EventArgs e)
        {
            if(gemeenteTextbox.Text == "Voer plaatsnaam in...")
            {
                gemeenteTextbox.Text = null;
            }
        }
        private string createQueryString(string gemeente, List<string> dataRequest)
        {
            string s = "SELECT ";
            int count = 0;
            foreach(string request in dataRequest)
            {
                if(count == dataRequest.Count() - 1)
                {
                    s += request + " FROM Diefstal WHERE Gemeente = '" + gemeente + "'";
                }
                else
                {
                    s += request + ",";
                }
                count++;
            }
            label1.Text = s;
            return s;
        }
        private void addGemeenteButton_Click(object sender, EventArgs e)
        {
            if (gemeenteTextbox.AutoCompleteCustomSource.Contains(gemeenteTextbox.Text))
            {
                if (!gemeenteSelectionCheckbox.Items.Contains(gemeenteTextbox.Text))
                {
                    gemeenteSelectionCheckbox.Items.Add(gemeenteTextbox.Text);
                }
                else
                    MessageBox.Show("Deze gemeente is al toegevoegd");
            }
            else
                MessageBox.Show("Voer een geldige gemeente in, of ben je misschien de hoofdletter vergeten?");

        }

        private void renderGraphsButton_Click(object sender, EventArgs e)
        {
            if (dataSelectionCheckBox.CheckedItems.Count == 0)
            {
                dataChart.Series.Clear();
            }
            else
            {
                dataChart.Series.Clear();
                label2.Text = "";
                foreach (string Gemeente in gemeenteSelectionCheckbox.CheckedItems)
                {
                    dataChart.Series.Add(Gemeente);
                    dataChart.Series[Gemeente].ChartType = SeriesChartType.Column;
                    dataChart.Series[Gemeente].IsValueShownAsLabel = true;
                    dataChart.Series[Gemeente].LabelBackColor = Color.White;
                    using (connection = new SqlConnection(conString))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(createQueryString(Gemeente, dataSelectionCheckBox.CheckedItems.OfType<string>().ToList()), connection))
                    {
                        DataTable result = new DataTable();
                        adapter.Fill(result);
                        foreach (string Filter in dataSelectionCheckBox.CheckedItems)
                        {
                            dataChart.Series[Gemeente].Points.AddXY(Filter, result.Rows[0][Filter]);
                            dataChart.ChartAreas[0].RecalculateAxesScale();
                            if (Filter == "AantalInwoners")
                            {
                                label2.Text += ("In de gemeente " + Gemeente + " bedroeg het " + Filter + " in 2016: " + result.Rows[0][Filter] + "\n");
                            }
                            else
                            {
                                label2.Text += ("In de gemeente " + Gemeente + " bedroeg de " + Filter + " in 2016: " + result.Rows[0][Filter] + "\n");
                            }
                        }
                    }
                }
            }
        }

        private void gemeenteTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addGemeenteButton_Click(this, new EventArgs());
            }
        }

        private void helpButton_MouseHover(object sender, EventArgs e)
        {
            informationLabel.Visible = true;
            informationLabel.Text = "Stapsgewijs uitleg:" + "\n" +
                "Stap 1: Voer een gemeente in waarvan u informatie zoekt." + "\n" +
                "Stap 2: Druk daarna op 'Enter' of klik op de 'Voeg Toe' knop." + "\n" +
                "Stap 3: Voeg, naar uw voorkeur, meerdere gemeentes toe." + "\n" +
                "Stap 4: Vink de gemeente(s) aan die u wilt plotten in een grafiek." + "\n" +
                "Stap 5: Kies een of meerdere filters die u wilt bekijken in de grafiek." + "\n";
        }

        private void helpButton_MouseLeave(object sender, EventArgs e)
        {
            informationLabel.Visible = false;
            informationLabel.Text = "";
        }

        private void gemeenteSelectionCheckbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var control = (CheckedListBox)sender;
            control.ItemCheck -= gemeenteSelectionCheckbox_ItemCheck;
            control.SetItemCheckState(e.Index, e.NewValue);
            control.ItemCheck += gemeenteSelectionCheckbox_ItemCheck;
            renderGraphsButton_Click(this, new EventArgs());
        }

        private void dataSelectionCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var control = (CheckedListBox)sender;
            control.ItemCheck -= dataSelectionCheckBox_ItemCheck;
            control.SetItemCheckState(e.Index, e.NewValue);
            control.ItemCheck += dataSelectionCheckBox_ItemCheck;
            renderGraphsButton_Click(this, new EventArgs());
        }
    }
}
