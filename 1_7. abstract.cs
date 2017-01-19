using System;

class HelloClass
{
    //abstract
    abstract public class A
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
        // A b = new A(); // error 객채생성을 막는다.
        b.print();
     
    }
};