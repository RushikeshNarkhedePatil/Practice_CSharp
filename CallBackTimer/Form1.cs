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
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btnDisplay_Click(object sender, EventArgs e)
        {
       
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text=="Rushi"&& txtPassword.Text=="Rushi@123")
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
                MessageBox.Show("Sucess");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Text.
        }
    }
}