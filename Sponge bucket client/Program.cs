using System;
using System.Net.Sockets;
using System.Text;

class server client
{
    static void Main()
    {
        Console.Write("Enter server IP (default: 127.0.0.1): ");
        string ip = Console.ReadLine()?.Trim();
        if (string.IsNullOrWhiteSpace(ip)) ip = "127.0.0.1";

        TcpClient client = new TcpClient(ip, 9090);
        NetworkStream stream = client.GetStream();

        byte[] buffer = new byte[50];
        int bytes = stream.Read(buffer, 0, buffer.Length);
        Console.Write(Encoding.ASCII.GetString(buffer, 0, bytes));

        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) continue;
            if (input == "exit") break;

            byte[] data = Encoding.ASCII.GetBytes(input + "\n");
            stream.Write(data, 0, data.Length);

            bytes = stream.Read(buffer, 0, buffer.Length);
            Console.Write(Encoding.ASCII.GetString(buffer, 0, bytes));
        }

        stream.Close();
        client.Close();
    }
}

