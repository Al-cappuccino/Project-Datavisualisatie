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
        private List<string> SelectedGemeentes = new List<string>();
        private List<string> SelectedFilters = new List<string>();
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
                if (!SelectedGemeentes.Contains(gemeenteTextbox.Text))
                {
                    gemeenteSelectionCheckbox.Items.Add(gemeenteTextbox.Text);
                }
                else
                    MessageBox.Show("Deze gemeente is al toegevoegd");
            }
            else
                MessageBox.Show("Voer een geldige gemeente in");

        }

        private void renderGraphsButton_Click(object sender, EventArgs e)
        {
            foreach (string SelectedGemeente in gemeenteSelectionCheckbox.CheckedItems)
            {
                SelectedGemeentes.Add(SelectedGemeente);
            }
            foreach (string SelectedFilter in dataSelectionCheckBox.CheckedItems)
            {
                SelectedFilters.Add(SelectedFilter);
            }
            foreach (string Gemeente in SelectedGemeentes)
            {
                if (!dataChart.Series.IsUniqueName(Gemeente))
                    dataChart.Series.Remove(dataChart.Series[Gemeente]);

                dataChart.Series.Add(Gemeente);
                using (connection = new SqlConnection(conString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(createQueryString(Gemeente, SelectedFilters), connection))
                {
                    DataTable result = new DataTable();
                    adapter.Fill(result);
                    foreach (string Filter in SelectedFilters)
                    {
                        dataChart.Series[Gemeente].Points.AddXY(Filter, result.Rows[0][Filter]);
                    }
                }
            }
        }
    }

}
