/// <summury>
/// 동기화 Mutex
/// 공유자원에 쓰래드간 동시 접근을 막는다.
/// </summury>

using System;
using System.Threading;

public class MutexExample
{
    Mutex _mutex = new Mutex(false, "MutexExam");
    
    public void doSomething()
    {
        _mutex.WaitOne();

        for (int i=0;i<10;i++)
        { 
            Console.WriteLine("{0}", Thread.CurrentThread.Name);
            Thread.Sleep(200);
        }
        _mutex.ReleaseMutex();
    }
};

class Program
{
    static void Main()
    {
        MutexExample mutext_example = new MutexExample();

        Thread thread1 = new Thread(new ThreadStart(mutext_example.doSomething));
        Thread thread2 = new Thread(new ThreadStart(mutext_example.doSomething));

        thread1.Name = "1";
        thread2.Name = "2";

        thread1.Start();
        thread2.Start();

    }
};

