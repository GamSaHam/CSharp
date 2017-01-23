/// <summary>
/// IEnumerator 기본
/// </summary>

using System;
using System.Collections;

class HelloWorld
{

    public static void Main()
    {
        string[] array_str = {"A","B","C","D" };

        IEnumerator e = array_str.GetEnumerator();

        while(e.MoveNext())
        { 
            Console.WriteLine(e.Current);
        }

        e.Reset();

        while (e.MoveNext())
        {
            Console.WriteLine(e.Current);
        }

    }
};