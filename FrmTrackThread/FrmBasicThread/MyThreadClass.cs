using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrmBasicThread
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i < 3 ; i++) {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of thread: " + thread.Name + " = "+i);
                Thread.Sleep(500);// sleep for 0.5 secs
            }
        }

        public static void Thread2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of thread: " + thread.Name + " = " + i);
                Thread.Sleep(1500);// sleep for 1.5 secs
            }
            
               
        }
    }
}
