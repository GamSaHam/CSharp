///<summary>
/// base 키워드 이해
/// </summary>

using System;

class Base
{
    public int _val = 10;

    public Base()
    {
    }

    public Base(int val)
    {
        _val = val;
    }

};

class Derived : Base
{
    public Derived():base(20) // base이용한 부모 생성자 호출
    {
    }
    public void printValue()
    {
        Console.WriteLine("Base Value:{0}", base._val);
    }

};

class HelloWorld
{
    public static void Main()
    {
        Derived derived = new Derived();

        derived.printValue();
    }
};

