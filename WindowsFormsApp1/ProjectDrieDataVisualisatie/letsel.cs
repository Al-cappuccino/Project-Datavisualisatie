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
    //establish connection to database
    public partial class Letsel : UserControl
    {
        private List<string> SelectedGemeentes = new List<string>();
        private Dictionary<string, List<string>> SelectedData = new Dictionary<string, List<string>>();
        private static Letsel _Instance;
        public static Letsel Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Letsel();
                return _Instance;
            }
        }
        SqlConnection connection;
        string conString;
        public Letsel()
        {
            InitializeComponent();
            conString = ConfigurationManager.ConnectionStrings["ProjectDrieDataVisualisatie.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }


        //wipe Text box contents if clicked
        private void gemeenteTextBox_Click(object sender, EventArgs e)
        {
            gemeenteTextBox.Text = null;
        }


        //Create the string to find data
        private string createQueryString(string gemeente, List<string> dataRequest)
        {
            string s = "SELECT ";
            int count = 0;
            foreach (string request in dataRequest)
            {
                if (count == dataRequest.Count() - 1)
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


        //Add a gemeente to the ComboBox
        private void addGemeenteButton_Click(object sender, EventArgs e)
        {
            if (gemeenteTextBox.Text != "")
            {
                if (!SelectedGemeentes.Contains(gemeenteTextBox.Text))
                {
                    SelectedGemeentes.Add(gemeenteTextBox.Text);
                    SelectedData.Add(gemeenteTextBox.Text, new List<string>());
                    selectGemeenteComboBox.Items.Add(gemeenteTextBox.Text);
                }
            }
        }


        //Submits selected filters
        private void submitSeletedDataButton_Click(object sender, EventArgs e)
        {
            if (selectGemeenteComboBox.Text != "")
            {
                foreach (string item in dataSelectionCheckBox.CheckedItems)
                {
                    SelectedData[selectGemeenteComboBox.Text].Add(item);
                }
            }
        }


        //Renders the graph
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
    }
}
