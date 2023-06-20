using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace крестики_нолики
{
    internal class Server
    {
        static Socket listen = null;
        static public void Start()
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.1.66"), 8001);
            listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listen.Bind(ep);
            listen.Listen(10);
            StringBuilder stringBuilder = new StringBuilder();
            int bytes = 0;
            byte[] data = new byte[1024];
            try
            {
                //netGame = true;
                listen = listen.Accept();
                bytes = listen.Receive(data);
                string mes = Encoding.Unicode.GetString(data, 0, bytes);
                if (listen.Connected)
                {
                    MessageBox.Show(mes, "");

                }
                //stringBuilder.Append(Encoding.Unicode.GetString(data,0,bytes));
            }
            catch (Exception ex) { }

        }
        static Thread tServer = new Thread(Start);
        public static void StartServer(bool ServerON)
        {
            //ServerON = !ServerON;
            if (!ServerON)
            {
                tServer = new Thread(Start);
                tServer.Start();
                MessageBox.Show("server on", "2");
            }
            else
            {
                try
                {
                    listen.Close();
                }
                catch { }
                listen = null;
                tServer.Abort();
                MessageBox.Show("server off", "2");
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("192.168.51.224"), 8001);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(ipPoint);
            string mes = "";
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    mes += Arr.getArrone(i, j);
            byte[] data = Encoding.Unicode.GetBytes(mes);
            socket.Send(data);
            socket.Close();
        }
    }
}
