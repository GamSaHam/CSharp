///<summary>
/// 동기화 Monitor
/// 모니터를 통한 Thread 동시 접근 막음.
/// </summary>

using System;
using System.Threading;

class MoniterExam
{
    private static object monitor_object = new object(); // monitor에 사용될 인스턴스

    public void doSomething()
    {
        Monitor.Enter(MoniterExam.monitor_object);  // 시작

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0}. doSomething index:{1}",Thread.CurrentThread.Name,i);
            Thread.Sleep(100);
        }

        Monitor.Exit(MoniterExam.monitor_object); // 끝
    }
}

class Program
{
    public static void Main()
    {
        MoniterExam moniter_exam = new MoniterExam();

        Thread thread1 = new Thread(new ThreadStart(moniter_exam.doSomething));
        Thread thread2 = new Thread(new ThreadStart(moniter_exam.doSomething));

        thread1.Name = "A";
        thread2.Name = "B";

        thread1.Start();
        thread2.Start();
    }
};