
namespace GUI_ModBus
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combReadAddress = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnInput = new System.Windows.Forms.RadioButton();
            this.btnCoil = new System.Windows.Forms.RadioButton();
            this.btnClearReadInput = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtQuentity = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtSlaveId = new System.Windows.Forms.TextBox();
            this.lblQuentity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupMode = new System.Windows.Forms.GroupBox();
            this.btnASCII = new System.Windows.Forms.RadioButton();
            this.btnRTU = new System.Windows.Forms.RadioButton();
            this.combParitybit = new System.Windows.Forms.ComboBox();
            this.combStopBit = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbtBaud = new System.Windows.Forms.Label();
            this.lblComPort = new System.Windows.Forms.Label();
            this.txtDataBit = new System.Windows.Forms.TextBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSingleClear = new System.Windows.Forms.Button();
            this.groupValue = new System.Windows.Forms.GroupBox();
            this.btnOff = new System.Windows.Forms.RadioButton();
            this.btnOn = new System.Windows.Forms.RadioButton();
            this.btnWriteSingleCoil = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtWriteData = new System.Windows.Forms.TextBox();
            this.txtWriteAdd = new System.Windows.Forms.TextBox();
            this.txtWriteId = new System.Windows.Forms.TextBox();
            this.lblWriteQuentity = new System.Windows.Forms.Label();
            this.lblWriteAddress = new System.Windows.Forms.Label();
            this.lblWriteId = new System.Windows.Forms.Label();
            this.GroupBoxWriteMultiple = new System.Windows.Forms.GroupBox();
            this.combWriteMulti = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnMultiOnOff = new System.Windows.Forms.RadioButton();
            this.btnMultiOff = new System.Windows.Forms.RadioButton();
            this.btnMultiOn = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnWriteMultiCoil = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMultiAddress = new System.Windows.Forms.TextBox();
            this.txtWriteMultiId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupMode.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupValue.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.GroupBoxWriteMultiple.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combReadAddress);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.btnClearReadInput);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.txtQuentity);
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Controls.Add(this.txtSlaveId);
            this.groupBox1.Controls.Add(this.lblQuentity);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(444, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read  Input / Coil";
            // 
            // combReadAddress
            // 
            this.combReadAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combReadAddress.FormattingEnabled = true;
            this.combReadAddress.Items.AddRange(new object[] {
            "3999",
            "7999"});
            this.combReadAddress.Location = new System.Drawing.Point(96, 64);
            this.combReadAddress.Name = "combReadAddress";
            this.combReadAddress.Size = new System.Drawing.Size(100, 24);
            this.combReadAddress.TabIndex = 2;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnInput);
            this.groupBox8.Controls.Add(this.btnCoil);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(29, 126);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(154, 52);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Value";
            // 
            // btnInput
            // 
            this.btnInput.AutoSize = true;
            this.btnInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(67, 26);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(54, 20);
            this.btnInput.TabIndex = 0;
            this.btnInput.TabStop = true;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            // 
            // btnCoil
            // 
            this.btnCoil.AutoSize = true;
            this.btnCoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoil.Location = new System.Drawing.Point(6, 26);
            this.btnCoil.Name = "btnCoil";
            this.btnCoil.Size = new System.Drawing.Size(49, 20);
            this.btnCoil.TabIndex = 0;
            this.btnCoil.TabStop = true;
            this.btnCoil.Text = "Coil";
            this.btnCoil.UseVisualStyleBackColor = true;
            // 
            // btnClearReadInput
            // 
            this.btnClearReadInput.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearReadInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearReadInput.Location = new System.Drawing.Point(127, 184);
            this.btnClearReadInput.Name = "btnClearReadInput";
            this.btnClearReadInput.Size = new System.Drawing.Size(69, 36);
            this.btnClearReadInput.TabIndex = 5;
            this.btnClearReadInput.Text = "Clear";
            this.btnClearReadInput.UseVisualStyleBackColor = false;
            this.btnClearReadInput.Click += new System.EventHandler(this.btnClearReadInput_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(207, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(181, 187);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // txtQuentity
            // 
            this.txtQuentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuentity.Location = new System.Drawing.Point(96, 102);
            this.txtQuentity.Name = "txtQuentity";
            this.txtQuentity.Size = new System.Drawing.Size(100, 22);
            this.txtQuentity.TabIndex = 1;
            this.txtQuentity.Text = "4";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 249);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(355, 22);
            this.progressBar2.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(-335, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 174);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Open Connection";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Slave Id :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Slave Id :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Slave Id :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Slave Id :";
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.SystemColors.Control;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(17, 184);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(83, 36);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read Coil";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtSlaveId
            // 
            this.txtSlaveId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlaveId.Location = new System.Drawing.Point(96, 33);
            this.txtSlaveId.Name = "txtSlaveId";
            this.txtSlaveId.Size = new System.Drawing.Size(100, 22);
            this.txtSlaveId.TabIndex = 1;
            this.txtSlaveId.Text = "10";
            // 
            // lblQuentity
            // 
            this.lblQuentity.AutoSize = true;
            this.lblQuentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuentity.Location = new System.Drawing.Point(6, 101);
            this.lblQuentity.Name = "lblQuentity";
            this.lblQuentity.Size = new System.Drawing.Size(56, 16);
            this.lblQuentity.TabIndex = 0;
            this.lblQuentity.Text = "Quentity";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(6, 70);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 16);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(6, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(63, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Slave Id :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupMode);
            this.groupBox2.Controls.Add(this.combParitybit);
            this.groupBox2.Controls.Add(this.combStopBit);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbtBaud);
            this.groupBox2.Controls.Add(this.lblComPort);
            this.groupBox2.Controls.Add(this.txtDataBit);
            this.groupBox2.Controls.Add(this.txtBaudRate);
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Open Connection";
            // 
            // groupMode
            // 
            this.groupMode.Controls.Add(this.btnASCII);
            this.groupMode.Controls.Add(this.btnRTU);
            this.groupMode.Location = new System.Drawing.Point(229, 22);
            this.groupMode.Name = "groupMode";
            this.groupMode.Size = new System.Drawing.Size(153, 59);
            this.groupMode.TabIndex = 5;
            this.groupMode.TabStop = false;
            this.groupMode.Text = "Mode";
            // 
            // btnASCII
            // 
            this.btnASCII.AutoSize = true;
            this.btnASCII.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnASCII.Location = new System.Drawing.Point(67, 25);
            this.btnASCII.Name = "btnASCII";
            this.btnASCII.Size = new System.Drawing.Size(59, 20);
            this.btnASCII.TabIndex = 0;
            this.btnASCII.TabStop = true;
            this.btnASCII.Text = "ASCII";
            this.btnASCII.UseVisualStyleBackColor = true;
            // 
            // btnRTU
            // 
            this.btnRTU.AutoSize = true;
            this.btnRTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRTU.Location = new System.Drawing.Point(6, 26);
            this.btnRTU.Name = "btnRTU";
            this.btnRTU.Size = new System.Drawing.Size(55, 20);
            this.btnRTU.TabIndex = 0;
            this.btnRTU.TabStop = true;
            this.btnRTU.Text = "RTU";
            this.btnRTU.UseVisualStyleBackColor = true;
            // 
            // combParitybit
            // 
            this.combParitybit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combParitybit.FormattingEnabled = true;
            this.combParitybit.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.combParitybit.Location = new System.Drawing.Point(93, 168);
            this.combParitybit.Name = "combParitybit";
            this.combParitybit.Size = new System.Drawing.Size(121, 24);
            this.combParitybit.TabIndex = 4;
            // 
            // combStopBit
            // 
            this.combStopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combStopBit.FormattingEnabled = true;
            this.combStopBit.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.combStopBit.Location = new System.Drawing.Point(91, 131);
            this.combStopBit.Name = "combStopBit";
            this.combStopBit.Size = new System.Drawing.Size(121, 24);
            this.combStopBit.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 248);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(371, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(105, 205);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(11, 205);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(78, 36);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.OpenConnection);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Parity bit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stop bit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data bit";
            // 
            // lbtBaud
            // 
            this.lbtBaud.AutoSize = true;
            this.lbtBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtBaud.Location = new System.Drawing.Point(6, 70);
            this.lbtBaud.Name = "lbtBaud";
            this.lbtBaud.Size = new System.Drawing.Size(72, 16);
            this.lbtBaud.TabIndex = 0;
            this.lbtBaud.Text = "Baud Rate";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComPort.Location = new System.Drawing.Point(6, 35);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(63, 16);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "Com Port";
            // 
            // txtDataBit
            // 
            this.txtDataBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataBit.Location = new System.Drawing.Point(93, 99);
            this.txtDataBit.Name = "txtDataBit";
            this.txtDataBit.Size = new System.Drawing.Size(121, 22);
            this.txtDataBit.TabIndex = 1;
            this.txtDataBit.Text = "8";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaudRate.Location = new System.Drawing.Point(93, 64);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(121, 22);
            this.txtBaudRate.TabIndex = 1;
            this.txtBaudRate.Text = "9600";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(93, 33);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(121, 22);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "COM4";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSingleClear);
            this.groupBox4.Controls.Add(this.groupValue);
            this.groupBox4.Controls.Add(this.btnWriteSingleCoil);
            this.groupBox4.Controls.Add(this.listView2);
            this.groupBox4.Controls.Add(this.progressBar3);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.txtWriteData);
            this.groupBox4.Controls.Add(this.txtWriteAdd);
            this.groupBox4.Controls.Add(this.txtWriteId);
            this.groupBox4.Controls.Add(this.lblWriteQuentity);
            this.groupBox4.Controls.Add(this.lblWriteAddress);
            this.groupBox4.Controls.Add(this.lblWriteId);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(21, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 257);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Write Single Coil";
            // 
            // btnSingleClear
            // 
            this.btnSingleClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnSingleClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleClear.Location = new System.Drawing.Point(111, 179);
            this.btnSingleClear.Name = "btnSingleClear";
            this.btnSingleClear.Size = new System.Drawing.Size(87, 34);
            this.btnSingleClear.TabIndex = 7;
            this.btnSingleClear.Text = "Clear";
            this.btnSingleClear.UseVisualStyleBackColor = false;
            this.btnSingleClear.Click += new System.EventHandler(this.btnSingleClear_Click);
            // 
            // groupValue
            // 
            this.groupValue.Controls.Add(this.btnOff);
            this.groupValue.Controls.Add(this.btnOn);
            this.groupValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupValue.Location = new System.Drawing.Point(6, 131);
            this.groupValue.Name = "groupValue";
            this.groupValue.Size = new System.Drawing.Size(96, 66);
            this.groupValue.TabIndex = 6;
            this.groupValue.TabStop = false;
            this.groupValue.Text = "Value";
            // 
            // btnOff
            // 
            this.btnOff.AutoSize = true;
            this.btnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.Location = new System.Drawing.Point(11, 45);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(42, 20);
            this.btnOff.TabIndex = 0;
            this.btnOff.TabStop = true;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            // 
            // btnOn
            // 
            this.btnOn.AutoSize = true;
            this.btnOn.BackColor = System.Drawing.SystemColors.Control;
            this.btnOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn.Location = new System.Drawing.Point(11, 19);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(43, 20);
            this.btnOn.TabIndex = 0;
            this.btnOn.TabStop = true;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = false;
            // 
            // btnWriteSingleCoil
            // 
            this.btnWriteSingleCoil.BackColor = System.Drawing.SystemColors.Control;
            this.btnWriteSingleCoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteSingleCoil.Location = new System.Drawing.Point(111, 137);
            this.btnWriteSingleCoil.Name = "btnWriteSingleCoil";
            this.btnWriteSingleCoil.Size = new System.Drawing.Size(87, 36);
            this.btnWriteSingleCoil.TabIndex = 5;
            this.btnWriteSingleCoil.Text = "Write";
            this.btnWriteSingleCoil.UseVisualStyleBackColor = false;
            this.btnWriteSingleCoil.Click += new System.EventHandler(this.btnWriteSingleCoil_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(219, 25);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(175, 207);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(11, 229);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(187, 23);
            this.progressBar3.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(-335, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(207, 174);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Open Connection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slave Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Slave Id :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Slave Id :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Slave Id :";
            // 
            // txtWriteData
            // 
            this.txtWriteData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteData.Location = new System.Drawing.Point(96, 96);
            this.txtWriteData.Name = "txtWriteData";
            this.txtWriteData.Size = new System.Drawing.Size(100, 22);
            this.txtWriteData.TabIndex = 1;
            this.txtWriteData.Text = "true";
            // 
            // txtWriteAdd
            // 
            this.txtWriteAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteAdd.Location = new System.Drawing.Point(96, 64);
            this.txtWriteAdd.Name = "txtWriteAdd";
            this.txtWriteAdd.Size = new System.Drawing.Size(100, 22);
            this.txtWriteAdd.TabIndex = 1;
            this.txtWriteAdd.Text = "3999";
            // 
            // txtWriteId
            // 
            this.txtWriteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteId.Location = new System.Drawing.Point(96, 33);
            this.txtWriteId.Name = "txtWriteId";
            this.txtWriteId.Size = new System.Drawing.Size(100, 22);
            this.txtWriteId.TabIndex = 1;
            this.txtWriteId.Text = "10";
            // 
            // lblWriteQuentity
            // 
            this.lblWriteQuentity.AutoSize = true;
            this.lblWriteQuentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteQuentity.Location = new System.Drawing.Point(6, 101);
            this.lblWriteQuentity.Name = "lblWriteQuentity";
            this.lblWriteQuentity.Size = new System.Drawing.Size(71, 16);
            this.lblWriteQuentity.TabIndex = 0;
            this.lblWriteQuentity.Text = "Write Data";
            // 
            // lblWriteAddress
            // 
            this.lblWriteAddress.AutoSize = true;
            this.lblWriteAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteAddress.Location = new System.Drawing.Point(6, 70);
            this.lblWriteAddress.Name = "lblWriteAddress";
            this.lblWriteAddress.Size = new System.Drawing.Size(59, 16);
            this.lblWriteAddress.TabIndex = 0;
            this.lblWriteAddress.Text = "Address";
            // 
            // lblWriteId
            // 
            this.lblWriteId.AutoSize = true;
            this.lblWriteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteId.Location = new System.Drawing.Point(6, 38);
            this.lblWriteId.Name = "lblWriteId";
            this.lblWriteId.Size = new System.Drawing.Size(63, 16);
            this.lblWriteId.TabIndex = 0;
            this.lblWriteId.Text = "Slave Id :";
            // 
            // GroupBoxWriteMultiple
            // 
            this.GroupBoxWriteMultiple.Controls.Add(this.combWriteMulti);
            this.GroupBoxWriteMultiple.Controls.Add(this.groupBox6);
            this.GroupBoxWriteMultiple.Controls.Add(this.btnClear);
            this.GroupBoxWriteMultiple.Controls.Add(this.btnWriteMultiCoil);
            this.GroupBoxWriteMultiple.Controls.Add(this.listView3);
            this.GroupBoxWriteMultiple.Controls.Add(this.progressBar4);
            this.GroupBoxWriteMultiple.Controls.Add(this.groupBox7);
            this.GroupBoxWriteMultiple.Controls.Add(this.txtMultiAddress);
            this.GroupBoxWriteMultiple.Controls.Add(this.txtWriteMultiId);
            this.GroupBoxWriteMultiple.Controls.Add(this.label16);
            this.GroupBoxWriteMultiple.Controls.Add(this.label17);
            this.GroupBoxWriteMultiple.Controls.Add(this.label18);
            this.GroupBoxWriteMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxWriteMultiple.Location = new System.Drawing.Point(444, 319);
            this.GroupBoxWriteMultiple.Name = "GroupBoxWriteMultiple";
            this.GroupBoxWriteMultiple.Size = new System.Drawing.Size(411, 257);
            this.GroupBoxWriteMultiple.TabIndex = 0;
            this.GroupBoxWriteMultiple.TabStop = false;
            this.GroupBoxWriteMultiple.Text = "Write Multiple Coil";
            // 
            // combWriteMulti
            // 
            this.combWriteMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combWriteMulti.FormattingEnabled = true;
            this.combWriteMulti.Items.AddRange(new object[] {
            "false",
            "true"});
            this.combWriteMulti.Location = new System.Drawing.Point(96, 94);
            this.combWriteMulti.Name = "combWriteMulti";
            this.combWriteMulti.Size = new System.Drawing.Size(109, 24);
            this.combWriteMulti.TabIndex = 2;
            this.combWriteMulti.SelectedIndexChanged += new System.EventHandler(this.combWriteMulti_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnMultiOnOff);
            this.groupBox6.Controls.Add(this.btnMultiOff);
            this.groupBox6.Controls.Add(this.btnMultiOn);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(11, 127);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(172, 49);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Value";
            // 
            // btnMultiOnOff
            // 
            this.btnMultiOnOff.AutoSize = true;
            this.btnMultiOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiOnOff.Location = new System.Drawing.Point(103, 19);
            this.btnMultiOnOff.Name = "btnMultiOnOff";
            this.btnMultiOnOff.Size = new System.Drawing.Size(69, 19);
            this.btnMultiOnOff.TabIndex = 2;
            this.btnMultiOnOff.TabStop = true;
            this.btnMultiOnOff.Text = "ON/OFF";
            this.btnMultiOnOff.UseVisualStyleBackColor = true;
            // 
            // btnMultiOff
            // 
            this.btnMultiOff.AutoSize = true;
            this.btnMultiOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiOff.Location = new System.Drawing.Point(55, 18);
            this.btnMultiOff.Name = "btnMultiOff";
            this.btnMultiOff.Size = new System.Drawing.Size(42, 20);
            this.btnMultiOff.TabIndex = 0;
            this.btnMultiOff.TabStop = true;
            this.btnMultiOff.Text = "Off";
            this.btnMultiOff.UseVisualStyleBackColor = true;
            // 
            // btnMultiOn
            // 
            this.btnMultiOn.AutoSize = true;
            this.btnMultiOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiOn.Location = new System.Drawing.Point(6, 18);
            this.btnMultiOn.Name = "btnMultiOn";
            this.btnMultiOn.Size = new System.Drawing.Size(43, 20);
            this.btnMultiOn.TabIndex = 0;
            this.btnMultiOn.TabStop = true;
            this.btnMultiOn.Text = "On";
            this.btnMultiOn.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(9, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 42);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnWriteMultiCoil
            // 
            this.btnWriteMultiCoil.BackColor = System.Drawing.SystemColors.Control;
            this.btnWriteMultiCoil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteMultiCoil.Location = new System.Drawing.Point(90, 182);
            this.btnWriteMultiCoil.Name = "btnWriteMultiCoil";
            this.btnWriteMultiCoil.Size = new System.Drawing.Size(81, 42);
            this.btnWriteMultiCoil.TabIndex = 5;
            this.btnWriteMultiCoil.Text = "Write";
            this.btnWriteMultiCoil.UseVisualStyleBackColor = false;
            this.btnWriteMultiCoil.Click += new System.EventHandler(this.btnWriteMultiCoil_Click);
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(219, 16);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(181, 235);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(9, 229);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(187, 23);
            this.progressBar4.TabIndex = 4;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(-335, 14);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(207, 174);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Open Connection";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Slave Id :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Slave Id :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Slave Id :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Slave Id :";
            // 
            // txtMultiAddress
            // 
            this.txtMultiAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultiAddress.Location = new System.Drawing.Point(96, 64);
            this.txtMultiAddress.Name = "txtMultiAddress";
            this.txtMultiAddress.Size = new System.Drawing.Size(109, 22);
            this.txtMultiAddress.TabIndex = 1;
            this.txtMultiAddress.Text = "3999";
            // 
            // txtWriteMultiId
            // 
            this.txtWriteMultiId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteMultiId.Location = new System.Drawing.Point(96, 33);
            this.txtWriteMultiId.Name = "txtWriteMultiId";
            this.txtWriteMultiId.Size = new System.Drawing.Size(109, 22);
            this.txtWriteMultiId.TabIndex = 1;
            this.txtWriteMultiId.Text = "10";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Write Data";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "Slave Id :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(865, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBoxWriteMultiple);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModBus Project Perform Read Write  Operation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupMode.ResumeLayout(false);
            this.groupMode.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupValue.ResumeLayout(false);
            this.groupValue.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.GroupBoxWriteMultiple.ResumeLayout(false);
            this.GroupBoxWriteMultiple.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtQuentity;
        private System.Windows.Forms.TextBox txtSlaveId;
        private System.Windows.Forms.Label lblQuentity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbtBaud;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDataBit;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtWriteData;
        private System.Windows.Forms.TextBox txtWriteAdd;
        private System.Windows.Forms.TextBox txtWriteId;
        private System.Windows.Forms.Label lblWriteQuentity;
        private System.Windows.Forms.Label lblWriteAddress;
        private System.Windows.Forms.Label lblWriteId;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox combParitybit;
        private System.Windows.Forms.ComboBox combStopBit;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnWriteSingleCoil;
        private System.Windows.Forms.GroupBox GroupBoxWriteMultiple;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMultiAddress;
        private System.Windows.Forms.TextBox txtWriteMultiId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnWriteMultiCoil;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearReadInput;
        private System.Windows.Forms.GroupBox groupMode;
        private System.Windows.Forms.RadioButton btnASCII;
        private System.Windows.Forms.RadioButton btnRTU;
        private System.Windows.Forms.GroupBox groupValue;
        private System.Windows.Forms.RadioButton btnOff;
        private System.Windows.Forms.RadioButton btnOn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton btnMultiOff;
        private System.Windows.Forms.RadioButton btnMultiOn;
        private System.Windows.Forms.Button btnSingleClear;
        private System.Windows.Forms.ComboBox combWriteMulti;
        private System.Windows.Forms.RadioButton btnMultiOnOff;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton btnInput;
        private System.Windows.Forms.RadioButton btnCoil;
        private System.Windows.Forms.ComboBox combReadAddress;
    }
}

