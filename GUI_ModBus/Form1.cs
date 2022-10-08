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

namespace GUI_ModBus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Modbus.Device.IModbusSerialMaster masterRtu, masterAscii;
        private byte SlaveId = 10;
        private ushort Address = 3999;      //7999 add kel hot adhi
        private ushort Quentity = 4;
        private bool WriteCoil=false;
        private bool ParityStatus = false;
        private bool[] WriteMultiCoil= {false,false,false,false };
        private bool[] ONMultiCoil = { true, true, true, true };
        private bool[] ReadCoilData = { false, false, false, false };
        private SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
        private bool CheckParity()
        {
            if(serialPort.Parity!=Parity.None)
            {
                MessageBox.Show("Parity bit is Not Supported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
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
                        ReadCoilData = masterRtu.ReadCoils(SlaveId, Address, Quentity);    // read inputs
                    }
                    else if(btnInput.Checked==true)
                    {
                        ReadCoilData = masterRtu.ReadInputs(SlaveId, Address, Quentity);    // read inputs
                    }
                    progressBar2.Value = 100;

                    foreach (var item in ReadCoilData)
                    {
                        listView1.Items.Add(item.ToString());
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenConnection(object sender, EventArgs e)  // open connection
        {
            try
            {
                btnClose.Enabled = true;
                // set SerialPort object property to open connection
                serialPort.PortName = txtPort.Text;
                serialPort.BaudRate = Convert.ToInt32(txtBaudRate.Text);
                serialPort.DataBits = Convert.ToInt32(txtDataBit.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), combParitybit.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), combStopBit.Text);
                //serialPort.Open();
                ParityStatus = CheckParity();
                // Check Mode
                if ((btnRTU.Checked==true)&&(ParityStatus==true))
                {
                    serialPort.Open();
                    progressBar1.Value = 100;
                    this.btnOpen.Enabled = false;
                    masterRtu = ModbusSerialMaster.CreateRtu(serialPort);
                }
                else if((btnASCII.Checked==true) && (ParityStatus == true))
                {
                    serialPort.Open();
                    progressBar1.Value = 100;
                    this.btnOpen.Enabled = false;
                    masterAscii = ModbusSerialMaster.CreateAscii(serialPort);
                }
                else if(btnASCII.Checked==false&&btnRTU.Checked==false)
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
                // check Mode
                if (btnRTU.Checked==true)
                {
                    masterRtu = ModbusSerialMaster.CreateRtu(serialPort);

                    //SlaveId = Convert.ToByte(txtWriteId.Text);
                    //Address = Convert.ToUInt16(txtWriteAdd.Text);
                    //WriteCoil = Convert.ToBoolean(txtWriteData.Text);
                    if(btnOn.Checked==true)
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

                if(btnASCII.Checked==true)
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
                            //foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                            //{
                            //    Console.WriteLine($"\tSubitem:{subitem.Text}");
                            //}
                        }
              
                        if(listView3.Items.Count!=0)
                        {
                            masterRtu.WriteMultipleCoils(SlaveId, Address, WriteMultiCoil);        // write data
                                                                                                // listView2.Items.Add(WriteCoil.ToString());
                            progressBar4.Value = 100;
                        }
                        else
                        {
                            MessageBox.Show("Add Data true or false to On OFF the Coil. true means ON and false means OFF", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                       
                    }
                    else if(btnMultiOn.Checked==true)
                    { 
                        masterRtu.WriteMultipleCoils(SlaveId, Address, ONMultiCoil);        // ON all Coil
                        progressBar4.Value = 100;
                    }
                    else if (btnMultiOff.Checked == true)       // off all coil
                    {
                        DialogResult DialogResult = MessageBox.Show("Off all Coil", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                        if(DialogResult==DialogResult.Yes)
                        {
                            // master.WriteMultipleCoils(SlaveId, Address, OffMultiCoil);        // Off all Coil
                            int i = 0;
                            foreach (ListViewItem item in listView3.Items)
                            {
                                var val = item.Text;
                                WriteMultiCoil[i] = false;  
                                i++;
                            }
                            masterRtu.WriteMultipleCoils(SlaveId, Address, WriteMultiCoil);        // Off all Coil
                            listView3.Items.Clear();        // Remove all items
                            progressBar4.Value = 0;
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
                var ErrCode = err.Message;
<<<<<<< HEAD
                if(ErrCode== "Function code 63 not supported.")
                {
                    MessageBox.Show("Function Code Not Supported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                Console.WriteLine(ErrCode);
=======
                if (ErrCode == "Function code 63 not supported.")
                {
                    MessageBox.Show("Not Supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
>>>>>>> Rushikesh
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
