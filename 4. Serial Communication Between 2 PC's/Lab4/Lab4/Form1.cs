using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        bool on = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (on)
                {
                    button1.Text = ("ON");
                    serialPort1.Write("Lampu ON");
                    on = false;
                }
                else
                {
                    button1.Text = ("OFF");
                    serialPort1.Write("Lampu OFF");
                    on = true;
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (on)
                {
                    button2.Text = ("ON");
                    serialPort1.Write("Kipas ON");
                    on = false;
                }
                else
                {
                    button2.Text = ("OFF");
                    serialPort1.Write("Kipas OFF");
                    on = true;
                }
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (on)
                {
                    button3.Text = ("ON");
                    serialPort1.Write("AC ON");
                    on = false;
                }
                else
                {
                    button3.Text = ("OFF");
                    serialPort1.Write("AC OFF");
                    on = true;
                }
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (on)
                {
                    button4.Text = ("ON");
                    serialPort1.Write("CCTV ON");
                    on = false;
                }
                else
                {
                    button4.Text = ("OFF");
                    serialPort1.Write("CCTV OFF");
                    on = true;
                }
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (on)
                {
                    button5.Text = ("ON");
                    serialPort1.Write("TV ON");
                    on = false;
                }
                else
                {
                    button5.Text = ("OFF");
                    serialPort1.Write("TV OFF");
                    on = true;
                }
            }
            catch { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (button7.Text == ("Connect"))
                {
                    button7.Text = ("Connected");
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.Open();
                    Form1.ActiveForm.Text = serialPort1.PortName;
                }
                else
                {
                    button7.Text = ("Connect");
                    serialPort1.Close();
                    Form1.ActiveForm.Text = ("Not Connect");
                }
            }
            catch
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] portlist = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string portName in portlist)
                comboBox1.Items.Add(portName);
        }
    }
}