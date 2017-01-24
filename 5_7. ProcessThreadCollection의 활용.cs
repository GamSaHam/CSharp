///<summary>
/// ProcessThreadCollection 활용
/// 프로세스에 접근 프로세스에있는 스래드접근 스래드에 정보 출력
///</summary>

using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static int count = 0;

    public static void print()
    {
        while (true)
        {
            Thread.Sleep(1000);
            if (count > 10)
                break;

            Console.WriteLine("print");

            count++;
        }
    }

    public static void Main()
    {
        Thread thread = new Thread(print);
        thread.Start();


        Process process = Process.GetCurrentProcess();
        ProcessThreadCollection process_thread_collection = process.Threads;


        Console.WriteLine("Thread Count {0}", process_thread_collection.Count);
        Console.WriteLine("-------------------------");

        foreach (ProcessThread process_thread in process_thread_collection)
        {
            Console.WriteLine("{0}",process_thread.ThreadState);
        }

        Console.WriteLine("-------------------------");

        Thread.Sleep(5000);
    }
};