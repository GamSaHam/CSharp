///<summury>
/// override 와 seal의 이해
///</summury>


using System;

class HelloClass
{
    public class A
    {
        public virtual void print()
        {
            Console.WriteLine("Call the A");
        }


    };

    public class B : A
    {
        public override void print()
        //public sealed override void print() // 2.
        {
            Console.WriteLine("Call the B");
        }

    };

    public class C : B
    {
        public override void print()   // 2. 일 경우 error
        {
            Console.WriteLine("Call the C");
        }



    };

    public static void Main()
    {
        A b = new B();
        b.print();
    }
};