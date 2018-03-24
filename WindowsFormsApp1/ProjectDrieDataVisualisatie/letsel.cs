using System;
using System.Data;
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
        private readonly SqlConnection _connection;
        private string _gemeentenaam;
        private DataTable _result;
        private static Letsel _instance;
        private bool _check;
        private bool _check2;
        private int _columnNum;
        private string[] _oldquery = new string[6];
        private int _selectindex;

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
            var conString = ConfigurationManager.ConnectionStrings["ProjectDrieDataVisualisatie.Properties.Settings.Database1ConnectionString"].ConnectionString;
            _connection = new SqlConnection(conString);
            //fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel", "global");

            selectGemeenteComboBox.Items.Add("Nederland");
            selectGemeenteComboBox.SelectedIndex = 0;
            comboBox1.Items.Add("Nederland");
            comboBox3.Items.Add("Nederland");
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
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
                comboBox1.Items.Add(_gemeentenaam);
                comboBox3.Items.Add(_gemeentenaam);
            }
        }

        private void Fillchart(string query, string names, int columnNum, int name, int compare)
        {
            if (compare == 1)
            {
                _oldquery[3] = query;
                _oldquery[4] = columnNum.ToString();
                _oldquery[5] = name.ToString();

                for (int a = 0; a <= _result.Columns.Count - 1; a++)
                {
                    _result.Columns[a].ColumnName = _result.Columns[a].ColumnName + "1";

                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                adapter.Fill(_result);
                for (int a = 0; a <= _result.Columns.Count - 1; a++)
                {
                    if (_result.Columns[a].ColumnName == "Column1" || _result.Columns[a].ColumnName == "Column2" || _result.Columns[a].ColumnName == "Column3")
                    {
                        _result.Columns[a].ColumnName = _result.Columns[a].ColumnName + "11";
                    }
                }
                for (int a = 0; a <= _result.Columns.Count - 1; a++)
                {
                    if (_result.Columns[a].ColumnName == "Column11" || _result.Columns[a].ColumnName == "Column21" || _result.Columns[a].ColumnName == "Column31")
                    {
                        _result.Columns[a].ColumnName = _result.Columns[a].ColumnName.Remove(_result.Columns[a].ColumnName.Length - 1);
                        _columnNum = a + 1;
                    }
                }
            }
            else if (compare == 2)
            {
                for (int a = 0; a <= _result.Columns.Count - 1; a++)
                {
                    if (_result.Columns[a].ColumnName == "Column1" || _result.Columns[a].ColumnName == "Column2" || _result.Columns[a].ColumnName == "Column3")
                    {
                        _result.Columns[a].ColumnName = _result.Columns[a].ColumnName + "1";
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                adapter.Fill(_result);

                for (int a = 0; a <= _result.Columns.Count - 1; a++)
                {
                    if (_result.Columns[a].ColumnName == "Column1" || _result.Columns[a].ColumnName == "Column2" || _result.Columns[a].ColumnName == "Column3")
                    {
                        _result.Columns[a].ColumnName = _result.Columns[a].ColumnName + "111";
                    }
                }
                for (int a = 0; a <= _result.Columns.Count - 1; a++)
                {
                    if (_result.Columns[a].ColumnName == "Column11" || _result.Columns[a].ColumnName == "Column21" || _result.Columns[a].ColumnName == "Column31")
                    {
                        _result.Columns[a].ColumnName = _result.Columns[a].ColumnName.Remove(_result.Columns[a].ColumnName.Length - 1);
                    }

                    if (_result.Columns[a].ColumnName == "Column311")
                    {
                        _columnNum = a + 1;
                    }
                }
            }
            else if (compare == 0)
            {
                _oldquery[0] = query;
                _oldquery[1] = columnNum.ToString();
                _oldquery[2] = name.ToString();
                _columnNum = 0;
                dataChart.Series.Clear();
                _result = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
                adapter.Fill(_result);
            }

            dataChart.DataSource = _result;

            if (columnNum == 1)
            {
                dataChart.Series.Add(names + name);
                dataChart.Series[names + name].YValueMembers = _result.Columns[_columnNum].ColumnName;
                dataChart.Series[names + name].LegendText = names + " HIC_geweldsmisdrijven";
            }
            else if (columnNum == 2)
            {
                dataChart.Series.Add(names + name);
                dataChart.Series.Add(names + (name + 1));
                dataChart.Series[names + name].YValueMembers = _result.Columns[_columnNum].ColumnName;
                dataChart.Series[names + (name + 1)].YValueMembers = _result.Columns[_columnNum + 1].ColumnName;
                dataChart.Series[names + name].LegendText = names + " HIC_geweldsmisdrijven";
                dataChart.Series[names + (name + 1)].LegendText = names + " Mishandeling";
            }
            else if (columnNum == 3)
            {
                dataChart.Series.Add(names + name);
                dataChart.Series.Add(names + (name + 1));
                dataChart.Series.Add(names + (name + 2));
                dataChart.Series[names + name].YValueMembers = _result.Columns[_columnNum].ColumnName;
                dataChart.Series[names + (name + 1)].YValueMembers = _result.Columns[_columnNum + 1].ColumnName;
                dataChart.Series[names + (name + 2)].YValueMembers = _result.Columns[_columnNum + 2].ColumnName;
                dataChart.Series[names + name].LegendText = names + " HIC_geweldsmisdrijven";
                dataChart.Series[names + (name + 1)].LegendText = names + " Mishandeling";
                dataChart.Series[names + (name + 2)].LegendText = names + " Openlijk_Geweld";
            }
            else if (columnNum == 4)
            {
                dataChart.Series.Add(names + name);
                dataChart.Series.Add(names + (name + 1));
                dataChart.Series[names + name].YValueMembers = _result.Columns[_columnNum].ColumnName;
                dataChart.Series[names + (name + 1)].YValueMembers = _result.Columns[_columnNum + 1].ColumnName;
                dataChart.Series[names + name].LegendText = names + " HIC_geweldsmisdrijven";
                dataChart.Series[names + (name + 1)].LegendText = names + " Openlijk_Geweld";
            }
            else if (columnNum == 5)
            {
                dataChart.Series.Add(names + name);
                dataChart.Series.Add(names + (name + 1));
                dataChart.Series[names + name].YValueMembers = _result.Columns[_columnNum].ColumnName;
                dataChart.Series[names + (name + 1)].YValueMembers = _result.Columns[_columnNum + 1].ColumnName;
                dataChart.Series[names + name].LegendText = names + " Mishandeling";
                dataChart.Series[names + (name + 1)].LegendText = names + " Openlijk_Geweld";
            }
            else if (columnNum == 6)
            {
                dataChart.Series.Add(names + name);
                dataChart.Series[names + name].YValueMembers = _result.Columns[_columnNum].ColumnName;
                dataChart.Series[names + name].LegendText = names + " Mishandeling";
            }
            else if (columnNum == 7)
            {
                dataChart.Series.Add(names + name);
                dataChart.Series[names + name].YValueMembers = _result.Columns[_columnNum].ColumnName;
                dataChart.Series[names + name].LegendText = names + " Openlijk_Geweld";
            }
            dataChart.DataBind();
        }

        private void selectGemeenteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectGemeenteComboBox.SelectedIndex != 0 && selectGemeenteComboBox.SelectedIndex != -1)
            {
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 3, 1, 0);
                }
                else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked == false)
                {
                    Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 2, 1, 0);
                }
                else if (checkBox1.Checked && checkBox3.Checked && checkBox2.Checked == false)
                {
                    Fillchart("select sum(HIC_geweldsmisdrijven), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 4, 1, 0);
                }
                else if (checkBox2.Checked && checkBox3.Checked && checkBox1.Checked == false)
                {
                    Fillchart("select sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 5, 1, 0);
                }
                else if (checkBox1.Checked && checkBox2.Checked == false && checkBox3.Checked == false)
                {
                    Fillchart("select sum(HIC_geweldsmisdrijven) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 1, 1, 0);
                }
                else if (checkBox2.Checked && checkBox1.Checked == false && checkBox3.Checked == false)
                {
                    Fillchart("select sum(Mishandeling) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 6, 1, 0);
                }
                else if (checkBox3.Checked && checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    Fillchart("select sum(Openlijk_Geweld) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 7, 1, 0);
                }
                else if (checkBox3.Checked == false && checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    dataChart.Series.Clear();
                }
            }
            else if (selectGemeenteComboBox.SelectedIndex == 0)
            {
                Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel", selectGemeenteComboBox.Text, 3, 1, 0);
            }
        }

        private void gemeenteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0 && selectGemeenteComboBox.Text != comboBox1.Text && comboBox1.SelectedIndex != -1)
            {
                for (int a = 0; a <= _result.Columns.Count - 1; a++)
                {
                    if (_result.Columns[a].ColumnName != "Column1" && _result.Columns[a].ColumnName != "Column2" && _result.Columns[a].ColumnName != "Column3")
                    {
                        _result.Columns.Remove(_result.Columns[a]);
                        a = a - 1;
                    }
                }
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox1.Text + "'", comboBox1.Text, 3, 4, 1);
                }
                else if (checkBox3.Checked && checkBox2.Checked && checkBox1.Checked == false)
                {
                    Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling) from Letsel where Gemeente = '" + comboBox1.Text + "'", comboBox1.Text, 2, 4, 1);
                }
                else if (checkBox3.Checked && checkBox1.Checked && checkBox2.Checked == false)
                {
                    Fillchart("select sum(HIC_geweldsmisdrijven), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox1.Text + "'", comboBox1.Text, 4, 4, 1);
                }
                else if (checkBox2.Checked && checkBox1.Checked && checkBox3.Checked == false)
                {
                    Fillchart("select sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox1.Text + "'", comboBox1.Text, 5, 4, 1);
                }
                else if (checkBox3.Checked && checkBox2.Checked == false && checkBox1.Checked == false)
                {
                    Fillchart("select sum(HIC_geweldsmisdrijven) from Letsel where Gemeente = '" + comboBox1.Text + "'", comboBox1.Text, 1, 4, 1);
                }
                else if (checkBox2.Checked && checkBox3.Checked == false && checkBox1.Checked == false)
                {
                    Fillchart("select sum(Mishandeling) from Letsel where Gemeente = '" + comboBox1.Text + "'", comboBox1.Text, 6, 4, 1);
                }
                else if (checkBox1.Checked && checkBox3.Checked == false && checkBox2.Checked == false)
                {
                    Fillchart("select sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox1.Text + "'", comboBox1.Text, 7, 4, 1);
                }
                else if (checkBox1.Checked == false && checkBox3.Checked == false && checkBox2.Checked == false)
                {
                    dataChart.Series.Clear();
                }
            }
            else if (comboBox1.SelectedIndex == 0 && selectGemeenteComboBox.Text != comboBox1.Text && comboBox1.SelectedIndex != -1)
            {
                for (int a = 0; a <= _result.Columns.Count - 1; a++)
                {
                    if (_result.Columns[a].ColumnName != "Column1" && _result.Columns[a].ColumnName != "Column2" && _result.Columns[a].ColumnName != "Column3")
                    {
                        _result.Columns.Remove(_result.Columns[a]);
                        a = a - 1;
                    }
                }
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel", comboBox1.Text, 3, 4, 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_check)
            {
                _check = false;
            }
            else
            {
                _check = true;
            }

            if (_check)
            {
                comboBox1.Visible = true;
                button2.Visible = true;
            }
            else
            {
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                comboBox1.Visible = false;
                button2.Visible = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1)
            {
                for (int a = 0; a <= dataChart.Series.Count - 1; a++)
                {
                    dataChart.Series[a].ChartType = SeriesChartType.StackedColumn;
                }
            }
            if (comboBox2.SelectedIndex == 0)
            {
                for (int a = 0; a <= dataChart.Series.Count - 1; a++)
                {
                    dataChart.Series[a].ChartType = SeriesChartType.Column;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_check2)
            {
                _check2 = false;
            }
            else
            {
                _check2 = true;
            }

            if (_check2)
            {
                comboBox3.Visible = true;
            }
            else
            {
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                Fillchart(_oldquery[3], comboBox1.Text, Convert.ToInt16(_oldquery[4]), Convert.ToInt16(_oldquery[5]), 1);
                comboBox3.Visible = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != 0 && selectGemeenteComboBox.Text != comboBox3.Text && comboBox3.SelectedIndex != -1)
            {
                for (int a = 0; a <= _result.Columns.Count - 1; a++)
                {
                    if (_result.Columns[a].ColumnName != "Column1" && _result.Columns[a].ColumnName != "Column2" && _result.Columns[a].ColumnName != "Column3" && _result.Columns[a].ColumnName != "Column111" && _result.Columns[a].ColumnName != "Column211" && _result.Columns[a].ColumnName != "Column311")
                    {
                        _result.Columns.Remove(_result.Columns[a]);
                        a = a - 1;
                    }
                }
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                Fillchart(_oldquery[3], comboBox1.Text, Convert.ToInt16(_oldquery[4]), Convert.ToInt16(_oldquery[5]), 1);
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox3.Text + "'", comboBox3.Text, 3, 8, 2);
                }
                else if (checkBox3.Checked && checkBox2.Checked && checkBox1.Checked == false)
                {
                    Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling) from Letsel where Gemeente = '" + comboBox3.Text + "'", comboBox3.Text, 2, 8, 2);
                }
                else if (checkBox3.Checked && checkBox1.Checked && checkBox2.Checked == false)
                {
                    Fillchart("select sum(HIC_geweldsmisdrijven), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox3.Text + "'", comboBox3.Text, 4, 8, 2);
                }
                else if (checkBox2.Checked && checkBox1.Checked && checkBox3.Checked == false)
                {
                    Fillchart("select sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox3.Text + "'", comboBox3.Text, 5, 8, 2);
                }
                else if (checkBox3.Checked && checkBox2.Checked == false && checkBox1.Checked == false)
                {
                    Fillchart("select sum(HIC_geweldsmisdrijven) from Letsel where Gemeente = '" + comboBox3.Text + "'", comboBox3.Text, 1, 8, 2);
                }
                else if (checkBox2.Checked && checkBox3.Checked == false && checkBox1.Checked == false)
                {
                    Fillchart("select sum(Mishandeling) from Letsel where Gemeente = '" + comboBox3.Text + "'", comboBox3.Text, 6, 8, 2);
                }
                else if (checkBox1.Checked && checkBox3.Checked == false && checkBox2.Checked == false)
                {
                    Fillchart("select sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox3.Text + "'", comboBox3.Text, 7, 8, 2);
                }
                else if (checkBox1.Checked == false && checkBox3.Checked == false && checkBox2.Checked == false)
                {
                    dataChart.Series.Clear();
                }
            }
            else if (comboBox3.SelectedIndex == 0 && selectGemeenteComboBox.Text != comboBox3.Text && comboBox3.SelectedIndex != -1)
            {
                for (int a = 0; a <= _result.Columns.Count - 1; a++)
                {
                    if (_result.Columns[a].ColumnName != "Column1" && _result.Columns[a].ColumnName != "Column2" && _result.Columns[a].ColumnName != "Column3" && _result.Columns[a].ColumnName != "Column111" && _result.Columns[a].ColumnName != "Column211" && _result.Columns[a].ColumnName != "Column311")
                    {
                        _result.Columns.Remove(_result.Columns[a]);
                        a = a - 1;
                    }
                }
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                Fillchart(_oldquery[3], comboBox1.Text, Convert.ToInt16(_oldquery[4]), Convert.ToInt16(_oldquery[5]), 1);
                Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel", comboBox3.Text, 3, 8, 2);
            }
        }
    }
}
