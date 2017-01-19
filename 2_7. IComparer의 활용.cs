// IComparer의 활용

using System;
using System.Collections;

class Person
{
    public Person(string name,int age)
    {
        _name = name;
        _age = age;
    }

    public void printAll()
    {
        Console.WriteLine(_name);
        Console.WriteLine(_age);
    }

    public string getName() { return _name; }

    private string _name;
    private int _age;
};

class SortByName : IComparer
{
    int IComparer.Compare(object x, object y)
    {
        Person p1 = (Person)x;
        Person p2 = (Person)y;

        return string.Compare(p1.getName(), p2.getName());
    }
};

class HelloWorld
{
    public static void Main()
    {
        Person[] persons = new Person[3] {
            new Person("Lee",27),
            new Person("Park",30),
            new Person("Kim",32),
        };

        Array.Sort(persons, new SortByName());

        foreach (Person p in persons)
        {
            p.printAll();
        }
    }
};