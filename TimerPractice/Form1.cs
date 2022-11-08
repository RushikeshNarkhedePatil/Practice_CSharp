using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Threading;
using System.Windows.Forms;

namespace TimerPractice
{
    public partial class Timer : Form
    {
        public Timer(TimerCallback timerCallback)
        {
            InitializeComponent();
        }

        public Timer()
        {
        }

        private int count1 = 0;
        private int count2 = 0;
        private int count3 = 0;
        private void Start()
        {
            
        }
        private void Stop()
        {

        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            lblDisplay.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.ToString());
        }

        private void btnStop(object sender, EventArgs e)
        {
            lblStop.Text = DateTime.Now.ToString();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {
            //lblDisplay.Text = DateTime.Now.ToString();
        }

        private void Timer_Load(object sender, EventArgs e)
        {

        }
    }
}
