using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace pendahuluan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.DrawItem += new DrawItemEventHandler(listBox1_SetColor);
        }

        public class MyListBoxItem
        {
            public MyListBoxItem(Color c, string m)
            {
                ItemColor = c;
                Message = m;
            }
            public Color ItemColor { get; set; }
            public string Message { get; set; }
        }

        private void listBox1_SetColor(object sender, DrawItemEventArgs e)
        {
            try
            {
                MyListBoxItem item = listBox1.Items[e.Index] as MyListBoxItem;
                if(item != null)
                {
                    e.Graphics.DrawString(item.Message, listBox1.Font, new SolidBrush(item.ItemColor), 0, e.Index * listBox1.ItemHeight);
                }
                else
                {
                    Form1.ActiveForm.Text = ("kok gini");
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();
                Form1.ActiveForm.Text = serialPort1.PortName + (" (is Connected)");
            }
            catch (Exception)
            {
                if (serialPort1.IsOpen)
                    Form1.ActiveForm.Text = serialPort1.PortName + (" (Sudah Konek Oy)");
                else
                    Form1.ActiveForm.Text = Form1.ActiveForm.Text + " (KOSONG?!! Serial Port-nya Jangan Kosong Bro)";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Form1.ActiveForm.Text = ("Serial Communication");
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(textBox1.Text);
                listBox1.Items.Add(new MyListBoxItem(Color.Gray, textBox1.Text));
                textBox1.Clear();         
                
            }
            catch(Exception)
            {
                Form1.ActiveForm.Text = Form1.ActiveForm.Text;
            }
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
                listBox1.Items.Add(new MyListBoxItem(Color.DarkGray, Convert.ToString(item)));                
            }
        }
    }
}
