///<summery>
/// String Builder 사용
/// 요즘에는 정규 표현식을 어느 언어나 써서 잘 사용되어지지 않음.
/// </summery>


using System;
using System.Text;

class HelloWorld
{
    static void Main()
    {
        StringBuilder str = new System.Text.StringBuilder();

        for (int i = 0; i < 10; i++)
        {
            str.Append(i.ToString());
        }

        Console.WriteLine(str.ToString());

        str.Replace("0", "1");

        Console.WriteLine(str.ToString());

        str.Remove(5, str.Length - 5);

        Console.WriteLine(str.ToString());
    }

};