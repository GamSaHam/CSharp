// is as키워드의 이해

using System;

class HelloClass
{
    public interface IWeapon
    {
        void attack();
    };

    public interface IArmor
    {
        void defence();
    };

    class Person : IWeapon
    {
        public void attack()
        {
            Console.WriteLine("Attack");
        }
    };

    static void Main()
    {
        Person p = new Person();

        IArmor iArmor = p as IArmor;  // 포함되어 있는지 확인.

        if (iArmor != null)
        {
            iArmor.defence();
        }
        else
        {
            Console.WriteLine("Armor Interface is not included.");
        }

        if (p is IWeapon)  // 포함 되어있는지 확인.
        {
            Console.WriteLine("Weapon Interface is included.");
        }
    }
}