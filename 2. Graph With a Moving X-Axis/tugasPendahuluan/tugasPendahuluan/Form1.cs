using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasPendahuluan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
            chart1.ChartAreas[0].AxisX.Title = ("Time (s)");
            chart1.ChartAreas[0].AxisY.Title = ("Amplitudo (V)");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 5;
            chart1.Series[0].Color = Color.Gray;
            chart1.ChartAreas[0].AxisY.Minimum = -60;
            chart1.ChartAreas[0].AxisY.Maximum = 60;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double y = amplitude * Math.Sin(2 * Math.PI * frequency * time);
            chart1.Series[0].Points.AddXY(time, y);
            time += 0.01;
            textBox1.Text = time.ToString("00.00");
            textBox2.Text = amplitude.ToString("00.00");
            
            if (chart1.Series[0].Points.Count > 40)
            {
                chart1.ChartAreas[0].AxisX.Minimum = time - (0.01 * 40);
                chart1.ChartAreas[0].AxisX.Maximum = time;
            }
        }
        private double amplitude = 50.0;
        private double frequency = 2.0;
        private double time = 0.0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled);
            if (timer1.Enabled == true)
            {
                button1.Text = "STOP";
                textBox3.Text = "RUN";
            }
            else
            {
                button1.Text = "START";
                textBox3.Text = "STOP";
            }  
        }
    }
}
