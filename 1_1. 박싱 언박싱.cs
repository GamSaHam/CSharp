// 박싱 언박싱에 이해

using System;

class HelloClass
{
    public static int Main(string[] args)
    {
        int val = 10;
        object obj = val; // 박싱

        int val2 = (int)val; // 언박싱

        Console.WriteLine(val2);

        return 0;
    }
}