///<summury>
/// TCP Server
/// System.Net.Sockets
/// TCP Socket 통신시에는 Receive 할때 정해진 바이트로 리시브를 받음
/// 그래서 수신할 바이트를 크기를 미리 보낸다. example 4byte data_size
/// TCP Socket 통신시 Send시에도 마찬가지
/// </summury>

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{

    static void Main()
    {
        IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("192.168.0.13"), 7000);
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        // 소캣 순서
        server.Bind(ipep); // Bind

        server.Listen(20); // Listen

        Console.WriteLine("Starting Server");

        Socket client = server.Accept(); // Accept

        IPEndPoint ip = (IPEndPoint)client.RemoteEndPoint;
        Console.WriteLine("{0}주소, {1}포트 접속", ip.Address, ip.Port);

        byte[] data = Encoding.Default.GetBytes("환영 합니다");

        // send Byte data
        client.Send(data, data.Length, SocketFlags.None);

        data = new byte[1024];

        if (client.Receive(data) != 0)
        {
            Console.WriteLine("수신 메시지 {0}", Encoding.Default.GetString(data));

        }

        client.Close();
        server.Close();


    }
};



/*
///<summury>
/// TCP Server
/// System.Net.Sockets
/// TCP Socket 통신시에는 Receive 할때 정해진 바이트로 리시브를 받음
/// 그래서 수신할 바이트를 크기를 미리 보낸다. example 4byte data_size
/// TCP Socket 통신시 Send시에도 마찬가지
/// </summury>

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{

    static void Main()
    {
        IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("192.168.0.13"), 7000);
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        // 소캣 순서
        server.Bind(ipep); // Bind

        server.Listen(20); // Listen

        Console.WriteLine("Starting Server");

        Socket client = server.Accept(); // Accept

        IPEndPoint ip = (IPEndPoint)client.RemoteEndPoint;
        Console.WriteLine("{0}주소, {1}포트 접속", ip.Address, ip.Port);


        byte[] data = Encoding.Default.GetBytes("환영 합니다");

        // send Byte data
        //client.Send(data, data.Length, SocketFlags.None);
        SendData(data, client);


        data = new byte[1024];

        ReceiveData(data, client);

        client.Close();
        server.Close();


    }

    static void SendData(byte[] data, Socket client)
    {
        try
        {
            int total = 0;
            int size = data.Length;
            int left_data = size;
            int send_data = 0;

            // 전송할 데이터의 크기 전달
            byte[] data_size = new byte[4];
            
            data_size = BitConverter.GetBytes(size);
            send_data = client.Send(data_size);

            // 실제 데이터 전송
            while (total < size)
            {
                send_data = client.Send(data, total, left_data, SocketFlags.None);
                total += send_data;
                left_data -= send_data;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }


    static void ReceiveData(byte[] data, Socket client)
    {
        try
        {
            int total = 0;
            int size = 0;
            int left_data = 0;
            int recv_data = 0;

            // 수신할 데이터 크기 알아내기 
            byte[] data_size = new byte[4];
            recv_data = client.Receive(data_size, 0, 4, SocketFlags.None);
            size = BitConverter.ToInt32(data_size, 0);
            left_data = size;

            data = new byte[size];

            // 실제 데이터 수신
            while (total < size)
            {
                recv_data = client.Receive(data, total, left_data, 0);
                if (recv_data == 0) break;
                total += recv_data;
                left_data -= recv_data;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
    }

};


*/