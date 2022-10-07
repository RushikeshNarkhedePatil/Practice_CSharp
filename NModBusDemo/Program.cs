using System;
using Modbus;
using System.IO;
using System.IO.Ports;
using Modbus.Device;
using System.Net.Sockets;

namespace NModBusDemo
{
    class Program
    {
        private static object master;
          //public ushort[] ReadWriteMultipleRegisters(byte slaveAddress, ushort startReadAddress, ushort numberOfPointsToRead, ushort startWriteAddress, ushort[] writeData);

        static void Main(string[] args)
        {
            ushort[] writeData;
            SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
            serialPort.PortName = "COM4";
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.Open();
            bool[] value = { true, false, false, false };
            ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);
            //var data= master.ReadInputs(10, 7999, 4);    // read inputs
            //var data = master.ReadCoils(10, 3999, 4);    // read Coil
            try
            {
                //var data = master.ReadInputs(10, 7999, 4);    // read Coil
                var data = master.WriteSingleCoilAsync(10, 3999,true);
                //foreach (var item in data)      // read data
                //{
                //    Console.WriteLine("{0}", item);    // dispaly data item
                //}
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
