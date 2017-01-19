// Queue 형식

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
        Queue queue = new Queue();

        queue.Enqueue(new Car("1002"));
        queue.Enqueue(new Car("1004"));
        queue.Enqueue(new Car("1006"));

        Console.WriteLine("First queue is: {0}", ((Car)(queue.Peek())).getId());
        Console.WriteLine("remove car number is {0}:",((Car)queue.Dequeue()).getId());

        foreach (Car car in queue)
        {
            car.printAll();
        }
    }
};

