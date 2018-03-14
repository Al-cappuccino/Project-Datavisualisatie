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
            // TODO: This line of code loads data into the 'database1Diefstal.Diefstal' table. You can move, or remove it, as needed.
            this.diefstalTableAdapter.Fill(this.database1Diefstal.Diefstal);
            fug = new DataSet();
            con = new OdbcConnection();
            con.ConnectionString = "Driver={Microsoft Excel Driver (*.xls)};DBQ=Misdrijven fysiek letsel.xls";
            con.Open();
            adapter = new OdbcDataAdapter("select * FROM [Misdrijven$]", con);
            adapter.Fill(fug);
            con.Close();
            dataGridView1.DataSource = fug.Tables[0];
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AreaSearchbox_Enter(object sender, EventArgs e)
        {
            if (AreaSearchbox.Text == "Voer plaatsnaam in...")
                AreaSearchbox.Text = "";
            AreaSearchbox.ForeColor = Color.Black;
        }

        private void AreaSearchbox_Leave(object sender, EventArgs e)
        {
            AreaSearchbox.Text = "Voer plaatsnaam in...";
            AreaSearchbox.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivePanel.Height = LetselButton.Height;
            ActivePanel.Top = LetselButton.Top;
            LetselPanel.Visible = true;
            DiefstalPanel.Visible = false;
        }

        private void DiefstalButton_Click(object sender, EventArgs e)
        {
            ActivePanel.Height = DiefstalButton.Height;
            ActivePanel.Top = DiefstalButton.Top;
            DiefstalPanel.Visible = true;
            LetselPanel.Visible = false;
        }
    }
}
