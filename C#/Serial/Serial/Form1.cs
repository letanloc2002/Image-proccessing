using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Serial
{
    public partial class Form1 : Form
    {

        string dataOut;
        string sendWith;
        string dataIn;
        //-----------//
        string LED0 = "0";
        string LED1 = "0";
        string LED2 = "0";
        string LED3 = "0";
        string LED4 = "0";
        string LED5 = "0";
        string LED6 = "0";
        string LED7 = "0";
        string text1;

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
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    button5.Enabled = true;


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
            button5.Enabled = false;

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
                textBox2.Text = serialPort1.ReadExisting();

            }
            catch (TimeoutException)
            {
                textBox2.Text = "Timeout Exception";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void data_Click(object sender, EventArgs e)
        {

        }
        private void led1on_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED0 = "1";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void led1off_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED0 = "0";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void led2on_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED1 = "1";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void led2off_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED1 = "0";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void led3on_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED2 = "1";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void led3off_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED2 = "0";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void led4on_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED3 = "1";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void led4off_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED3 = "0";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void led5on_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED4 = "1";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void led5off_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED4 = "0";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void led6on_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED5 = "1";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void led6off_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED5 = "0";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void led7on_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED6 = "1";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void led7off_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED6 = "0";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void led8on_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED7 = "1";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void led8off_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                LED7 = "0";
                dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
                label4.Text = dataOut;
                serialPort1.Write(dataOut);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.Write(dataOut); //Contains enter
            LED0 = "0";
            LED1 = "0";
            LED2 = "0";
            LED3 = "0";
            LED4 = "0";
            LED5 = "0";
            LED6 = "0";
            LED7 = "0";
            dataOut = "~" + LED0 + LED1 + LED2 + LED3 + LED4 + LED5 + LED6 + LED7;
            label4.Text = dataOut;
        }
        private void CRCForm_Load(object sender, EventArgs e)
        {
            try
            {
                serialPort1 = new SerialPort(comboBox1.Text, 9600, Parity.None, 8, StopBits.One);
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CRCForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private byte[] ReadHoldingRegister(byte slaveAddress, byte functionCode, ushort startAddress, ushort numberOfPoints)
        {
            byte[] frame = new byte[8]; // total 8 bits
            frame[0] = slaveAddress; // slave Address
            frame[1] = functionCode; // function 
            frame[2] = (byte)(startAddress >> 8); // starting Address high
            frame[3] = (byte)startAddress ; //  starting Address low
            frame[4] = (byte)(numberOfPoints >> 8); // Quantity of Register High
            frame[5] = (byte)numberOfPoints;// Quantity of Register Low
            byte[] crc = this.CalculateCRC(frame); // call calculate function 
            frame[6] = crc[0]; // error check high
            frame[7] = crc[1]; //  error check low
            return frame;
        }

        public static byte[] StringToHex(string input)
        {
            // Xóa khoảng trắng và các ký tự không hợp lệ khác khỏi chuỗi đầu vào
            input = new string(input.Where(c => "0123456789abcdefABCDEF".Contains(c)).ToArray());

            // Kiểm tra độ dài của chuỗi đầu vào và đảm bảo nó là số chẵn
            if (input.Length % 2 != 0)
                throw new ArgumentException("Chuỗi đầu vào không hợp lệ");

            // Chuyển đổi chuỗi Hexa thành mảng byte
            return Enumerable.Range(0, input.Length).Where(x => x % 2 == 0).Select(x => Convert.ToByte(input.Substring(x, 2), 16)).ToArray();
        }
        private byte[] WriteToRegister(byte slaveAddress, byte functionCode, ushort startAddress, ushort numberOfPoints)
        {  
            byte[] data_funtion10 = StringToHex(txt_data.Text);   
            byte[] frame = new byte[9+ data_funtion10.Length];
            frame[0] = slaveAddress; // slave Address
            frame[1] = functionCode; // function 
            frame[2] = (byte)(startAddress >> 8); // starting Address high
            frame[3] = (byte)startAddress; //  starting Address low
            frame[4] = (byte)(numberOfPoints >> 8); // Quantity of Register High
            frame[5] = (byte)numberOfPoints;// Quantity of Register Low
            frame[6] = (byte)(numberOfPoints*2);
            
            for (int i=0; i< data_funtion10.Length;i++)
            {
                frame[i+7] = data_funtion10[i];
            }
            byte[] crc = this.CalculateCRC(frame); // call calculate function 
            
            frame[data_funtion10.Length + 7] = crc[0]; // error check high
            frame[data_funtion10.Length + 8] = crc[1]; //  error check low
            return frame;
        }

        private byte[] CalculateCRC(byte[] frame)
        {
            byte[] result = new byte[2];
            ushort CRCFull = 0xFFFF; // set the 16-bit register (CRC) == FFFF
            char CRCLSB;
            for (int i = 0; i < frame.Length - 2; i++)
            {
                CRCFull = (ushort)(CRCFull ^ frame[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (char)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                    {
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                    }
                }
            }
            result[1] = (byte)((CRCFull >> 8) & 0xFF);
            result[0] = (byte)(CRCFull & 0xFF);

            return result;
        }
        private string Display(byte[] frame)
        {
            string result = string.Empty;
            foreach (byte item in frame)
            {
                result += string.Format("{0:X2}", item);
            }
            return result;
        }

        private void btn_Calculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                byte   slaveAddress   = (byte)Convert.ToInt16(txt_add.Text); // slave address
                byte   functionCode   = (byte)Convert.ToInt16(txt_func.Text); // function Code
                ushort startAddress   = (byte)Convert.ToInt16(txt_startadd.Text); // starting Address
                ushort numberOfPoints = (byte)Convert.ToInt16(txt_numberp.Text); // Quantity of Register

                byte[] frame = this.ReadHoldingRegister(slaveAddress, functionCode, startAddress, numberOfPoints);
                txt_SendMsg.Text = this.Display(frame); // display frame : send 
                // display CRC
                txt_CRCSend.Text = string.Format("CRC(Send): {0:X2} {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]);
                serialPort1.Write(frame, 0, frame.Length); // send frame to device 
                Thread.Sleep(100); // delay 100ms
                frame = new byte[256];
                if (serialPort1.BytesToRead >= 5)
                {
                    frame = new byte[serialPort1.BytesToRead];
                    int rs = serialPort1.Read(frame, 0, frame.Length);
                    txt_ReceiMsg.Text = this.Display(frame); // display frame :  Recieved.
                    txt_CRCRecied.Text = string.Format("CRC(Receied): {0:X2} {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string func = txt_func.Text;
                byte   slaveAddress = (byte)Convert.ToByte(txt_add.Text  ); // slave address
                byte   functionCode = (byte)Convert.ToByte(func,16); // function Code
                ushort startAddress = (byte)Convert.ToInt16(txt_startadd.Text); // starting Address
                ushort numberOfPoints = (byte)Convert.ToInt16(txt_numberp.Text); // Quantity of Register

                byte[] frame = this.WriteToRegister(slaveAddress, functionCode, startAddress, numberOfPoints);
                txt_SendMsg.Text = this.Display(frame); // display frame : send 
                // display CRC
                txt_CRCSend.Text = string.Format("CRC(Send): {0:X2} {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]);
                serialPort1.Write(frame, 0, frame.Length); // send frame to device 
                Thread.Sleep(100); // delay 100ms
                frame = new byte[256];
                if (serialPort1.BytesToRead >= 5)
                {
                    frame = new byte[serialPort1.BytesToRead];
                    int rs = serialPort1.Read(frame, 0, frame.Length);
                    txt_ReceiMsg.Text = this.Display(frame); // display frame :  Recieved.
                    txt_CRCRecied.Text = string.Format("CRC(Receied): {0:X2} {1:X2}", frame[frame.Length - 2], frame[frame.Length - 1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


