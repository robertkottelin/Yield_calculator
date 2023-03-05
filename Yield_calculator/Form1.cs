using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Yield_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double investment = Double.Parse(textBox1.Text);
            double years = Double.Parse(textBox3.Text);
            double yieldPercent = Double.Parse(textBox2.Text);
            double yield = yieldPercent / 100.0 + 1.0;

            Series series = chart1.Series.FirstOrDefault(s => s.Name == "Yield");
            if (series == null)
            {
                series = chart1.Series.Add("Yield");
                series.ChartType = SeriesChartType.Line;
                chart1.Series.Remove(chart1.Series["Series1"]);
            }
            else
            {
                series.Points.Clear();
            }

            double currentInvestment = investment;

            for (int i = 1; i <= years; i++)
            {
                currentInvestment *= yield;
                series.Points.AddXY(i, currentInvestment);
            }

            chart1.ChartAreas[0].AxisX.Interval = 1;
        }

    }
}
