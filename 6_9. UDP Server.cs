///<summary>
/// UDP Server
/// Bind후에 ReceiveForm을 통해서 대기
/// SendTo를 통해서 데이터 값 전달
/// </summary>

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
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); // udp 설정

        // 바인딩
        server.Bind(ipep);

        Console.WriteLine("UDP 서버 시작...");

        IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
        EndPoint remote = (EndPoint)(sender);

        // TCP에 Listen 대신 ReceiveForm
        int recv_size = server.ReceiveFrom(data, ref remote);

        Console.WriteLine("{0} 수신 데이터 {1}", remote.ToString(), Encoding.Default.GetString(data, 0, recv_size));

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Send data");
            data = Encoding.Default.GetBytes("data: " + i);
            server.SendTo(data, data.Length, SocketFlags.None, remote);

        }
        server.Close();
    }
};
