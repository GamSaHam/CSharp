///<summary>
/// MemoryStream의 관한 예제입니다.
/// 메모리를 스트림형으로 읽어서 제어함
/// </summary>

using System;
using System.IO;
using System.Text;

class HelloWorld
{
    public static void Main()
    {
        MemoryStream ms = new MemoryStream();
        ms.Capacity = 18;
        ms.Position = 0;

        byte[] array = new UTF8Encoding(true).GetBytes("www.daum.net");

        ms.Write(array, 0, array.Length);

        ms.Position = 3;
        ms.WriteByte((byte)65);

        array = ms.GetBuffer();

        Console.WriteLine(new UTF8Encoding(true).GetString(array));
    }

};
