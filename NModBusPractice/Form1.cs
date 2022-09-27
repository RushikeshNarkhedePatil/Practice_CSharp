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
        SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
        private static object master;

        //public object SerialPorts { get; private set; }

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
            //SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
            //serialPort.PortName = "COM4";
            //serialPort.BaudRate = 9600;
            //serialPort.DataBits = 8;
            //serialPort.Parity = Parity.None;
            //serialPort.StopBits = StopBits.One;
            //serialPort.Open();
            //ModbusSerialMaster master = ModbusSerialMaster.CreateRtu((Modbus.IO.IStreamResource)serialPort);
            //var data = master.ReadInputs(10, 7999, 4);    // slave address, start address, number of points
            //foreach (var item in data)      // read data
            //{
            //    Console.WriteLine(item);    // dispaly data item
            //}
            //var port = combPort.Text;
            //var baud=Convert.ToInt32(combBuildRate.Text);
            //var data1= Convert.ToInt32(combDataBit.Text);
            //var stop = (stop)Enum.Parse(typeof(stop), combStopBit.Text);
            //var parity=combParityBit.Text;
            try
            {
                SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
                serialPort.PortName = combPort.Text;
                serialPort.BaudRate = Convert.ToInt32(combBuildRate.Text);
                serialPort.DataBits = Convert.ToInt32(combDataBit.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), combParityBit.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), combStopBit.Text);
                serialPort.Open();
                if(!serialPort.IsOpen)
                {
                    MessageBox.Show("Connection is not open");
                }
                progressBar1.Value = 100;
                //ModbusSerialMaster master = ModbusSerialMaster.CreateRtu((Modbus.IO.IStreamResource)serialPort);
                ////var data = master.ReadInputs(10, 7999, 4);    // slave address, start address, number of points
                //bool[] data = { true, false, true, true };
                //master.WriteMultipleCoils(10, 3999, data);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
           
            if (!serialPort.IsOpen) ;
            {
                //serialPort.Close();
                progressBar1.Value = 0;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void combPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string SerialPorts = "9600";
            // MessageBox.Show(combPort.SelectedItem.ToString());
            //var port = combPort.SelectedItem.ToString();    // port number
        }

       
    }
}
