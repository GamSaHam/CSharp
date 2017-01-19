// Clone의 활용과 이해

using System;

public class Point: ICloneable
{
    private int _x, _y;

    public int X
    {
        get {
            return _x;
        }
        set
        {
            _x = value;
        }
    }

    public int Y
    {
        get
        {
            return _y;
        }
        set
        {
            _y = value;
        }
    }

    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public object Clone()
    {
        return new Point(_x, _y);
    }

    public void printAll()
    {
        Console.WriteLine(_x);
        Console.WriteLine(_y);
    }
}

class HelloWorld
{
    public static void Main()
    {
        Point point = new Point(1,2);
        Point point2 = (Point)point.Clone();

        point2.printAll();

    }
};