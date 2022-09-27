
namespace NModBusPractice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.combPort = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblComPort = new System.Windows.Forms.Label();
            this.combParityBit = new System.Windows.Forms.ComboBox();
            this.combStopBit = new System.Windows.Forms.ComboBox();
            this.combDataBit = new System.Windows.Forms.ComboBox();
            this.combBuildRate = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combPort
            // 
            this.combPort.FormattingEnabled = true;
            this.combPort.Items.AddRange(new object[] {
            "COM4",
            "COM3",
            "COM2",
            "COM1"});
            this.combPort.Location = new System.Drawing.Point(114, 37);
            this.combPort.Name = "combPort";
            this.combPort.Size = new System.Drawing.Size(135, 23);
            this.combPort.TabIndex = 1;
            this.combPort.SelectedIndexChanged += new System.EventHandler(this.combPort_SelectedIndexChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(84, 35);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(96, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblComPort);
            this.groupBox1.Controls.Add(this.combParityBit);
            this.groupBox1.Controls.Add(this.combStopBit);
            this.groupBox1.Controls.Add(this.combDataBit);
            this.groupBox1.Controls.Add(this.combBuildRate);
            this.groupBox1.Controls.Add(this.combPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 223);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Stop bit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Parity bit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data bit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Build Rate";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(18, 37);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(58, 15);
            this.lblComPort.TabIndex = 2;
            this.lblComPort.Text = "Com Port";
            // 
            // combParityBit
            // 
            this.combParityBit.FormattingEnabled = true;
            this.combParityBit.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.combParityBit.Location = new System.Drawing.Point(114, 196);
            this.combParityBit.Name = "combParityBit";
            this.combParityBit.Size = new System.Drawing.Size(135, 23);
            this.combParityBit.TabIndex = 1;
            // 
            // combStopBit
            // 
            this.combStopBit.FormattingEnabled = true;
            this.combStopBit.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.combStopBit.Location = new System.Drawing.Point(114, 158);
            this.combStopBit.Name = "combStopBit";
            this.combStopBit.Size = new System.Drawing.Size(135, 23);
            this.combStopBit.TabIndex = 1;
            // 
            // combDataBit
            // 
            this.combDataBit.FormattingEnabled = true;
            this.combDataBit.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "16"});
            this.combDataBit.Location = new System.Drawing.Point(114, 114);
            this.combDataBit.Name = "combDataBit";
            this.combDataBit.Size = new System.Drawing.Size(135, 23);
            this.combDataBit.TabIndex = 1;
            // 
            // combBuildRate
            // 
            this.combBuildRate.FormattingEnabled = true;
            this.combBuildRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.combBuildRate.Location = new System.Drawing.Point(114, 73);
            this.combBuildRate.Name = "combBuildRate";
            this.combBuildRate.Size = new System.Drawing.Size(135, 23);
            this.combBuildRate.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Location = new System.Drawing.Point(12, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 89);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 63);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(136, 27);
            this.progressBar1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 211);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 336);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combPort;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.ComboBox combParityBit;
        private System.Windows.Forms.ComboBox combStopBit;
        private System.Windows.Forms.ComboBox combDataBit;
        private System.Windows.Forms.ComboBox combBuildRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

