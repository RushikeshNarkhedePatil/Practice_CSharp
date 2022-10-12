using System;
using Modbus;
using System.IO;
using System.IO.Ports;
using Modbus.Device;
using System.Net.Sockets;
using System.Threading;
using System.Timers;
using System.Text;

namespace NModBusDemo
{
    class Program
    {
        private bool[] value = { true, false, false, false };
        private  SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.

        private static object master;
        //public ushort[] ReadWriteMultipleRegisters(byte slaveAddress, ushort startReadAddress, ushort numberOfPointsToRead, ushort startWriteAddress, ushort[] writeData);
        static System.Threading.Timer timer;


        internal static void Run()
        {
            int Seconds = 5 * 1000;
            var Timer = new System.Threading.Timer(TimerMethod, null, 0, Seconds);
            Console.ReadKey();
        }
        private static void TimerMethod(object o)
        {
                Console.WriteLine("Jay Ganesh");
        }
        static void Main(string[] args)
        {

            //System.Threading.TimerCallback cb = new System.Threading;
            //ushort[] writeData;
            //SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
            //serialPort.PortName = "COM4";
            //serialPort.BaudRate = 9600;
            //serialPort.DataBits = 8;
            //serialPort.Parity = Parity.None;
            //serialPort.StopBits = StopBits.One;
            //serialPort.Open();
            //ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);

            Run();
            //bool[] value = { true, false, false, false };
            //var data= master.ReadInputs(10, 7999, 4);    // read inputs
            //var data = master.ReadCoils(10, 3999, 4);    // read Coil
            try
            {
                ushort[] writeData;
                SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
                serialPort.PortName = "COM4";
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.Open();
                ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);

                //var data = master.ReadInputs(10, 7999, 4);    // read Coil
                var data = master.ReadCoils(10, 3999, 4);
                foreach (var item in data)      // read data
                {
                    Console.WriteLine("{0}", item);    // dispaly data item
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }


            //bool[] data = { true, false, true, true };      // multiple file read karaychya asalyas tyala bool array of data pass karava lagto. true : on false : off
            //master.WriteSingleCoil(10, 3999,false);     // write single coil
            //master.WriteMultipleCoils(10, 3999, data);


        }
    }
}
