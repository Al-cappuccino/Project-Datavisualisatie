using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace WindowsFormsApp1
{
    public partial class Main_Form : Form
    {
        DataSet fug;
        OdbcConnection con;
        OdbcDataAdapter adapter;
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            fug = new DataSet();
            con = new OdbcConnection();
            con.ConnectionString = "Driver={Microsoft Excel Driver (*.xls)};DBQ=Misdrijven fysiek letsel.xls";
            con.Open();
            adapter = new OdbcDataAdapter("select * FROM [Misdrijven$]", con);
            adapter.Fill(fug);
            con.Close();
            dataGridView1.DataSource = fug.Tables[0];
            adapter = new OdbcDataAdapter("select Soort, aantal FROM [Misdrijven$]", con);
            chart1.DataSource = fug.Tables[0];        }
    }
}
