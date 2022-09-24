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

        static void Main(string[] args)
        {

            //// NModBus Demo
            //SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
            //serialPort.PortName = "COM1";
            //serialPort.BaudRate = 115200;
            //serialPort.DataBits = 8;
            //serialPort.Parity = Parity.None;
            //serialPort.StopBits = StopBits.One;
            //serialPort.Open();
            //ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);
            // NModBus Demo
            SerialPort port = new SerialPort("COM1");

            // configure serial port
            port.BaudRate = 9600;
            port.DataBits = 8;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
            port.Open();

            // create modbus master
            IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);

            byte slaveId = 1;
            ushort startAddress = 1;
            ushort numRegisters = 4;

            // read five registers
            ushort[] registers = master.ReadHoldingRegisters(slaveId, startAddress, numRegisters);

            for (int i = 0; i < numRegisters; i++)
                Console.WriteLine("Register {0}={1}", startAddress + i, registers[i]);

           slaveId = 1;
           startAddress = 1;

            // write three coils
            master.WriteMultipleCoils(slaveId, startAddress, new bool[] { true, false, true });

        }
    }
}
