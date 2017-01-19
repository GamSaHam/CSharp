// override 이해

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

    public class B: A
    {
        public override void print()
        {
            Console.WriteLine("Call the B");
        }
    };

    public static void Main()
    {
        A b = new B();
        b.print();
    }
};