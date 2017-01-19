// getter setter 이해
// 어트리 뷰트데신 get/set 메소드를 활용할 것이다.
using System;

class HelloClass
{
    class Person
    {
        private int id;

        //getter setter
        public int ID
        {
            get {
                return id;
            }
            set {
                id = value;
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
        person.ID = 10;
    }
};