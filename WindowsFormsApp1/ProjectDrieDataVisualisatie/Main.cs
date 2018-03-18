using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectDrieDataVisualisatie
{
    public partial class Main : Form
    {
        SqlConnection connection;
        string conString;

        public Main()
        {   
            InitializeComponent();
            conString = ConfigurationManager.ConnectionStrings["ProjectDrieDataVisualisatie.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }


        private void submitGemeenteInputBtn_Click(object sender, EventArgs e)
        {
            if (testPieChart.Series.Count > 0)
                testPieChart.Series.RemoveAt(0);

            using(connection = new SqlConnection(conString))
            using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Diefstal WHERE Gemeente LIKE '%" + gemeenteInputTextbox.Text + "%'" , connection))
            {
                DataTable Test = new DataTable();
                adapter.Fill(Test);


                testPieChart.Series.Add("Serie 1");
                testPieChart.Series["Serie 1"].ChartType = SeriesChartType.Column;
                List<String> columns = new List<string>();
                bool added = false;

                foreach(DataRow dr in Test.Rows)
                {
                    if (!added)
                    {
                        foreach(DataColumn dc in dr.Table.Columns)
                        {
                            string columnName = dc.ColumnName.ToString();
                            columns.Add(columnName);
                            added = true;
                        }
                    }

                    foreach(string columnName in columns)
                    {
                        if(columnName != "Gemeente" && columnName != "AantalInwoners" && columnName != "TotaalDiefstal")
                        {
                           
                            testPieChart.Series["Serie 1"].Points.AddXY(columnName, dr[columnName]);
                            testPieChart.ChartAreas[0].RecalculateAxesScale();
                        }
                        
                    }
                }

            }
        }

        private void gemeenteInputTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LetselButton_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart2.Visible = true;
            chart3.Visible = true;
            chart4.Visible = true;
            chart5.Visible = true;
            testPieChart.Visible = true;
            pictureBox1.Visible = false;
        }

        private void gemeenteInputTextbox_Enter(object sender, EventArgs e)
        {
            if (gemeenteInputTextbox.Text == "Voer plaatsnaam in...")
                gemeenteInputTextbox.Text = "";
            gemeenteInputTextbox.ForeColor = Color.White;
        }

        private void DiefstalButton_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart2.Visible = true;
            chart3.Visible = true;
            chart4.Visible = true;
            chart5.Visible = true;
            testPieChart.Visible = true;
            pictureBox1.Visible = false;
        }

        private void Kaart_click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            chart5.Visible = false;
            testPieChart.Visible = false;
            pictureBox1.Visible = true;
        }
    }
}
