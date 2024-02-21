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

namespace Serial_CM
{
    public partial class Form1 : Form
    {
        string send_data;
        string receive_data;
        string receiveHex;
        string dataCR;
        string dataLF;
        string dataOut;
        string LED1="0";
        string LED2="0";
        string LED3="0";
        string LED4="0";
        string LED5 = "0";
        string LED6 = "0";
        string LED7 = "0";
        string LED8 = "0";
        public static byte[] FromHex(string hex)
        {
            hex = hex.Replace("-", "");
            byte[] raw = new byte[hex.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return raw;
        }
        public Form1()
        {
            InitializeComponent();
            string CR = "0D";
            string LF = "0A";
            byte[] data_CR = FromHex(CR);
            string stringdataCR = Encoding.ASCII.GetString(data_CR);
            dataCR = stringdataCR;
            byte[] data_LF = FromHex(LF);
            string stringdataLF = Encoding.ASCII.GetString(data_LF);
            dataLF = stringdataLF;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Lấy đầu vào các cổng com
            string[] ports = SerialPort.GetPortNames();
            CBxCOMPORT.Items.AddRange(ports);
            
        }

        private void BT_OPEN_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = CBxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(CBxBAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(CBxDATABITS.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CBxSTOPBITS.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CBxPARITYBITS.Text);
                BT_SEND.Enabled = true;

                serialPort1.Open();
                progressBar1.Value = 100;
            }

            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_CLOSE_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                BT_SEND.Enabled = false;
            }
        }

        private void BT_SEND_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                   
                send_data = Send_Data.Text;
                serialPort1.Write(send_data);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            receive_data = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            if(receiveHex == "hex")
            {
                byte[] bytes = Encoding.UTF8.GetBytes(receive_data);
                string receive_data_hex = BitConverter.ToString(bytes);
                receive_data_hex = receive_data_hex.Replace("-", "");
                receive_data_hex = receive_data_hex.Replace("00", "");
                receive_data = receive_data_hex;
            }    
            Data_Box.Text += receive_data;
        }

        private void clear_data_Click(object sender, EventArgs e)
        {
            if (Data_Box.Text != "")
            {
                Data_Box.Text = "";
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            buttonLedOn1.Enabled = true;
            buttonLedOff1.Enabled = true;
            buttonLedOn2.Enabled = true;
            buttonLedOff2.Enabled = true;
            buttonLedOn3.Enabled = true;
            buttonLedOff3.Enabled = true;
            buttonLedOn4.Enabled = true;
            buttonLedOff4.Enabled = true;
            buttonLedOn5.Enabled = true;
            buttonLedOff5.Enabled = true;
            buttonLedOn6.Enabled = true;
            buttonLedOff6.Enabled = true;
            buttonLedOn7.Enabled = true;
            buttonLedOff7.Enabled = true;
            buttonLedOn8.Enabled = true;
            buttonLedOff8.Enabled = true;
            Send_Data.Text = "";
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataCR);
                //serialPort1.Write(dataLF);
            }


        }
        private void buttonLedOn1_Click(object sender, EventArgs e)
        {
            buttonLedOff1.Enabled = false;
            LED1 = "0";
            dataOut= LED1+LED2+LED3+LED4+LED5 + LED6 + LED7+LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }

        private void buttonLedOff1_Click(object sender, EventArgs e)
        {
            buttonLedOn1.Enabled = false;
            LED1 = "1";
            dataOut =  LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7 + LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }

        private void buttonLedOn2_Click(object sender, EventArgs e)
        {
            buttonLedOff2.Enabled = false;
            LED2 = "0";
            dataOut = LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7 + LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }

        private void buttonLedOff2_Click(object sender, EventArgs e)
        {
            buttonLedOn2.Enabled = false;
            LED2 = "1";
            dataOut = LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7 + LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }

        private void buttonLedOn3_Click(object sender, EventArgs e)
        {
            buttonLedOff3.Enabled = false;
            LED3 = "0";
            dataOut = LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7 + LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }

        private void buttonLedOff3_Click(object sender, EventArgs e)
        {
            buttonLedOn3.Enabled = false;
            LED3 = "1";
            dataOut = LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7 + LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }

        private void buttonLedOn4_Click(object sender, EventArgs e)
        {
            buttonLedOff4.Enabled = false;
            LED4 = "0";
            dataOut = LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7 + LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }

        private void buttonLedOff4_Click(object sender, EventArgs e)
        {
            buttonLedOn4.Enabled = false;
            LED4 = "1";
            dataOut = LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7 + LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }

        private void buttonLedOn5_Click(object sender, EventArgs e)
        {
            buttonLedOff5.Enabled = false;
            LED5 = "0";
            dataOut = LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7 + LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }

        private void buttonLedOff5_Click(object sender, EventArgs e)
        {
            buttonLedOn5.Enabled = false;
            LED5 = "1";
            dataOut = LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7 + LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }

        private void buttonLedOn6_Click(object sender, EventArgs e)
        {
            buttonLedOff6.Enabled = false;
            LED6 = "0";
            dataOut = LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7 + LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }

        private void buttonLedOff6_Click(object sender, EventArgs e)
        {
            buttonLedOn6.Enabled = false;
            LED6 = "1";
            dataOut = LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7 + LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }

        private void buttonLedOn7_Click(object sender, EventArgs e)
        {
            buttonLedOff7.Enabled = false;
            LED7 = "0";
            dataOut = LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7 + LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }

        private void buttonLedOff7_Click(object sender, EventArgs e)
        {
            buttonLedOn7.Enabled = false;
            LED8 = "1";
            dataOut = LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7 + LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }

        private void buttonLedOn8_Click(object sender, EventArgs e)
        {
            buttonLedOff8.Enabled = false;
            LED8 = "0";
            dataOut = LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7 + LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }

        private void buttonLedOff8_Click(object sender, EventArgs e)
        {
            buttonLedOn8.Enabled = false;
            LED8 = "1";
            dataOut = LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7 + LED8;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(dataOut);
            }
        }
        
        private void buttonStartBit_Click(object sender, EventArgs e)
        {
            string startBit = "~";
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(startBit);
            }
        }

        private void buttonStopBit_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                //serialPort1.Write(dataCR);
                serialPort1.Write(dataLF);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {

                receiveHex = "hex";
            }    
        }
    }
}
