using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
namespace TaskSeven.cs
{

    public class Timer
    {
        public delegate void Taimer();
        public Taimer method;
        public void Start(int interval, int totalTime)
        {
            DateTime start = DateTime.Now;
            while (true)
            {
                method();
                Thread.Sleep(totalTime);
                start = DateTime.Now;
            }
        }
    }
    static class Program
    {

        private static void Doer()
        {
            Console.WriteLine("Appear every t seconds! {0}",DateTime.Now);
        }
        static void Main(string[] args)
        {
            Timer t=new Timer();
            t.method = Doer; //have an instance of method Doer
            t.Start(2, 400);
        }

       

      
    }
}
