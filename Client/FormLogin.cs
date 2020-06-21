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
                //trả về cho máy tính chủ với số cổng được chọn từ phạm vi số cổng đã đăng ký.
                //chứa đựng thông tin  như hostname , IP adress ,alises for host
                IPHostEntry ipHostEntry = Dns.GetHostEntry(hostName);
                // danh sách kiểu địa chỉ IP chứa  chứa địa chỉ IP phân giải tên máy chủ đc chứa trong thuộc tính alises
                IPAddress[] iPAddress = ipHostEntry.AddressList;
                //tạo giao thức TCP socket
                TCPclient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                foreach (IPAddress ip in iPAddress)
                {
                    try
                    {
                        ipe = new IPEndPoint(IPAddress.Parse(ip.ToString()), 9124);
                        // kết nối socket đến remove endpoint ( localhost sever )
                        
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
                if (txtusername.Text == string.Empty)
                {
                    MessageBox.Show("Username is not empty!");
                }
                else
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
