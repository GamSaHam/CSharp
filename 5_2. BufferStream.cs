///<summury>
/// BufferStream
/// 데이터 입출력 효율이 좋아진다.
/// FileStream의 Read() Write() 메서드를 바로 사용하지 않고
/// 임시 버퍼를 만들고, 버퍼에 데이터가 차면 한번에 파일 입출력을 수행함
/// 물리적으로 파일에 접근하는 횟수가 준다.
///</summury>

using System;
using System.IO;
using System.Text;

class HelloWorld
{
    static void Main()
    {
        FileStream fs = new FileStream(@"c:\test.txt", FileMode.CreateNew, FileAccess.ReadWrite);
        BufferedStream bs = new BufferedStream(fs);

        string value = "Hello World";
        byte[] array = new UTF8Encoding(true).GetBytes(value);

        bs.Write(array, 0, array.Length);
        bs.Close();
    }
};
