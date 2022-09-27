using System;

namespace NModBusPractice
{
    internal class SerialPort
    {
        public string PortName { get; internal set; }
        public int BaudRate { get; internal set; }
        public int DataBits { get; internal set; }
        public object Parity { get; internal set; }
        public object StopBits { get; internal set; }
        public bool IsOpen { get; internal set; }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}