using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicThread
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Thread Starts");

            ThreadStart delThreadObj = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart delThreadObj2 = new ThreadStart(MyThreadClass.Thread2);
           
            Thread ThreadA = new Thread(delThreadObj);
            ThreadA.Name = "Thread A Process";

            Thread ThreadB = new Thread(delThreadObj2);
            ThreadB.Name = "Thread B Process";

            Thread ThreadC = new Thread(delThreadObj);
            ThreadC.Name = "Thread C Process";

            Thread ThreadD = new Thread(delThreadObj2);
            ThreadD.Name = "Thread D Process";

            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;

            //Starting threads
            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();
            //Joining two threads
            ThreadA.Join(); 
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();

            label1.Text = "-End of Thread-";
            Console.WriteLine(label1.Text);

        }
    }
}
