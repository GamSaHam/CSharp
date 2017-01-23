///<summary>
/// 디렉토리 생성, 하위 생성, 삭제, 하위 삭제
/// </summary>

using System;
using System.IO;

class FileExam5
{
    static void Main(string[] args)
    {
        string str_option = "-r";

        DirectoryInfo dir = new DirectoryInfo(@"C:\Test2");   // 디렉토리 정보 가져오기

        if (str_option == "-m")
        {
            if (dir.Exists)
            {
                Console.WriteLine("{0} 디렉토리가 이미 존재합니다.", args[1]);
            }
            else
            {
                dir.Create();  // 디렉토리 생성
                Console.WriteLine("{0} 디렉토리 생성!", args[1]);
            }
        }
        else if (str_option == "-mm")  // 옵션이 -mm 일 경우
        {  
            if (dir.Exists)
            {
                Console.WriteLine("{0} 디렉토리가 이미 존재합니다.", args[1]);
            }
            else
            {
                dir.Create();    // 디렉토리 생성
                dir.CreateSubdirectory(@"Temp");   // 하위 디렉토리 생성
                dir.CreateSubdirectory(@"Bin\Debug"); // 하위 디렉토리 생성
                Console.WriteLine("{0} 디렉토리 생성!", args[1]);
                Console.WriteLine("{0} 하위 디렉토리 생성!", "Temp");
                Console.WriteLine("{0} 하위 디렉토리 생성!", @"Bin\Debug");
            }
        }
        else if (str_option == "-r")   // 옵션이 -r 일 경우
        {
            if (dir.Exists)    // 삭제하려는 디렉토리가 존재하면
            {
                dir.Delete();  // 해당 디렉토리를 삭제
                Console.WriteLine("{0} 디렉토리 삭제!", args[1]);
            }
            else
            {
                Console.WriteLine("{0} 디렉토리가 존재하지 않습니다.", args[1]);
            }
        }
        else if (str_option == "-rr")  // 옵션이 -rr일 경우 
        {
            if (dir.Exists)    // 삭제하려는 디렉토리가 존재하면
            {
                dir.Delete(true);  // 모든 하위 디렉토리 삭제
            }
            else
            {
                Console.WriteLine(" 디렉토리가 존재하지 않습니다.");
            }
        }
        else
        {
            Console.WriteLine("옵션이 잘못되었습니다!");
            return;
        }
    }
}