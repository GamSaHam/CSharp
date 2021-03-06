///<summary>
/// TCP Client
/// </summary>

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

        server.Connect(ipep);

        Console.WriteLine("서버에 접속...");

        byte[] data = new byte[1024];

        server.Receive(data);

        Console.WriteLine("수신 데이터: {0}", Encoding.Default.GetString(data));

        server.Send(Encoding.Default.GetBytes("데이터 전송중.."));

        server.Close();
    }
};



/*
///<summary>
/// TCP Client
/// </summary>

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

        server.Connect(ipep);

        Console.WriteLine("서버에 접속...");

        byte[] data = new byte[1024];

        ReceiveData(data, server);

        Console.WriteLine("수신 데이터: {0}", Encoding.Default.GetString(data));

        //server.Send(Encoding.Default.GetBytes("데이터 전송중.."));
        SendData(Encoding.Default.GetBytes("데이터 전송중.."), server);

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