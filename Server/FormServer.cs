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
using General;

namespace Server
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            tbActivityHis.Enabled = false;
        }
        private class bdata
        {
            public byte[] data = new byte[1024];
        }
        Socket TCPserver,TCPclient;
        IPEndPoint ipe;
        List<Player> player = new List<Player>();
        List<Room> phong = new List<Room>();
        Thread thclient;   // tạo luồng của clent 
        
        private void button1_Click(object sender, EventArgs e) // mở server để lắng nghe CLient
        {
            try
            {   //(IPAdress.any) cung cấp 1 địa chỉ IP chỉ ra rằng máy chủ phải lằng nghe hoạt động  của máy khách trên tất cả các giao diện mang 
                ipe = new IPEndPoint(IPAddress.Any, 9124); 
                // tạo socket sever bằng giao thức TCP socket 
                TCPserver = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // socket liên kết với endpoint ( điểm cuối sử dụng  bind)
                 TCPserver.Bind(ipe);
                //tối đa cho 100 máy client cho phép kết nối nếu máy thứ 101 thì phản hồi là sever đang bận
                TCPserver.Listen(100);

                Thread threadServer = new Thread(new ThreadStart(LangNgheClient));      //chạy tác vụ (phương thức) LangNgheClient 
                threadServer.IsBackground = true;
                //thread đc gọi khi bắt đầu start
                threadServer.Start();

                btOpenServ.Visible = false;
                btCloseServ.Visible = true;

                AppendTextThongBao("Sẵn Sàng Lằng Nghe Kết Nối Từ Client");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void AppendTextThongBao(string s)
        {
            tbActivityHis.SelectionColor = Color.Black;
            tbActivityHis.AppendText(s);
            tbActivityHis.ScrollToCaret();
        }
        private void LangNgheClient()
        {

            // chạy liên tục  lắng nghe  không dừng 
            while (true)
            {
                try
                {

                    TCPclient = TCPserver.Accept();         //chấp nhận kết nối của client
                    Player pl = new Player(); // tạo 1 cái play er
                    pl.socket = TCPclient;
                    pl.ipaddress = pl.socket.RemoteEndPoint.ToString();     //cỗng kết nối của client
                    player.Add(pl);

                    thclient = new Thread(LangNgheClientMoi);   // thread để các client không xung đột 
                    thclient.IsBackground = true;
                    // bắt đầu chạy ( phương thức LangNgheClientMoi)) player -> nhiều player thì sẽ chia nhiều luồn không xung đột
                    thclient.Start(pl);

                    tbActivityHis.SelectionColor = Color.Blue;
                    tbActivityHis.AppendText("\nChấp Nhận kết nối từ " + pl.socket.RemoteEndPoint.ToString());
                    tbActivityHis.ScrollToCaret();
                    
                }
                catch
                {
                    
                }
            }
        }
        string str;
        string[] a_str;
        int recv;

        bdata bb = new bdata();
        private void LangNgheClientMoi(object obj)
        {
            Player ple = (Player)obj;
            while (true)
            {
                try
                {
                    recv=ple.socket.Receive(bb.data);
                    str = Encoding.Unicode.GetString(bb.data,0,recv);
                    a_str = str.Split('|');
                    bdata dd = new bdata();
                    dd.data = Encoding.Unicode.GetBytes(str);
                    LangNgheClient2(a_str[0], dd.data, ple);
                }
                catch
                {

                    tbActivityHis.SelectionColor = Color.Blue;
                    tbActivityHis.AppendText("\n" + ple.socket.RemoteEndPoint.ToString() + " Đã Đóng Kết Nối");
                    tbActivityHis.ScrollToCaret();

                    player.Remove(ple);

                    break;
                }
            }
        }
        private void LangNgheClient2(string s, byte[] data, Player ple)
        {
            switch (s)
            {
                case "DANHCARO":
                    DanhCaRo(str, data, ple);
                    break;
                case "CHAT":
                    SendAllClient(data);
                    break;
                case "CHATPHONG":
                    chatphong(data, ple);
                    break;
                case "WINNER":
                    Winner(str, data,ple);
                    break;
                case "NAMECLIENT":
                    setnameclient(str,ple);
                    break;
                case "TAOPHONGMOI":
                    taophongmoi(str, ple);
                    break;
                case "LAYIDPHONG":
                    layidphong(ple);
                    break;
                case "LAYDANHSACHPHONG":
                    laydanhsachphong(ple);
                    break;
                case "VAOPHONGGAME":
                    vaophong(str,ple);
                    break;
                case "THOATKHOIPHONGGAME":
                    thoatphonggame(str,data,ple);
                    break;
                case "LAYDANHSACHPLAYER":
                    laydanhsachplayer(ple);
                    break;
            }
        }
        private void thoatphonggame(string str,byte[] data,Player ple)
        {
            a_str = str.Split(',');
            if (int.Parse(a_str[1]) == 2)
            {
                if (ple.room.siso == 2)
                {
                    Room r = ple.room;
                    data=Encoding.Unicode.GetBytes("BANLACHUPHONG|,"+"Người Chơi "+r.plnguoichoi1.name+" Đã thoát,");
                    r.plnguoichoi2.socket.Send(data, data.Length, SocketFlags.None);
                    r.plnguoichoi1 = r.plnguoichoi2;
                    r.plnguoichoi2 = null;
                    r.siso = 1;
                    ple.room.plnguoichoi1.room = r;
                }
                else
                {
                    phong.Remove(ple.room);
                    ple.room = null;
                }
            }
            else
            {
                if (ple.room.siso == 2)
                {
                    Room r = ple.room;
                    data = Encoding.Unicode.GetBytes("BANLACHUPHONG|," + "Người Chơi " + r.plnguoichoi2.name + " Đã thoát,");
                    r.plnguoichoi1.socket.Send(data, data.Length, SocketFlags.None);
                    r.siso = 1;
                    r.plnguoichoi2 = null;
                    r.plnguoichoi1.room = r;
                }
                else
                {
                    phong.Remove(ple.room);
                    ple.room = null;
                }
            }

        }
        private void vaophong(string str,Player ple)
        {
            a_str = str.Split(',');
            int idphong = int.Parse(a_str[1]);
            Player plr = timphong(idphong);
            bdata b = new bdata();
            Room r=plr.room;
            if (r.siso == 1)
            {
                r.siso = 2;
                r.plnguoichoi2 = ple;
                ple.room = r;
                plr.room = r;
                b.data = Encoding.Unicode.GetBytes("NGUOICHOIMOIVAOPHONG|," + r.plnguoichoi2.name + ",");
                plr.socket.Send(b.data, b.data.Length, SocketFlags.None);
            }
            else
            {
                b.data = Encoding.Unicode.GetBytes("PHONGDADAY|,");
                ple.socket.Send(b.data, b.data.Length, SocketFlags.None);
            }
        }
        private Player timphong(int idphong)
        {
            foreach (Player plr in player)
            {
                if (plr.room.sophong == idphong)
                {
                    return plr;
                }
            }
            return null;
        }
        private void laydanhsachphong(Player ply)
        {
            if (phong.Count > 0)
            {
                byte[] data=new byte[1024];
                string danhsachphong = "DANHSACHPHONGGAME|,";
                foreach (Room r in phong)
                {
                    danhsachphong += r.sophong+"\t("+r.siso + "/2),";
                }
                data = Encoding.Unicode.GetBytes(danhsachphong);
                ply.socket.Send(data, data.Length, SocketFlags.None);
            }
        }

        private void laydanhsachplayer(Player ply)
        {
            //if (phong.Count > 0)
            {
                byte[] data = new byte[1024];
                string danhsachplayer = "DANHSACHPLAYER|,";
                foreach (Player p in player)
                {
                    danhsachplayer += p.room + "\t(" + p.name + "/2),";
                }
                data = Encoding.Unicode.GetBytes(danhsachplayer);
                ply.socket.Send(data, data.Length, SocketFlags.None);
            }
        }
        private void layidphong(Player ple)
        {
            bdata b = new bdata();
            b.data = Encoding.Unicode.GetBytes("IDPHONGGAME|," +ple.room.sophong +",");
            ple.socket.Send(b.data, b.data.Length, SocketFlags.None);
        }
        private void taophongmoi(string str, Player ple)
        {
            Room r = new Room();
            r.sophong = phong.Count+1;
            r.siso = 1;
            r.plnguoichoi1 = ple;
            phong.Add(r);
            ple.room = r;
        }
        private void setnameclient(string str,Player ple)
        {
            a_str = str.Split(',');
            ple.name = a_str[1];
        }
        private void Winner(string str, byte[] data,Player ple)
        {
            a_str = str.Split(',');
            
            SendAClient((int.Parse(a_str[1]) == 2) ? ple.room.plnguoichoi2.socket : ple.room.plnguoichoi1.socket, data);
        }
        private void chatphong(byte[] data, Player ple)
        {
            if (ple.room.siso == 1)
                SendAClient(ple.socket, data);
            else
            {
                SendAClient(ple.room.plnguoichoi1.socket, data);
                SendAClient(ple.room.plnguoichoi2.socket, data);
            }
        }
        private void DanhCaRo(string str,byte[] data,Player ple)
        {
            a_str = str.Split(',');
            SendAClient((int.Parse(a_str[3]) == 2) ? ple.room.plnguoichoi2.socket : ple.room.plnguoichoi1.socket, data);
        }
        private void SendAClient(Socket sk, byte[] data)
        {
            sk.Send(data, data.Length, SocketFlags.None);
        }
        private void SendAllClient(byte[] data)
        {
            foreach (Player pl in player)
            {
                pl.socket.Send(data, data.Length, SocketFlags.None);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                btOpenServ.Visible = true;
                btCloseServ.Visible = false;

                TCPserver.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
