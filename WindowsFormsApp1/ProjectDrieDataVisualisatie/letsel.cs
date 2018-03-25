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
        private bool _check3;
        private int _columnNum;
        private string[] _oldquery = new string[12];
        private int[] _selectindex = new int[4];

        public static Letsel Instance => _instance ?? (_instance = new Letsel());

        public Letsel()
        {
            InitializeComponent();
            var conString = ConfigurationManager.ConnectionStrings["ProjectDrieDataVisualisatie.Properties.Settings.Database1ConnectionString"].ConnectionString;
            _connection = new SqlConnection(conString);

            selectGemeenteComboBox.Items.Add("Nederland");
            selectGemeenteComboBox.SelectedIndex = 0;
            comboBox1.Items.Add("Nederland");
            comboBox3.Items.Add("Nederland");
            comboBox4.Items.Add("Nederland");
            comboBox2.SelectedIndex = 0;
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
                comboBox4.Items.Add(_gemeentenaam);
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
                _oldquery[6] = query;
                _oldquery[7] = columnNum.ToString();
                _oldquery[8] = name.ToString();
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
            else if (compare == 3)
            {
                _oldquery[9] = query;
                _oldquery[10] = columnNum.ToString();
                _oldquery[11] = name.ToString();

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
                        _result.Columns[a].ColumnName = _result.Columns[a].ColumnName + "1111";
                    }
                }

                for (int a = 0; a <= _result.Columns.Count - 1; a++)
                {
                    if (_result.Columns[a].ColumnName == "Column11" || _result.Columns[a].ColumnName == "Column21" || _result.Columns[a].ColumnName == "Column31")
                    {
                        _result.Columns[a].ColumnName = _result.Columns[a].ColumnName.Remove(_result.Columns[a].ColumnName.Length - 1);
                    }

                    if (_result.Columns[a].ColumnName == "Column3111")
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
            _selectindex[0] = selectGemeenteComboBox.SelectedIndex;
            _selectindex[1] = comboBox1.SelectedIndex;
            _selectindex[2] = comboBox3.SelectedIndex;
            _selectindex[3] = comboBox4.SelectedIndex;

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
            if (comboBox1.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 &&
                selectGemeenteComboBox.Text != comboBox1.Text && selectGemeenteComboBox.Text != comboBox3.Text &&
                selectGemeenteComboBox.Text != comboBox4.Text && comboBox1.Text != comboBox3.Text &&
                comboBox1.Text != comboBox4.Text && comboBox3.Text != comboBox4.Text)
            {
                Check1();
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex == -1 &&
                     selectGemeenteComboBox.Text != comboBox1.Text && selectGemeenteComboBox.Text != comboBox3.Text &&
                     comboBox1.Text != comboBox3.Text)
            {
                Check1();
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox3.SelectedIndex == -1 && comboBox4.SelectedIndex == -1 &&
                     selectGemeenteComboBox.Text != comboBox1.Text)
            {
                Check1();
            }
            else if (comboBox1.SelectedIndex == -1 && comboBox3.SelectedIndex == -1 && comboBox4.SelectedIndex == -1)
            {
                Check1();
            }
            else
            {
                MessageBox.Show(@"Je kan niet twee dezelfde gemeenten of provincies met elkaar vergelijken.");
                selectGemeenteComboBox.SelectedIndex = _selectindex[0];
            }
        }

        private void Check1()
        {
            if (selectGemeenteComboBox.SelectedIndex != 0 && selectGemeenteComboBox.SelectedIndex != -1 && selectGemeenteComboBox.Text != comboBox1.Text && selectGemeenteComboBox.Text != comboBox3.Text && selectGemeenteComboBox.Text != comboBox4.Text)
            {
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    if (selectGemeenteComboBox.Text == @"drenthe" || selectGemeenteComboBox.Text == @"noord-Brabant" ||
                        selectGemeenteComboBox.Text == @"noord-Holland" ||
                        selectGemeenteComboBox.Text == @"gelderland" || selectGemeenteComboBox.Text == @"friesland" ||
                        selectGemeenteComboBox.Text == @"zuid-Holland" ||
                        selectGemeenteComboBox.Text == @"overijssel" || selectGemeenteComboBox.Text == @"flevoland" ||
                        selectGemeenteComboBox.Text == @"groningen" || selectGemeenteComboBox.Text == @"zeeland" ||
                        selectGemeenteComboBox.Text == @"limburg" || selectGemeenteComboBox.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Provincie = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 3, 1, 0);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 3, 1, 0);
                    }
                        
                }
                else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked == false)
                {
                    if (selectGemeenteComboBox.Text == @"drenthe" || selectGemeenteComboBox.Text == @"noord-Brabant" ||
                        selectGemeenteComboBox.Text == @"noord-Holland" ||
                        selectGemeenteComboBox.Text == @"gelderland" || selectGemeenteComboBox.Text == @"friesland" ||
                        selectGemeenteComboBox.Text == @"zuid-Holland" ||
                        selectGemeenteComboBox.Text == @"overijssel" || selectGemeenteComboBox.Text == @"flevoland" ||
                        selectGemeenteComboBox.Text == @"groningen" || selectGemeenteComboBox.Text == @"zeeland" ||
                        selectGemeenteComboBox.Text == @"limburg" || selectGemeenteComboBox.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling) from Letsel where Provincie = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 2, 1, 0);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 2, 1, 0);
                    }

                    
                }
                else if (checkBox1.Checked && checkBox3.Checked && checkBox2.Checked == false)
                {
                    if (selectGemeenteComboBox.Text == @"drenthe" || selectGemeenteComboBox.Text == @"noord-Brabant" ||
                        selectGemeenteComboBox.Text == @"noord-Holland" ||
                        selectGemeenteComboBox.Text == @"gelderland" || selectGemeenteComboBox.Text == @"friesland" ||
                        selectGemeenteComboBox.Text == @"zuid-Holland" ||
                        selectGemeenteComboBox.Text == @"overijssel" || selectGemeenteComboBox.Text == @"flevoland" ||
                        selectGemeenteComboBox.Text == @"groningen" || selectGemeenteComboBox.Text == @"zeeland" ||
                        selectGemeenteComboBox.Text == @"limburg" || selectGemeenteComboBox.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Openlijk_Geweld) from Letsel where Provincie = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 4, 1, 0);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 4, 1, 0);
                    }
                    
                }
                else if (checkBox2.Checked && checkBox3.Checked && checkBox1.Checked == false)
                {
                    if (selectGemeenteComboBox.Text == @"drenthe" || selectGemeenteComboBox.Text == @"noord-Brabant" ||
                        selectGemeenteComboBox.Text == @"noord-Holland" ||
                        selectGemeenteComboBox.Text == @"gelderland" || selectGemeenteComboBox.Text == @"friesland" ||
                        selectGemeenteComboBox.Text == @"zuid-Holland" ||
                        selectGemeenteComboBox.Text == @"overijssel" || selectGemeenteComboBox.Text == @"flevoland" ||
                        selectGemeenteComboBox.Text == @"groningen" || selectGemeenteComboBox.Text == @"zeeland" ||
                        selectGemeenteComboBox.Text == @"limburg" || selectGemeenteComboBox.Text == @"utrecht")
                    {
                        Fillchart("select sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Provincie = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 5, 1, 0);
                    }
                    else
                    {
                        Fillchart("select sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 5, 1, 0);
                    }
                    
                }
                else if (checkBox1.Checked && checkBox2.Checked == false && checkBox3.Checked == false)
                {
                    if (selectGemeenteComboBox.Text == @"drenthe" || selectGemeenteComboBox.Text == @"noord-Brabant" ||
                        selectGemeenteComboBox.Text == @"noord-Holland" ||
                        selectGemeenteComboBox.Text == @"gelderland" || selectGemeenteComboBox.Text == @"friesland" ||
                        selectGemeenteComboBox.Text == @"zuid-Holland" ||
                        selectGemeenteComboBox.Text == @"overijssel" || selectGemeenteComboBox.Text == @"flevoland" ||
                        selectGemeenteComboBox.Text == @"groningen" || selectGemeenteComboBox.Text == @"zeeland" ||
                        selectGemeenteComboBox.Text == @"limburg" || selectGemeenteComboBox.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven) from Letsel where Provincie = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 1, 1, 0);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 1, 1, 0);
                    }
                    
                }
                else if (checkBox2.Checked && checkBox1.Checked == false && checkBox3.Checked == false)
                {
                    if (selectGemeenteComboBox.Text == @"drenthe" || selectGemeenteComboBox.Text == @"noord-Brabant" ||
                        selectGemeenteComboBox.Text == @"noord-Holland" ||
                        selectGemeenteComboBox.Text == @"gelderland" || selectGemeenteComboBox.Text == @"friesland" ||
                        selectGemeenteComboBox.Text == @"zuid-Holland" ||
                        selectGemeenteComboBox.Text == @"overijssel" || selectGemeenteComboBox.Text == @"flevoland" ||
                        selectGemeenteComboBox.Text == @"groningen" || selectGemeenteComboBox.Text == @"zeeland" ||
                        selectGemeenteComboBox.Text == @"limburg" || selectGemeenteComboBox.Text == @"utrecht")
                    {
                        Fillchart("select sum(Mishandeling) from Letsel where Provincie = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 6, 1, 0);
                    }
                    else
                    {
                        Fillchart("select sum(Mishandeling) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 6, 1, 0);
                    }
                    
                }
                else if (checkBox3.Checked && checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    if (selectGemeenteComboBox.Text == @"drenthe" || selectGemeenteComboBox.Text == @"noord-Brabant" ||
                        selectGemeenteComboBox.Text == @"noord-Holland" ||
                        selectGemeenteComboBox.Text == @"gelderland" || selectGemeenteComboBox.Text == @"friesland" ||
                        selectGemeenteComboBox.Text == @"zuid-Holland" ||
                        selectGemeenteComboBox.Text == @"overijssel" || selectGemeenteComboBox.Text == @"flevoland" ||
                        selectGemeenteComboBox.Text == @"groningen" || selectGemeenteComboBox.Text == @"zeeland" ||
                        selectGemeenteComboBox.Text == @"limburg" || selectGemeenteComboBox.Text == @"utrecht")
                    {
                        Fillchart("select sum(Openlijk_Geweld) from Letsel where Provincie = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 7, 1, 0);
                    }
                    else
                    {
                        Fillchart("select sum(Openlijk_Geweld) from Letsel where Gemeente = '" + selectGemeenteComboBox.Text + "'", selectGemeenteComboBox.Text, 7, 1, 0);
                    }
                    
                }
                else if (checkBox3.Checked == false && checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    dataChart.Series.Clear();
                }
            }
            else if (selectGemeenteComboBox.SelectedIndex == 0 && selectGemeenteComboBox.Text != comboBox1.Text && selectGemeenteComboBox.Text != comboBox3.Text && selectGemeenteComboBox.Text != comboBox4.Text)
            {
                Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel", selectGemeenteComboBox.Text, 3, 1, 0);
            }

            if (comboBox1.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && selectGemeenteComboBox.Text != comboBox1.Text && selectGemeenteComboBox.Text != comboBox3.Text && selectGemeenteComboBox.Text != comboBox4.Text)
            {
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                Fillchart(_oldquery[3], comboBox1.Text, Convert.ToInt16(_oldquery[4]), Convert.ToInt16(_oldquery[5]), 1);
                Fillchart(_oldquery[6], comboBox3.Text, Convert.ToInt16(_oldquery[7]), Convert.ToInt16(_oldquery[8]), 2);
                Fillchart(_oldquery[9], comboBox4.Text, Convert.ToInt16(_oldquery[10]), Convert.ToInt16(_oldquery[11]), 3);
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex == -1 && selectGemeenteComboBox.Text != comboBox1.Text && selectGemeenteComboBox.Text != comboBox3.Text)
            {
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                Fillchart(_oldquery[3], comboBox1.Text, Convert.ToInt16(_oldquery[4]), Convert.ToInt16(_oldquery[5]), 1);
                Fillchart(_oldquery[6], comboBox3.Text, Convert.ToInt16(_oldquery[7]), Convert.ToInt16(_oldquery[8]), 2);
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox3.SelectedIndex == -1 && comboBox4.SelectedIndex == -1 && selectGemeenteComboBox.Text != comboBox1.Text)
            {
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                Fillchart(_oldquery[3], comboBox1.Text, Convert.ToInt16(_oldquery[4]), Convert.ToInt16(_oldquery[5]), 1);
            }
        }

        private void Check2()
        {
            if (comboBox1.SelectedIndex != 0 && comboBox1.Text != selectGemeenteComboBox.Text && comboBox1.SelectedIndex != -1 && comboBox1.Text != comboBox3.Text && comboBox1.Text != comboBox4.Text)
            {
                for (int a = 0; a <= _result.Columns.Count - 1; a++)
                {
                    if (_result.Columns[a].ColumnName == "Column111" || _result.Columns[a].ColumnName == "Column211" || _result.Columns[a].ColumnName == "Column311")
                    {
                        _result.Columns.Remove(_result.Columns[a]);
                        a = a - 1;
                    }
                }
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    if (comboBox1.Text == @"drenthe" || comboBox1.Text == @"noord-Brabant" ||
                        comboBox1.Text == @"noord-Holland" ||
                        comboBox1.Text == @"gelderland" || comboBox1.Text == @"friesland" ||
                        comboBox1.Text == @"zuid-Holland" ||
                        comboBox1.Text == @"overijssel" || comboBox1.Text == @"flevoland" ||
                        comboBox1.Text == @"groningen" || comboBox1.Text == @"zeeland" ||
                        comboBox1.Text == @"limburg" || comboBox1.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Provincie = '" + comboBox1.Text + "'", comboBox1.Text, 3, 4, 1);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox1.Text + "'", comboBox1.Text, 3, 4, 1);
                    }

                }
                else if (checkBox3.Checked && checkBox2.Checked && checkBox1.Checked == false)
                {
                    if (comboBox1.Text == @"drenthe" || comboBox1.Text == @"noord-Brabant" ||
                        comboBox1.Text == @"noord-Holland" ||
                        comboBox1.Text == @"gelderland" || comboBox1.Text == @"friesland" ||
                        comboBox1.Text == @"zuid-Holland" ||
                        comboBox1.Text == @"overijssel" || comboBox1.Text == @"flevoland" ||
                        comboBox1.Text == @"groningen" || comboBox1.Text == @"zeeland" ||
                        comboBox1.Text == @"limburg" || comboBox1.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling) from Letsel where Provincie = '" + comboBox1.Text + "'", comboBox1.Text, 2, 4, 1);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling) from Letsel where Gemeente = '" + comboBox1.Text + "'", comboBox1.Text, 2, 4, 1);
                    }
                    
                }
                else if (checkBox3.Checked && checkBox1.Checked && checkBox2.Checked == false)
                {
                    if (comboBox1.Text == @"drenthe" || comboBox1.Text == @"noord-Brabant" ||
                        comboBox1.Text == @"noord-Holland" ||
                        comboBox1.Text == @"gelderland" || comboBox1.Text == @"friesland" ||
                        comboBox1.Text == @"zuid-Holland" ||
                        comboBox1.Text == @"overijssel" || comboBox1.Text == @"flevoland" ||
                        comboBox1.Text == @"groningen" || comboBox1.Text == @"zeeland" ||
                        comboBox1.Text == @"limburg" || comboBox1.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Openlijk_Geweld) from Letsel where Provincie = '" + comboBox1.Text + "'", comboBox1.Text, 4, 4, 1);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox1.Text + "'", comboBox1.Text, 4, 4, 1);
                    }
                    
                }
                else if (checkBox2.Checked && checkBox1.Checked && checkBox3.Checked == false)
                {
                    if (comboBox1.Text == @"drenthe" || comboBox1.Text == @"noord-Brabant" ||
                        comboBox1.Text == @"noord-Holland" ||
                        comboBox1.Text == @"gelderland" || comboBox1.Text == @"friesland" ||
                        comboBox1.Text == @"zuid-Holland" ||
                        comboBox1.Text == @"overijssel" || comboBox1.Text == @"flevoland" ||
                        comboBox1.Text == @"groningen" || comboBox1.Text == @"zeeland" ||
                        comboBox1.Text == @"limburg" || comboBox1.Text == @"utrecht")
                    {
                        Fillchart("select sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Provincie = '" + comboBox1.Text + "'", comboBox1.Text, 5, 4, 1);
                    }
                    else
                    {
                        Fillchart("select sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox1.Text + "'", comboBox1.Text, 5, 4, 1);
                    }
                    
                }
                else if (checkBox3.Checked && checkBox2.Checked == false && checkBox1.Checked == false)
                {
                    if (comboBox1.Text == @"drenthe" || comboBox1.Text == @"noord-Brabant" ||
                        comboBox1.Text == @"noord-Holland" ||
                        comboBox1.Text == @"gelderland" || comboBox1.Text == @"friesland" ||
                        comboBox1.Text == @"zuid-Holland" ||
                        comboBox1.Text == @"overijssel" || comboBox1.Text == @"flevoland" ||
                        comboBox1.Text == @"groningen" || comboBox1.Text == @"zeeland" ||
                        comboBox1.Text == @"limburg" || comboBox1.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven) from Letsel where Provincie = '" + comboBox1.Text + "'", comboBox1.Text, 1, 4, 1);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven) from Letsel where Gemeente = '" + comboBox1.Text + "'", comboBox1.Text, 1, 4, 1);
                    }
                    
                }
                else if (checkBox2.Checked && checkBox3.Checked == false && checkBox1.Checked == false)
                {
                    if (comboBox1.Text == @"drenthe" || comboBox1.Text == @"noord-Brabant" ||
                        comboBox1.Text == @"noord-Holland" ||
                        comboBox1.Text == @"gelderland" || comboBox1.Text == @"friesland" ||
                        comboBox1.Text == @"zuid-Holland" ||
                        comboBox1.Text == @"overijssel" || comboBox1.Text == @"flevoland" ||
                        comboBox1.Text == @"groningen" || comboBox1.Text == @"zeeland" ||
                        comboBox1.Text == @"limburg" || comboBox1.Text == @"utrecht")
                    {
                        Fillchart("select sum(Mishandeling) from Letsel where Provincie = '" + comboBox1.Text + "'", comboBox1.Text, 6, 4, 1);
                    }
                    else
                    {
                        Fillchart("select sum(Mishandeling) from Letsel where Gemeente = '" + comboBox1.Text + "'", comboBox1.Text, 6, 4, 1);
                    }
                    
                }
                else if (checkBox1.Checked && checkBox3.Checked == false && checkBox2.Checked == false)
                {
                    if (comboBox1.Text == @"drenthe" || comboBox1.Text == @"noord-Brabant" ||
                        comboBox1.Text == @"noord-Holland" ||
                        comboBox1.Text == @"gelderland" || comboBox1.Text == @"friesland" ||
                        comboBox1.Text == @"zuid-Holland" ||
                        comboBox1.Text == @"overijssel" || comboBox1.Text == @"flevoland" ||
                        comboBox1.Text == @"groningen" || comboBox1.Text == @"zeeland" ||
                        comboBox1.Text == @"limburg" || comboBox1.Text == @"utrecht")
                    {
                        Fillchart("select sum(Openlijk_Geweld) from Letsel where Provincie = '" + comboBox1.Text + "'", comboBox1.Text, 7, 4, 1);
                    }
                    else
                    {
                        Fillchart("select sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox1.Text + "'", comboBox1.Text, 7, 4, 1);
                    }
                    
                }
                else if (checkBox1.Checked == false && checkBox3.Checked == false && checkBox2.Checked == false)
                {
                    dataChart.Series.Clear();
                }
            }
            else if (comboBox1.SelectedIndex == 0 && selectGemeenteComboBox.Text != comboBox1.Text && comboBox1.Text != comboBox3.Text && comboBox1.Text != comboBox4.Text)
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

            if (comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 && comboBox1.Text != comboBox3.Text && comboBox1.Text != comboBox4.Text)
            {
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                Fillchart(_oldquery[3], comboBox1.Text, Convert.ToInt16(_oldquery[4]), Convert.ToInt16(_oldquery[5]), 1);
                Fillchart(_oldquery[6], comboBox3.Text, Convert.ToInt16(_oldquery[7]), Convert.ToInt16(_oldquery[8]), 2);
                Fillchart(_oldquery[9], comboBox4.Text, Convert.ToInt16(_oldquery[10]), Convert.ToInt16(_oldquery[11]), 3);
            }
            else if (comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex == -1 && comboBox1.Text != comboBox3.Text)
            {
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                Fillchart(_oldquery[3], comboBox1.Text, Convert.ToInt16(_oldquery[4]), Convert.ToInt16(_oldquery[5]), 1);
                Fillchart(_oldquery[6], comboBox3.Text, Convert.ToInt16(_oldquery[7]), Convert.ToInt16(_oldquery[8]), 2);
            }
        }

        private void Check3()
        {
            if (comboBox3.SelectedIndex != 0 && selectGemeenteComboBox.Text != comboBox3.Text && comboBox3.SelectedIndex != -1 && comboBox3.Text != comboBox1.Text && comboBox3.Text != comboBox4.Text)
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
                    if (comboBox3.Text == @"drenthe" || comboBox3.Text == @"noord-Brabant" ||
                        comboBox3.Text == @"noord-Holland" ||
                        comboBox3.Text == @"gelderland" || comboBox3.Text == @"friesland" ||
                        comboBox3.Text == @"zuid-Holland" ||
                        comboBox3.Text == @"overijssel" || comboBox3.Text == @"flevoland" ||
                        comboBox3.Text == @"groningen" || comboBox3.Text == @"zeeland" ||
                        comboBox3.Text == @"limburg" || comboBox3.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Provincie = '" + comboBox3.Text + "'", comboBox3.Text, 3, 8, 2);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox3.Text + "'", comboBox3.Text, 3, 8, 2);
                    }
                    
                }
                else if (checkBox3.Checked && checkBox2.Checked && checkBox1.Checked == false)
                {
                    if (comboBox3.Text == @"drenthe" || comboBox3.Text == @"noord-Brabant" ||
                        comboBox3.Text == @"noord-Holland" ||
                        comboBox3.Text == @"gelderland" || comboBox3.Text == @"friesland" ||
                        comboBox3.Text == @"zuid-Holland" ||
                        comboBox3.Text == @"overijssel" || comboBox3.Text == @"flevoland" ||
                        comboBox3.Text == @"groningen" || comboBox3.Text == @"zeeland" ||
                        comboBox3.Text == @"limburg" || comboBox3.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling) from Letsel where Provincie = '" + comboBox3.Text + "'", comboBox3.Text, 2, 8, 2);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling) from Letsel where Gemeente = '" + comboBox3.Text + "'", comboBox3.Text, 2, 8, 2);
                    }
                    
                }
                else if (checkBox3.Checked && checkBox1.Checked && checkBox2.Checked == false)
                {
                    if (comboBox3.Text == @"drenthe" || comboBox3.Text == @"noord-Brabant" ||
                        comboBox3.Text == @"noord-Holland" ||
                        comboBox3.Text == @"gelderland" || comboBox3.Text == @"friesland" ||
                        comboBox3.Text == @"zuid-Holland" ||
                        comboBox3.Text == @"overijssel" || comboBox3.Text == @"flevoland" ||
                        comboBox3.Text == @"groningen" || comboBox3.Text == @"zeeland" ||
                        comboBox3.Text == @"limburg" || comboBox3.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Openlijk_Geweld) from Letsel where Provincie = '" + comboBox3.Text + "'", comboBox3.Text, 4, 8, 2);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox3.Text + "'", comboBox3.Text, 4, 8, 2);
                    }
                    
                }
                else if (checkBox2.Checked && checkBox1.Checked && checkBox3.Checked == false)
                {
                    if (comboBox3.Text == @"drenthe" || comboBox3.Text == @"noord-Brabant" ||
                        comboBox3.Text == @"noord-Holland" ||
                        comboBox3.Text == @"gelderland" || comboBox3.Text == @"friesland" ||
                        comboBox3.Text == @"zuid-Holland" ||
                        comboBox3.Text == @"overijssel" || comboBox3.Text == @"flevoland" ||
                        comboBox3.Text == @"groningen" || comboBox3.Text == @"zeeland" ||
                        comboBox3.Text == @"limburg" || comboBox3.Text == @"utrecht")
                    {
                        Fillchart("select sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Provincie = '" + comboBox3.Text + "'", comboBox3.Text, 5, 8, 2);
                    }
                    else
                    {
                        Fillchart("select sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox3.Text + "'", comboBox3.Text, 5, 8, 2);
                    }
                    
                }
                else if (checkBox3.Checked && checkBox2.Checked == false && checkBox1.Checked == false)
                {
                    if (comboBox3.Text == @"drenthe" || comboBox3.Text == @"noord-Brabant" ||
                        comboBox3.Text == @"noord-Holland" ||
                        comboBox3.Text == @"gelderland" || comboBox3.Text == @"friesland" ||
                        comboBox3.Text == @"zuid-Holland" ||
                        comboBox3.Text == @"overijssel" || comboBox3.Text == @"flevoland" ||
                        comboBox3.Text == @"groningen" || comboBox3.Text == @"zeeland" ||
                        comboBox3.Text == @"limburg" || comboBox3.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven) from Letsel where Provincie = '" + comboBox3.Text + "'", comboBox3.Text, 1, 8, 2);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven) from Letsel where Gemeente = '" + comboBox3.Text + "'", comboBox3.Text, 1, 8, 2);
                    }
                    
                }
                else if (checkBox2.Checked && checkBox3.Checked == false && checkBox1.Checked == false)
                {
                    if (comboBox3.Text == @"drenthe" || comboBox3.Text == @"noord-Brabant" ||
                        comboBox3.Text == @"noord-Holland" ||
                        comboBox3.Text == @"gelderland" || comboBox3.Text == @"friesland" ||
                        comboBox3.Text == @"zuid-Holland" ||
                        comboBox3.Text == @"overijssel" || comboBox3.Text == @"flevoland" ||
                        comboBox3.Text == @"groningen" || comboBox3.Text == @"zeeland" ||
                        comboBox3.Text == @"limburg" || comboBox3.Text == @"utrecht")
                    {
                        Fillchart("select sum(Mishandeling) from Letsel where Provincie = '" + comboBox3.Text + "'", comboBox3.Text, 6, 8, 2);
                    }
                    else
                    {
                        Fillchart("select sum(Mishandeling) from Letsel where Gemeente = '" + comboBox3.Text + "'", comboBox3.Text, 6, 8, 2);
                    }
                    
                }
                else if (checkBox1.Checked && checkBox3.Checked == false && checkBox2.Checked == false)
                {
                    if (comboBox3.Text == @"drenthe" || comboBox3.Text == @"noord-Brabant" ||
                        comboBox3.Text == @"noord-Holland" ||
                        comboBox3.Text == @"gelderland" || comboBox3.Text == @"friesland" ||
                        comboBox3.Text == @"zuid-Holland" ||
                        comboBox3.Text == @"overijssel" || comboBox3.Text == @"flevoland" ||
                        comboBox3.Text == @"groningen" || comboBox3.Text == @"zeeland" ||
                        comboBox3.Text == @"limburg" || comboBox3.Text == @"utrecht")
                    {
                        Fillchart("select sum(Openlijk_Geweld) from Letsel where Provincie = '" + comboBox3.Text + "'", comboBox3.Text, 7, 8, 2);
                    }
                    else
                    {
                        Fillchart("select sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox3.Text + "'", comboBox3.Text, 7, 8, 2);
                    }
                    
                }
                else if (checkBox1.Checked == false && checkBox3.Checked == false && checkBox2.Checked == false)
                {
                    dataChart.Series.Clear();
                }
            }
            else if (comboBox3.SelectedIndex == 0 && selectGemeenteComboBox.Text != comboBox3.Text && comboBox3.SelectedIndex != -1 && comboBox3.Text != comboBox1.Text && comboBox3.Text != comboBox4.Text)
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

            if (comboBox4.SelectedIndex != -1 && comboBox3.Text != selectGemeenteComboBox.Text && comboBox3.Text != comboBox1.Text && comboBox3.Text != comboBox4.Text)
            {
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                Fillchart(_oldquery[3], comboBox1.Text, Convert.ToInt16(_oldquery[4]), Convert.ToInt16(_oldquery[5]), 1);
                Fillchart(_oldquery[6], comboBox3.Text, Convert.ToInt16(_oldquery[7]), Convert.ToInt16(_oldquery[8]), 2);
                Fillchart(_oldquery[9], comboBox4.Text, Convert.ToInt16(_oldquery[10]), Convert.ToInt16(_oldquery[11]), 3);
            }
        }

        private void Check4()
        {
            if (comboBox4.SelectedIndex != 0 && selectGemeenteComboBox.Text != comboBox4.Text && comboBox4.SelectedIndex != -1)
            {
                for (int a = 0; a <= _result.Columns.Count - 1; a++)
                {
                    if (_result.Columns[a].ColumnName == "Column11111" || _result.Columns[a].ColumnName == "Column21111" || _result.Columns[a].ColumnName == "Column31111")
                    {
                        _result.Columns.Remove(_result.Columns[a]);
                        a = a - 1;
                    }
                }
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                Fillchart(_oldquery[3], comboBox1.Text, Convert.ToInt16(_oldquery[4]), Convert.ToInt16(_oldquery[5]), 1);
                Fillchart(_oldquery[6], comboBox3.Text, Convert.ToInt16(_oldquery[7]), Convert.ToInt16(_oldquery[8]), 2);
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    if (comboBox4.Text == @"drenthe" || comboBox4.Text == @"noord-Brabant" ||
                        comboBox4.Text == @"noord-Holland" ||
                        comboBox4.Text == @"gelderland" || comboBox4.Text == @"friesland" ||
                        comboBox4.Text == @"zuid-Holland" ||
                        comboBox4.Text == @"overijssel" || comboBox4.Text == @"flevoland" ||
                        comboBox4.Text == @"groningen" || comboBox4.Text == @"zeeland" ||
                        comboBox4.Text == @"limburg" || comboBox4.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Provincie = '" + comboBox4.Text + "'", comboBox4.Text, 3, 8, 3);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox4.Text + "'", comboBox4.Text, 3, 8, 3);
                    }
                    
                }
                else if (checkBox3.Checked && checkBox2.Checked && checkBox1.Checked == false)
                {
                    if (comboBox4.Text == @"drenthe" || comboBox4.Text == @"noord-Brabant" ||
                        comboBox4.Text == @"noord-Holland" ||
                        comboBox4.Text == @"gelderland" || comboBox4.Text == @"friesland" ||
                        comboBox4.Text == @"zuid-Holland" ||
                        comboBox4.Text == @"overijssel" || comboBox4.Text == @"flevoland" ||
                        comboBox4.Text == @"groningen" || comboBox4.Text == @"zeeland" ||
                        comboBox4.Text == @"limburg" || comboBox4.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling) from Letsel where Provincie = '" + comboBox4.Text + "'", comboBox4.Text, 2, 8, 3);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling) from Letsel where Gemeente = '" + comboBox4.Text + "'", comboBox4.Text, 2, 8, 3);
                    }
                    
                }
                else if (checkBox3.Checked && checkBox1.Checked && checkBox2.Checked == false)
                {
                    if (comboBox4.Text == @"drenthe" || comboBox4.Text == @"noord-Brabant" ||
                        comboBox4.Text == @"noord-Holland" ||
                        comboBox4.Text == @"gelderland" || comboBox4.Text == @"friesland" ||
                        comboBox4.Text == @"zuid-Holland" ||
                        comboBox4.Text == @"overijssel" || comboBox4.Text == @"flevoland" ||
                        comboBox4.Text == @"groningen" || comboBox4.Text == @"zeeland" ||
                        comboBox4.Text == @"limburg" || comboBox4.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Openlijk_Geweld) from Letsel where Provincie = '" + comboBox4.Text + "'", comboBox4.Text, 4, 8, 3);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox4.Text + "'", comboBox4.Text, 4, 8, 3);
                    }
                    
                }
                else if (checkBox2.Checked && checkBox1.Checked && checkBox3.Checked == false)
                {
                    if (comboBox4.Text == @"drenthe" || comboBox4.Text == @"noord-Brabant" ||
                        comboBox4.Text == @"noord-Holland" ||
                        comboBox4.Text == @"gelderland" || comboBox4.Text == @"friesland" ||
                        comboBox4.Text == @"zuid-Holland" ||
                        comboBox4.Text == @"overijssel" || comboBox4.Text == @"flevoland" ||
                        comboBox4.Text == @"groningen" || comboBox4.Text == @"zeeland" ||
                        comboBox4.Text == @"limburg" || comboBox4.Text == @"utrecht")
                    {
                        Fillchart("select sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Provincie = '" + comboBox4.Text + "'", comboBox4.Text, 5, 8, 3);
                    }
                    else
                    {
                        Fillchart("select sum(Mishandeling), sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox4.Text + "'", comboBox4.Text, 5, 8, 3);
                    }
                    
                }
                else if (checkBox3.Checked && checkBox2.Checked == false && checkBox1.Checked == false)
                {
                    if (comboBox4.Text == @"drenthe" || comboBox4.Text == @"noord-Brabant" ||
                        comboBox4.Text == @"noord-Holland" ||
                        comboBox4.Text == @"gelderland" || comboBox4.Text == @"friesland" ||
                        comboBox4.Text == @"zuid-Holland" ||
                        comboBox4.Text == @"overijssel" || comboBox4.Text == @"flevoland" ||
                        comboBox4.Text == @"groningen" || comboBox4.Text == @"zeeland" ||
                        comboBox4.Text == @"limburg" || comboBox4.Text == @"utrecht")
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven) from Letsel where Provincie = '" + comboBox4.Text + "'", comboBox4.Text, 1, 8, 3);
                    }
                    else
                    {
                        Fillchart("select sum(HIC_geweldsmisdrijven) from Letsel where Gemeente = '" + comboBox4.Text + "'", comboBox4.Text, 1, 8, 3);
                    }
                    
                }
                else if (checkBox2.Checked && checkBox3.Checked == false && checkBox1.Checked == false)
                {
                    if (comboBox4.Text == @"drenthe" || comboBox4.Text == @"noord-Brabant" ||
                        comboBox4.Text == @"noord-Holland" ||
                        comboBox4.Text == @"gelderland" || comboBox4.Text == @"friesland" ||
                        comboBox4.Text == @"zuid-Holland" ||
                        comboBox4.Text == @"overijssel" || comboBox4.Text == @"flevoland" ||
                        comboBox4.Text == @"groningen" || comboBox4.Text == @"zeeland" ||
                        comboBox4.Text == @"limburg" || comboBox4.Text == @"utrecht")
                    {
                        Fillchart("select sum(Mishandeling) from Letsel where Provincie = '" + comboBox4.Text + "'", comboBox4.Text, 6, 8, 3);
                    }
                    else
                    {
                        Fillchart("select sum(Mishandeling) from Letsel where Gemeente = '" + comboBox4.Text + "'", comboBox4.Text, 6, 8, 3);
                    }
                    
                }
                else if (checkBox1.Checked && checkBox3.Checked == false && checkBox2.Checked == false)
                {
                    if (comboBox4.Text == @"drenthe" || comboBox4.Text == @"noord-Brabant" ||
                        comboBox4.Text == @"noord-Holland" ||
                        comboBox4.Text == @"gelderland" || comboBox4.Text == @"friesland" ||
                        comboBox4.Text == @"zuid-Holland" ||
                        comboBox4.Text == @"overijssel" || comboBox4.Text == @"flevoland" ||
                        comboBox4.Text == @"groningen" || comboBox4.Text == @"zeeland" ||
                        comboBox4.Text == @"limburg" || comboBox4.Text == @"utrecht")
                    {
                        Fillchart("select sum(Openlijk_Geweld) from Letsel where Provincie = '" + comboBox4.Text + "'", comboBox4.Text, 7, 8, 3);
                    }
                    else
                    {
                        Fillchart("select sum(Openlijk_Geweld) from Letsel where Gemeente = '" + comboBox4.Text + "'", comboBox4.Text, 7, 8, 3);
                    }
                    
                }
                else if (checkBox1.Checked == false && checkBox3.Checked == false && checkBox2.Checked == false)
                {
                    dataChart.Series.Clear();
                }
            }
            else if (comboBox4.SelectedIndex == 0 && selectGemeenteComboBox.Text != comboBox4.Text)
            {
                for (int a = 0; a <= _result.Columns.Count - 1; a++)
                {
                    if (_result.Columns[a].ColumnName == "Column11111" || _result.Columns[a].ColumnName == "Column21111" || _result.Columns[a].ColumnName == "Column31111")
                    {
                        _result.Columns.Remove(_result.Columns[a]);
                        a = a - 1;
                    }
                }
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                Fillchart(_oldquery[3], comboBox1.Text, Convert.ToInt16(_oldquery[4]), Convert.ToInt16(_oldquery[5]), 1);
                Fillchart(_oldquery[6], comboBox3.Text, Convert.ToInt16(_oldquery[7]), Convert.ToInt16(_oldquery[8]), 2);
                Fillchart("select sum(HIC_geweldsmisdrijven), sum(Mishandeling), sum(Openlijk_Geweld) from Letsel", comboBox4.Text, 3, 8, 3);
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
            if (comboBox1.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 &&
                selectGemeenteComboBox.Text != comboBox1.Text && selectGemeenteComboBox.Text != comboBox3.Text &&
                selectGemeenteComboBox.Text != comboBox4.Text && comboBox1.Text != comboBox3.Text &&
                comboBox1.Text != comboBox4.Text && comboBox3.Text != comboBox4.Text)
            {
                Check2();
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex == -1 &&
                     selectGemeenteComboBox.Text != comboBox1.Text && selectGemeenteComboBox.Text != comboBox3.Text &&
                     comboBox1.Text != comboBox3.Text)
            {
                Check2();
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox3.SelectedIndex == -1 && comboBox4.SelectedIndex == -1 &&
                     selectGemeenteComboBox.Text != comboBox1.Text)
            {
                Check2();
            }
            else if (comboBox1.SelectedIndex == -1 && comboBox3.SelectedIndex == -1 && comboBox4.SelectedIndex == -1)
            {
                Check2();
            }
            else
            {
                MessageBox.Show(@"Je kan niet twee dezelfde gemeenten of provincies met elkaar vergelijken.");
                comboBox1.SelectedIndex = _selectindex[1];
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
                comboBox1.SelectedIndex = -1;
                button2.Visible = false;
                comboBox3.Visible = false;
                comboBox3.SelectedIndex = -1;
                button3.Visible = false;
                comboBox4.Visible = false;
                comboBox4.SelectedIndex = -1;
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
                button3.Visible = true;
            }
            else
            {
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                Fillchart(_oldquery[3], comboBox1.Text, Convert.ToInt16(_oldquery[4]), Convert.ToInt16(_oldquery[5]), 1);
                comboBox3.Visible = false;
                comboBox3.SelectedIndex = -1;
                button3.Visible = false;
                comboBox4.Visible = false;
                comboBox4.SelectedIndex = -1;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 &&
                selectGemeenteComboBox.Text != comboBox1.Text && selectGemeenteComboBox.Text != comboBox3.Text &&
                selectGemeenteComboBox.Text != comboBox4.Text && comboBox1.Text != comboBox3.Text &&
                comboBox1.Text != comboBox4.Text && comboBox3.Text != comboBox4.Text)
            {
                Check3();
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex == -1 &&
                     selectGemeenteComboBox.Text != comboBox1.Text && selectGemeenteComboBox.Text != comboBox3.Text &&
                     comboBox1.Text != comboBox3.Text)
            {
                Check3();
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox3.SelectedIndex == -1 && comboBox4.SelectedIndex == -1 &&
                     selectGemeenteComboBox.Text != comboBox1.Text)
            {
                Check3();
            }
            else if (comboBox1.SelectedIndex == -1 && comboBox3.SelectedIndex == -1 && comboBox4.SelectedIndex == -1)
            {
                Check3();
            }
            else
            {
                MessageBox.Show(@"Je kan niet twee dezelfde gemeenten of provincies met elkaar vergelijken.");
                comboBox3.SelectedIndex = _selectindex[2];
            }
        }

        private void Letsel_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_check3)
            {
                _check3 = false;
            }
            else
            {
                _check3 = true;
            }

            if (_check3)
            {
                comboBox4.Visible = true;
            }
            else
            {
                Fillchart(_oldquery[0], selectGemeenteComboBox.Text, Convert.ToInt16(_oldquery[1]), Convert.ToInt16(_oldquery[2]), 0);
                Fillchart(_oldquery[3], comboBox1.Text, Convert.ToInt16(_oldquery[4]), Convert.ToInt16(_oldquery[5]), 1);
                Fillchart(_oldquery[6], comboBox3.Text, Convert.ToInt16(_oldquery[7]), Convert.ToInt16(_oldquery[8]), 2);
                comboBox4.Visible = false;
                comboBox4.SelectedIndex = -1;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 &&
                selectGemeenteComboBox.Text != comboBox1.Text && selectGemeenteComboBox.Text != comboBox3.Text &&
                selectGemeenteComboBox.Text != comboBox4.Text && comboBox1.Text != comboBox3.Text &&
                comboBox1.Text != comboBox4.Text && comboBox3.Text != comboBox4.Text)
            {
                Check4();
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex == -1 &&
                     selectGemeenteComboBox.Text != comboBox1.Text && selectGemeenteComboBox.Text != comboBox3.Text &&
                     comboBox1.Text != comboBox3.Text)
            {
                Check4();
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox3.SelectedIndex == -1 && comboBox4.SelectedIndex == -1 &&
                     selectGemeenteComboBox.Text != comboBox1.Text)
            {
                Check4();
            }
            else if (comboBox1.SelectedIndex == -1 && comboBox3.SelectedIndex == -1 && comboBox4.SelectedIndex == -1)
            {
                Check4();
            }
            else
            {
                MessageBox.Show(@"Je kan niet twee dezelfde gemeenten of provincies met elkaar vergelijken.");
                comboBox4.SelectedIndex = _selectindex[3];
            }
        }
    }
}
