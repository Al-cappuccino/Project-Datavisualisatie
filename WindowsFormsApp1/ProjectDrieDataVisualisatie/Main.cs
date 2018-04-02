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
            mainpanelTop.Visible = false;
            if (!mainPanel.Controls.Contains(Letsel.Instance))
            {
                mainPanel.Controls.Add(Letsel.Instance);
                mainPanel.Controls.Remove(Diefstal.Instance);
                Letsel.Instance.Dock = DockStyle.Fill;
                Letsel.Instance.BringToFront();
                ActivePanel1.Visible = false;
                ActivePanel2.Visible = true;
                ActivePanel3.Visible = false;                
            }

        }


        private void DiefstalButton_Click(object sender, EventArgs e)
        {
            mainpanelTop.Visible = false;
            if (!mainPanel.Controls.Contains(Diefstal.Instance))
            {
                mainPanel.Controls.Add(Diefstal.Instance);
                mainPanel.Controls.Remove(Letsel.Instance);
                Diefstal.Instance.Dock = DockStyle.Fill;
                Diefstal.Instance.BringToFront();
            }
            else
                Diefstal.Instance.BringToFront();
            ActivePanel1.Visible = false;
            ActivePanel2.Visible = false;
            ActivePanel3.Visible = true;
        }

        private void Kaart_click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.Contains(Diefstal.Instance))
            {
                mainPanel.Controls.Remove(Diefstal.Instance);
            }

        }


        private void homeButton_Click(object sender, EventArgs e)
        {
            mainpanelTop.Visible = true;
            if (mainPanel.Controls.Contains(Diefstal.Instance))
            {
                mainPanel.Controls.Remove(Diefstal.Instance);
            }

            if (mainPanel.Controls.Contains(Letsel.Instance))
            {
                mainPanel.Controls.Remove(Letsel.Instance);
            }
            ActivePanel1.Visible = true;
            ActivePanel2.Visible = false;
            ActivePanel3.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
