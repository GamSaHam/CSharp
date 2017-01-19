// ArrayList 활용

using System;
using System.Collections; // ArrayList

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

    private string _id;
};

class HelloWorld
{
    public static void Main()
    {
        ArrayList array_list = new ArrayList();

        array_list.AddRange(new Car[] { // 초기화
            new Car("1123"),
            new Car("2345"),
            new Car("6542")
        });

        Console.WriteLine("array_list Count is :{0}", array_list.Count);

        array_list.Insert(array_list.Count, new Car("5504")); // 추가

        foreach (Car car in array_list) //출력
        {
            car.printAll();
        }
    }
};


/// ArrayList 는 어떠한 자료형이든 추가가능 Object형이기 때문에.
// ArrayList 활용 2

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

public class Cars
{
    public void addCar(Car car)
    {
        _array_list.Add(car);
    }

    public void removeCar(Car car)
    {
        _array_list.Remove(car);
    }

    public Car findCarById(string id)
    {
        foreach (Car car in _array_list)
        {
            if (car.getId() == id)
            {
                return car;  
            }
        }
        return null;

    }

    public void printAll()
    {
        foreach (Car car in _array_list)
        {
            Console.WriteLine(car.getId());
        }
    }

    private ArrayList _array_list = new ArrayList();
};

class HelloWorld
{

    public static void Main()
    {
        Cars cars = new Cars();

        cars.addCar(new Car("1001"));
        cars.addCar(new Car("1002"));
        cars.addCar(new Car("1003"));

        Car car = cars.findCarById("1002");
        if (car == null)
        {
            Console.WriteLine("Car Is Empty");
        }

        cars.removeCar(car);

        cars.printAll();
    }
};
///