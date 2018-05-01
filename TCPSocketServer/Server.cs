using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;


namespace TCPSocketServer
{
    class Server
    {
      
        static Socket ServerSocket; 
        
        public IPAddress IP { get; set; }
      
        public int Port { get; set; }
        private bool ServerOn = false;
        public string Name { get; set; }
        static List<ClientInfo> ClientList;
        private string strLocalIP4;



        public Server(IPAddress ip, int port)
        {         
            ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipEndPoint = new IPEndPoint(ip, port);
            ServerSocket.Bind(ipEndPoint);

            Thread listeningThread = new Thread(ListenForClient);
            listeningThread.Start();

            ServerOn = true;                          
        }

        static void ListenForClient()
        {
            for(; ; )
            {
                ServerSocket.Listen(0);
                ClientList.Add(new ClientInfo(ServerSocket.Accept()));
            }
        }



    }
    
    class ClientInfo
    {
        public Socket ClientSocket;
        public Thread ClientThread;
        public string ClientID;

        public ClientInfo()
        {
            ClientID = Guid.NewGuid().ToString();
        }
        public ClientInfo(Socket clientSocket)
        {
            this.ClientSocket = clientSocket;
            ClientID = Guid.NewGuid().ToString();
        }
    }



}
