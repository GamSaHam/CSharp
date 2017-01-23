///<summery>
/// 어트리뷰트 
/// DllImport 어트리뷰트
/// 윈도우 API를 사용할 때 주로 사용
/// .NET 에서 지원하는 어트리 뷰트는 200개 정도가 됨.
///</summery>

using System;
using System.Runtime.InteropServices;   // dllimport 어트리뷰트 정의됨

class Program
{
    [DllImport("User32.dll")] //Win32 : User32.dll참조
    public static extern int MessageBox(int hwnd, string lpText,
                string lpCation, int uType);
    static void Main(string[] args)
    {
        MessageBox(0, "Win32 MessageBox호출", "DllImport사용", 3);
    }
}
