// new 한정자

using System;

class HelloClass
{
    public class A
    {
        public  void print()  // 1
        {
            Console.WriteLine("Call the A");
        }

    };

    public class B: A
    {
        public void print()  // 2
        {
            Console.WriteLine("Call the B");
        }

    };

    public static void Main()
    {
        B b = new B();

        b.print();
     
    }
};

// 1 과 2가 같다고 경고문을 띠원다
// 경고문을 없에기 위해 2번에 public new void print()로 작성해준다.