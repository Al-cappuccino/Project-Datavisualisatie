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


        public Main()
        {   
            InitializeComponent();

        }


        private void gemeenteInputTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LetselButton_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(letsel.Instance))
            {
                mainPanel.Controls.Add(letsel.Instance);
                mainPanel.Controls.Remove(Diefstal.Instance);
                letsel.Instance.Dock = DockStyle.Fill;
                letsel.Instance.BringToFront();


            }
            chart1.Visible = true;
            chart2.Visible = true;
            chart3.Visible = true;
            chart4.Visible = true;
            chart5.Visible = true;
            pictureBox1.Visible = false;
        }


        private void DiefstalButton_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(Diefstal.Instance))
            {
                mainPanel.Controls.Add(Diefstal.Instance);
                mainPanel.Controls.Remove(letsel.Instance);
                Diefstal.Instance.Dock = DockStyle.Fill;
                Diefstal.Instance.BringToFront();
            }
            else
                Diefstal.Instance.BringToFront();


        }

        private void Kaart_click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.Contains(Diefstal.Instance))
            {
                mainPanel.Controls.Remove(Diefstal.Instance);
            }
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            chart5.Visible = false;
            pictureBox1.Visible = true;
        }
    }
}
