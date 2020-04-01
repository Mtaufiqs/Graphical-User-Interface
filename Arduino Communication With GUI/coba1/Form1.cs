using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace coba1
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;

        public Form1()
        {
            InitializeComponent();
            disableControls();
            getAvailablePorts();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!isConnected)
            {
                connectArduino();
            }
            else
            {
                disconnectArduino();
            }
        }

        void getAvailablePorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectArduino()
        {
            try
            {
                isConnected = true;
                string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
                port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                port.Open();
                port.Write("#Start\n");
                button2.Text = ("Disconnect");
                enableControls();
            }
            catch(Exception)
            {
                Form1.ActiveForm.Text = Form1.ActiveForm.Text + (" (Wrong Selected Port!)");
            }
        }

        private void enableControls()
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            button1.Enabled = true;
            textBox1.Enabled = true;
            groupBox1.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBox1.Checked)
                {
                    port.Write("#LED1ON\n");
                }
                else
                {
                    port.Write("#LED1OFF\n");
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBox2.Checked)
                {
                    port.Write("#LED2ON\n");
                }
                else
                {
                    port.Write("#LED2OFF\n");
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBox3.Checked)
                {
                    port.Write("#LED3ON\n");
                }
                else
                {
                    port.Write("#LED3OFF\n");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#Text" + textBox1.Text + "#\n");
            }
        }

        private void disconnectArduino()
        {
            isConnected = false;
            port.Write("#Stop\n");
            port.Close();
            button2.Text = ("Connect");
            disableControls();
        }

        private void disableControls()
        {
            textBox1.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            button1.Enabled = false;
            textBox1.Enabled = false;
            groupBox1.Enabled = false;
            groupBox3.Enabled = false;
        }    
    }
}
