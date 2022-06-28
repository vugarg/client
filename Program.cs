using System.Net;
using System.Net.Sockets;
using System.Text;

IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
IPAddress ipAddr = ipHost.AddressList[2];
IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 8080);

Socket sender = new Socket(ipAddr.AddressFamily, 
    SocketType.Stream, ProtocolType.Tcp);

sender.Connect(localEndPoint);

byte[] messageReceived = new byte[1024];


string data = null;

while (data != "q")
{
    int byteRecv = sender.Receive(messageReceived);
    data = Encoding.ASCII.GetString(messageReceived, 0, byteRecv);
    Console.WriteLine("Message from Server -> {0}",
        Encoding.ASCII.GetString(messageReceived,
            0, byteRecv));
}






