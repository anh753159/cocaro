using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        Socket TCPclient;
        IPEndPoint ipe;
        bool daketnoi = false;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName();
            try
            {

                IPHostEntry ipHostEntry = Dns.GetHostEntry(hostName);

                IPAddress[] iPAddress = ipHostEntry.AddressList;
                TCPclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                foreach (IPAddress ip in iPAddress)
                {
                    try
                    {
                        ipe = new IPEndPoint(IPAddress.Parse(ip.ToString()), 9124);
                       
                        TCPclient.Connect(ipe);
                        daketnoi = true;
                        break;
                    }
                    catch { }
                }
                if (!daketnoi)
                {
                    MessageBox.Show("Không tìm thấy server");
                    Application.Exit(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy server");
                Application.Exit();    
            }
        }

        private void btnvaogame_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = new byte[1024];
                data = Encoding.Unicode.GetBytes("NAMECLIENT|," + txtusername.Text + ",");
                TCPclient.Send(data, data.Length, SocketFlags.None);
                

                FormGame frm = new FormGame();
                frm.username = txtusername.Text;
                frm.client = TCPclient;
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
