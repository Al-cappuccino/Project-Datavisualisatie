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
        }


        private void submitGemeenteInputBtn_Click_1(object sender, EventArgs e)
        {
            if (testPieChart.Series.Count > 0)
                testPieChart.Series.RemoveAt(0);

            using (connection = new SqlConnection(conString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Diefstal WHERE Gemeente LIKE '%" + gemeenteInputTextbox.Text + "%'", connection))
            {
                DataTable Test = new DataTable();
                adapter.Fill(Test);


                testPieChart.Series.Add("Serie 1");
                testPieChart.Series["Serie 1"].ChartType = SeriesChartType.Column;
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
                        if (columnName != "Gemeente" && columnName != "AantalInwoners" && columnName != "TotaalDiefstal")
                        {

                            testPieChart.Series["Serie 1"].Points.AddXY(columnName, dr[columnName]);
                            testPieChart.ChartAreas[0].RecalculateAxesScale();
                        }

                    }
                }

            }
        }


        private void gemeenteInputTextbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (gemeenteInputTextbox.Text == "Voer plaatsnaam in...")
                gemeenteInputTextbox.Text = "";
            gemeenteInputTextbox.ForeColor = Color.White;
        }
    }

}
