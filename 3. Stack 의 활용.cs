// Stack 활용
using System;
using System.Collections;

public class Car
{
    public Car(string id)
    {
        _id = id;
    }

    public void printAll()
    {
        Console.WriteLine("car id is {0}", _id);
    }

    public string getId() { return _id; }

    private string _id;
};

class HelloWorld
{
    static void Main()
    {
        Stack stack = new Stack();
        stack.Push(new Car("1002"));
        stack.Push(new Car("1003"));
        stack.Push(new Car("1004"));

        Console.WriteLine("{0}", ((Car)stack.Peek()).getId());
        Console.WriteLine("{0}", ((Car)stack.Pop()).getId());

        foreach (Car car in stack)
        {
            car.printAll();
        }
    }
};