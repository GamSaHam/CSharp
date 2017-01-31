///<summary>
/// Net 
/// </summary>


// example 1
/*
using System;
using System.Net;

class Program
{
    static void Main()
    {
        IPAddress ex1 = IPAddress.Parse("192.168.0.13");
        IPEndPoint ie = new IPEndPoint(ex1, 8000);

        Console.WriteLine("{0}", ie.Address);
        Console.WriteLine("{0}", ie.Port);
        Console.WriteLine("{0}, {1}", IPEndPoint.MaxPort,IPEndPoint.MinPort);
    }
};
*/

/*
using System;
using System.Net;

class Program
{
    static void Main()
    {
        IPAddress[] host = Dns.GetHostAddresses("192.168.0.13");


        Console.WriteLine("호스트 이름:{0}", Dns.GetHostEntry(host[0]).HostName);

        for (int i = 0; i < host.Length; i++)
        {
            IPAddress ip = host[i];
            Console.WriteLine("[{0}]", ip.ToString());
        }
    }
};
*/