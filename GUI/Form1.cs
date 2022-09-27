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
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
                serialPort.PortName = "COM4";
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.Open();
                ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
                serialPort.PortName = "COM4";
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.Open();
                ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);
                //var data = master.ReadInputs(10, 7999, 4);    // read inputs
                bool[] data = { true, true, false, false };      // multiple file read karaychya asalyas tyala bool array of data pass karava lagto. true : on false : off
                //master.WriteSingleCoil(10, 3999,false);     // write single coil
                master.WriteMultipleCoils(10, 3999, data);

                foreach (var item in data)
                {
                    //dataGridView1.DataSource = item;
                    
                    txtbox1.Text = item.ToString();
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRead_Click_1(object sender, EventArgs e)
        {
            SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
            serialPort.PortName = "COM4";
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.Open();
            ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);
            var data = master.ReadInputs(10, 7999, 4);    // read inputs
            
            for(int i=0;i<data.Length;i++)
            {
                 string arr=txtbox1.Text=data[i].ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ColumnCount = 3;

            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Age";
            dataGridView1.Columns[2].Name = "City";

            dataGridView1.Rows.Add("kathir", "25", "salem");
            dataGridView1.Rows.Add("vino", "24", "attur");
            dataGridView1.Rows.Add("maruthi", "26", "dharmapuri");
            dataGridView1.Rows.Add("arun", "27", "chennai");
        }
    }
}
