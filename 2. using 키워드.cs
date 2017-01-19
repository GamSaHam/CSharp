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
            // 내부 리소스 제거
        }


    };

    public static void Main()
    {
        using (Car car = new Car(10))
        {
        } // 호출시 Dispose 호출 되어진다.

    }
};