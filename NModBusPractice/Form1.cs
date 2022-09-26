using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus.Device;
using System.IO.Ports;
namespace NModBusPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static object master;
        private void button1_Click(object sender, EventArgs e)      // open Device
        {
            SerialPort serialPort = new SerialPort
            {
                PortName = "COM4",
                BaudRate = 9600,
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One
            }; //Create a new SerialPort object.
            serialPort.Open();
            ModbusSerialMaster master = ModbusSerialMaster.CreateRtu((Modbus.IO.IStreamResource)serialPort);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
            serialPort.PortName = "COM4";
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.Open();
            ModbusSerialMaster master = ModbusSerialMaster.CreateRtu((Modbus.IO.IStreamResource)serialPort);
            var data= master.ReadInputs(10, 7999, 4);    // slave address, start address, number of points
            foreach (var item in data)      // read data
            {
                Console.WriteLine(item);    // dispaly data item
            }
        }

      
    }
}
