///<summury>
/// UDP Client
/// 바인딩 없이 SendTo를 통해서 데이터 전달
/// ReceiveFrom을 통해서 데이터 받기
/// </summury>

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main()
    {
        byte[] data = new byte[1024];

        IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("192.168.0.13"), 7000);
        Socket server = new Socket(AddressFamily.I
        nterNetwork, SocketType.Dgram, ProtocolType.Udp);

        data = Encoding.Default.GetBytes("Hello Udp Server");
        server.SendTo(data, data.Length, SocketFlags.None, ipep);

        Console.WriteLine("UDP 서버 접속 성공..");

        IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
        EndPoint remote = (EndPoint)(sender);

        for (int i = 0; i < 10; i++)
        {
            data = new byte[1024];
            int recv_size = server.ReceiveFrom(data, ref remote);
            Console.WriteLine("Recive data: {0} , {1}", remote.ToString(), Encoding.Default.GetString(data, 0, recv_size));

        }
        server.Close();

    }


};