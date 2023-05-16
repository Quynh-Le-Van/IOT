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

namespace Serial_Port
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_portname.Text == "" || comboBox_baudrate.Text == ""|| comboBox_databits.Text == "" || comboBox_stopbits.Text == ""||comboBox_parity.Text=="")
                {
                    textBox_receive.Text = "Please select port settings";
                }

                else
                {
                    serialPort1.PortName = comboBox_portname.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox_baudrate.Text);
                    serialPort1.DataBits = Convert.ToInt32(comboBox_databits.Text);
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox_stopbits.Text);
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox_parity.Text);
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    button_send.Enabled = true;
                    button_clear.Enabled = true;
                    textBox_send.Enabled = true;
                    button_open.Enabled = false;
                    button_close.Enabled = true;


                }
            }
            catch (UnauthorizedAccessException)
            {
                textBox_receive.Text = "Unauthorized Access Exception";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_portname.Items.AddRange(ports);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0;
            button_send.Enabled = false;
            button_clear.Enabled = false;
            button_close.Enabled = false;
            button_open.Enabled = true;
            textBox_send.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(textBox_send.Text);
            textBox_send.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_receive.Text != "")
            {
                textBox_receive.Text = "";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            textBox_receive.Text = serialPort1.ReadExisting();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort1.Write("d");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            serialPort1.Write("f");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            serialPort1.Write("j");
        }

        private void on11_Click(object sender, EventArgs e)
        {
            serialPort1.Write("l");
        }

        private void on1_pb0_2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");
        }

        private void on8_pe11_10_Click(object sender, EventArgs e)
        {
            serialPort1.Write("h");
        }

        private void on2_pa7_3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("b");
        }

        private void on3_pb2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("c");
        }

        private void on5_pe8_7_Click(object sender, EventArgs e)
        {
            serialPort1.Write("e");
        }

        private void on7_pe10_9_Click(object sender, EventArgs e)
        {
            serialPort1.Write("g");
        }

        private void on10_pb6_13_Click(object sender, EventArgs e)
        {
            serialPort1.Write("k");
        }

        private void on12_pe0_15_Click(object sender, EventArgs e)
        {
            serialPort1.Write("m");
        }

        private void off1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
        }

        private void off2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("2");
        }

        private void off3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("3");
        }

        private void off4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("4");
        }

        private void off5_Click(object sender, EventArgs e)
        {
            serialPort1.Write("5");
        }

        private void off6_Click(object sender, EventArgs e)
        {
            serialPort1.Write("6");
        }

        private void off7_Click(object sender, EventArgs e)
        {
            serialPort1.Write("7");
        }

        private void off8_Click(object sender, EventArgs e)
        {
            serialPort1.Write("8");
        }

        private void off9_Click(object sender, EventArgs e)
        {
            serialPort1.Write("9");
        }

        private void off10_Click(object sender, EventArgs e)
        {
            serialPort1.Write("u");
        }

        private void off11_Click(object sender, EventArgs e)
        {
            serialPort1.Write("i");
        }

        private void off12_Click(object sender, EventArgs e)
        {
            serialPort1.Write("o");
        }
    }
}
