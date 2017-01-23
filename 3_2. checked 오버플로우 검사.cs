using System;
class CheckedExam
{
    static void Main()
    {
        int data1 = 99999;
        
        short data2 = checked((short)data1);// 오버플로우 검사를 명시적으로 활성화

        Console.WriteLine("data1 = " + data1);

    }
}

