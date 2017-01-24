///<summury>
/// Thread 상태 제어
/// Start, Suspend, Resume, Join, Aort를 사용한다.
///</summury>

using System;
using System.Threading;

class Program
{
    static int count = 0;

    public static void print()
    {
        while(true)
        {
            if (count > 9)
            {
                break;
            }

            Console.WriteLine("print");

            Thread.Sleep(1000);

            count++;
        }
    }

    public static void Main()
    {
        Thread thread = new Thread(new ThreadStart(print));

        thread.Start(); // 스래드 시작

        Console.WriteLine("HelloWorld");


        thread.Suspend(); // 스래드 중지


        thread.Resume(); // 재시작


        thread.Join(); // 완료될때까지 기달린다.

        Console.WriteLine(thread.ThreadState); // 스래드 상태 출력

        //thread.Abort(); // 스래드 종료

    }
};

