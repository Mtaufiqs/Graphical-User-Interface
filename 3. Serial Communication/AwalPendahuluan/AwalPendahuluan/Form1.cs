using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwalPendahuluan
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.Open();
            Form1.ActiveForm.Text = serialPort1.PortName + (" (is Connected)");
        }   

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Form1.ActiveForm.Text = ("Serial Communication");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox1.Text);
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Tampilkan(serialPort1.ReadExisting());
        }

        private delegate void TampilkanDelegate(object item);

        private void Tampilkan(object item)
        {
            if (InvokeRequired)
            {
                // This is a worker thread so delegate the task
                listBox1.Invoke(new TampilkanDelegate(Tampilkan), item);
            }
            else
            {
                // This is the UI thread so perform the task
                listBox1.Items.Add(item);
            }
        }
    }
}