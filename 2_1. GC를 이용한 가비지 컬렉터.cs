using System;

class HelloClass
{
    public class Car:IDisposable
    {
        private int m_mile;
        
        public Car(int mile)
        {
            m_mile = mile;
        }

        public void Dispose()
        {
            // GC 를 이용하여 메모리상에 해제
            GC.SuppressFinalize(this);
        }


    };

    public static void Main()
    {
        using (Car car = new Car(10))
        {
        }
    }
};