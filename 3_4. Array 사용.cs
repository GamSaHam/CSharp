///<summary>
/// Array의 클래스에 활용
/// </summary>

using System;

class ArrayExam
{

    static void printArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ,", array[i]);
        }

        Console.WriteLine();
    }

    static void Main()
    {
        int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        Console.WriteLine("Array.IndexOf(30)={0}", Array.IndexOf(month, 30)); // 인덱스 반환 처음
        Console.WriteLine("Array.LastIndexOf(30)={0}", Array.LastIndexOf(month, 30)); // 마지막 30 반환 

        printArray(month);

        Array.Reverse(month); // 배열 역으로 

        printArray(month);

        Console.WriteLine("\n Array.Srot(month) -->");
        Array.Sort(month);
        for (int i = 0; i < month.Length; i++)
        {
            Console.Write("{0} , ", month[i]);
        }
        Console.WriteLine();

        Console.WriteLine("return array Index : {0}",Array.BinarySearch(month, 31)); // 인덱스 반환
    }
}

