///<summary>
/// Task
/// 유니티 상에서는 Task가 안된다.
/// </summary>

using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Action print = () =>
        {
            Console.WriteLine("Action1");
        };

        Task t1 = new Task(print);

        t1.Start();
        t1.Wait();
    }
};