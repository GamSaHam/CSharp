///<summary>
/// delegate 의 활용 2
/// </summary>

using System;

class HelloWorld
{
    public void foo()
    {
        Console.WriteLine("foo()");
    }
    public void goo()
    {
        Console.WriteLine("goo()");
    }

    public delegate void PrintDelegate();

    public static void Main()
    {
        HelloWorld hello_wolrd = new HelloWorld();

        PrintDelegate operation1 = new PrintDelegate(hello_wolrd.foo);
        PrintDelegate operation2 = new PrintDelegate(hello_wolrd.goo);
        PrintDelegate operation3;

        operation3 = operation1; operation3();
        operation3 += operation2; operation3();
    }
};
