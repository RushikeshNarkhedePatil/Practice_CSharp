
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtQuentity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSlaveId = new System.Windows.Forms.TextBox();
            this.lblQuentity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtWriteQuentity = new System.Windows.Forms.TextBox();
            this.txtWriteAdd = new System.Windows.Forms.TextBox();
            this.txtWriteId = new System.Windows.Forms.TextBox();
            this.lblWriteQuentity = new System.Windows.Forms.Label();
            this.lblWriteAddress = new System.Windows.Forms.Label();
            this.lblWriteId = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.combStopBit = new System.Windows.Forms.ComboBox();
            this.combParitybit = new System.Windows.Forms.ComboBox();
            this.txtWriteOut = new System.Windows.Forms.TextBox();
            this.txtReadInput = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Controls.Add(this.txtReadInput);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Controls.Add(this.txtQuentity);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtSlaveId);
            this.groupBox1.Controls.Add(this.lblQuentity);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(291, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read  Input";
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
            this.groupBox3.Size = new System.Drawing.Size(208, 174);
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
            this.label6.Location = new System.Drawing.Point(6, 98);
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
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(35, 156);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(110, 34);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read Coil";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtQuentity
            // 
            this.txtQuentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuentity.Location = new System.Drawing.Point(96, 96);
            this.txtQuentity.Name = "txtQuentity";
            this.txtQuentity.Size = new System.Drawing.Size(100, 22);
            this.txtQuentity.TabIndex = 1;
            this.txtQuentity.Text = "4";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(96, 64);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "7999";
            // 
            // txtSlaveId
            // 
            this.txtSlaveId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlaveId.Location = new System.Drawing.Point(96, 32);
            this.txtSlaveId.Name = "txtSlaveId";
            this.txtSlaveId.Size = new System.Drawing.Size(100, 22);
            this.txtSlaveId.TabIndex = 1;
            this.txtSlaveId.Text = "10";
            // 
            // lblQuentity
            // 
            this.lblQuentity.AutoSize = true;
            this.lblQuentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuentity.Location = new System.Drawing.Point(6, 102);
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
            this.groupBox2.Size = new System.Drawing.Size(218, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Open Connection";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(105, 206);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(11, 206);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 28);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 171);
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
            this.label3.Location = new System.Drawing.Point(6, 102);
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
            this.txtDataBit.Location = new System.Drawing.Point(92, 99);
            this.txtDataBit.Name = "txtDataBit";
            this.txtDataBit.Size = new System.Drawing.Size(120, 22);
            this.txtDataBit.TabIndex = 1;
            this.txtDataBit.Text = "8";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaudRate.Location = new System.Drawing.Point(92, 64);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(120, 22);
            this.txtBaudRate.TabIndex = 1;
            this.txtBaudRate.Text = "9600";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(92, 32);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(120, 22);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "COM4";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressBar3);
            this.groupBox4.Controls.Add(this.txtWriteOut);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnWrite);
            this.groupBox4.Controls.Add(this.txtWriteQuentity);
            this.groupBox4.Controls.Add(this.txtWriteAdd);
            this.groupBox4.Controls.Add(this.txtWriteId);
            this.groupBox4.Controls.Add(this.lblWriteQuentity);
            this.groupBox4.Controls.Add(this.lblWriteAddress);
            this.groupBox4.Controls.Add(this.lblWriteId);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(230, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 215);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Write";
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
            this.groupBox5.Size = new System.Drawing.Size(208, 174);
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
            this.label2.Location = new System.Drawing.Point(6, 98);
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
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(34, 128);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(110, 34);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Write Coil";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtWriteQuentity
            // 
            this.txtWriteQuentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteQuentity.Location = new System.Drawing.Point(96, 96);
            this.txtWriteQuentity.Name = "txtWriteQuentity";
            this.txtWriteQuentity.Size = new System.Drawing.Size(100, 22);
            this.txtWriteQuentity.TabIndex = 1;
            // 
            // txtWriteAdd
            // 
            this.txtWriteAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteAdd.Location = new System.Drawing.Point(96, 64);
            this.txtWriteAdd.Name = "txtWriteAdd";
            this.txtWriteAdd.Size = new System.Drawing.Size(100, 22);
            this.txtWriteAdd.TabIndex = 1;
            // 
            // txtWriteId
            // 
            this.txtWriteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriteId.Location = new System.Drawing.Point(96, 32);
            this.txtWriteId.Name = "txtWriteId";
            this.txtWriteId.Size = new System.Drawing.Size(100, 22);
            this.txtWriteId.TabIndex = 1;
            // 
            // lblWriteQuentity
            // 
            this.lblWriteQuentity.AutoSize = true;
            this.lblWriteQuentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriteQuentity.Location = new System.Drawing.Point(6, 102);
            this.lblWriteQuentity.Name = "lblWriteQuentity";
            this.lblWriteQuentity.Size = new System.Drawing.Size(56, 16);
            this.lblWriteQuentity.TabIndex = 0;
            this.lblWriteQuentity.Text = "Quentity";
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 248);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(154, 23);
            this.progressBar1.TabIndex = 3;
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
            // combParitybit
            // 
            this.combParitybit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combParitybit.FormattingEnabled = true;
            this.combParitybit.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.combParitybit.Location = new System.Drawing.Point(92, 168);
            this.combParitybit.Name = "combParitybit";
            this.combParitybit.Size = new System.Drawing.Size(121, 24);
            this.combParitybit.TabIndex = 4;
            // 
            // txtWriteOut
            // 
            this.txtWriteOut.Location = new System.Drawing.Point(225, 25);
            this.txtWriteOut.Multiline = true;
            this.txtWriteOut.Name = "txtWriteOut";
            this.txtWriteOut.Size = new System.Drawing.Size(177, 178);
            this.txtWriteOut.TabIndex = 3;
            // 
            // txtReadInput
            // 
            this.txtReadInput.Location = new System.Drawing.Point(217, 25);
            this.txtReadInput.Multiline = true;
            this.txtReadInput.Name = "txtReadInput";
            this.txtReadInput.Size = new System.Drawing.Size(173, 194);
            this.txtReadInput.TabIndex = 3;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(9, 233);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(355, 22);
            this.progressBar2.TabIndex = 4;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(9, 180);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(187, 23);
            this.progressBar3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtQuentity;
        private System.Windows.Forms.TextBox txtAddress;
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
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtWriteQuentity;
        private System.Windows.Forms.TextBox txtWriteAdd;
        private System.Windows.Forms.TextBox txtWriteId;
        private System.Windows.Forms.Label lblWriteQuentity;
        private System.Windows.Forms.Label lblWriteAddress;
        private System.Windows.Forms.Label lblWriteId;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox combParitybit;
        private System.Windows.Forms.ComboBox combStopBit;
        private System.Windows.Forms.TextBox txtReadInput;
        private System.Windows.Forms.TextBox txtWriteOut;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
    }
}

