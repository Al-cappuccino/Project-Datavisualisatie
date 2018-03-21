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
            string selected1 = this.filterDiefstal1.GetItemText(this.filterDiefstal1.SelectedItem);
            string selected2 = this.filterDiefstal2.GetItemText(this.filterDiefstal2.SelectedItem);
            string selected3 = this.filterDiefstal3.GetItemText(this.filterDiefstal3.SelectedItem);
            string selected4 = this.filterDiefstal4.GetItemText(this.filterDiefstal4.SelectedItem);
            string selected = selected1 + ", " + selected2 + ", " + selected3 + ", " + selected4;
            if (selected1 == "")
            {
                MessageBox.Show("Kies een geldige filter");
                selected = selected1;
            }
            else if (filterDiefstal2.Visible == true && selected2 == "")
            {
                MessageBox.Show("Kies een geldige filter");
                selected = selected1 + ", " + selected2;
            }
            else if (filterDiefstal3.Visible == true && selected3 == "")
            {
                MessageBox.Show("Kies een geldige filter");
                selected = selected1 + ", " + selected2 + ", " + selected3;
            }
            else if (filterDiefstal4.Visible == true && selected4 == "")
            {
                MessageBox.Show("Kies een geldige filter");
                selected = selected1 + ", " + selected2 + ", " + selected3 + ", " + selected4;
            }
            else
            {
                if (filterDiefstal4.Visible)
                {
                    selected = selected1 + ", " + selected2 + ", " + selected3 + ", " + selected4;
                }
                else if (filterDiefstal3.Visible)
                {
                    selected = selected1 + ", " + selected2 + ", " + selected3;
                }
                else if (filterDiefstal2.Visible)
                {
                    selected = selected1 + ", " + selected2;
                }
                else if (filterDiefstal1.Visible)
                {
                    selected = selected1;
                }

                if (testPieChart.Series.Count > 0)
                    testPieChart.Series.RemoveAt(0);

                using (connection = new SqlConnection(conString))
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT " + selected + " FROM Diefstal WHERE Gemeente LIKE '%" + gemeenteInputTextbox.Text + "%'", connection))
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


        private void gemeenteInputTextbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (gemeenteInputTextbox.Text == "Voer plaatsnaam in...")
                gemeenteInputTextbox.Text = "";
            gemeenteInputTextbox.ForeColor = Color.White;
        }

        private void adddiefstalfilter_Click(object sender, EventArgs e)
        {
            if (filterDiefstal2.Visible == false)
            {
                filterDiefstal2.Visible = true;
            
            }
            else if (filterDiefstal3.Visible == false && filterDiefstal2.Visible == true)
            {
                filterDiefstal3.Visible = true;

            }
            else if (filterDiefstal4.Visible == false && filterDiefstal3.Visible == true)
            {
                filterDiefstal4.Visible = true;
            }
        }

        private void deletediefstalFilter_Click(object sender, EventArgs e)
        {
            if (filterDiefstal4.Visible == true)
            {
                filterDiefstal4.Visible = false;
                filterDiefstal4.Text = "";

            }
            else if (filterDiefstal3.Visible == true)
            {
                filterDiefstal3.Visible = false;
                filterDiefstal3.Text = "";

            }
            else if (filterDiefstal2.Visible == true)
            {
                filterDiefstal2.Visible = false;
                filterDiefstal2.Text = "";
            }
        }
    }

}
