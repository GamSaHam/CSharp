///<summury>
/// 스래드 우선순위
///</summury>

using System;
using System.Threading;

class Program
{
    public static void doSomething()
    {
        Console.WriteLine("{0}", Thread.CurrentThread.Name);
    }

    public static void Main()
    {
        Thread thread1 = new Thread(new ThreadStart(doSomething));
        Thread thread2 = new Thread(new ThreadStart(doSomething));
        Thread thread3 = new Thread(new ThreadStart(doSomething));
        Thread thread4 = new Thread(new ThreadStart(doSomething));

        thread1.Name = "1";
        thread2.Name = "2";
        thread3.Name = "3";
        thread4.Name = "4";

        thread1.Priority = ThreadPriority.Highest;
        thread4.Priority = ThreadPriority.Lowest;


        thread1.Start();
        thread2.Start();
        thread3.Start();
        thread4.Start();
    }
};
