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

        static void Main(string[] args)
        {

            SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
            serialPort.PortName = "COM4";
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.Open();
            if(!serialPort.IsOpen)
            {
                serialPort.Close();
            }
            ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);
            //var data= master.ReadInputs(10, 7999, 4);    // read inputs
            //bool[] data = { true, false, true, true };      // multiple file read karaychya asalyas tyala bool array of data pass karava lagto. true : on false : off
            //master.WriteSingleCoil(10, 3999,false);     // write single coil
            //master.WriteMultipleCoils(10, 3999, data);
            //foreach (var item in data)      // read data
            //{
            //    Console.WriteLine(item);    // dispaly data item
            //}


        }
    }
}
