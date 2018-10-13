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

namespace CubingStats
{
    public partial class LineChartForm : Form
    {
        public List<double> Averages;

        public LineChartForm(List<double> averages, double lowerBound, double upperBound)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Averages = averages;
            Series series = new Series("Averages");
            series.ChartType = SeriesChartType.Line;
            for(int k = 0; k < Averages.Count; k++)
            {
                series.Points.Add(new DataPoint(k + 1, Averages[k]));
            }
            chart1.Series.Add(series);
            //var lowerBound = Math.Floor(averages.Min() * 0.9 * 10) / 10;
            chart1.ChartAreas[0].AxisY.Minimum = lowerBound;
            chart1.ChartAreas[0].AxisY.Maximum = upperBound;
            double diff = upperBound - lowerBound;
            double interval;
            if (diff < 0.8)
                interval = 0.1;
            else if (diff < 1.5)
                interval = 0.2;
            else if (diff < 4)
                interval = 0.5;
            else
                interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = interval;
            chart1.Legends.Clear();
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
