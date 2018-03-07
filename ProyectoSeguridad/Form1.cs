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
namespace ProyectoSeguridad
{
    public partial class Form1 : Form
    {
        Socket socket;
        EndPoint endlocal, endremote;
        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setup socket
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

           
        }

        private string GetLocalIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIpA.Text = GetLocalIP();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            //socket binding
            try {
                endlocal = new IPEndPoint(IPAddress.Parse(txtIpA.Text), Convert.ToInt32(txtPortA.Text));
                socket.Bind(endlocal);

                //Connecting
                endremote = new IPEndPoint(IPAddress.Parse(txtIpB.Text), Convert.ToInt32(txtPortB.Text));
                socket.Connect(endremote);

                //Listening
                buffer = new byte[255];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref endremote, new AsyncCallback(MessageCallBack), buffer);
                MessageBox.Show("Conexion exitosa!");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }


        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[255];
                receivedData = (byte[])aResult.AsyncState;

                //Converting byte to string

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedMessage = aEncoding.GetString(receivedData);

                //Adding messsage into listbox
                messages.Items.Add("Mi camarada: " + receivedMessage);



                buffer = new byte[255];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref endremote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[255];
            sendingMessage = aEncoding.GetBytes(txtsend.Text);

            //sending encoded message

            socket.Send(sendingMessage);

            //add to listbox
            messages.Items.Add("Yo: " + txtsend.Text);
            txtsend.Text = "";
        }

    }
}
