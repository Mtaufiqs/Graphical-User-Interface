using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace receiver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.PortName = ("COM18");
            serialPort1.Open();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Tampilkan(serialPort1.ReadExisting());
        }

        private delegate void TampilkanDelegate(object item);
        
        
        private void Tampilkan(object item)
        {
            if(InvokeRequired)
            {
                button1.Invoke(new TampilkanDelegate(Tampilkan), item);
            }
            else
            {
                string buttons;
                buttons = (Convert.ToString(item));

                if (buttons == ("Lampu ON"))
                {
                    
                    button1.Text = ("Lampu ON");
                    button1.BackColor = Color.Green;
                }
                else if(buttons == ("Lampu OFF"))
                {
                    button1.Text = ("Lampu OFF");
                    button1.BackColor = Color.Red;
                }

                else if (buttons == ("Kipas ON"))
                {
                    button2.Text = ("Kipas ON");
                    button2.BackColor = Color.Green;
                }
                else if (buttons == ("Kipas OFF"))
                {
                    button2.Text = ("Kipas OFF");
                    button2.BackColor = Color.Red;
                }

                else if (buttons == ("AC ON"))
                {
                    button3.Text = ("AC ON");
                    button3.BackColor = Color.Green;
                }
                else if (buttons == ("AC OFF"))
                {
                    button3.Text = ("AC OFF");
                    button3.BackColor = Color.Red;
                }

                else if (buttons == ("CCTV ON"))
                {
                    button4.Text = ("CCTV ON");
                    button4.BackColor = Color.Green;
                }
                else if (buttons == ("CCTV OFF"))
                {
                    button4.Text = ("CCTV OFF");
                    button4.BackColor = Color.Red;
                }

                else if (buttons == ("TV ON"))
                {
                    button5.Text = ("TV ON");
                    button5.BackColor = Color.Green;
                }
                else
                {
                    button5.Text = ("TV OFF");
                    button5.BackColor = Color.Red;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] portlist = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string portName in portlist)
                comboBox1.Items.Add(portName);
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
                    Form1.ActiveForm.Text = Form1.ActiveForm.Text;
                }
            }
            catch
            {
            }
        }
    }
}