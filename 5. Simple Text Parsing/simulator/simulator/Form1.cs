using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] portList = System.IO.Ports.SerialPort.GetPortNames();
            foreach (String portName in portList)
                comboBox1.Items.Add(portName);

            comboBox1.Text = comboBox1.Items[comboBox1.Items.Count - 1].ToString();

            String[] baudrate = {"9600", "14400", "19200", "38400", "56000", "57600", "76800", "115200"};
            foreach (String baudrates in baudrate)
                comboBox2.Items.Add(baudrates);

            String[] newlines = { "<CR><LF>", "<CR>", "<LF>"};
            foreach (String newline in newlines)
                comboBox3.Items.Add(newline);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Int32.Parse(comboBox2.Text);
                serialPort1.Open();
                toolStripStatusLabel1.Text = serialPort1.PortName + (" is connected.");

                if (comboBox3.Text == ("<CR><LF>"))
                {
                    serialPort1.NewLine = ("\r\n");
                }
                else if(comboBox3.Text == ("<CR>"))
                {
                    serialPort1.NewLine = ("\r");
                }
                else
                {
                    serialPort1.NewLine = ("\n");
                }
            }
            catch(Exception ex)
            {
                toolStripStatusLabel1.Text = ("ERROR: ") + ex.Message.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            toolStripStatusLabel1.Text = serialPort1.PortName + (" is closed.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("AA");
            }
            catch(Exception ex)
            {
                toolStripStatusLabel1.Text = ("ERROR: ") + ex.Message.ToString(); 
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                String receiveMsg = serialPort1.ReadLine();
                Tampilkan(receiveMsg);
            }
            catch { }
        }

        private delegate void TampilkanDelegate(object item);

        private void Tampilkan(object item)
        {
            if (InvokeRequired)
                listBox1.Invoke(new TampilkanDelegate(Tampilkan), item);
            else
            {
                listBox1.Items.Add(item);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                splitData(item);
            }
        }

        private void splitData(object item)
        {
            String[] data = item.ToString().Split(',', ';', ':');
            textBox1.Text = data[1];
            textBox2.Text = data[2];
            textBox3.Text = data[3];
            textBox4.Text = data[4];
        }

    }
}