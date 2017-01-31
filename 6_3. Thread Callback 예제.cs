///<summary>
/// Thread Callback 응용 예제
/// </summary>

using System;
using System.Threading;

class DeleagteCollection
{
    public delegate void delegateCallback1();
};

class Foo
{
    public void resultCallBack()
    {
        Console.WriteLine("finish callback");
    }

};


class CallBackExam
{
    public event DeleagteCollection.delegateCallback1 _call_back;

    public CallBackExam(object obj)
    {
        Foo foo = (Foo)obj;
        _call_back += new DeleagteCollection.delegateCallback1(foo.resultCallBack);

    }

    public void Thread1()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Dosomething");
        }

        _call_back();
    }

};

class Program
{

    static void Main()
    {
        Foo foo = new Foo();
        CallBackExam call_back = new CallBackExam(foo);

        Thread thread = new Thread(new ThreadStart(call_back.Thread1));

        thread.Start();

        thread.Join();
    }
};