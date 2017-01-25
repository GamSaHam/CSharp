///<summary>
/// Thread에 인자 전달
/// </summary>

using System;
using System.Threading;

class ThreadParameterExample
{
    public void doSomething(object data)
    {
        Console.WriteLine(data);
    }
};

class Program
{
    public static void Main()
    {
        ThreadParameterExample thread_paramter_example = new ThreadParameterExample();

        Thread thread = new Thread(new ParameterizedThreadStart(thread_paramter_example.doSomething));

        thread.Start("Hello");
    }
};