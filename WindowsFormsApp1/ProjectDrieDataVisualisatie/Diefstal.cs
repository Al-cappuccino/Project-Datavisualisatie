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
                MessageBox.Show("Voer een geldige gemeente in");

        }

        private void renderGraphsButton_Click(object sender, EventArgs e)
        {
            if (dataSelectionCheckBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Kies een geldig filter");
            }
            else
            {
                dataChart.Series.Clear();
                label2.Text = "";
                foreach (string Gemeente in gemeenteSelectionCheckbox.CheckedItems)
                {
                    dataChart.Series.Add(Gemeente);
                    using (connection = new SqlConnection(conString))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(createQueryString(Gemeente, dataSelectionCheckBox.CheckedItems.OfType<string>().ToList()), connection))
                    {
                        DataTable result = new DataTable();
                        adapter.Fill(result);
                        foreach (string Filter in dataSelectionCheckBox.CheckedItems)
                        {
                            dataChart.Series[Gemeente].Points.AddXY(Filter, result.Rows[0][Filter]);
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
    }
}
