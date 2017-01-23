///<summary>
/// String 클래스의 활용
/// </summary>

using System;

class HelloWorld
{
    static void Main()
    {
        String str = "Hello,Wolrd,My Name";

        // 1. Compare
        if (String.Compare(str, "Hello World") == 0)
        {
        }

        // 2. Format
        String str_coment = String.Format("Hello World");

        // 3. Indexof
        int find_index = str.IndexOf("e");

        // 4. LastIndexOf
        int last_index = str.LastIndexOf("l");

        // 5. PadRight
        Console.WriteLine(str.PadLeft(5,'e'));

        // 6. Replace
        Console.WriteLine(str.Replace("Hello", "My"));

        // 7. Split
        char[] ch = new char[1];
        ch[0] = ',';

        String[] array_str = str.Split(ch);

        foreach (String obj in array_str)
        {
            Console.WriteLine(obj);
        }
        
        //8. subString
        Console.WriteLine(str.Substring(5));
    }
};