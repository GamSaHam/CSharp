///<summary>
/// Process
/// 프로세스에 관한 개요
/// </summary>

using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Process proc = Process.GetCurrentProcess();

        string name = proc.ProcessName; // 이름
        DateTime date_time = proc.StartTime; // 시작시간
        int pro_id = proc.Id;
        int memory = proc.VirtualMemorySize;

        Console.WriteLine(name);

        Process[] all_proc = Process.GetProcesses(); // 프로세스 목록 전부 가져오기
    }
};