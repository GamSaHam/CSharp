///<summary>
/// Parallel 분산 처리
/// </summary>

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{ 
    const int MAX = 10000000;
    const int SHIFT = 3;

    static void SequentialEncryt()
    {
        // 테스트 데이타 셋업
        // 1000 만개의 스트링
        string text = "I am a boy. My name is Tom.";
        List<string> textList = new List<string>(MAX);
        for (int i = 0; i < MAX; i++)
        {
            textList.Add(text);
        }

        // 순차 처리 (Test run: 8.7 초)
        System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        watch.Start();
        for (int i = 0; i < MAX; i++)
        {
            char[] chArr = textList[i].ToCharArray();

            // 모든 문자를 시저 암호화
            for (int x = 0; x < chArr.Length; x++)
            {
                // 시저 암호
                if (chArr[x] >= 'a' && chArr[x] <= 'z')
                {
                    chArr[x] = (char)('a' + ((chArr[x] - 'a' + SHIFT) % 26));
                }
                else if (chArr[x] >= 'A' && chArr[x] <= 'Z')
                {
                    chArr[x] = (char)('A' + ((chArr[x] - 'A' + SHIFT) % 26));
                }
            }

            // 변경된 암호로 치환
            textList[i] = new String(chArr);
        };
        watch.Stop();
        Console.WriteLine(watch.Elapsed.ToString());
    }

    static void ParallelEncryt()
    {
        // 테스트 데이타 셋업
        // 1000 만개의 스트링
        string text = "I am a boy. My name is Tom.";
        List<string> textList = new List<string>(MAX);
        for (int i = 0; i < MAX; i++)
        {
            textList.Add(text);
        }

        // 병렬 처리 (Test run: 6.1 초)
        System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        watch.Start();
        Parallel.For(0, MAX, i =>
        {
            char[] chArr = textList[i].ToCharArray();

            // 모든 문자를 시저 암호화
            for (int x = 0; x < chArr.Length; x++)
            {
                // 시저 암호
                if (chArr[x] >= 'a' && chArr[x] <= 'z')
                {
                    chArr[x] = (char)('a' + ((chArr[x] - 'a' + SHIFT) % 26));
                }
                else if (chArr[x] >= 'A' && chArr[x] <= 'Z')
                {
                    chArr[x] = (char)('A' + ((chArr[x] - 'A' + SHIFT) % 26));
                }
            }

            // 변경된 암호로 치환
            textList[i] = new String(chArr);
        });
        watch.Stop();
        Console.WriteLine(watch.Elapsed.ToString());
    }

    static void Main(string[] args)
    {
        SequentialEncryt();
        ParallelEncryt();
        Console.ReadLine();
    }

}