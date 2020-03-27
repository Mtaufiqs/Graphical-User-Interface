//Library yang akan digunakan
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.00"; //Untuk mengatur format dari nilai di X-axis
            chart1.ChartAreas[0].AxisX.Title = ("Time (s)"); //Memberikan title pada X-axis
            chart1.ChartAreas[0].AxisY.Title = ("Amplitudo (V)"); //Memberikan title pada Y-Axis
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line; //Memberikan tipe/tampilan dari Chart
            chart1.Series[0].BorderWidth = 5; //Mengatur ketebalan border/ garis grafik
            chart1.Series[0].Color = Color.Gray; //memberikan warna garis grafik
            chart1.ChartAreas[0].AxisY.Minimum = -60; //menentukan batas minimum grafik pada Y-axis
            chart1.ChartAreas[0].AxisY.Maximum = 60; //menentukan batas maximum grafik pada Y-axis

            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "0.00"; //Untuk mengatur format dari nilai di X-axis
            chart2.ChartAreas[0].AxisX.Title = ("Time (s)"); //Memberikan title pada X-axis
            chart2.ChartAreas[0].AxisY.Title = ("Amplitudo (V)"); //Memberikan title pada Y-Axis
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line; //Memberikan tipe/tampilan dari Chart
            chart2.Series[0].BorderWidth = 5; //Mengatur ketebalan border/ garis grafik
            chart2.Series[0].Color = Color.Orange; //memberikan warna garis grafik
            chart2.ChartAreas[0].AxisY.Minimum = -60; //menentukan batas minimum grafik pada Y-axis
            chart2.ChartAreas[0].AxisY.Maximum = 60; //menentukan batas maximum grafik pada Y-axis
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled); //Mengubah nilai boolean timer1 dari nilai sebelumnya
                        
            if (timer1.Enabled == true)
            {
                timer2.Enabled = false; //Mengubah nilai timer2 menjadi 'false'
                textBoxStatus.Visible = true; //Memunculkan tampilan/tulisan pada textBoxStatus
                button1.Text = "STOP"; //Mengubah teks pada button1
                textBoxStatus.Text = "RUN"; //mengubah teks pada textBoxStatus
                textBoxStatus.ForeColor = Color.Lime; //memberikan warna text pada textBoxStatus
            }
            else
            {
                timer2.Enabled = true; //Mengubah nilai timer2 menjadi 'true'
                button1.Text = "START"; //Mengubah teks pada button1
                textBoxStatus.Text = "STOP"; //mengubah teks pada textBoxStatus
                textBoxStatus.ForeColor = Color.Red; //memberikan warna text pada textBoxStatus
            }
        }
        private double amplitude1 = 50.0; //menentukan nilai awal amplitude1
        private double frequency1 = 2.0; //menentukan nilai awal frequency1
        private double amplitude2 = 50.0; //menentukan nilai awal amplitude2
        private double frequency2 = 2.0; //menentukan nilai awal amplitude2
        private double time1 = 0.0; //menentukan nilai awal time1
        private double time2 = 0.0; //menentukan nilai awal time2

        private void timer1_Tick(object sender, EventArgs e)
        {
            double y1 = amplitude1 * Math.Sin(2 * Math.PI * frequency1 * time1); //rumus sinus y1
            double y2 = amplitude2 * Math.Sin(2 * Math.PI * frequency2 * time2); //rumus sinus y2

            chart1.Series[0].Points.AddXY(time1, y1); //menambahkan nilai di X-axis dan Y-axis pada chart1
            chart2.Series[0].Points.AddXY(time2, y2); //menambahkan nilai di X-axis dan Y-axis pada chart2
            time1 += 0.01; //menambahkan nilai time1 sebanyak 0.01 setiap tick time berjalan
            time2 += 0.02; //menambahkan nilai time2 sebanyak 0.01 setiap tick time berjalan

            textBoxTime1.Text = time1.ToString("00.00"); //untuk menampilkan data time1 pada textBoxTime1 sekaligus dengan formatnya
            textBoxAmp1.Text = y1.ToString("00.00"); //untuk menampilkan data y1 pada textBoxAmp1 sekaligus dengan formatnya
            textBoxTime2.Text = time2.ToString("00.00"); //untuk menampilkan data time2 pada textBoxTime2 sekaligus dengan formatnya
            textBoxAmp2.Text = y2.ToString("00.00"); //untuk menampilkan data y2 pada textBoxAmp2 sekaligus dengan formatnya



            if (chart1.Series[0].Points.Count > 100)
            {
                chart1.ChartAreas[0].AxisX.Minimum = time1 - (0.01 * 100); //memberikan nilai range minimum pada X-Axis chart1
                chart1.ChartAreas[0].AxisX.Maximum = time1; //memberikan nilai range maximum pada X-Axis chart1
                chart2.ChartAreas[0].AxisX.Minimum = time2 - (0.02 * 100); //memberikan nilai range maximum pada X-Axis chart2
                chart2.ChartAreas[0].AxisX.Maximum = time2; //memberikan nilai range maximum pada X-Axis chart2
            }
        }


        // PROSES BLINK

        int blink = 3; //menginisialisasi variabel blink
        int start = 0; //menginisialisasi variabel start
        private void timer2_Tick(object sender, EventArgs e)
        {
            textBoxStatus.Visible = true; //Memunculkan tampilan/tulisan pada textBoxStatus
            start++; //menambahkan nilai start setiap tick time berjalan
            if (start == blink) //pengkondisian jika start dan blink mempunyai nilai yang sama
            {
                textBoxStatus.Visible = false; //menghilangkan tampilan/tulisan pada textBoxStatus
                start = 0; //mengubah nilai start menjadi '0'
            }
        }
    }
}
