using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;


namespace Serial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();

        }
        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "" || comboBox2.Text == "")
                {
                    textBox2.Text = "Please select port setting";
                }
                else
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    button1.Enabled = true;
                    button3.Enabled = false;
                    textBox1.Enabled = true;
                    button2.Enabled = true;
                    button4.Enabled = true;

                }
            }
            catch (UnauthorizedAccessException)
            {
                textBox2.Text = "UNauthorized Access";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0;
            button1.Enabled = false;
            button2.Enabled = false;
            textBox1.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            serialPort1.WriteLine(textBox1.Text);
            textBox1.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = serialPort1.ReadLine();

            }
            catch (TimeoutException)
            {
                textBox2.Text = "Timeout Exception";
            }
        }
    }
}
