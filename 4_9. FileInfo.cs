///<summary>
///  FileInfo 기본 정보
/// </summary>


using System;
using System.IO;

// 정보 검색
class FileExam2
{
    static void Main()
    {
        FileInfo finfo = new FileInfo(@"c:\test.txt");  // FileInfo 개체 생성

        if (finfo.Exists)  // 파일이 존재하면 
        {
            Console.WriteLine("폴더 이름 : {0}", finfo.Directory);
            Console.WriteLine("파일 이름 : {0}", finfo.Name);
            Console.WriteLine("확장자    : {0}", finfo.Extension);
            Console.WriteLine("생성일    : {0}", finfo.CreationTime);
            Console.WriteLine("파일 크기 : {0} byte", finfo.Length);
            Console.WriteLine("파일 속성 : {0}", finfo.Attributes);
        }
        else
        {
            Console.WriteLine("파일이 존재하지 않습니다.");
        }
    }
}


// 파일 이동 및 복사

///<summary>
/// FileInfo 쓰기,읽기, 삭제, 이동
/// </summary>

using System;
using System.IO;

class Test
{
    public static void Main()
    {
        const string file_path = @"c:\temp\Test.txt";

        // 파일 쓰기
        FileInfo file_info = new FileInfo(file_path);

        if (!file_info.Exists)
        {
            using (StreamWriter sw = file_info.CreateText())
            {
                sw.WriteLine("1");
                sw.WriteLine("2");
                sw.WriteLine("3");
            }
        }

        // 파일 쓰기2

        const string file_path2 = @"c:\temp\Test2.txt";

        // 파일 쓰기
        FileInfo file_info2 = new FileInfo(file_path2);

        if (!file_info2.Exists)
        {
            using (StreamWriter sw = file_info2.CreateText())
            {
                sw.WriteLine("1");
                sw.WriteLine("2");
                sw.WriteLine("3");
            }
        }

        // 파일 읽기
        using (StreamReader sr = file_info.OpenText())
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }

        try
        {
            FileInfo fi2 = new FileInfo(file_path2);

            //Ensure that the target does not exist.
            fi2.Delete();

            //Copy the file.
            file_info.CopyTo(file_path2);

            //Delete the newly created file.
            fi2.Delete();

        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }

        
    }
}