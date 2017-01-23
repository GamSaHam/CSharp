/*****************************************************************
 * [문자열 클래스 다루기]
 * StringBuilder 클래스 주요 매서드
 *  - Append()       : 현재 문자열에 문자열을 추가
 *  - Insert()       : 현재 문자열 사이에 문자열을 추가 
 *  - Remove()       : 문자를 현재 문자열에서 삭제
 *  - Replace()      : 문자열에서 특정 문자/문자열을 찾아 교체
 *  - ToString()     : 문자열의 내용을 System.String개체로 형 변환
 *****************************************************************/
using System;
class StringExam4
{
    static void Main()
    {
        long start = DateTime.Now.Ticks;    // 시작 시간 가져오기
        // str 문자열 선언
        System.Text.StringBuilder str = new System.Text.StringBuilder();

        for (int i = 0; i < 20000; i++)      // “안녕하세요”를 20000번 더함
        {
            str.Append("안녕하세요");
        }

        str.Replace('안', '만');               // 문자열에서 ‘안’자를 찾아 ‘만’자로 교체
        str.Remove(30, str.Length - 30);   // 앞에 30자만 남기고 제거

        long end = DateTime.Now.Ticks;   // 종료 시간 가져오기

        Console.WriteLine("str 크기: {0}", str.Length);  // 문자열 길이 출력
        Console.WriteLine("str 내용: {0}", str);         // 문자열 내용 출력

        Console.WriteLine("소요 시간 : {0}", end - start);   // 소요 시간 출력

        Console.ReadLine();
    }
}
