using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].Name = ("Sinyal 1");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 5;
            chart1.Series[0].Color = Color.Gray;
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;

            chart1.Series.Add("Sinyal 2");
            chart1.Series["Sinyal 2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Sinyal 2"].BorderWidth = 5;
            chart1.Series["Sinyal 2"].Color = Color.Green;
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;

            chart1.Series.Add("Sinyal 3");
            chart1.Series["Sinyal 3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Sinyal 3"].BorderWidth = 5;
            chart1.Series["Sinyal 3"].Color = Color.Blue;
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled);
            if (timer1.Enabled == true)
                btnStart.Text = ("STOP");
            else
                btnStart.Text = ("START");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double numericUD1 = Convert.ToDouble(numericUpDown1.Value);
            double numericUD2 = Convert.ToDouble(numericUpDown2.Value);
            double numericUD3 = Convert.ToDouble(numericUpDown3.Value);
            double numericUD4 = Convert.ToDouble(numericUpDown4.Value);
            double numericUD5 = Convert.ToDouble(numericUpDown5.Value);
            double numericUD6 = Convert.ToDouble(numericUpDown6.Value);
            double numericUD7 = Convert.ToDouble(numericUpDown7.Value);

            double y0 = numericUD2 * Math.Sin(2 * Math.PI * numericUD3 * time);
            double y1 = numericUD4 * Math.Sin(2 * Math.PI * numericUD5 * time);
            double y2 = numericUD6 * Math.Sin(2 * Math.PI * numericUD7 * time);

            if (chart1.Series[0].Points.Count > 60)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Series["Sinyal 2"].Points.RemoveAt(0);
                chart1.Series["Sinyal 3"].Points.RemoveAt(0);
            }

            chart1.Series[0].Points.AddY(y0);
            chart1.Series["Sinyal 2"].Points.AddY(y1);
            chart1.Series["Sinyal 3"].Points.AddY(y2);

            time += (numericUD1 * 0.001);
        }
        private double time = 0.0;

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
