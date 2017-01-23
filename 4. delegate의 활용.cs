///<summary>
/// delegate 의 활용
/// </summary>

using System;

class HelloWorld
{
    public int plus(int a, int b)
    {
        return a + b;
    }

    public int minus(int a, int b)
    {
        return a - b;
    }

    public int multiple(int a, int b)
    {
        return a * b;
    }

    public int division(int a, int b)
    {
        if (a == 0)
            return 0;

        return a / b;
    }

    
    public delegate int ArithMeticOperationDelegate(int a, int b);

    public static void Main()
    {
        HelloWorld hello_wolrd = new HelloWorld();

        ArithMeticOperationDelegate delegate_arithmetic_operation = hello_wolrd.plus;

        Console.WriteLine("result value is :{0}", delegate_arithmetic_operation(10, 20));
    }

};
