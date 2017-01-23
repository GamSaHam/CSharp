///<summery>
/// DirectoryInfo 활용
/// </summery>

using System;
using System.IO;

class HelloWorld
{
    static void Main()
    {
        DirectoryInfo info = new DirectoryInfo(@"C:\Program Files\Internet Explorer");

        if (info.Exists)
        {
            Console.WriteLine("전체 경로     : {0}", info.FullName);
            Console.WriteLine("디렉토리 이름 : {0}", info.Name);
            Console.WriteLine("생성일        : {0}", info.CreationTime);
            Console.WriteLine("디렉토리 속성 : {0}", info.Attributes);
            Console.WriteLine("루트 경로     : {0}", info.Root);
            Console.WriteLine("부모 디렉토리 : {0}", info.Parent);
        }
        else
        {
            Console.WriteLine("디렉토리가 존재 하지 않습니다.");
        }
    }
};