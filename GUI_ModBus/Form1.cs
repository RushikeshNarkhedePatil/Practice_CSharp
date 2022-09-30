﻿using System;
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
        private byte SlaveId = 10;
        private ushort Address = 7999;
        private ushort Quentity = 4;
        private bool WriteCoil=false;
        private bool[] WriteMultiCoil= {false,false,false,false };
        private bool[] ONMultiCoil = { true, true, true, true };
        private SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
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
                if(btnRTU.Checked==true)
                {
                    ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);

                    SlaveId = Convert.ToByte(txtSlaveId.Text);
                    Address = Convert.ToUInt16(txtAddress.Text);
                    Quentity = Convert.ToUInt16(txtQuentity.Text);
                    var data = master.ReadInputs(SlaveId, Address, Quentity);    // read inputs
                    progressBar2.Value = 100;

                    foreach (var item in data)
                    {
                        //MessageBox.Show(item.ToString());
                        //txtReadInput.Text = item.ToString();
                        listView1.Items.Add(item.ToString());
                    }
                    this.btnClearReadInput.Enabled = true;
                }
                else if(btnASCII.Checked==true)
                {
                    try
                    {
                        ModbusSerialMaster master = ModbusSerialMaster.CreateAscii(serialPort);

                        SlaveId = Convert.ToByte(txtSlaveId.Text);
                        Address = Convert.ToUInt16(txtAddress.Text);
                        Quentity = Convert.ToUInt16(txtQuentity.Text);
                        var data = master.ReadInputs(SlaveId, Address, Quentity);    // read inputs
                        progressBar2.Value = 100;

                        foreach (var item in data)
                        {
                            //MessageBox.Show(item.ToString());
                            //txtReadInput.Text = item.ToString();
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

        private void button1_Click(object sender, EventArgs e)  // open connection
        {
            // SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
            try
            {
                btnClose.Enabled = true;
                // Check Mode
                if(btnRTU.Checked==true)
                {
                    // MessageBox.Show("RTU");
                    serialPort.PortName = txtPort.Text;
                    serialPort.BaudRate = Convert.ToInt32(txtBaudRate.Text);
                    serialPort.DataBits = Convert.ToInt32(txtDataBit.Text);
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), combParitybit.Text);
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), combStopBit.Text);
                    serialPort.Open();
                    progressBar1.Value = 100;
                    this.btnOpen.Enabled = false;
                    ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);
                }
                else if(btnASCII.Checked==true)
                {
                    //MessageBox.Show("ASCII");
                    //SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
                    serialPort.PortName = txtPort.Text;
                    serialPort.BaudRate = Convert.ToInt32(txtBaudRate.Text);
                    serialPort.DataBits = Convert.ToInt32(txtDataBit.Text);
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), combParitybit.Text);
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), combStopBit.Text);
                    serialPort.Open();
                    progressBar1.Value = 100;
                    this.btnOpen.Enabled = false;
                    ModbusSerialMaster master = ModbusSerialMaster.CreateAscii(serialPort);
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
        }

        private void btnWriteSingleCoil_Click(object sender, EventArgs e)   // Write Single Coil
        {
            try
            {
                // check Mode
                if(btnRTU.Checked==true)
                {
                    ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);

                    SlaveId = Convert.ToByte(txtWriteId.Text);
                    Address = Convert.ToUInt16(txtWriteAdd.Text);
                    WriteCoil = Convert.ToBoolean(txtWriteData.Text);
                    if(btnOn.Checked==true)
                    {
                        master.WriteSingleCoil(SlaveId, Address, WriteCoil);        // write data
                        listView2.Items.Add(WriteCoil.ToString());
                        progressBar3.Value = 100;
                    }
                    else if(btnOff.Checked==true)
                    {
                        master.WriteSingleCoil(SlaveId, Address, false);
                        listView2.Items.Add(WriteCoil.ToString());
                        progressBar3.Value = 100;
                    }
                    else
                    {
                        MessageBox.Show("Select On or Off option");
                    }
                    btnSingleClear.Enabled = true;
                    //listView2.Items.Add(WriteCoil.ToString());
                    //progressBar3.Value = 100;
                }

                if(btnASCII.Checked==true)
                {
                    ModbusSerialMaster master = ModbusSerialMaster.CreateAscii(serialPort);
                    SlaveId = Convert.ToByte(txtWriteId.Text);
                    Address = Convert.ToUInt16(txtWriteAdd.Text);
                    WriteCoil = Convert.ToBoolean(txtWriteData.Text);
                    if (btnOn.Checked == true)
                    {
                        master.WriteSingleCoil(SlaveId, Address, WriteCoil);        // write data
                        
                        listView2.Items.Add(WriteCoil.ToString());
                        progressBar3.Value = 100;
                    }
                    else if (btnOff.Checked == true)
                    {
                        master.WriteSingleCoil(SlaveId, Address, false);    // off coil
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
                //// Validation Check all information fill or not
                //if (combWriteMulti.Text == "")
                //{
                //    MessageBox.Show("Fill Write Data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //}
                if (btnRTU.Checked==true)            // check Mode
                {
                    ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort);

                    SlaveId = Convert.ToByte(txtWriteMultiId.Text);
                    Address = Convert.ToUInt16(txtMultiAddress.Text);
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
                            master.WriteMultipleCoils(SlaveId, Address, WriteMultiCoil);        // write data
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
                        master.WriteMultipleCoils(SlaveId, Address, ONMultiCoil);        // ON all Coil
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
                            master.WriteMultipleCoils(SlaveId, Address, WriteMultiCoil);        // Off all Coil
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
                    ModbusSerialMaster ASCIImaster = ModbusSerialMaster.CreateAscii(serialPort);

                    if (btnMultiOn.Checked == true)
                    {
                        int i = 0;
                        foreach (ListViewItem item in listView3.Items)
                        {
                            var val = item.Text;
                            WriteMultiCoil[i] = Convert.ToBoolean(val);
                            i++;
                        }
                        ASCIImaster.WriteMultipleCoils(SlaveId, Address, WriteMultiCoil);        // write data
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
                            ASCIImaster.WriteMultipleCoils(SlaveId, Address, WriteMultiCoil);        // Off all Coil
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
