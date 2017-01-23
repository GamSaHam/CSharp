// Interface 에 이해

/// 인터페이스 활용 1
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
///

/// 인터페이스 활용 2
using System;

namespace TEST
{
    interface MyInterface
    {
        void Show();   
    }

    class A : MyInterface
    {
        public void Show() { Console.WriteLine("A::Show()"); }
    }

    class B : MyInterface
    {
        public void Show() { Console.WriteLine("B::Show()"); }
    }

    class C : MyInterface
    {
        public void Show() { Console.WriteLine("C::Show()"); }
    }
    class InterfaceExam
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            MyInterface[] inter = new MyInterface[3];
            inter[0] = (MyInterface)a;
            inter[1] = (MyInterface)b;
            inter[2] = (MyInterface)c;

            for (int i = 0; i < inter.Length; i++)
                inter[i].Show();
        }
    }
}

///