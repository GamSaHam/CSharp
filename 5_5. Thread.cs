/***********************************************************************
 *  스레드 생성 방법 
 *   1. Thread 클래스를 이용한 생성
 *      가장 일반적인 방법
 * 
 *   2. ThreadPool 클래스를 이용한 생성
 *      과도한 컨텍스트 스위칭을 발생시킬 수 있슴
 *      프로세스 별로 일정량의 스레드를 수용할 수 있는 풀을 만들고,
 *      스레드 풀 내에서 스레드를 이용함으로써 적절한 스레드 수를 
 *      유지할 수 있다.
 *      적절한 수준의 스레드 수를 유지할 수 있기 문에 1번 방법보다 상대적
 *      으로 높은 안정성과 성능 제공함
 *   3. Timer 클래스를 이용한 생성
 *      .NET에서 제공되는 Timer
 *      (1) System.WinForms.TImer
 *          단일 스레드 환경에서 사용하는 윈폼 툴 박스 Timer로 주어진 시간마다
 *          Tick 이벤트를 발생
 *      (2) System.Timer.Timer
 *          멀티 스레드 호나경에서 사용 가능하며 Server Timer, Component 툴 박
 *          스의 타이머에서 사용되며 주어진 기간마다 Tick 이벤트를 발생시킴
 *      (3) System.Threading.Timer
 *          Timer를 이용한 스레드는 주로 System.Threading.Timer 클래스를 사용
 *          해 발생시킴
 *          Timer 클래스 객체를 생성한 후 TimerCallback 델리게이트 인자와 
 *          메서드로 타이머에 전달할 인자, 기간을 설정해 스레드를 만듬
 ***********************************************************************/
using System;
using System.Threading;


namespace 확인
{
    /*
    // 1 방법
    class Program
    {
        public static void Print1()
        {
            Console.WriteLine("첫번째 Thread...");
        }
        public void Print2()
        {
            Console.WriteLine("두번째 Thread...");
        }

        static void Main(string[] args)
        {
            // 스레드 생성
            // ThreadStart 델리게이트를 이용해 static 매서드인 Print1 등록
            Thread thread = new Thread(new ThreadStart(Print1));

            // 스레드 실행
            thread.Start();     

            // 스레드 생성
            // static 형태가 아닌 메서드일 경우 
            // new 연산자를 이용해 인스턴스를 만든 후 ThreadStart 델리게이트
            // 에 등록
            thread = new Thread(new ThreadStart((new Program()).Print2));

            thread.Start();


            Console.WriteLine("세번째 thread...");
        }
    }*/
    

    /*
    // 2 방법
    class Program
    {
        static int i = 0;

        // 첫번째 스레드
        public static void Print1(object obj)
        {
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("첫번째 Thread : {0} ***", i);
                Thread.Sleep(2000);
            }
        }

        // 두번째 스레드
        public void Print2(object obj)
        {
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("두번째 Thread : {0} ***", i);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            // static method를 이용한 ThreadPool에 대한 작업 요청
            ThreadPool.QueueUserWorkItem(new WaitCallback(Print1) , null);

            // method를 이용한 ThreadPool에대한 작업 요청
            ThreadPool.QueueUserWorkItem(new WaitCallback(
                ( new Program()).Print2), null);

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
            }

        }
    }*/

    //3 방법
    class Program
    {

        // 첫번째 스레드
        public static void Print1(object obj)
        {
            Console.WriteLine("첫번째 Thread ***");
        }

        // 두번째 스레드
        public void Print2(object obj)
        {
            Console.WriteLine("두번째 Thread  ***");
        }

        static void Main(string[] args)
        {
            // Timer 클래스 객체를 생성하는 부분
            Timer timer = new Timer(new TimerCallback(Print1), null, 200, 1000);

            // Timer 클래스 객체를 생성하는 부분 
            timer = new Timer(new TimerCallback((new
                Program()).Print2), null, 200, 1000);

            Thread.Sleep(5000);

            timer.Dispose();

        }
    }


}
