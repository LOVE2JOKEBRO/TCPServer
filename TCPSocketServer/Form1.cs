using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace TCPSocketServer
{
    public partial class Form1 : Form
    {
        IPAddress ip;
        int port;

        public Form1()
        {
            InitializeComponent();
            txtLocalIP4.Text = Packet.GetLocalIP4();
            txtPort.Text = "9000";
            
        }

    

        private void btnHost_Click(object sender, EventArgs e)
        {
            try
            {
                ip = IPAddress.Parse(Packet.GetLocalIP4());//IPAddress.Parse(txtLocalIP4.Text);
                port = int.Parse(txtPort.Text);

                Server hostServer = new Server(ip, port);

                rtConsole.Text = "Local Host Created At : " + ip + ", " + port;
            }
            catch
            {
                rtConsole.Text = "Server Failed";
            }
        }

    }

}
