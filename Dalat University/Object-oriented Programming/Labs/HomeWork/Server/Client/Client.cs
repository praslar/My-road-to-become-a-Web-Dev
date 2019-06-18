using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            Connect();
            CheckForIllegalCrossThreadCalls = false;
        }
        IPEndPoint Ip;
        Socket client;
        /// <summary>
        /// kết nối tới server
        /// </summary>
        void Connect()
        {
            Ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                client.Connect(Ip);
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
          

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        /// <summary>
        /// Đóng kết nối
        /// </summary>
        void close()
        {
            client.Close();
        }

        /// <summary>
        /// Gửi data
        /// </summary>
        void Send()
        {
            if (textBox1.Text != string.Empty)
                client.Send(Serialize(textBox1.Text));

        }

        /// <summary>
        /// Nhận data
        /// </summary>
        void Receive()
        {
            try
            { 
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = (string)Deserialize(data);

                    AddMessage(message);
                }
            }
            catch (Exception)
            {
                Close();
            }

        }

        /// <summary>
        /// Add message vào khung chat
        /// </summary>
        /// <param name="s"></param>
        void AddMessage(string s)
        {

            listView1.Items.Add(new ListViewItem() { Text = s });
            textBox1.Clear();
        }
        /// <summary>
        /// Phân mảnh data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        byte[] Serialize(object data)
        {
            MemoryStream steam = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(steam, data);

            return steam.ToArray();
        }

        /// <summary>
        /// Gom mảnh data 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void buttonclientsend_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(textBox1.Text);

        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            close();
        }
    }
}
