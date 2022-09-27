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
using Modbus.Device;

namespace GUI_ModBus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private byte SlaveId = 10;
        private ushort Address = 7999;
        private ushort Quentity = 4;
        private SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
               // SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
                serialPort.PortName = "COM4";
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.Open();
                ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);
              
                SlaveId = Convert.ToByte(txtSlaveId.Text);
                Address = Convert.ToUInt16(txtAddress.Text);
                Quentity =Convert.ToUInt16(txtQuentity.Text);
                var data= master.ReadInputs(SlaveId, Address, Quentity);    // read inputs
                progressBar2.Value = 100;
                string[] ReadData;
                int i = 0;
                foreach (var item in data)
                {
                    //MessageBox.Show(item.ToString());
                    txtReadInput.Text = item.ToString();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)  // open connection
        {
            // SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
            serialPort.PortName = txtPort.Text;
            serialPort.BaudRate = Convert.ToInt32(txtBaudRate.Text);
            serialPort.DataBits = Convert.ToInt32(txtDataBit.Text);
            serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), combParitybit.Text);
            serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), combStopBit.Text);
            serialPort.Open();
            progressBar1.Value = 100;
            this.btnOpen.Enabled = false;
            //serialPort.PortName = "COM4";
            //serialPort.BaudRate = 9600;
            //serialPort.DataBits = 8;
            //serialPort.Parity = Parity.None;
            //serialPort.StopBits = StopBits.One;
            //serialPort.Open();
            ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(serialPort.IsOpen)
            {
                serialPort.Close();
                //MessageBox.Show("Connection is Close");
                progressBar1.Value = 0;
                this.btnOpen.Enabled = true;
            }
        }
    }
}
