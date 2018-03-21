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
    public partial class letsel : UserControl
    {
        SqlConnection connection;
        string conString;
        private static letsel _Instance;
        public static letsel Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new letsel();
                return _Instance;
            }
        }
        public letsel()
        {
            InitializeComponent();
            conString = ConfigurationManager.ConnectionStrings["ProjectDrieDataVisualisatie.Properties.Settings.Database1ConnectionString"].ConnectionString;

        }

        private void submitGemeenteInputBtn_Click(object sender, EventArgs e)
        {
            string selected1 = this.filterDiefstal1.GetItemText(this.filterDiefstal1.SelectedItem);
            string selected = selected1;
            if (selected1 == "")
            {
                MessageBox.Show("Kies een geldige filter");
            }
            else
                if (filterDiefstal1.Visible)
                {
                    selected = selected1;
                }

                if (testPieChart.Series.Count > 0)
                    testPieChart.Series.RemoveAt(0);

                using (connection = new SqlConnection(conString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Letsel WHERE Gemeente LIKE '%" + gemeenteInputTextbox.Text + "%'", connection))
                {
                    DataTable Test = new DataTable();
                    adapter.Fill(Test);


                    testPieChart.Series.Add(gemeenteInputTextbox.Text);
                    testPieChart.Series[gemeenteInputTextbox.Text].ChartType = SeriesChartType.Column;
                    List<String> columns = new List<string>();
                    bool added = false;

                    foreach (DataRow dr in Test.Rows)
                    {
                        if (!added)
                        {
                            foreach (DataColumn dc in dr.Table.Columns)
                            {
                                string columnName = dc.ColumnName.ToString();
                                columns.Add(columnName);
                                added = true;
                            }
                        }

                        foreach (string columnName in columns)
                        {


                            testPieChart.Series[gemeenteInputTextbox.Text].Points.AddXY(columnName, dr[columnName]);
                            testPieChart.ChartAreas[0].RecalculateAxesScale();


                        }
                    }

                }
            
        }
    }
}
