﻿using System;
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
        private Dictionary<string, List<string>> SelectedData = new Dictionary<string, List<string>>();
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
            if (gemeenteTextbox.Text == "Voer plaatsnaam in...")
                gemeenteTextbox.Text = null;
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
                    SelectedGemeentes.Add(gemeenteTextbox.Text);
                    SelectedData.Add(gemeenteTextbox.Text, new List<string>());
                    selectGemeenteComboBox.Items.Add(gemeenteTextbox.Text);
                    selectGemeenteComboBox.SelectedIndex = 0;
                }
            }
            else
                MessageBox.Show("Voer een geldige gemeente in");
            
            
        }

        private void selectGemeenteComboBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitSeletedDataButton_Click(object sender, EventArgs e)
        {
            if (dataSelectionCheckBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Kies een geldig filter");
            }
            else if (selectGemeenteComboBox.Text != "")
            {
                foreach (string item in dataSelectionCheckBox.CheckedItems)
                {
                    SelectedData[selectGemeenteComboBox.Text].Add(item);
                }
            }
        }

        private void renderGraphsButton_Click(object sender, EventArgs e)
        {
            if (dataChart.Series.Count > 0)
                dataChart.Series.RemoveAt(0);

            foreach (KeyValuePair<string, List<string>> dataRequest in SelectedData)
            {
                dataChart.Series.Add(dataRequest.Key);
                createQueryString(dataRequest.Key, dataRequest.Value);
                using (connection = new SqlConnection(conString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(createQueryString(dataRequest.Key, dataRequest.Value), connection))
                {
                    DataTable result = new DataTable();
                    adapter.Fill(result);
                    foreach (string column in dataRequest.Value)
                    {
                        dataChart.Series[dataRequest.Key].Points.AddXY(column, result.Rows[0][column]);
                    }
                }
            }
        }

        private void gemeenteTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
