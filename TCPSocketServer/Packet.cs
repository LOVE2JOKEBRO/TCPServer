using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;




namespace TCPSocketServer
{
    [Serializable]
    public class Packet
    {
        public List<string> Gdata;
        public int numPacket;
        public bool isPacket;
        public string senderID;
        //public PacketType packetType;

        public Packet(string senderID)
        {
            Gdata = new List<string>();
            this.senderID = senderID;
            //this.packetType = type;

        }

        public Packet(byte[] arrPacketBytes)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream mStream = new MemoryStream(arrPacketBytes);

            Packet packet = (Packet)bf.Deserialize(mStream);
            mStream.Close();

            this.Gdata = packet.Gdata;
            this.numPacket = packet.numPacket;
            this.isPacket = packet.isPacket;
            this.senderID = packet.senderID;
            //this.packetType = pack.packetType;
        }
        public byte[] ToBytes()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();

            bf.Serialize(ms, this);
            byte[] bytes = ms.ToArray();

            ms.Close();
            return bytes;
        }
        public static string GetLocalIP4()
        {
            IPAddress[] arrayIP4 = Dns.GetHostAddresses(Dns.GetHostName());
            foreach(IPAddress i in arrayIP4)
            {
                if (i.AddressFamily == AddressFamily.InterNetwork)
                {
                    return i.ToString();
                }
            }
            return "127.0.0.1";
        }
    }
}
