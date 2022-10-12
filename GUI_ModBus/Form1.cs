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
using System.IO;
using System.Threading;

namespace GUI_ModBus
{
    public partial class Form1 : Form
    {
        private readonly SynchronizationContext synchronizationContext;
        private DateTime dt = DateTime.Now;
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            synchronizationContext = SynchronizationContext.Current;
        }
        private Modbus.Device.IModbusSerialMaster masterRtu, masterAscii;
        private byte SlaveId = 10;
        private ushort Address = 3999;      //7999 add kel hot adhi
        private ushort Quentity = 4;
        private bool WriteCoil=false;
        private bool ParityStatus = false;
        private bool SingleCoilStatus=false;
        private int SingleCoilPosition = 0;
        private short CoilCount = 1;
        private short InputCount = 1;
        private int MultiCoilPosition = 0;
        private string dataBitStatus;
        private bool[] WriteMultiCoil= {false,false,false,false };
        private bool[] ONMultiCoil = { true, true, true, true };
        private bool[] ReadCoilData = { false, false, false, false };
        private bool[] ReadInputData = { false, false, false, false };
        private SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
        private bool CheckParity()
        {
            //MessageBox.Show(serialPort.DataBits.ToString());
            if (serialPort.Parity!=Parity.None)
            {
                MessageBox.Show("Parity bit is Not Supported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        private string CheckDataBits()
        {
            var dataBits = serialPort.DataBits.ToString();    // check data bit 
            if(dataBits=="8")
            {
                return "Rtu";
            }
            else if(dataBits=="7")
            {
                return "Ascii";
            }
            else
            {
                MessageBox.Show("Check Data Bit","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            return "Different Mode";
        }
        //add for testing and display result continueosly on Screen
        private void AutoCoilStatus()
        {
            
            TimerCallback timeCB = new TimerCallback(PrintCoil);
            System.Threading.Timer t = new System.Threading.Timer(
            timeCB,   // The TimerCallback delegate type.
            "Hi",     // Any info to pass into the called method.
            0,        // Amount of time to wait before starting.
            3000);
        }

        void PrintCoil(object state)
        {
            ReadCoilData = masterRtu.ReadCoils(SlaveId, Address, Quentity);
            
            //Console.WriteLine("Time is: {0}, Param is: {1}", DateTime.Now.ToLongTimeString(), state.ToString());
            if (this.listView4.InvokeRequired)
            {
                CoilCount = 1;
                InputCount = 1;
                //ReadCoilData = masterRtu.ReadCoils(SlaveId, Address, Quentity);
                foreach (var item in ReadCoilData)
                {
                    listView4.Invoke((MethodInvoker)(() => listView4.Items.Add("Coil " + CoilCount + " " + item.ToString())));

                    CoilCount++;
                }
                if (listView4.Items.Count >= 5)
                {
                    listView4.Invoke((MethodInvoker)(() => listView4.Items.Clear()));
                    CoilCount = 1;
                }

            }
           // ReadInputData = masterRtu.ReadInputs(SlaveId, Address, Quentity);
            //if (this.listView5.InvokeRequired)
            //{
            //    InputCount = 1;
            //    //ReadCoilData = masterRtu.ReadCoils(SlaveId, Address, Quentity);
            //    foreach (var item in ReadInputData)
            //    {
            //        listView5.Invoke((MethodInvoker)(() => listView5.Items.Add("Input " + InputCount + " " + item.ToString())));

            //        InputCount++;
            //    }
            //    if (listView5.Items.Count >= 5)
            //    {
            //        listView5.Invoke((MethodInvoker)(() => listView5.Items.Clear()));
            //        CoilCount = 1;
            //    }
            //    if (listView5.Items.Count >= 5)
            //    {
            //        listView5.Invoke((MethodInvoker)(() => listView5.Items.Clear()));
            //        InputCount = 1;
            //    }

            //}

        }
        //end of auto display method
        private bool CheckSingleCoilStatus()
        {
            if (WriteCoil == true)
            {
                //MessageBox.Show("Already Coil On");
                return true;
            }
            else
            {
                return false;
            }
        }
        //private bool CheckMultiCoilStatus()
        //{
        //    int i = 0;
        //    CoilCount = 1;
        //    foreach (var item in ReadCoilData)
        //    {
        //        if((btncheckCoil1.Checked==true|| btncheckCoil2.Checked == true || btncheckCoil3.Checked == true || btncheckCoil4.Checked == true) && (item==true))
        //        {
        //            MessageBox.Show($"Coil{CoilCount} alreay On");
        //        }
        //        else
        //        {
                   
        //        }
        //        CoilCount++;
        //    }
        //    return true;
        //}
        private int CheckSingleCoilPosition()
        {
            if(btnCoil1.Checked==true)
            {
                return 0;   // coil 1
            }
            else if (btnCoil2.Checked == true)
            {
                return 1;
            }
            else if (btnCoil3.Checked == true)
            {
                return 2;
            }
            else if (btnCoil4.Checked == true)
            {
                return 3;
            }
            else
            {
                return -1;  
            }
        }
        private void DisplayMultiCoil()
        {
            CoilCount = 1;
            foreach (var item in WriteMultiCoil)        // display result in listview
            {
                listView3.Items.Add("Coil" + CoilCount + "  " + item.ToString());
                CoilCount++;
            }
        }
        private void OnMultiCoil()
        {
            // Test Output
            //WriteMultiCoil = ReadCoilData;
            //foreach (var item in WriteMultiCoil)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            if(btncheckCoil1.Checked==true|| btncheckCoil2.Checked == true|| btncheckCoil3.Checked == true|| btncheckCoil4.Checked == true)
            {
                if (btncheckCoil1.Checked == true)
                {
                    WriteMultiCoil[0] = true;
                }
                if (btncheckCoil2.Checked == true)
                {
                    WriteMultiCoil[1] = true;
                }
                if (btncheckCoil3.Checked == true)
                {
                    WriteMultiCoil[2] = true;
                }
                if (btncheckCoil4.Checked == true)
                {
                    WriteMultiCoil[3] = true;
                }
                DisplayMultiCoil();        
                masterRtu.WriteMultipleCoils(SlaveId, Address, WriteMultiCoil);
                progressBar4.Value = 100;
                AutoCoilStatus();
            }
            else
            {
                MessageBox.Show("Select Coil Position", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void OffMultiCoil()
        {
            if(btncheckCoil1.Checked == true || btncheckCoil2.Checked == true || btncheckCoil3.Checked == true || btncheckCoil4.Checked == true)
            {
                if (btncheckCoil1.Checked == true)
                {
                    WriteMultiCoil[0] = false;
                }
                if (btncheckCoil2.Checked == true)
                {
                    WriteMultiCoil[1] = false;
                }
                if (btncheckCoil3.Checked == true)
                {
                    WriteMultiCoil[2] = false;
                }
                if (btncheckCoil4.Checked == true)
                {
                    WriteMultiCoil[3] = false;
                }
                masterRtu.WriteMultipleCoils(SlaveId, Address, WriteMultiCoil);        // Off all Coil
                DisplayMultiCoil();     // display result 
                AutoCoilStatus();
            }
            else
            {
                MessageBox.Show("Select Coil Position", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                // SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
                //serialPort.PortName = "COM4";
                //serialPort.BaudRate = 9600;
                //serialPort.DataBits = 8;
                //serialPort.Parity = Parity.None;
                //serialPort.StopBits = StopBits.One;
                //serialPort.Open();
                masterRtu = ModbusSerialMaster.CreateRtu(serialPort);

                SlaveId = Convert.ToByte(txtSlaveId.Text);
                //Address = Convert.ToUInt16(txtAddress.Text);
                Address = Convert.ToUInt16(combReadAddress.Text);
                Quentity = Convert.ToUInt16(txtQuentity.Text);

                if (btnRTU.Checked==true)
                {
                    //var data = masterRtu.ReadCoils(SlaveId, Address, Quentity);    // read inputs
                    // Check Read Coil or Inputs
                    
                    if(btnCoil.Checked==true)
                    {
                        ReadCoilData = masterRtu.ReadCoils(SlaveId, Address, Quentity);    // read Coil
                    }
                    else if(btnInput.Checked==true)
                    {
                        ReadCoilData = masterRtu.ReadInputs(SlaveId, Address, Quentity);    // read inputs
                    }
                    progressBar2.Value = 100;
                    CoilCount = 1;
                    foreach (var item in ReadCoilData)
                    {
                        listView1.Items.Add("Coil" + CoilCount + "  " + item.ToString());
                        CoilCount++;
                    }
                    this.btnClearReadInput.Enabled = true;
                }
                else if(btnASCII.Checked==true)
                {
                    try
                    {
                        var data = masterAscii.ReadCoils(SlaveId, Address, Quentity);    // read inputs
                        progressBar2.Value = 100;

                        foreach (var item in data)
                        {
                            listView1.Items.Add(item.ToString());
                        }
                        this.btnClearReadInput.Enabled = true;
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                }
              
            }
            catch (Exception ex)
            {
                int val = Convert.ToInt32(txtQuentity.Text);    // check value less than 4 or not 
                if (val>=5)
                {
                    MessageBox.Show("Only 4 Register , Please specify Range between 1 to 4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenConnection(object sender, EventArgs e)  // open connection
        {
           
            void OpenConAscii()
            {
                try
                {
                    serialPort.Open();
                    progressBar1.Value = 100;
                    this.btnOpen.Enabled = false;
                    
                    masterAscii = ModbusSerialMaster.CreateAscii(serialPort);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            void OpenConRtu()
            {
                try
                {
                    serialPort.Open();
                    progressBar1.Value = 100;
                    this.btnOpen.Enabled = false;
                    masterRtu = ModbusSerialMaster.CreateRtu(serialPort);
                    //Thread threadCoilStatus = new Thread(AutoCoilStatus);
                    //threadCoilStatus.Start();
                    AutoCoilStatus();       // Display automatic coil on off status
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            try
            {
                btnClose.Enabled = true;
                // set SerialPort object property to open connection
                serialPort.PortName = txtPort.Text;
                serialPort.BaudRate = Convert.ToInt32(txtBaudRate.Text);
                serialPort.DataBits = Convert.ToInt32(txtDataBit.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), combParitybit.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), combStopBit.Text);
                ParityStatus = CheckParity();
                //dataBitStatus = CheckDataBits();
                // Check Mode
                //if ((btnRTU.Checked==true)&&(ParityStatus==true)&&(dataBitStatus=="Rtu"))
                if ((btnRTU.Checked == true) && (ParityStatus == true))
                {
                    OpenConRtu();
                }
                //else if((btnASCII.Checked==true) && (ParityStatus == true) && (dataBitStatus =="Ascii"))
                else if ((btnASCII.Checked == true) && (ParityStatus == true))
                {
                    OpenConAscii();
                }
                else
                {
                    MessageBox.Show("Select Mode","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(serialPort.IsOpen)
            {
                serialPort.Close();
                //MessageBox.Show("Connection is Close");
                progressBar1.Value = 0;
                this.btnClose.Enabled = false;
                this.btnOpen.Enabled = true;
            }
            else
            {
                btnOpen.Enabled = true;
                MessageBox.Show("Connection is already close", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnWriteSingleCoil_Click(object sender, EventArgs e)   // Write Single Coil
        {
            try
            {
                SlaveId = Convert.ToByte(txtWriteId.Text);
                Address = Convert.ToUInt16(txtWriteAdd.Text);
                WriteCoil = Convert.ToBoolean(txtWriteData.Text);
                SingleCoilPosition = CheckSingleCoilPosition();     // check coil position status
                AutoCoilStatus();
                SingleCoilStatus = CheckSingleCoilStatus();
                for (int i = 0; i < SingleCoilPosition; i++)        // find coil position
                {
                    Address++;
                }
                //Address = Convert.ToUInt16(Address-1);
                // check Mode
                if(SingleCoilPosition==-1)          // filter
                {
                    MessageBox.Show("Please Select Coil Position", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //else if (SingleCoilStatus == true)     //fillter to check coil already on or not
                //{
                //    MessageBox.Show("Coil is already ON", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                else if (btnRTU.Checked==true)
                {
                    masterRtu = ModbusSerialMaster.CreateRtu(serialPort);
                    if (btnOn.Checked==true)
                    {
                        masterRtu.WriteSingleCoil(SlaveId, Address, WriteCoil);        // write data
                        listView2.Items.Add(WriteCoil.ToString());
                         //listView2.Items.Add("Address : " + Address + " " + WriteCoil.ToString());
                        progressBar3.Value = 100;
                    }
                    else if(btnOff.Checked==true)
                    {
                        masterRtu.WriteSingleCoil(SlaveId, Address, false);
                        listView2.Items.Add("false");
                        //listView2.Items.Add("Address : " + Address + " " + WriteCoil.ToString());
                        progressBar3.Value = 100;
                    }
                    else
                    {
                        MessageBox.Show("Select On or Off option");
                    }
                    btnSingleClear.Enabled = true;
                }

                else if(btnASCII.Checked==true)
                {
                     masterAscii = ModbusSerialMaster.CreateAscii(serialPort);
                    //SlaveId = Convert.ToByte(txtWriteId.Text);
                    //Address = Convert.ToUInt16(txtWriteAdd.Text);
                    //WriteCoil = Convert.ToBoolean(txtWriteData.Text);
                    if (btnOn.Checked == true)
                    {
                        masterAscii.WriteSingleCoil(SlaveId, Address, WriteCoil);        // write data
                        
                        listView2.Items.Add(WriteCoil.ToString());
                        progressBar3.Value = 100;
                    }
                    else if (btnOff.Checked == true)
                    {
                        masterAscii.WriteSingleCoil(SlaveId, Address, false);    // off coil
                    }
                    else
                    {
                        MessageBox.Show("Select On or Off option");
                    }
                    //master.WriteSingleCoil(SlaveId, Address, WriteCoil);        // write data
                    listView2.Items.Add(WriteCoil.ToString());
                    progressBar3.Value = 100;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteMultiCoil_Click(object sender, EventArgs e)    // write multiple Coil
        {
            try
            {

                if (!serialPort.IsOpen)      // check Connection Open Or Not
                {
                    MessageBox.Show("Connection is Not Open Please establish Connection", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SlaveId = Convert.ToByte(txtWriteMultiId.Text);
                Address = Convert.ToUInt16(txtMultiAddress.Text);

                if (btnRTU.Checked==true)            // check Mode
                {
                     masterRtu = ModbusSerialMaster.CreateRtu(serialPort);

                    //SlaveId = Convert.ToByte(txtWriteMultiId.Text);
                    //Address = Convert.ToUInt16(txtMultiAddress.Text);
                    // Check Button On Off Control
                    if (btnMultiOnOff.Checked == true)                      // ON OFF Specific Coil 
                    {
                        // WriteCoil = Convert.ToBoolean(txtWriteData.Text);
                        int i = 0;
                        foreach (ListViewItem item in listView3.Items)
                        {
                            Console.WriteLine($"Item: {item.Text}");
                            var val = item.Text;
                            WriteMultiCoil[i] = Convert.ToBoolean(val);
                            i++;
                        }
                        masterRtu.WriteMultipleCoils(SlaveId, Address, WriteMultiCoil);        // write data                                                                    
                        progressBar4.Value = 100;
                        //if (listView3.Items.Count!=0)
                        //{
                        //    masterRtu.WriteMultipleCoils(SlaveId, Address, WriteMultiCoil);        // write data
                        //                                                                        // listView2.Items.Add(WriteCoil.ToString());
                        //    progressBar4.Value = 100;
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Add Data true or false to On OFF the Coil. true means ON and false means OFF", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                       
                    }
                    else if(btnMultiOn.Checked==true)
                    {
                        //masterRtu.WriteMultipleCoils(SlaveId, Address, ONMultiCoil);        // ON all Coil
                        //CheckMultiCoilStatus();
                        OnMultiCoil();       // check coil position
                        //masterRtu.WriteMultipleCoils(SlaveId, Address, WriteMultiCoil);
                        //progressBar4.Value = 100;
                    }
                    else if (btnMultiOff.Checked == true)       // off all coil
                    {
                        DialogResult DialogResult = MessageBox.Show("Off all Coil", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                        if(DialogResult==DialogResult.Yes)
                        {
                            // master.WriteMultipleCoils(SlaveId, Address, OffMultiCoil);        // Off all Coil
                            OffMultiCoil();       // check coil position
                            //int i = 0;
                            //foreach (ListViewItem item in listView3.Items)
                            //{
                            //    var val = item.Text;
                            //    WriteMultiCoil[i] = false;  
                            //    i++;
                            //}
                            //masterRtu.WriteMultipleCoils(SlaveId, Address, WriteMultiCoil);        // Off all Coil
                            //listView3.Items.Clear();        // Remove all items
                            //progressBar4.Value = 0;
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Select Value On Or Off", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if(btnASCII.Checked==true)
                {
                    masterAscii = ModbusSerialMaster.CreateAscii(serialPort);

                    if (btnMultiOn.Checked == true)
                    {
                        int i = 0;
                        foreach (ListViewItem item in listView3.Items)
                        {
                            var val = item.Text;
                            WriteMultiCoil[i] = Convert.ToBoolean(val);
                            i++;
                        }
                        masterAscii.WriteMultipleCoils(SlaveId, Address, WriteMultiCoil);        // write data
                        // listView2.Items.Add(WriteCoil.ToString());
                        progressBar4.Value = 100;

                    }
                    else if (btnMultiOff.Checked == true)
                    {
                        DialogResult DialogResult = MessageBox.Show("Off all Coil", "Message", MessageBoxButtons.YesNo);
                        if (DialogResult == DialogResult.Yes)
                        {
                            // master.WriteMultipleCoils(SlaveId, Address, OffMultiCoil);        // Off all Coil
                            int i = 0;
                            foreach (ListViewItem item in listView3.Items)
                            {
                                var val = item.Text;
                                WriteMultiCoil[i] = false;
                                i++;
                            }
                            masterAscii.WriteMultipleCoils(SlaveId, Address, WriteMultiCoil);        // Off all Coil
                            listView3.Items.Clear();        // Remove all items
                            progressBar4.Value = 0;
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
               
            }
            catch (Exception err)
            {
                if (listView3.Items.Count == 5)
                {
                    MessageBox.Show("Only Add Less than 4 Values , Because Only four coils are available , Clear list and try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listView3.Items.Clear();    // Remove all items
            progressBar4.Value = 0;
        }

        private void btnClearReadInput_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            this.btnClearReadInput.Enabled = false;
            progressBar2.Value = 0;
        }

        private void btnSingleClear_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            this.btnSingleClear.Enabled = false;
        }

        private void combWriteMulti_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView3.Items.Add(combWriteMulti.Text);   // add data item in listview
        }
    }
}
