using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace крестики_нолики
{
    public partial class Connect : Form
    {
        IPEndPoint ep;
        public Connect()
        {
            InitializeComponent();
        }

        private void Connect_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.1.66"), 8001);
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ep);
            string msg="  ";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    msg += Arr.getArrone(i, j);

                }
            }

            
                byte[] data = Encoding.Unicode.GetBytes(msg);
                socket.Send(data);
                socket.Close();
                buttonconnect.Enabled = true;
          

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
