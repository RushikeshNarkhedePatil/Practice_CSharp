using System;
using System.Net.Sockets;
using Modbus.Device;
using System.Threading;
using System.IO.Ports;

namespace NModBusDemo
{
    // Test Driver
    class Demo
    {
        private int invokeCount;
        private int maxCount;
        private SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
        public void DisplayCoil()
        {
            try
            {
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
        }
        public Demo()
        {
            //try
            //{
            //    using (TcpClient client = new TcpClient("127.0.0.1", 502))
            //    {
            //        client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);

            //        var master = ModbusIpMaster.CreateIp(client);
            //        read five input values
            //        ushort startAddress = 100;
            //        ushort numInputs = 5;
            //        bool[] inputs = master.ReadInputs(startAddress, numInputs);

            //        for (int i = 0; i < numInputs; i++)
            //        {
            //            Console.WriteLine($"Input {(startAddress + i)}={(inputs[i] ? 1 : 0)}");
            //        }

            //        while (true)
            //        {
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            serialPort.PortName = "COM4";
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.Open();
            bool[] value = { true, false, false, false };
            ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);
            DisplayCoil();
            invokeCount = 0;
            //maxCount = count;
        }
    }
}
