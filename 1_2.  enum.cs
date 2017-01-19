// enum 이해

using System;

class HelloClass
{
    public enum CITY
    {
        CITY_SEOUL,
        CITY_NEWYORK
    };

    public static void Main()
    {
        CITY city = CITY.CITY_SEOUL;

        if(city == CITY.CITY_SEOUL)
        { 
            Console.WriteLine(city);
        }
    }
};