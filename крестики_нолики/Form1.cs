using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace крестики_нолики
{
    public partial class Form1 : Form
    {
        string player = "X";
        static int k = 3;
        static int l = 3;
        string [,] keys = new string [k,l];
        int turn = 0;
        
        public Form1()
        {
            for (int i = 0;i<k;i++) 
            {
                for (int j = 0;j<l;j++)
                {
                    Arr.setArr(i, j, " ");
                   
                }
            }
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button_Click(object sender, EventArgs e)
        {
            turn += 1;
            if (((Button)sender).Name == button1.Name)
                Arr.setArr(0, 0, player);
            if (((Button)sender).Name == button2.Name)
                Arr.setArr(0, 1, player);
            if (((Button)sender).Name == button3.Name)
                Arr.setArr(0, 2, player);
            if (((Button)sender).Name == button4.Name)
                Arr.setArr(1, 0, player);
            if (((Button)sender).Name == button5.Name)
                Arr.setArr(1, 1, player);
            if (((Button)sender).Name == button6.Name)
                Arr.setArr(1, 2, player);
            if (((Button)sender).Name == button7.Name)
                Arr.setArr(2, 0, player);
            if (((Button)sender).Name == button8.Name)
                Arr.setArr(2, 1, player);
            if (((Button)sender).Name == button9.Name)
                Arr.setArr(2, 2, player);
            ((Button)sender).Text = player;
            player = (player == "X") ? "0" : "X";
            ((Button)sender).Enabled = false;
            updateview();
            if(arrWin())
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else if (turn==9)
            {
                MessageBox.Show("Ничья!");

            }
                







        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            button_Click(sender, e);
            
        }
         bool arrWin()
        {
           if(Arr.getArrone(0, 0) == Arr.getArrone(0, 1) && (Arr.getArrone(0, 0) == Arr.getArrone(0, 2)) &&(Arr.getArrone(0, 0) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(0, 0) == Arr.getArrone(1, 0) && (Arr.getArrone(0, 0) == Arr.getArrone(2, 0)) && (Arr.getArrone(0, 0) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(0, 0) == Arr.getArrone(1, 1) && (Arr.getArrone(0, 0) == Arr.getArrone(2, 2)) && (Arr.getArrone(0, 0) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(0, 1) == Arr.getArrone(0, 0) && (Arr.getArrone(0, 1) == Arr.getArrone(0, 2)) && (Arr.getArrone(0, 1) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(0, 1) == Arr.getArrone(1, 1) && (Arr.getArrone(0, 1) == Arr.getArrone(2, 1)) && (Arr.getArrone(0, 1) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(0, 2) == Arr.getArrone(0, 1) && (Arr.getArrone(0, 2) == Arr.getArrone(0, 0)) && (Arr.getArrone(0, 2) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(0, 2) == Arr.getArrone(1, 2) && (Arr.getArrone(0, 2) == Arr.getArrone(2, 2)) && (Arr.getArrone(0, 2) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((Arr.getArrone(0, 2) == Arr.getArrone(1, 1)) && (Arr.getArrone(0, 2) == Arr.getArrone(2, 0)) && (Arr.getArrone(0, 2) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((Arr.getArrone(1, 0) == Arr.getArrone(1, 1)) && (Arr.getArrone(1, 0) == Arr.getArrone(1, 2)) && (Arr.getArrone(1, 0) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(1, 0) == Arr.getArrone(0, 0) && (Arr.getArrone(1, 0) == Arr.getArrone(2, 0)) && (Arr.getArrone(1, 0) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(1, 0) == Arr.getArrone(1, 1) && (Arr.getArrone(1, 0) == Arr.getArrone(1, 2)) && (Arr.getArrone(1, 0) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(1, 1) == Arr.getArrone(0, 0) && (Arr.getArrone(1, 1) == Arr.getArrone(2, 2)) && (Arr.getArrone(1, 1) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(1, 1) == Arr.getArrone(2, 1) && (Arr.getArrone(1, 1) == Arr.getArrone(0, 2)) && (Arr.getArrone(1, 1) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(1, 1) == Arr.getArrone(0, 2) && (Arr.getArrone(1, 1) == Arr.getArrone(2, 0)) && (Arr.getArrone(1, 1) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(1, 1) == Arr.getArrone(0, 1) && (Arr.getArrone(1, 1) == Arr.getArrone(2, 0)) && (Arr.getArrone(1, 1) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(1, 2) == Arr.getArrone(0, 2) && (Arr.getArrone(1, 2) == Arr.getArrone(2, 0)) && (Arr.getArrone(1, 2) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(1, 2) == Arr.getArrone(1, 0) && (Arr.getArrone(1, 2) == Arr.getArrone(1, 1)) && (Arr.getArrone(1, 2) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(2, 0) == Arr.getArrone(2, 1) && (Arr.getArrone(2, 0) == Arr.getArrone(2, 2)) && (Arr.getArrone(2, 0) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if (Arr.getArrone(2, 1) == Arr.getArrone(2, 0) && (Arr.getArrone(2, 1) == Arr.getArrone(2, 2)) && (Arr.getArrone(2, 1) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((Arr.getArrone(2, 2) == Arr.getArrone(2, 1)) && (Arr.getArrone(2, 2) == Arr.getArrone(2, 0)) && (Arr.getArrone(2, 2) != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            return false;


        }
        public void updateview()
        {
            button1.Text =Arr.getArrone(0,0);
            button2.Text = Arr.getArrone(0, 1);
            button3.Text = Arr.getArrone(0, 2);
            button4.Text = Arr.getArrone(1, 0);
            button5.Text = Arr.getArrone(1, 1);
            button6.Text = Arr.getArrone(1, 2);
            button7.Text = Arr.getArrone(2, 0);
            button8.Text = Arr.getArrone(2, 1);
            button9.Text = Arr.getArrone(2, 2);   
        }
        bool Iswin() 
        { 
            if(((button1.Text != " " && button1.Text==button2.Text)&&(button1.Text == button3.Text))&&(button1.Text !=" "))
            {
                MessageBox.Show("Победа!");
                return true; 
            }
            if ((button1.Text == button4.Text) && (button1.Text == button7.Text) && (button1.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((button1.Text == button5.Text) && (button1.Text == button9.Text) && (button1.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            //кнопка 2
            if ((button2.Text == button1.Text) && (button2.Text == button3.Text) && (button2.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((button2.Text == button5.Text) && (button2.Text == button8.Text) && (button2.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            //кнопка 3
            if ((button3.Text == button1.Text) && (button3.Text == button2.Text) && (button3.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((button3.Text == button4.Text) && (button3.Text == button5.Text) && (button3.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((button3.Text == button5.Text) && (button3.Text == button7.Text) && (button3.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            //кнопка 4
            if ((button4.Text == button4.Text) && (button4.Text == button6.Text) && (button4.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((button4.Text == button1.Text) && (button4.Text == button7.Text) && (button4.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            //кнопка 5
            if ((button5.Text == button2.Text) && (button5.Text == button8.Text) && (button5.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((button5.Text == button4.Text) && (button5.Text == button6.Text) && (button5.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((button5.Text == button1.Text) && (button5.Text == button9.Text) && (button5.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((button5.Text == button3.Text) && (button5.Text == button7.Text) && (button5.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            //кнопка 6
            if ((button6.Text == button5.Text) && (button6.Text == button4.Text) && (button6.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((button6.Text == button3.Text) && (button6.Text == button9.Text) && (button6.Text != " "))
            {
                MessageBox.Show("Победа!");
                this.Close();
                return true;
            }
            //кнопка 7
            if ((button7.Text == button4.Text) && (button7.Text == button1.Text) && (button7.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((button7.Text == button8.Text) && (button7.Text == button9.Text) && (button7.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((button7.Text == button5.Text) && (button7.Text == button3.Text) && (button7.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            //кнопка 8
            if ((button8.Text == button7.Text) && (button8.Text == button9.Text) && (button8.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((button8.Text == button5.Text) && (button8.Text == button2.Text) && (button8.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            //кнопка 9
            if ((button9.Text == button8.Text) && (button9.Text == button7.Text) && (button9.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((button9.Text == button5.Text) && (button9.Text == button1.Text) && (button9.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            if ((button9.Text == button6.Text) && (button9.Text == button3.Text) && (button9.Text != " "))
            {
                MessageBox.Show("Победа!");
                return true;
            }
            return false;

        }
        static Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static bool netgame = false;
        static void serverstart()
        {
            try
            {
                IPEndPoint ep=new IPEndPoint(IPAddress.Parse("192.168.1.66"), 8001);
            

            listen.Bind(ep);
            listen.Listen(10);
            StringBuilder sb=new StringBuilder();
            int bytes = 0;
            byte[] data = new byte[1024];
           


                listen=listen.Accept();
                bytes=listen.Receive(data);
                if (listen.Connected)
                {
                    string msg=Encoding.Unicode.GetString(data, 0, bytes);
                    MessageBox.Show(msg,"подключен");
                }
                

            


            sb.Append(Encoding.Unicode.GetString(data));
            netgame=true;
            }
            catch { }


        }
        Thread tserver = new Thread(serverstart);
         bool server = false;
        static public void ServerStart()
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
        Thread tServer = new Thread(ServerStart);
        bool ServerON = false;
        private void button10_Click(object sender, EventArgs e)
        {

            Server.StartServer(ServerON);
            ServerON = !ServerON;

        }
        

        private void button11_Click(object sender, EventArgs e)
        {
            player = "X";
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    keys[i, j] = " ";
                }
            }
            Connect c = new Connect();
            c.ShowDialog();
        }
    }
}
