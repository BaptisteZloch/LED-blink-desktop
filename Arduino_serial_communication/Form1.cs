using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_serial_communication
{
    public partial class Form1 : Form
    {
        String port_name = "";
        int[] baudes_rates = new int[] { 300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 74880, 115200, 230400 };
        int baud_rate;
        SerialPort _serialPort;


        public Form1()
        {
            InitializeComponent();
            Serialports.DataSource = SerialPort.GetPortNames();
        }


        private void connect_button_Click(object sender, EventArgs e)
        {
            baud_rate = baudes_rates[baudrates.SelectedIndex];
            Console.WriteLine("baud rate : " + baud_rate);
            port_name = (string)Serialports.SelectedItem;
            Console.WriteLine("COM port : " + port_name);
            _serialPort = new SerialPort(port_name, baud_rate);
            _serialPort.Open();
            if (_serialPort.IsOpen)
            {
                Console.WriteLine("Connected !");
            }

        }

        private void disconnect_button_Click(object sender, EventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Write("0");
                Console.WriteLine("LED switched off");
                _serialPort.Close();
                baudrates.Text = "";
                Console.WriteLine("Disconnected !");
            }
        }

        private void on_button_Click(object sender, EventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Write("1");
                Console.WriteLine("LED switched on");
            }
        }

        private void off_button_Click(object sender, EventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Write("0");
                Console.WriteLine("LED switched off");
            }
        }
    }
}
