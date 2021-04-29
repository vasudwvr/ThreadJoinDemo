using System;
using System.Threading;

namespace Demo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main Thread";
            Thread t = new Thread(Go);
            t.Name = "Thread to execute Go nethod";
            t.Start();
            Console.WriteLine("This is from Main Thread "+Thread.CurrentThread.Name);
            t.Join();
            Console.WriteLine("Thread t has ended!");
        }

        static void Go()
        {
            for (int i = 0; i < 10; i++) Console.WriteLine(Thread.CurrentThread.Name + " y");
        }
    }
}
