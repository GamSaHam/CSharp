///<summary>
/// params 키워드
/// </summary>

using System;

public class MyClass
{
    public static void UseParams(params int[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }


    static void Main()
    {
        UseParams(1, 2, 3, 4);
     
    }
}
