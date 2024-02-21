namespace Serial_CM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBxPARITYBITS = new System.Windows.Forms.ComboBox();
            this.CBxSTOPBITS = new System.Windows.Forms.ComboBox();
            this.CBxDATABITS = new System.Windows.Forms.ComboBox();
            this.CBxBAUDRATE = new System.Windows.Forms.ComboBox();
            this.CBxCOMPORT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BT_CLOSE = new System.Windows.Forms.Button();
            this.BT_OPEN = new System.Windows.Forms.Button();
            this.BT_SEND = new System.Windows.Forms.Button();
            this.Data_Box = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.Send_Data = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clear_data = new System.Windows.Forms.Button();
            this.buttonLedOn1 = new System.Windows.Forms.Button();
            this.buttonLedOff1 = new System.Windows.Forms.Button();
            this.buttonLedOn2 = new System.Windows.Forms.Button();
            this.buttonLedOff2 = new System.Windows.Forms.Button();
            this.buttonLedOn3 = new System.Windows.Forms.Button();
            this.buttonLedOn4 = new System.Windows.Forms.Button();
            this.buttonLedOn5 = new System.Windows.Forms.Button();
            this.buttonLedOn6 = new System.Windows.Forms.Button();
            this.buttonLedOn7 = new System.Windows.Forms.Button();
            this.buttonLedOn8 = new System.Windows.Forms.Button();
            this.buttonLedOff3 = new System.Windows.Forms.Button();
            this.buttonLedOff4 = new System.Windows.Forms.Button();
            this.buttonLedOff5 = new System.Windows.Forms.Button();
            this.buttonLedOff6 = new System.Windows.Forms.Button();
            this.buttonLedOff7 = new System.Windows.Forms.Button();
            this.buttonLedOff8 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonStartBit = new System.Windows.Forms.Button();
            this.buttonStopBit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CBxPARITYBITS);
            this.groupBox1.Controls.Add(this.CBxSTOPBITS);
            this.groupBox1.Controls.Add(this.CBxDATABITS);
            this.groupBox1.Controls.Add(this.CBxBAUDRATE);
            this.groupBox1.Controls.Add(this.CBxCOMPORT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // CBxPARITYBITS
            // 
            this.CBxPARITYBITS.FormattingEnabled = true;
            this.CBxPARITYBITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.CBxPARITYBITS.Location = new System.Drawing.Point(165, 161);
            this.CBxPARITYBITS.Name = "CBxPARITYBITS";
            this.CBxPARITYBITS.Size = new System.Drawing.Size(140, 24);
            this.CBxPARITYBITS.TabIndex = 5;
            this.CBxPARITYBITS.Text = "None";
            // 
            // CBxSTOPBITS
            // 
            this.CBxSTOPBITS.FormattingEnabled = true;
            this.CBxSTOPBITS.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.CBxSTOPBITS.Location = new System.Drawing.Point(165, 131);
            this.CBxSTOPBITS.Name = "CBxSTOPBITS";
            this.CBxSTOPBITS.Size = new System.Drawing.Size(140, 24);
            this.CBxSTOPBITS.TabIndex = 4;
            this.CBxSTOPBITS.Text = "One";
            // 
            // CBxDATABITS
            // 
            this.CBxDATABITS.FormattingEnabled = true;
            this.CBxDATABITS.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.CBxDATABITS.Location = new System.Drawing.Point(165, 101);
            this.CBxDATABITS.Name = "CBxDATABITS";
            this.CBxDATABITS.Size = new System.Drawing.Size(140, 24);
            this.CBxDATABITS.TabIndex = 3;
            this.CBxDATABITS.Text = "8";
            // 
            // CBxBAUDRATE
            // 
            this.CBxBAUDRATE.FormattingEnabled = true;
            this.CBxBAUDRATE.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "115200",
            "128000"});
            this.CBxBAUDRATE.Location = new System.Drawing.Point(165, 71);
            this.CBxBAUDRATE.Name = "CBxBAUDRATE";
            this.CBxBAUDRATE.Size = new System.Drawing.Size(140, 24);
            this.CBxBAUDRATE.TabIndex = 2;
            this.CBxBAUDRATE.Text = "9600";
            // 
            // CBxCOMPORT
            // 
            this.CBxCOMPORT.FormattingEnabled = true;
            this.CBxCOMPORT.Location = new System.Drawing.Point(165, 41);
            this.CBxCOMPORT.Name = "CBxCOMPORT";
            this.CBxCOMPORT.Size = new System.Drawing.Size(140, 24);
            this.CBxCOMPORT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.BT_CLOSE);
            this.groupBox2.Controls.Add(this.BT_OPEN);
            this.groupBox2.Location = new System.Drawing.Point(39, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 78);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(194, 40);
            this.progressBar1.TabIndex = 2;
            // 
            // BT_CLOSE
            // 
            this.BT_CLOSE.Location = new System.Drawing.Point(110, 21);
            this.BT_CLOSE.Name = "BT_CLOSE";
            this.BT_CLOSE.Size = new System.Drawing.Size(90, 51);
            this.BT_CLOSE.TabIndex = 1;
            this.BT_CLOSE.Text = "CLOSE";
            this.BT_CLOSE.UseVisualStyleBackColor = true;
            this.BT_CLOSE.Click += new System.EventHandler(this.BT_CLOSE_Click);
            // 
            // BT_OPEN
            // 
            this.BT_OPEN.Location = new System.Drawing.Point(6, 21);
            this.BT_OPEN.Name = "BT_OPEN";
            this.BT_OPEN.Size = new System.Drawing.Size(89, 51);
            this.BT_OPEN.TabIndex = 0;
            this.BT_OPEN.Text = "OPEN";
            this.BT_OPEN.UseVisualStyleBackColor = true;
            this.BT_OPEN.Click += new System.EventHandler(this.BT_OPEN_Click);
            // 
            // BT_SEND
            // 
            this.BT_SEND.Location = new System.Drawing.Point(255, 273);
            this.BT_SEND.Name = "BT_SEND";
            this.BT_SEND.Size = new System.Drawing.Size(115, 106);
            this.BT_SEND.TabIndex = 2;
            this.BT_SEND.Text = "SEND DATA";
            this.BT_SEND.UseVisualStyleBackColor = true;
            this.BT_SEND.Click += new System.EventHandler(this.BT_SEND_Click);
            // 
            // Data_Box
            // 
            this.Data_Box.BackColor = System.Drawing.SystemColors.Window;
            this.Data_Box.Location = new System.Drawing.Point(392, 216);
            this.Data_Box.Multiline = true;
            this.Data_Box.Name = "Data_Box";
            this.Data_Box.ReadOnly = true;
            this.Data_Box.Size = new System.Drawing.Size(603, 163);
            this.Data_Box.TabIndex = 3;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1020, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Send Here";
            // 
            // Send_Data
            // 
            this.Send_Data.Location = new System.Drawing.Point(392, 31);
            this.Send_Data.Multiline = true;
            this.Send_Data.Name = "Send_Data";
            this.Send_Data.Size = new System.Drawing.Size(603, 172);
            this.Send_Data.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1020, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Receive Here";
            // 
            // clear_data
            // 
            this.clear_data.Location = new System.Drawing.Point(1024, 288);
            this.clear_data.Name = "clear_data";
            this.clear_data.Size = new System.Drawing.Size(107, 83);
            this.clear_data.TabIndex = 8;
            this.clear_data.Text = "CLEAR DATA";
            this.clear_data.UseVisualStyleBackColor = true;
            this.clear_data.Click += new System.EventHandler(this.clear_data_Click);
            // 
            // buttonLedOn1
            // 
            this.buttonLedOn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOn1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOn1.Location = new System.Drawing.Point(164, 440);
            this.buttonLedOn1.Name = "buttonLedOn1";
            this.buttonLedOn1.Size = new System.Drawing.Size(121, 41);
            this.buttonLedOn1.TabIndex = 9;
            this.buttonLedOn1.Text = "Led 1 ON";
            this.buttonLedOn1.UseVisualStyleBackColor = true;
            this.buttonLedOn1.Click += new System.EventHandler(this.buttonLedOn1_Click);
            // 
            // buttonLedOff1
            // 
            this.buttonLedOff1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOff1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOff1.Location = new System.Drawing.Point(164, 487);
            this.buttonLedOff1.Name = "buttonLedOff1";
            this.buttonLedOff1.Size = new System.Drawing.Size(120, 41);
            this.buttonLedOff1.TabIndex = 10;
            this.buttonLedOff1.Text = "Led 1 OFF";
            this.buttonLedOff1.UseVisualStyleBackColor = true;
            this.buttonLedOff1.Click += new System.EventHandler(this.buttonLedOff1_Click);
            // 
            // buttonLedOn2
            // 
            this.buttonLedOn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOn2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOn2.Location = new System.Drawing.Point(291, 440);
            this.buttonLedOn2.Name = "buttonLedOn2";
            this.buttonLedOn2.Size = new System.Drawing.Size(121, 41);
            this.buttonLedOn2.TabIndex = 11;
            this.buttonLedOn2.Text = "Led 2 ON";
            this.buttonLedOn2.UseVisualStyleBackColor = true;
            this.buttonLedOn2.Click += new System.EventHandler(this.buttonLedOn2_Click);
            // 
            // buttonLedOff2
            // 
            this.buttonLedOff2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOff2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOff2.Location = new System.Drawing.Point(291, 487);
            this.buttonLedOff2.Name = "buttonLedOff2";
            this.buttonLedOff2.Size = new System.Drawing.Size(121, 41);
            this.buttonLedOff2.TabIndex = 12;
            this.buttonLedOff2.Text = "Led 2 OFF";
            this.buttonLedOff2.UseVisualStyleBackColor = true;
            this.buttonLedOff2.Click += new System.EventHandler(this.buttonLedOff2_Click);
            // 
            // buttonLedOn3
            // 
            this.buttonLedOn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOn3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOn3.Location = new System.Drawing.Point(418, 440);
            this.buttonLedOn3.Name = "buttonLedOn3";
            this.buttonLedOn3.Size = new System.Drawing.Size(121, 41);
            this.buttonLedOn3.TabIndex = 13;
            this.buttonLedOn3.Text = "Led 3 ON";
            this.buttonLedOn3.UseVisualStyleBackColor = true;
            this.buttonLedOn3.Click += new System.EventHandler(this.buttonLedOn3_Click);
            // 
            // buttonLedOn4
            // 
            this.buttonLedOn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOn4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOn4.Location = new System.Drawing.Point(545, 440);
            this.buttonLedOn4.Name = "buttonLedOn4";
            this.buttonLedOn4.Size = new System.Drawing.Size(121, 41);
            this.buttonLedOn4.TabIndex = 14;
            this.buttonLedOn4.Text = "Led 4 ON";
            this.buttonLedOn4.UseVisualStyleBackColor = true;
            this.buttonLedOn4.Click += new System.EventHandler(this.buttonLedOn4_Click);
            // 
            // buttonLedOn5
            // 
            this.buttonLedOn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOn5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOn5.Location = new System.Drawing.Point(672, 440);
            this.buttonLedOn5.Name = "buttonLedOn5";
            this.buttonLedOn5.Size = new System.Drawing.Size(121, 41);
            this.buttonLedOn5.TabIndex = 15;
            this.buttonLedOn5.Text = "Led 5 ON";
            this.buttonLedOn5.UseVisualStyleBackColor = true;
            this.buttonLedOn5.Click += new System.EventHandler(this.buttonLedOn5_Click);
            // 
            // buttonLedOn6
            // 
            this.buttonLedOn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOn6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOn6.Location = new System.Drawing.Point(799, 440);
            this.buttonLedOn6.Name = "buttonLedOn6";
            this.buttonLedOn6.Size = new System.Drawing.Size(121, 41);
            this.buttonLedOn6.TabIndex = 16;
            this.buttonLedOn6.Text = "Led 6 ON";
            this.buttonLedOn6.UseVisualStyleBackColor = true;
            this.buttonLedOn6.Click += new System.EventHandler(this.buttonLedOn6_Click);
            // 
            // buttonLedOn7
            // 
            this.buttonLedOn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOn7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOn7.Location = new System.Drawing.Point(926, 440);
            this.buttonLedOn7.Name = "buttonLedOn7";
            this.buttonLedOn7.Size = new System.Drawing.Size(121, 41);
            this.buttonLedOn7.TabIndex = 17;
            this.buttonLedOn7.Text = "Led 7 ON";
            this.buttonLedOn7.UseVisualStyleBackColor = true;
            this.buttonLedOn7.Click += new System.EventHandler(this.buttonLedOn7_Click);
            // 
            // buttonLedOn8
            // 
            this.buttonLedOn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOn8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOn8.Location = new System.Drawing.Point(1053, 440);
            this.buttonLedOn8.Name = "buttonLedOn8";
            this.buttonLedOn8.Size = new System.Drawing.Size(121, 41);
            this.buttonLedOn8.TabIndex = 18;
            this.buttonLedOn8.Text = "Led 8 ON";
            this.buttonLedOn8.UseVisualStyleBackColor = true;
            this.buttonLedOn8.Click += new System.EventHandler(this.buttonLedOn8_Click);
            // 
            // buttonLedOff3
            // 
            this.buttonLedOff3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOff3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOff3.Location = new System.Drawing.Point(418, 487);
            this.buttonLedOff3.Name = "buttonLedOff3";
            this.buttonLedOff3.Size = new System.Drawing.Size(121, 41);
            this.buttonLedOff3.TabIndex = 19;
            this.buttonLedOff3.Text = "Led 3 OFF";
            this.buttonLedOff3.UseVisualStyleBackColor = true;
            this.buttonLedOff3.Click += new System.EventHandler(this.buttonLedOff3_Click);
            // 
            // buttonLedOff4
            // 
            this.buttonLedOff4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOff4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOff4.Location = new System.Drawing.Point(545, 487);
            this.buttonLedOff4.Name = "buttonLedOff4";
            this.buttonLedOff4.Size = new System.Drawing.Size(121, 41);
            this.buttonLedOff4.TabIndex = 20;
            this.buttonLedOff4.Text = "Led 4 OFF";
            this.buttonLedOff4.UseVisualStyleBackColor = true;
            this.buttonLedOff4.Click += new System.EventHandler(this.buttonLedOff4_Click);
            // 
            // buttonLedOff5
            // 
            this.buttonLedOff5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOff5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOff5.Location = new System.Drawing.Point(672, 487);
            this.buttonLedOff5.Name = "buttonLedOff5";
            this.buttonLedOff5.Size = new System.Drawing.Size(121, 41);
            this.buttonLedOff5.TabIndex = 21;
            this.buttonLedOff5.Text = "Led 5 OFF";
            this.buttonLedOff5.UseVisualStyleBackColor = true;
            this.buttonLedOff5.Click += new System.EventHandler(this.buttonLedOff5_Click);
            // 
            // buttonLedOff6
            // 
            this.buttonLedOff6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOff6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOff6.Location = new System.Drawing.Point(799, 487);
            this.buttonLedOff6.Name = "buttonLedOff6";
            this.buttonLedOff6.Size = new System.Drawing.Size(121, 41);
            this.buttonLedOff6.TabIndex = 22;
            this.buttonLedOff6.Text = "Led 6 OFF";
            this.buttonLedOff6.UseVisualStyleBackColor = true;
            this.buttonLedOff6.Click += new System.EventHandler(this.buttonLedOff6_Click);
            // 
            // buttonLedOff7
            // 
            this.buttonLedOff7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOff7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOff7.Location = new System.Drawing.Point(926, 487);
            this.buttonLedOff7.Name = "buttonLedOff7";
            this.buttonLedOff7.Size = new System.Drawing.Size(121, 41);
            this.buttonLedOff7.TabIndex = 23;
            this.buttonLedOff7.Text = "Led 7 OFF";
            this.buttonLedOff7.UseVisualStyleBackColor = true;
            this.buttonLedOff7.Click += new System.EventHandler(this.buttonLedOff7_Click);
            // 
            // buttonLedOff8
            // 
            this.buttonLedOff8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLedOff8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLedOff8.Location = new System.Drawing.Point(1053, 487);
            this.buttonLedOff8.Name = "buttonLedOff8";
            this.buttonLedOff8.Size = new System.Drawing.Size(121, 41);
            this.buttonLedOff8.TabIndex = 24;
            this.buttonLedOff8.Text = "Led 8 OFF";
            this.buttonLedOff8.UseVisualStyleBackColor = true;
            this.buttonLedOff8.Click += new System.EventHandler(this.buttonLedOff8_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonReset.Location = new System.Drawing.Point(1180, 440);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(88, 88);
            this.buttonReset.TabIndex = 25;
            this.buttonReset.Text = "Reset Button";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonStartBit
            // 
            this.buttonStartBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartBit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonStartBit.Location = new System.Drawing.Point(37, 440);
            this.buttonStartBit.Name = "buttonStartBit";
            this.buttonStartBit.Size = new System.Drawing.Size(121, 41);
            this.buttonStartBit.TabIndex = 29;
            this.buttonStartBit.Text = "Start Bit";
            this.buttonStartBit.UseVisualStyleBackColor = true;
            this.buttonStartBit.Click += new System.EventHandler(this.buttonStartBit_Click);
            // 
            // buttonStopBit
            // 
            this.buttonStopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopBit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonStopBit.Location = new System.Drawing.Point(37, 487);
            this.buttonStopBit.Name = "buttonStopBit";
            this.buttonStopBit.Size = new System.Drawing.Size(121, 41);
            this.buttonStopBit.TabIndex = 30;
            this.buttonStopBit.Text = "Stop Bit";
            this.buttonStopBit.UseVisualStyleBackColor = true;
            this.buttonStopBit.Click += new System.EventHandler(this.buttonStopBit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(1024, 258);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(176, 24);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Hiển thị giá trị HEX";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 613);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonStopBit);
            this.Controls.Add(this.buttonStartBit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonLedOff8);
            this.Controls.Add(this.buttonLedOff7);
            this.Controls.Add(this.buttonLedOff6);
            this.Controls.Add(this.buttonLedOff5);
            this.Controls.Add(this.buttonLedOff4);
            this.Controls.Add(this.buttonLedOff3);
            this.Controls.Add(this.buttonLedOn8);
            this.Controls.Add(this.buttonLedOn7);
            this.Controls.Add(this.buttonLedOn6);
            this.Controls.Add(this.buttonLedOn5);
            this.Controls.Add(this.buttonLedOn4);
            this.Controls.Add(this.buttonLedOn3);
            this.Controls.Add(this.buttonLedOff2);
            this.Controls.Add(this.buttonLedOn2);
            this.Controls.Add(this.buttonLedOff1);
            this.Controls.Add(this.buttonLedOn1);
            this.Controls.Add(this.clear_data);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Send_Data);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Data_Box);
            this.Controls.Add(this.BT_SEND);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Serial Communication By Hoegond";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBxPARITYBITS;
        private System.Windows.Forms.ComboBox CBxSTOPBITS;
        private System.Windows.Forms.ComboBox CBxDATABITS;
        private System.Windows.Forms.ComboBox CBxBAUDRATE;
        private System.Windows.Forms.ComboBox CBxCOMPORT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BT_CLOSE;
        private System.Windows.Forms.Button BT_OPEN;
        private System.Windows.Forms.Button BT_SEND;
        private System.Windows.Forms.TextBox Data_Box;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Send_Data;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clear_data;
        private System.Windows.Forms.Button buttonLedOn1;
        private System.Windows.Forms.Button buttonLedOff1;
        private System.Windows.Forms.Button buttonLedOn2;
        private System.Windows.Forms.Button buttonLedOff2;
        private System.Windows.Forms.Button buttonLedOn3;
        private System.Windows.Forms.Button buttonLedOn4;
        private System.Windows.Forms.Button buttonLedOn5;
        private System.Windows.Forms.Button buttonLedOn6;
        private System.Windows.Forms.Button buttonLedOn7;
        private System.Windows.Forms.Button buttonLedOn8;
        private System.Windows.Forms.Button buttonLedOff3;
        private System.Windows.Forms.Button buttonLedOff4;
        private System.Windows.Forms.Button buttonLedOff5;
        private System.Windows.Forms.Button buttonLedOff6;
        private System.Windows.Forms.Button buttonLedOff7;
        private System.Windows.Forms.Button buttonLedOff8;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonStartBit;
        private System.Windows.Forms.Button buttonStopBit;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

