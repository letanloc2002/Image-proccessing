namespace Serial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.led8off = new System.Windows.Forms.Button();
            this.led8on = new System.Windows.Forms.Button();
            this.led7off = new System.Windows.Forms.Button();
            this.led7on = new System.Windows.Forms.Button();
            this.led6off = new System.Windows.Forms.Button();
            this.led6on = new System.Windows.Forms.Button();
            this.led5off = new System.Windows.Forms.Button();
            this.led5on = new System.Windows.Forms.Button();
            this.led4off = new System.Windows.Forms.Button();
            this.led4on = new System.Windows.Forms.Button();
            this.led3off = new System.Windows.Forms.Button();
            this.led3on = new System.Windows.Forms.Button();
            this.led2off = new System.Windows.Forms.Button();
            this.led2on = new System.Windows.Forms.Button();
            this.led1off = new System.Windows.Forms.Button();
            this.led1on = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_WriteToReg = new System.Windows.Forms.Button();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_numberp = new System.Windows.Forms.TextBox();
            this.txt_func = new System.Windows.Forms.TextBox();
            this.txt_startadd = new System.Windows.Forms.TextBox();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_CRCRecied = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.txt_CRCSend = new System.Windows.Forms.TextBox();
            this.txt_ReceiMsg = new System.Windows.Forms.TextBox();
            this.txt_SendMsg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "9600",
            "112500"});
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "19200",
            "112500"});
            this.comboBox2.Location = new System.Drawing.Point(258, 98);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(466, 108);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(142, 24);
            this.progressBar1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(27, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 234);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Here";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(92, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(7, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 155);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(251, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 234);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Received Here";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(92, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Received";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(7, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(187, 155);
            this.textBox2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(466, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 73);
            this.button3.TabIndex = 5;
            this.button3.Text = "Open Port";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(466, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 70);
            this.button4.TabIndex = 6;
            this.button4.Text = "Close Port";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Port names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.data);
            this.groupBox2.Controls.Add(this.led8off);
            this.groupBox2.Controls.Add(this.led8on);
            this.groupBox2.Controls.Add(this.led7off);
            this.groupBox2.Controls.Add(this.led7on);
            this.groupBox2.Controls.Add(this.led6off);
            this.groupBox2.Controls.Add(this.led6on);
            this.groupBox2.Controls.Add(this.led5off);
            this.groupBox2.Controls.Add(this.led5on);
            this.groupBox2.Controls.Add(this.led4off);
            this.groupBox2.Controls.Add(this.led4on);
            this.groupBox2.Controls.Add(this.led3off);
            this.groupBox2.Controls.Add(this.led3on);
            this.groupBox2.Controls.Add(this.led2off);
            this.groupBox2.Controls.Add(this.led2on);
            this.groupBox2.Controls.Add(this.led1off);
            this.groupBox2.Controls.Add(this.led1on);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(639, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 429);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ON/OFF LED";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "label4";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(91, 18);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(0, 16);
            this.data.TabIndex = 15;
            // 
            // led8off
            // 
            this.led8off.Location = new System.Drawing.Point(177, 295);
            this.led8off.Name = "led8off";
            this.led8off.Size = new System.Drawing.Size(75, 23);
            this.led8off.TabIndex = 35;
            this.led8off.Text = "OFF";
            this.led8off.UseVisualStyleBackColor = true;
            this.led8off.Click += new System.EventHandler(this.led8off_Click);
            // 
            // led8on
            // 
            this.led8on.Location = new System.Drawing.Point(67, 295);
            this.led8on.Name = "led8on";
            this.led8on.Size = new System.Drawing.Size(75, 23);
            this.led8on.TabIndex = 34;
            this.led8on.Text = "ON";
            this.led8on.UseVisualStyleBackColor = true;
            this.led8on.Click += new System.EventHandler(this.led8on_Click);
            // 
            // led7off
            // 
            this.led7off.Location = new System.Drawing.Point(177, 259);
            this.led7off.Name = "led7off";
            this.led7off.Size = new System.Drawing.Size(75, 23);
            this.led7off.TabIndex = 33;
            this.led7off.Text = "OFF";
            this.led7off.UseVisualStyleBackColor = true;
            this.led7off.Click += new System.EventHandler(this.led7off_Click);
            // 
            // led7on
            // 
            this.led7on.Location = new System.Drawing.Point(67, 259);
            this.led7on.Name = "led7on";
            this.led7on.Size = new System.Drawing.Size(75, 23);
            this.led7on.TabIndex = 32;
            this.led7on.Text = "ON";
            this.led7on.UseVisualStyleBackColor = true;
            this.led7on.Click += new System.EventHandler(this.led7on_Click);
            // 
            // led6off
            // 
            this.led6off.Location = new System.Drawing.Point(177, 223);
            this.led6off.Name = "led6off";
            this.led6off.Size = new System.Drawing.Size(75, 23);
            this.led6off.TabIndex = 31;
            this.led6off.Text = "OFF";
            this.led6off.UseVisualStyleBackColor = true;
            this.led6off.Click += new System.EventHandler(this.led6off_Click);
            // 
            // led6on
            // 
            this.led6on.Location = new System.Drawing.Point(67, 223);
            this.led6on.Name = "led6on";
            this.led6on.Size = new System.Drawing.Size(75, 23);
            this.led6on.TabIndex = 30;
            this.led6on.Text = "ON";
            this.led6on.UseVisualStyleBackColor = true;
            this.led6on.Click += new System.EventHandler(this.led6on_Click);
            // 
            // led5off
            // 
            this.led5off.Location = new System.Drawing.Point(177, 187);
            this.led5off.Name = "led5off";
            this.led5off.Size = new System.Drawing.Size(75, 23);
            this.led5off.TabIndex = 29;
            this.led5off.Text = "OFF";
            this.led5off.UseVisualStyleBackColor = true;
            this.led5off.Click += new System.EventHandler(this.led5off_Click);
            // 
            // led5on
            // 
            this.led5on.Location = new System.Drawing.Point(67, 187);
            this.led5on.Name = "led5on";
            this.led5on.Size = new System.Drawing.Size(75, 23);
            this.led5on.TabIndex = 28;
            this.led5on.Text = "ON";
            this.led5on.UseVisualStyleBackColor = true;
            this.led5on.Click += new System.EventHandler(this.led5on_Click);
            // 
            // led4off
            // 
            this.led4off.Location = new System.Drawing.Point(177, 151);
            this.led4off.Name = "led4off";
            this.led4off.Size = new System.Drawing.Size(75, 23);
            this.led4off.TabIndex = 27;
            this.led4off.Text = "OFF";
            this.led4off.UseVisualStyleBackColor = true;
            this.led4off.Click += new System.EventHandler(this.led4off_Click);
            // 
            // led4on
            // 
            this.led4on.Location = new System.Drawing.Point(67, 151);
            this.led4on.Name = "led4on";
            this.led4on.Size = new System.Drawing.Size(75, 23);
            this.led4on.TabIndex = 26;
            this.led4on.Text = "ON";
            this.led4on.UseVisualStyleBackColor = true;
            this.led4on.Click += new System.EventHandler(this.led4on_Click);
            // 
            // led3off
            // 
            this.led3off.Location = new System.Drawing.Point(177, 115);
            this.led3off.Name = "led3off";
            this.led3off.Size = new System.Drawing.Size(75, 23);
            this.led3off.TabIndex = 25;
            this.led3off.Text = "OFF";
            this.led3off.UseVisualStyleBackColor = true;
            this.led3off.Click += new System.EventHandler(this.led3off_Click_1);
            // 
            // led3on
            // 
            this.led3on.Location = new System.Drawing.Point(67, 115);
            this.led3on.Name = "led3on";
            this.led3on.Size = new System.Drawing.Size(75, 23);
            this.led3on.TabIndex = 24;
            this.led3on.Text = "ON";
            this.led3on.UseVisualStyleBackColor = true;
            this.led3on.Click += new System.EventHandler(this.led3on_Click_1);
            // 
            // led2off
            // 
            this.led2off.Location = new System.Drawing.Point(177, 79);
            this.led2off.Name = "led2off";
            this.led2off.Size = new System.Drawing.Size(75, 23);
            this.led2off.TabIndex = 23;
            this.led2off.Text = "OFF";
            this.led2off.UseVisualStyleBackColor = true;
            this.led2off.Click += new System.EventHandler(this.led2off_Click_1);
            // 
            // led2on
            // 
            this.led2on.Location = new System.Drawing.Point(67, 79);
            this.led2on.Name = "led2on";
            this.led2on.Size = new System.Drawing.Size(75, 23);
            this.led2on.TabIndex = 22;
            this.led2on.Text = "ON";
            this.led2on.UseVisualStyleBackColor = true;
            this.led2on.Click += new System.EventHandler(this.led2on_Click_1);
            // 
            // led1off
            // 
            this.led1off.Location = new System.Drawing.Point(177, 42);
            this.led1off.Name = "led1off";
            this.led1off.Size = new System.Drawing.Size(75, 23);
            this.led1off.TabIndex = 21;
            this.led1off.Text = "OFF";
            this.led1off.UseVisualStyleBackColor = true;
            this.led1off.Click += new System.EventHandler(this.led1off_Click_1);
            // 
            // led1on
            // 
            this.led1on.Location = new System.Drawing.Point(67, 42);
            this.led1on.Name = "led1on";
            this.led1on.Size = new System.Drawing.Size(75, 23);
            this.led1on.TabIndex = 20;
            this.led1on.Text = "ON";
            this.led1on.UseVisualStyleBackColor = true;
            this.led1on.Click += new System.EventHandler(this.led1on_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "LED8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "LED7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "LED6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "LED5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "LED4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "LED3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "LED2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "LED1";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(113, 376);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 37);
            this.button5.TabIndex = 3;
            this.button5.Text = "Send";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_WriteToReg);
            this.groupBox4.Controls.Add(this.txt_data);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txt_numberp);
            this.groupBox4.Controls.Add(this.txt_func);
            this.groupBox4.Controls.Add(this.txt_startadd);
            this.groupBox4.Controls.Add(this.txt_add);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txt_CRCRecied);
            this.groupBox4.Controls.Add(this.btn_Calculate);
            this.groupBox4.Controls.Add(this.txt_CRCSend);
            this.groupBox4.Controls.Add(this.txt_ReceiMsg);
            this.groupBox4.Controls.Add(this.txt_SendMsg);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(916, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 429);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CRC: Cyclical Redundancy Check Calculation";
            // 
            // btn_WriteToReg
            // 
            this.btn_WriteToReg.Location = new System.Drawing.Point(338, 111);
            this.btn_WriteToReg.Name = "btn_WriteToReg";
            this.btn_WriteToReg.Size = new System.Drawing.Size(141, 37);
            this.btn_WriteToReg.TabIndex = 20;
            this.btn_WriteToReg.Text = "Write to Reg";
            this.btn_WriteToReg.UseVisualStyleBackColor = true;
            this.btn_WriteToReg.Click += new System.EventHandler(this.button6_Click);
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(129, 199);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(350, 22);
            this.txt_data.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 199);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 16);
            this.label21.TabIndex = 18;
            this.label21.Text = "Data Write";
            // 
            // txt_numberp
            // 
            this.txt_numberp.Location = new System.Drawing.Point(184, 118);
            this.txt_numberp.Name = "txt_numberp";
            this.txt_numberp.Size = new System.Drawing.Size(128, 22);
            this.txt_numberp.TabIndex = 16;
            this.txt_numberp.Text = "05";
            // 
            // txt_func
            // 
            this.txt_func.Location = new System.Drawing.Point(24, 118);
            this.txt_func.Name = "txt_func";
            this.txt_func.Size = new System.Drawing.Size(128, 22);
            this.txt_func.TabIndex = 15;
            this.txt_func.Text = "03";
            // 
            // txt_startadd
            // 
            this.txt_startadd.Location = new System.Drawing.Point(184, 61);
            this.txt_startadd.Name = "txt_startadd";
            this.txt_startadd.Size = new System.Drawing.Size(128, 22);
            this.txt_startadd.TabIndex = 14;
            this.txt_startadd.Text = "00";
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(24, 60);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(128, 22);
            this.txt_add.TabIndex = 13;
            this.txt_add.Text = "05";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(181, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 16);
            this.label20.TabIndex = 12;
            this.label20.Text = "StartAdd";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(176, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 16);
            this.label19.TabIndex = 11;
            this.label19.Text = "NumberP";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 16);
            this.label18.TabIndex = 10;
            this.label18.Text = "Func";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 16);
            this.label17.TabIndex = 9;
            this.label17.Text = "Add";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 387);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "CRC(Recieved)";
            // 
            // txt_CRCRecied
            // 
            this.txt_CRCRecied.Location = new System.Drawing.Point(129, 381);
            this.txt_CRCRecied.Name = "txt_CRCRecied";
            this.txt_CRCRecied.ReadOnly = true;
            this.txt_CRCRecied.Size = new System.Drawing.Size(350, 22);
            this.txt_CRCRecied.TabIndex = 7;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(338, 54);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(141, 37);
            this.btn_Calculate.TabIndex = 6;
            this.btn_Calculate.Text = "Read to Reg";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click_1);
            // 
            // txt_CRCSend
            // 
            this.txt_CRCSend.Location = new System.Drawing.Point(129, 331);
            this.txt_CRCSend.Name = "txt_CRCSend";
            this.txt_CRCSend.ReadOnly = true;
            this.txt_CRCSend.Size = new System.Drawing.Size(350, 22);
            this.txt_CRCSend.TabIndex = 5;
            // 
            // txt_ReceiMsg
            // 
            this.txt_ReceiMsg.Location = new System.Drawing.Point(129, 286);
            this.txt_ReceiMsg.Name = "txt_ReceiMsg";
            this.txt_ReceiMsg.ReadOnly = true;
            this.txt_ReceiMsg.Size = new System.Drawing.Size(350, 22);
            this.txt_ReceiMsg.TabIndex = 4;
            // 
            // txt_SendMsg
            // 
            this.txt_SendMsg.Location = new System.Drawing.Point(129, 241);
            this.txt_SendMsg.Name = "txt_SendMsg";
            this.txt_SendMsg.Size = new System.Drawing.Size(350, 22);
            this.txt_SendMsg.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 337);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "CRC(Send)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 292);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "ReceiMsg";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "SendMsg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 494);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Serial Communucation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button led8off;
        private System.Windows.Forms.Button led8on;
        private System.Windows.Forms.Button led7off;
        private System.Windows.Forms.Button led7on;
        private System.Windows.Forms.Button led6off;
        private System.Windows.Forms.Button led6on;
        private System.Windows.Forms.Button led5off;
        private System.Windows.Forms.Button led5on;
        private System.Windows.Forms.Button led4off;
        private System.Windows.Forms.Button led4on;
        private System.Windows.Forms.Button led3off;
        private System.Windows.Forms.Button led3on;
        private System.Windows.Forms.Button led2off;
        private System.Windows.Forms.Button led2on;
        private System.Windows.Forms.Button led1off;
        private System.Windows.Forms.Button led1on;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_CRCRecied;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.TextBox txt_CRCSend;
        private System.Windows.Forms.TextBox txt_ReceiMsg;
        private System.Windows.Forms.TextBox txt_SendMsg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_numberp;
        private System.Windows.Forms.TextBox txt_func;
        private System.Windows.Forms.TextBox txt_startadd;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_WriteToReg;
    }
}

