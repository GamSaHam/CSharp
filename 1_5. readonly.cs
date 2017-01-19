// readonly 이해

using System;

class HelloClass
{
    class Person
    {
        //readonly
        private readonly int id;

        public int ID
        {
            get {
                return id;
            }
            set
            {
                id = value; //error

            }

        }

        public Person(int id)
        {
            this.id = id;
        }
    };

    public static void Main()
    {
        Person person = new Person(1);
        Console.WriteLine(person.ID);
    }
};