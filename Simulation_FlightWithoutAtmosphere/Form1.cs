using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_FlightWithoutAtmosphere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isStarted = false;

        const double dt = 0.01;
        const double g = 9.81;

        double alpha;
        double v0;
        double y0;

        double t;
        double x;
        double y;
        private void btStart_Click(object sender, EventArgs e)
        {
            if (isStarted)
            {
                timer1.Start();
                return;
            }

            alpha = (double)edAngle.Value;
            v0 = (double)edSpeed.Value;
            y0 = (double)edHeight.Value;

            t = 0;
            x = 0;
            y = y0;

            double maxX = (int)(v0 * v0 * Math.Sin(alpha * Math.PI / 90) / g + 1.0);
            double maxY = (int)(y0 + v0 * v0 * Math.Pow(Math.Sin(alpha * Math.PI / 180), 2) / (2 * g) + 1.0);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            
            chartArea.AxisX.Minimum = 0D;
            chartArea.AxisX.Maximum = maxX;
            chartArea.AxisY.Minimum = 0D;
            chartArea.AxisY.Maximum = maxY;
            chartArea.Name = "ChartArea1";

            this.chart1.ChartAreas.Clear();
            this.chart1.ChartAreas.Add(chartArea);

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(x, y);

            isStarted = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            labTime.Text = $"Time: {Math.Round(t, 2)} s";
            x = v0 * Math.Cos(alpha * Math.PI / 180) * t;
            y = y0 + v0 * Math.Sin(alpha * Math.PI / 180) * t - g * t * t / 2;
            chart1.Series[0].Points.AddXY(x, y);
            if (y <= 0)
            {
                timer1.Stop();
                isStarted = false;
            }
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
        }
    }
}
