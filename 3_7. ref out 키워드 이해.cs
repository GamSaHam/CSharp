///<summary>
/// ref out 의 이해
/// </summary>

using System;

class HelloClass
{
    public static void swap(out int a, out int b)
    {
        // a = b; // error 할당 되지 않는 a를 사용
        a = 200;
        b = 100;
    }

    public static void swap2(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void printTwoParameter(int a,int b)
    {
        Console.WriteLine("{0} {1}",a,b);
    }

    public static void Main()
    {
        int a = 100, b = 200;

        printTwoParameter(a, b);

        swap(out a,out b);

        printTwoParameter(a, b);

        swap2(ref a, ref b);

        printTwoParameter(a, b);
    }
}