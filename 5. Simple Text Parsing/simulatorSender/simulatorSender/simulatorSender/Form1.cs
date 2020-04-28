using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulatorSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] portlist = System.IO.Ports.SerialPort.GetPortNames();
            foreach (String portName in portlist)
                comboBox1.Items.Add(portName);

            string[] baudrate = { "9600", "14400", "19200", "38400", "56000", "57600", "76800", "115200" };
            foreach (String baudrates in baudrate)
                comboBox2.Items.Add(baudrates);

            Char[] separators = { ',', ';', ':' };
            foreach (Char separator in separators)
                comboBox3.Items.Add(separator);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Int32.Parse(comboBox2.Text);
                serialPort1.NewLine = ("\r\n");
                serialPort1.Open();
                toolStripStatusLabel1.Text = serialPort1.PortName + (" is connected.");

                Random rnd = new Random();
                int suhu = rnd.Next(20, 33);
                int kelembaban = rnd.Next(40, 90);
                int tekanan = rnd.Next(200, 1000);
                int uvindex = rnd.Next(0, 6);

                textBox3.Text = suhu.ToString();
                textBox4.Text = kelembaban.ToString();
                textBox5.Text = tekanan.ToString();
                textBox6.Text = uvindex.ToString();

                while (true)
                {
                    serialPort1.WriteLine(textBox1.Text + textBox3.Text + ',' + textBox4.Text + ',' + textBox5.Text + ',' + textBox6.Text + textBox2.Text + ("\r\n"));
                    listBox1.Text = (textBox1.Text + textBox3.Text + ',' + textBox4.Text + ',' + textBox5.Text + ',' + textBox6.Text + textBox2.Text);
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ("ERROR: ") + ex.Message.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            toolStripStatusLabel1.Text = serialPort1.PortName + (" is closed.");
        }
    }
}
