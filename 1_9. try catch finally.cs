// try catch finally 이해
// C++ 에서는 finally 가 없다.

using System;

class HelloClass
{
    public static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;
            //int b = 1;

            if (b == 0)
            {
                throw new Exception("b should not be zero.");
            }

        } catch (Exception e)
        {
            Console.WriteLine(e.Message);

        } finally
        {
            Console.WriteLine("Success");
        }
    }
};

/*
b should not be zero.

*/