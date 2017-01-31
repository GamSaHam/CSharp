using System;
using System.Collections;

class Program
{
    static void Main()
    {
        string[] array_str = new string[4] { "A", "B", "C", "D" };

        IEnumerator e = array_str.GetEnumerator();

        while (e.MoveNext())
        {
            Console.WriteLine(e.Current);
        }

        e.Reset();

        while (e.MoveNext())
        {
            Console.WriteLine(e.Current);
        }
    }
}