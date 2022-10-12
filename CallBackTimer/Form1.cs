using System;
using System.Windows.Forms;
using System.Threading;
namespace CallBackTimer
{
    public delegate void MyDelegate();
    public delegate void myTimer(TimerCallback callback);

    public partial class Form1 : Form
    {
       // void RunInThread()
       // {
       //     MyDelegate delInstatnce = new MyDelegate(AddControl);
       //     myTimer delTimer = new myTimer(TimerMethod);
       //     this.Invoke(delInstatnce);
       //     //this.Invoke(delTimer);
       //     //MessageBox.Show("Hello");

       //     int Seconds = 5 * 1000;
       //     var Timer = new System.Threading.Timer(TimerMethod, null, 0, Seconds);
       //     //Add your code that needs to be executed in separate thread 
       //     //except UI updation
       // }
       //void TimerMethod(object o)
       // {
       //     Console.WriteLine("Jay Ganesh");
       // }
       // void AddControl()
       // {
       //     TextBox textBox1 = new TextBox();
       //     Controls.Add(textBox1);
       // }

        public Form1()
        {
            InitializeComponent();
          
        }
        //private void Display()
        //{
        //    //
        //    Console.WriteLine("Jay Ganesh");
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            TimerCallback timeCB = new TimerCallback(PrintTime);
            System.Threading.Timer t = new System.Threading.Timer(
           timeCB,   // The TimerCallback delegate type.
           "Hi",     // Any info to pass into the called method.
           0,        // Amount of time to wait before starting.
           1000);    // Interval of time between calls. 

            void PrintTime(object state)
            {
                //Console.WriteLine("Time is: {0}, Param is: {1}", DateTime.Now.ToLongTimeString(), state.ToString());
                if (this.textBox1.InvokeRequired)
                {
                    textBox1.Invoke((MethodInvoker)(() => textBox1.Text = "Jay Ganesh"));
                    listView1.Invoke((MethodInvoker)(() => listView1.Items.Add(DateTime.Now.ToLongTimeString())));
                }

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btnDisplay_Click(object sender, EventArgs e)
        {
       
        }
    }
}