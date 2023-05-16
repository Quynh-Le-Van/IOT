namespace Serial_Port
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_portname = new System.Windows.Forms.ComboBox();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.textBox_receive = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_databits = new System.Windows.Forms.ComboBox();
            this.comboBox_stopbits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_parity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.on1_pb0_2 = new System.Windows.Forms.Button();
            this.on2_pa7_3 = new System.Windows.Forms.Button();
            this.on4_pe7 = new System.Windows.Forms.Button();
            this.on3_pb2 = new System.Windows.Forms.Button();
            this.on6_pe9_8 = new System.Windows.Forms.Button();
            this.on5_pe8_7 = new System.Windows.Forms.Button();
            this.on8_pe11_10 = new System.Windows.Forms.Button();
            this.on7_pe10_9 = new System.Windows.Forms.Button();
            this.on10_pb6_13 = new System.Windows.Forms.Button();
            this.on9_pb7_12 = new System.Windows.Forms.Button();
            this.on12_pe0_15 = new System.Windows.Forms.Button();
            this.on11_pb9_14 = new System.Windows.Forms.Button();
            this.off12 = new System.Windows.Forms.Button();
            this.off11 = new System.Windows.Forms.Button();
            this.off10 = new System.Windows.Forms.Button();
            this.off9 = new System.Windows.Forms.Button();
            this.off8 = new System.Windows.Forms.Button();
            this.off7 = new System.Windows.Forms.Button();
            this.off6 = new System.Windows.Forms.Button();
            this.off5 = new System.Windows.Forms.Button();
            this.off4 = new System.Windows.Forms.Button();
            this.off3 = new System.Windows.Forms.Button();
            this.off2 = new System.Windows.Forms.Button();
            this.off1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud rate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox_portname
            // 
            this.comboBox_portname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_portname.FormattingEnabled = true;
            this.comboBox_portname.Location = new System.Drawing.Point(12, 53);
            this.comboBox_portname.Name = "comboBox_portname";
            this.comboBox_portname.Size = new System.Drawing.Size(121, 24);
            this.comboBox_portname.TabIndex = 3;
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.AutoCompleteCustomSource.AddRange(new string[] {
            "150",
            "300",
            "600"});
            this.comboBox_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Items.AddRange(new object[] {
            "150",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "28800",
            "38400",
            "56000",
            "115200"});
            this.comboBox_baudrate.Location = new System.Drawing.Point(12, 121);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(121, 24);
            this.comboBox_baudrate.TabIndex = 4;
            // 
            // textBox_send
            // 
            this.textBox_send.Enabled = false;
            this.textBox_send.Location = new System.Drawing.Point(169, 145);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(237, 191);
            this.textBox_send.TabIndex = 7;
            // 
            // textBox_receive
            // 
            this.textBox_receive.CausesValidation = false;
            this.textBox_receive.Enabled = false;
            this.textBox_receive.Location = new System.Drawing.Point(480, 145);
            this.textBox_receive.Multiline = true;
            this.textBox_receive.Name = "textBox_receive";
            this.textBox_receive.ReadOnly = true;
            this.textBox_receive.Size = new System.Drawing.Size(237, 191);
            this.textBox_receive.TabIndex = 8;
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(331, 356);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 11;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(169, 28);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(100, 64);
            this.button_open.TabIndex = 13;
            this.button_open.Text = "Open Port";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(294, 28);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(100, 64);
            this.button_close.TabIndex = 14;
            this.button_close.Text = "Close Port";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(166, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 321);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send here";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(480, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 321);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Received here";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(480, 53);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 17;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data bits";
            // 
            // comboBox_databits
            // 
            this.comboBox_databits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_databits.FormattingEnabled = true;
            this.comboBox_databits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboBox_databits.Location = new System.Drawing.Point(12, 185);
            this.comboBox_databits.Name = "comboBox_databits";
            this.comboBox_databits.Size = new System.Drawing.Size(121, 24);
            this.comboBox_databits.TabIndex = 19;
            // 
            // comboBox_stopbits
            // 
            this.comboBox_stopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_stopbits.FormattingEnabled = true;
            this.comboBox_stopbits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox_stopbits.Location = new System.Drawing.Point(12, 260);
            this.comboBox_stopbits.Name = "comboBox_stopbits";
            this.comboBox_stopbits.Size = new System.Drawing.Size(121, 24);
            this.comboBox_stopbits.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Stop bits";
            // 
            // comboBox_parity
            // 
            this.comboBox_parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_parity.FormattingEnabled = true;
            this.comboBox_parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBox_parity.Location = new System.Drawing.Point(12, 340);
            this.comboBox_parity.Name = "comboBox_parity";
            this.comboBox_parity.Size = new System.Drawing.Size(121, 24);
            this.comboBox_parity.TabIndex = 23;
            this.comboBox_parity.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Parity bits";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button_clear
            // 
            this.button_clear.Enabled = false;
            this.button_clear.Location = new System.Drawing.Point(642, 356);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 12;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(898, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Relay Control";
            // 
            // on1_pb0_2
            // 
            this.on1_pb0_2.Location = new System.Drawing.Point(855, 93);
            this.on1_pb0_2.Name = "on1_pb0_2";
            this.on1_pb0_2.Size = new System.Drawing.Size(75, 23);
            this.on1_pb0_2.TabIndex = 27;
            this.on1_pb0_2.Text = "ON1";
            this.on1_pb0_2.UseVisualStyleBackColor = true;
            this.on1_pb0_2.Click += new System.EventHandler(this.on1_pb0_2_Click);
            // 
            // on2_pa7_3
            // 
            this.on2_pa7_3.Location = new System.Drawing.Point(855, 132);
            this.on2_pa7_3.Name = "on2_pa7_3";
            this.on2_pa7_3.Size = new System.Drawing.Size(75, 23);
            this.on2_pa7_3.TabIndex = 28;
            this.on2_pa7_3.Text = "ON2";
            this.on2_pa7_3.UseVisualStyleBackColor = true;
            this.on2_pa7_3.Click += new System.EventHandler(this.on2_pa7_3_Click);
            // 
            // on4_pe7
            // 
            this.on4_pe7.Location = new System.Drawing.Point(855, 215);
            this.on4_pe7.Name = "on4_pe7";
            this.on4_pe7.Size = new System.Drawing.Size(75, 23);
            this.on4_pe7.TabIndex = 30;
            this.on4_pe7.Text = "ON4";
            this.on4_pe7.UseVisualStyleBackColor = true;
            this.on4_pe7.Click += new System.EventHandler(this.button7_Click);
            // 
            // on3_pb2
            // 
            this.on3_pb2.Location = new System.Drawing.Point(855, 176);
            this.on3_pb2.Name = "on3_pb2";
            this.on3_pb2.Size = new System.Drawing.Size(75, 23);
            this.on3_pb2.TabIndex = 29;
            this.on3_pb2.Text = "ON3";
            this.on3_pb2.UseVisualStyleBackColor = true;
            this.on3_pb2.Click += new System.EventHandler(this.on3_pb2_Click);
            // 
            // on6_pe9_8
            // 
            this.on6_pe9_8.Location = new System.Drawing.Point(855, 300);
            this.on6_pe9_8.Name = "on6_pe9_8";
            this.on6_pe9_8.Size = new System.Drawing.Size(75, 23);
            this.on6_pe9_8.TabIndex = 32;
            this.on6_pe9_8.Text = "ON6";
            this.on6_pe9_8.UseVisualStyleBackColor = true;
            this.on6_pe9_8.Click += new System.EventHandler(this.button9_Click);
            // 
            // on5_pe8_7
            // 
            this.on5_pe8_7.Location = new System.Drawing.Point(855, 261);
            this.on5_pe8_7.Name = "on5_pe8_7";
            this.on5_pe8_7.Size = new System.Drawing.Size(75, 23);
            this.on5_pe8_7.TabIndex = 31;
            this.on5_pe8_7.Text = "ON5";
            this.on5_pe8_7.UseVisualStyleBackColor = true;
            this.on5_pe8_7.Click += new System.EventHandler(this.on5_pe8_7_Click);
            // 
            // on8_pe11_10
            // 
            this.on8_pe11_10.Location = new System.Drawing.Point(855, 380);
            this.on8_pe11_10.Name = "on8_pe11_10";
            this.on8_pe11_10.Size = new System.Drawing.Size(75, 23);
            this.on8_pe11_10.TabIndex = 34;
            this.on8_pe11_10.Text = "ON8";
            this.on8_pe11_10.UseVisualStyleBackColor = true;
            this.on8_pe11_10.Click += new System.EventHandler(this.on8_pe11_10_Click);
            // 
            // on7_pe10_9
            // 
            this.on7_pe10_9.Location = new System.Drawing.Point(855, 341);
            this.on7_pe10_9.Name = "on7_pe10_9";
            this.on7_pe10_9.Size = new System.Drawing.Size(75, 23);
            this.on7_pe10_9.TabIndex = 33;
            this.on7_pe10_9.Text = "ON7";
            this.on7_pe10_9.UseVisualStyleBackColor = true;
            this.on7_pe10_9.Click += new System.EventHandler(this.on7_pe10_9_Click);
            // 
            // on10_pb6_13
            // 
            this.on10_pb6_13.Location = new System.Drawing.Point(855, 461);
            this.on10_pb6_13.Name = "on10_pb6_13";
            this.on10_pb6_13.Size = new System.Drawing.Size(75, 23);
            this.on10_pb6_13.TabIndex = 36;
            this.on10_pb6_13.Text = "ON10";
            this.on10_pb6_13.UseVisualStyleBackColor = true;
            this.on10_pb6_13.Click += new System.EventHandler(this.on10_pb6_13_Click);
            // 
            // on9_pb7_12
            // 
            this.on9_pb7_12.Location = new System.Drawing.Point(855, 422);
            this.on9_pb7_12.Name = "on9_pb7_12";
            this.on9_pb7_12.Size = new System.Drawing.Size(75, 23);
            this.on9_pb7_12.TabIndex = 35;
            this.on9_pb7_12.Text = "ON9";
            this.on9_pb7_12.UseVisualStyleBackColor = true;
            this.on9_pb7_12.Click += new System.EventHandler(this.button14_Click);
            // 
            // on12_pe0_15
            // 
            this.on12_pe0_15.Location = new System.Drawing.Point(855, 542);
            this.on12_pe0_15.Name = "on12_pe0_15";
            this.on12_pe0_15.Size = new System.Drawing.Size(75, 23);
            this.on12_pe0_15.TabIndex = 38;
            this.on12_pe0_15.Text = "ON12";
            this.on12_pe0_15.UseVisualStyleBackColor = true;
            this.on12_pe0_15.Click += new System.EventHandler(this.on12_pe0_15_Click);
            // 
            // on11_pb9_14
            // 
            this.on11_pb9_14.Location = new System.Drawing.Point(855, 503);
            this.on11_pb9_14.Name = "on11_pb9_14";
            this.on11_pb9_14.Size = new System.Drawing.Size(75, 23);
            this.on11_pb9_14.TabIndex = 37;
            this.on11_pb9_14.Text = "ON11";
            this.on11_pb9_14.UseVisualStyleBackColor = true;
            this.on11_pb9_14.Click += new System.EventHandler(this.on11_Click);
            // 
            // off12
            // 
            this.off12.Location = new System.Drawing.Point(957, 542);
            this.off12.Name = "off12";
            this.off12.Size = new System.Drawing.Size(75, 23);
            this.off12.TabIndex = 50;
            this.off12.Text = "OFF12";
            this.off12.UseVisualStyleBackColor = true;
            this.off12.Click += new System.EventHandler(this.off12_Click);
            // 
            // off11
            // 
            this.off11.Location = new System.Drawing.Point(957, 503);
            this.off11.Name = "off11";
            this.off11.Size = new System.Drawing.Size(75, 23);
            this.off11.TabIndex = 49;
            this.off11.Text = "OFF11";
            this.off11.UseVisualStyleBackColor = true;
            this.off11.Click += new System.EventHandler(this.off11_Click);
            // 
            // off10
            // 
            this.off10.Location = new System.Drawing.Point(957, 461);
            this.off10.Name = "off10";
            this.off10.Size = new System.Drawing.Size(75, 23);
            this.off10.TabIndex = 48;
            this.off10.Text = "OFF10";
            this.off10.UseVisualStyleBackColor = true;
            this.off10.Click += new System.EventHandler(this.off10_Click);
            // 
            // off9
            // 
            this.off9.Location = new System.Drawing.Point(957, 422);
            this.off9.Name = "off9";
            this.off9.Size = new System.Drawing.Size(75, 23);
            this.off9.TabIndex = 47;
            this.off9.Text = "OFF9";
            this.off9.UseVisualStyleBackColor = true;
            this.off9.Click += new System.EventHandler(this.off9_Click);
            // 
            // off8
            // 
            this.off8.Location = new System.Drawing.Point(957, 380);
            this.off8.Name = "off8";
            this.off8.Size = new System.Drawing.Size(75, 23);
            this.off8.TabIndex = 46;
            this.off8.Text = "OFF8";
            this.off8.UseVisualStyleBackColor = true;
            this.off8.Click += new System.EventHandler(this.off8_Click);
            // 
            // off7
            // 
            this.off7.Location = new System.Drawing.Point(957, 341);
            this.off7.Name = "off7";
            this.off7.Size = new System.Drawing.Size(75, 23);
            this.off7.TabIndex = 45;
            this.off7.Text = "OFF7";
            this.off7.UseVisualStyleBackColor = true;
            this.off7.Click += new System.EventHandler(this.off7_Click);
            // 
            // off6
            // 
            this.off6.Location = new System.Drawing.Point(957, 300);
            this.off6.Name = "off6";
            this.off6.Size = new System.Drawing.Size(75, 23);
            this.off6.TabIndex = 44;
            this.off6.Text = "OFF6";
            this.off6.UseVisualStyleBackColor = true;
            this.off6.Click += new System.EventHandler(this.off6_Click);
            // 
            // off5
            // 
            this.off5.Location = new System.Drawing.Point(957, 261);
            this.off5.Name = "off5";
            this.off5.Size = new System.Drawing.Size(75, 23);
            this.off5.TabIndex = 43;
            this.off5.Text = "OFF5";
            this.off5.UseVisualStyleBackColor = true;
            this.off5.Click += new System.EventHandler(this.off5_Click);
            // 
            // off4
            // 
            this.off4.Location = new System.Drawing.Point(957, 215);
            this.off4.Name = "off4";
            this.off4.Size = new System.Drawing.Size(75, 23);
            this.off4.TabIndex = 42;
            this.off4.Text = "OFF4";
            this.off4.UseVisualStyleBackColor = true;
            this.off4.Click += new System.EventHandler(this.off4_Click);
            // 
            // off3
            // 
            this.off3.Location = new System.Drawing.Point(957, 176);
            this.off3.Name = "off3";
            this.off3.Size = new System.Drawing.Size(75, 23);
            this.off3.TabIndex = 41;
            this.off3.Text = "OFF3";
            this.off3.UseVisualStyleBackColor = true;
            this.off3.Click += new System.EventHandler(this.off3_Click);
            // 
            // off2
            // 
            this.off2.Location = new System.Drawing.Point(957, 132);
            this.off2.Name = "off2";
            this.off2.Size = new System.Drawing.Size(75, 23);
            this.off2.TabIndex = 40;
            this.off2.Text = "OFF2";
            this.off2.UseVisualStyleBackColor = true;
            this.off2.Click += new System.EventHandler(this.off2_Click);
            // 
            // off1
            // 
            this.off1.Location = new System.Drawing.Point(957, 93);
            this.off1.Name = "off1";
            this.off1.Size = new System.Drawing.Size(75, 23);
            this.off1.TabIndex = 39;
            this.off1.Text = "OFF1";
            this.off1.UseVisualStyleBackColor = true;
            this.off1.Click += new System.EventHandler(this.off1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 647);
            this.Controls.Add(this.off12);
            this.Controls.Add(this.off11);
            this.Controls.Add(this.off10);
            this.Controls.Add(this.off9);
            this.Controls.Add(this.off8);
            this.Controls.Add(this.off7);
            this.Controls.Add(this.off6);
            this.Controls.Add(this.off5);
            this.Controls.Add(this.off4);
            this.Controls.Add(this.off3);
            this.Controls.Add(this.off2);
            this.Controls.Add(this.off1);
            this.Controls.Add(this.on12_pe0_15);
            this.Controls.Add(this.on11_pb9_14);
            this.Controls.Add(this.on10_pb6_13);
            this.Controls.Add(this.on9_pb7_12);
            this.Controls.Add(this.on8_pe11_10);
            this.Controls.Add(this.on7_pe10_9);
            this.Controls.Add(this.on6_pe9_8);
            this.Controls.Add(this.on5_pe8_7);
            this.Controls.Add(this.on4_pe7);
            this.Controls.Add(this.on3_pb2);
            this.Controls.Add(this.on2_pa7_3);
            this.Controls.Add(this.on1_pb0_2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_parity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_stopbits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_databits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_receive);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.comboBox_baudrate);
            this.Controls.Add(this.comboBox_portname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Serial Communication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_portname;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.TextBox textBox_receive;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_databits;
        private System.Windows.Forms.ComboBox comboBox_stopbits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_parity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button on1_pb0_2;
        private System.Windows.Forms.Button on2_pa7_3;
        private System.Windows.Forms.Button on4_pe7;
        private System.Windows.Forms.Button on3_pb2;
        private System.Windows.Forms.Button on6_pe9_8;
        private System.Windows.Forms.Button on5_pe8_7;
        private System.Windows.Forms.Button on8_pe11_10;
        private System.Windows.Forms.Button on7_pe10_9;
        private System.Windows.Forms.Button on10_pb6_13;
        private System.Windows.Forms.Button on9_pb7_12;
        private System.Windows.Forms.Button on12_pe0_15;
        private System.Windows.Forms.Button on11_pb9_14;
        private System.Windows.Forms.Button off12;
        private System.Windows.Forms.Button off11;
        private System.Windows.Forms.Button off10;
        private System.Windows.Forms.Button off9;
        private System.Windows.Forms.Button off8;
        private System.Windows.Forms.Button off7;
        private System.Windows.Forms.Button off6;
        private System.Windows.Forms.Button off5;
        private System.Windows.Forms.Button off4;
        private System.Windows.Forms.Button off3;
        private System.Windows.Forms.Button off2;
        private System.Windows.Forms.Button off1;
    }
}

