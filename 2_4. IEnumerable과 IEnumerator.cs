// IEnumerable과 IEnumerator 활용

using System;
using System.Collections;

public class Animal
{
    public Animal(string duck)
    {
        _duck = duck;
    }

    private string _duck;
    public string DUCK
    {
        get { return _duck; }
    }

};

public class Farm: IEnumerable
{
    private Animal[] _array_animals;

    public Farm(Animal[] array_animal)
    {
        _array_animals = new Animal[array_animal.Length];

        for (int i = 0; i < array_animal.Length; i++)
        {
            _array_animals[i] = array_animal[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator)GetEnumerator();
    }

    public AnimalEnum GetEnumerator() { return new AnimalEnum(_array_animals); }
};

public class AnimalEnum : IEnumerator
{
    public Animal[] _array_animal;

    // Enumerators are positioned before the first element
    // until the first MoveNext() call.
    int position = -1;

    public AnimalEnum(Animal[] array)
    {
        _array_animal = array;
    }

    public bool MoveNext()
    {
        position++;
        return (position < _array_animal.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public Animal Current
    {
        get
        {
            try
            {
                return _array_animal[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}

class HelloClass
{
    public static void Main()
    {
        Animal[] array_animal = new Animal[3]
            {
                new Animal("dog"),
                new Animal("cat"),
                new Animal("bird")
            };

        Farm fram = new Farm(array_animal);

        foreach (Animal animal in fram)
        {
            Console.WriteLine(animal.DUCK);
        }
    }
}