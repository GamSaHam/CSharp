///<summary>
/// enum 키워드
/// </summary>

using System;

class HelloClass
{
    public enum CITY
    {
        CITY_SEOUL,
        CITY_NEWYORK
    };

    public enum CITY_LONG_FRUIT: long
    {
        APPLE = 1000L,
        BANANAN = 2000L
    };

    public static void Main()
    {
        CITY city = CITY.CITY_SEOUL;

        if (city == CITY.CITY_SEOUL)
        {
            Console.WriteLine(city);
        }

        long l = (long)CITY_LONG_FRUIT.APPLE;

        Console.WriteLine(l);
    }
};