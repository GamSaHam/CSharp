// Interface 에 이해
using System;

namespace ConsoleApplication32
{
    interface IMyInterfaceA
    {
        void print();
    }

    interface IMyInterfaceB
    {
        void print();
    }

    class MyClass : IMyInterfaceA, IMyInterfaceB
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            IMyInterfaceA imca = mc;
            imca.print();

            IMyInterfaceB imcb = mc;
            imcb.print();
        }

        void IMyInterfaceA.print()
        {
            Console.WriteLine("IMyInterfaceA.print() 호출.");
        }

        void IMyInterfaceB.print()
        {
            Console.WriteLine("IMyInterfaceB.print() 호출.");
        }
    }
}