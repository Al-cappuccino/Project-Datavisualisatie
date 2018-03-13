namespace WindowsFormsApp1
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.database1Diefstal = new WindowsFormsApp1.Database1Diefstal();
            this.diefstalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diefstalTableAdapter = new WindowsFormsApp1.Database1DiefstalTableAdapters.DiefstalTableAdapter();
            this.diefstalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1Diefstal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diefstalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diefstalBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(218, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.diefstalBindingSource1;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(674, 169);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Gemeente";
            series1.YValueMembers = "TotaalDiefstal";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Diefstal";
            title1.Name = "Diefstal";
            title1.Text = "Diefstal";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // database1Diefstal
            // 
            this.database1Diefstal.DataSetName = "Database1Diefstal";
            this.database1Diefstal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diefstalBindingSource
            // 
            this.diefstalBindingSource.DataMember = "Diefstal";
            this.diefstalBindingSource.DataSource = this.database1Diefstal;
            // 
            // diefstalTableAdapter
            // 
            this.diefstalTableAdapter.ClearBeforeFill = true;
            // 
            // diefstalBindingSource1
            // 
            this.diefstalBindingSource1.DataMember = "Diefstal";
            this.diefstalBindingSource1.DataSource = this.database1Diefstal;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 481);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1Diefstal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diefstalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diefstalBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Database1Diefstal database1Diefstal;
        private System.Windows.Forms.BindingSource diefstalBindingSource;
        private Database1DiefstalTableAdapters.DiefstalTableAdapter diefstalTableAdapter;
        private System.Windows.Forms.BindingSource diefstalBindingSource1;
    }
}