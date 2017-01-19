// IComparable의 활용

using System;

class Car:IComparable
{
    public Car(int id)
    {
        m_id = id;
    }

    int IComparable.CompareTo(object obj)
    {
        Car temp = (Car)obj;

        if (this.m_id > temp.m_id)
        {
            return 1;
        }
        else if (this.m_id < temp.m_id)
        {
            return -1;
        }
        else
            return 0;
    }

    public void printAll()
    {
        Console.WriteLine(m_id);
    }

    private int m_id;
};

public class HelloWorld
{
    public static void Main()
    {
        Car[] array_car = new Car[3] {
           new Car(3894),
           new Car(1001),
           new Car(2019)
        };

        Array.Sort(array_car); // 정리

        foreach (Car car in array_car)
        {
            car.printAll();
        }
    }
}