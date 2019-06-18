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
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Server
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
            Connect();
            CheckForIllegalCrossThreadCalls = false;
        }

        IPEndPoint Ip;
        Socket Server;
        List<Socket> clients;
        /// <summary>
        /// kết nối tới server
        /// </summary>
        void Connect()
        {
            clients = new List<Socket>();
            Ip = new IPEndPoint(IPAddress.Any, 9999);
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            Server.Bind(Ip);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {

                        Server.Listen(100);
                        Socket client = Server.Accept();
                        clients.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);

                    }
                }
                catch (Exception)
                {

                    Ip = new IPEndPoint(IPAddress.Any, 9999);
                    Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
              
            });
            Listen.IsBackground = true;
            Listen.Start();

        }

        /// <summary>
        /// Đóng kết nối
        /// </summary>
        void close()
        {
            Server.Close();
        }

        /// <summary>
        /// Gửi data cho tất cả client
        /// </summary>
        void Send(Socket client)
        {
            if (client != null && textBox1.Text != string.Empty)
                client.Send(Serialize("Server: " + textBox1.Text));
           
        }

        /// <summary>
        /// Nhận data
        /// </summary>
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    foreach (Socket item in clients)
                    {
                        if(item!=null && item != client)
                       item.Send(Serialize((string)Deserialize(data)));
                    }
                    AddMessage((string)Deserialize(data));

                }
            }
            catch (Exception)
            {
                clients.Remove(client);
                client.Close();
            }
        }


        void AddMessage(string s)
        {
            listView1.Items.Add(new ListViewItem() { Text = s });
        }
        /// <summary>
        /// Phân mảnh data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        byte[] Serialize(object data)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, data);

            return stream.ToArray();
        }

        /// <summary>
        /// Gom mảnh data 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        object Deserialize(byte[] data)
        {
            MemoryStream steam = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(steam);
        }

        private void FormServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            close();
        }

        private void buttonserversend_Click(object sender, EventArgs e)
        {
            foreach (Socket client in clients)
            {
                Send(client);
            }
            AddMessage("Server: " +textBox1.Text );
            textBox1.Clear();

        }
    }
}
