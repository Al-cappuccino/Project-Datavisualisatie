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
using System.Security.AccessControl;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjectDrieDataVisualisatie
{
    //establish connection to database
    public partial class Letsel : UserControl
    {
        private SqlConnection _connection;
        private SqlDataAdapter adapter;
        private DataTable result;
        private string _conString;
        private string _gemeentenaam;
        private static Letsel _instance;

        public static Letsel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Letsel();
                return _instance;
            }
        }
        public Letsel()
        {
            InitializeComponent();
            _conString = ConfigurationManager.ConnectionStrings["ProjectDrieDataVisualisatie.Properties.Settings.Database1ConnectionString"].ConnectionString;
            _connection = new SqlConnection(_conString);
            //fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel", "global");

            selectGemeenteComboBox.Items.Add("Nederland");
            selectGemeenteComboBox.SelectedIndex = 0;
            dataSelectionCheckBox.SetItemChecked(0, true);
            dataSelectionCheckBox.SetItemChecked(1, true);
            dataSelectionCheckBox.SetItemChecked(2, true);
        }

        private void gemeenteTextBox_Click(object sender, EventArgs e)
        {
            gemeenteTextBox.Text = null;
        }

        private void addGemeenteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gemeenteTextBox.Text))
            {
                _gemeentenaam = gemeenteTextBox.Text;
                selectGemeenteComboBox.Items.Add(_gemeentenaam);
                selectGemeenteComboBox.SelectedIndex = selectGemeenteComboBox.Items.Count - 1;
                dataSelectionCheckBox.SetItemChecked(0, true);
                dataSelectionCheckBox.SetItemChecked(1, true);
                dataSelectionCheckBox.SetItemChecked(2, true);
            }
        }

        private void renderGraphsButton_Click(object sender, EventArgs e)
        {

        }

        private void fillchart(string query, string names, int column_num)
        {
            dataChart.Series.Clear();
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
            adapter.Fill(result);
            if (column_num == 1)
            {
                dataChart.Series.Add(names + "1");
                dataChart.Series[names + "1"].YValueMembers = result.Columns[0].ColumnName;
                dataChart.Series[names + "1"].LegendText = selectGemeenteComboBox.Text + " HIC_geweldsmisdrijven";
            }
            else if (column_num == 2)
            {
                dataChart.Series.Add(names + "1");
                dataChart.Series.Add(names + "2");
                dataChart.Series[names + "1"].YValueMembers = result.Columns[0].ColumnName;
                dataChart.Series[names + "2"].YValueMembers = result.Columns[1].ColumnName;
                dataChart.Series[names + "1"].LegendText = selectGemeenteComboBox.Text + " HIC_geweldsmisdrijven";
                dataChart.Series[names + "2"].LegendText = selectGemeenteComboBox.Text + " Mishandeling";
            }
            else if (column_num == 3)
            {
                dataChart.Series.Add(names + "1");
                dataChart.Series.Add(names + "2");
                dataChart.Series.Add(names + "3");
                dataChart.Series[names + "1"].YValueMembers = result.Columns[0].ColumnName;
                dataChart.Series[names + "2"].YValueMembers = result.Columns[1].ColumnName;
                dataChart.Series[names + "3"].YValueMembers = result.Columns[2].ColumnName;
                dataChart.Series[names + "1"].LegendText = selectGemeenteComboBox.Text + " HIC_geweldsmisdrijven";
                dataChart.Series[names + "2"].LegendText = selectGemeenteComboBox.Text + " Mishandeling";
                dataChart.Series[names + "3"].LegendText = selectGemeenteComboBox.Text + " Openlijk_Geweld";
            }
            else if (column_num == 4)
            {
                dataChart.Series.Add(names + "1");
                dataChart.Series.Add(names + "2");
                dataChart.Series[names + "1"].YValueMembers = result.Columns[0].ColumnName;
                dataChart.Series[names + "2"].YValueMembers = result.Columns[1].ColumnName;
                dataChart.Series[names + "1"].LegendText = selectGemeenteComboBox.Text + " HIC_geweldsmisdrijven";
                dataChart.Series[names + "2"].LegendText = selectGemeenteComboBox.Text + " Openlijk_Geweld";
            }
            else if (column_num == 5)
            {
                dataChart.Series.Add(names + "1");
                dataChart.Series.Add(names + "2");
                dataChart.Series[names + "1"].YValueMembers = result.Columns[0].ColumnName;
                dataChart.Series[names + "2"].YValueMembers = result.Columns[1].ColumnName;
                dataChart.Series[names + "1"].LegendText = selectGemeenteComboBox.Text + " Mishandeling";
                dataChart.Series[names + "2"].LegendText = selectGemeenteComboBox.Text + " Openlijk_Geweld";
            }
            dataChart.DataSource = result;
            dataChart.DataBind();
        }

        private void selectGemeenteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectGemeenteComboBox.SelectedIndex != 0)
            {
                dataSelectionCheckBox.SetItemChecked(0, true);
                dataSelectionCheckBox.SetItemChecked(1, true);
                dataSelectionCheckBox.SetItemChecked(2, true);
                fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 3);
            }
            else
            {
                dataSelectionCheckBox.SetItemChecked(0, true);
                dataSelectionCheckBox.SetItemChecked(1, true);
                dataSelectionCheckBox.SetItemChecked(2, true);
                fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel", "global", 3);
            }

        }

        private void gemeenteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataSelectionCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataSelectionCheckBox_ItemCheck(object sender, EventArgs e)
        {
            if (dataSelectionCheckBox.GetItemChecked(0) && dataSelectionCheckBox.GetItemChecked(1) && dataSelectionCheckBox.GetItemChecked(2))
            {
                if (selectGemeenteComboBox.SelectedIndex != 0)
                {
                    fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 3);
                }
                else
                {
                    fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel", "global", 3);
                }
            }
            else if (dataSelectionCheckBox.GetItemChecked(0) && dataSelectionCheckBox.GetItemChecked(1))
            {
                if (selectGemeenteComboBox.SelectedIndex != 0)
                {
                    fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 2);
                }
                else
                {
                    fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling) from Letsel", "global", 2);
                }
            }
            else if (dataSelectionCheckBox.GetItemChecked(0) && dataSelectionCheckBox.GetItemChecked(2))
            {
                if (selectGemeenteComboBox.SelectedIndex != 0)
                {
                    fillchart("select sum(HIC_geweldsmisdrijven), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 4);
                }
                else
                {
                    fillchart("select sum(HIC_geweldsmisdrijven), sum(Openlijk_Geweld) from Letsel", "global", 4);
                }
            }
            else if (dataSelectionCheckBox.GetItemChecked(1) && dataSelectionCheckBox.GetItemChecked(2))
            {
                if (selectGemeenteComboBox.SelectedIndex != 0)
                {
                    fillchart("select sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 5);
                }
                else
                {
                    fillchart("select sum(Mishandeling), sum(Openlijk_Geweld) from Letsel", "global", 5);
                }
            }
            else if (dataSelectionCheckBox.GetItemChecked(0))
            {
                if (selectGemeenteComboBox.SelectedIndex != 0)
                {
                    fillchart("select sum(HIC_geweldsmisdrijven) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 1);
                }
                else
                {
                    fillchart("select sum(HIC_geweldsmisdrijven) from Letsel", "global", 1);
                }
            }
        }
    }
}
