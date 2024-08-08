using CommunityToolkit.WinUI.Notifications;
using EazyLab;
using EazyLab.Classes;
using EazyLab.Cpt.Classes;
using EazyLab.Cpt.Forms;
using EazyLab.Instrumentation.Standard;
using SuperSimpleTcp;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EazyLabClient
{
    public partial class frmCptMain : Form
    {
        DbAccess DbAccess = Server.DbAccess;
        private SuperSimpleTcp.SimpleTcpServer TcpServer;
        private string TcpServerIp = "192.168.1.201";
        private int TcpPort = 9000;
        private int IdleClientTimeoutMs = 0;
        private string TerminalIpAddress = "192.168.1.201";
        private IPEndPoint TerminalAddress;
        bool TerminalIsConnected = false;
        public int StationNo = 0;

        public CptChamber Chamber { set; get; }
        public frmCptMain()
        {

            InitializeComponent();
            try
            {

                TerminalAddress = new IPEndPoint(IPAddress.Parse(TerminalIpAddress), TcpPort); // EndPoint..creat(TerminalIpAddress);
                TerminalIpAddress = TerminalAddress.Address.ToString();
                TcpServer = new SimpleTcpServer(TcpServerIp, TcpPort);
                TcpServer.Events.ClientConnected += Events_ClientConnected;
                TcpServer.Events.ClientDisconnected += Events_ClientDisconnected;
                TcpServer.Events.DataReceived += Events_DataReceived;
                TcpServer.Events.DataSent += Events_DataSent;
                TcpServer.Keepalive.EnableTcpKeepAlives = true;
                TcpServer.Settings.IdleClientTimeoutMs = IdleClientTimeoutMs;
                TcpServer.Settings.MutuallyAuthenticate = false;
                TcpServer.Settings.AcceptInvalidCertificates = true;
                TcpServer.Settings.NoDelay = true;
                TcpServer.Logger = LoggerFile.WriteMessage;
                TcpServer.Start();
                ToastMessage(TcpServer.IsListening ? "Server Started" : "Server Not Started");
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);

            }
            ToastMessage(TcpServer.IsListening ? "Server Started" : "Server Not Started");

        }


        private void ToastMessage(string msg)
        {
            try
            {

                new ToastContentBuilder().AddText(msg).Show();

            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }

        private void Events_DataSent(object sender, DataSentEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            var ipe = IPAddressFromEndPoint(e.IpPort);

            if (ipe == TerminalIpAddress)//send by Terminal
            {
                char[] cccc = Encoding.ASCII.GetChars(e.Data.Array);
                string sss = new String(cccc);
                CommDataPacket commDataPacket = CommDataPacket.DeSerializer(sss);

            }

        }

        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            throw new NotImplementedException();
        }
        public static IPEndPoint ParseIPEndpoint(string ipEndPoint)
        {
            int ipAddressLength = ipEndPoint.LastIndexOf(':');
            return new IPEndPoint(
                IPAddress.Parse(ipEndPoint.Substring(0, ipAddressLength)),
                Convert.ToInt32(ipEndPoint.Substring(ipAddressLength + 1)));
        }
        public string IPAddressFromEndPoint(string ipEndPoint)
        {
            int ipAddressLength = ipEndPoint.LastIndexOf(':');
            return ipEndPoint.Substring(0, ipAddressLength);
        }
        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            System.Net.IPEndPoint iPEndPoint = null;
            iPEndPoint = ParseIPEndpoint(e.IpPort);
            CommDataPacket cdp = new CommDataPacket();
            cdp.Command = EnumCommands.DefineYourSelf.ToString();
            TerminalIsConnected = iPEndPoint.Address.ToString() == TerminalIpAddress.ToString();
            if (TerminalIsConnected) ToastMessage("Terminal is connected");
        }

        public string Title
        {
            set => this.Text = labelTitle.Text = value;
            get => labelTitle.Text;
        }
        private void btSettings_Click(object sender, EventArgs e)
        {
            //var frm = new frmSettings();
            //this.Hide();
            //frm.ShowDialog();
            //this.Show();
        }



        private void buttonSetup_Click_1(object sender, EventArgs e)
        {
            buttonSetup.ContextMenuStrip.Show(Cursor.Position);

        }

        private void contextMenuStripSetup_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                var clickedItem = e.ClickedItem;
                var itemName = clickedItem.Text;
                var frm = new Form();
                frm.FormBorderStyle = FormBorderStyle.None;
                switch (itemName)
                {
                    case "Server Config":

                        frm = new EazyLab.Design.frmConfigServer();
                        frm.Text = "InDoor Air Handling Configuration";
                        frm.ShowDialog();

                        break;
                    case "Ahu":

                        //EazyLab.Equipments.Controls.frmAhuDbtWbt frm1 = new EazyLab.Equipments.Controls.frmAhuDbtWbt(_chamber.Ahu);
                        ////    cntrl.Dock = DockStyle.Fill;
                        //frm1.DisplayUpdateTime = Program.UpdateTime;

                        ////frm.Width = cntrl.Width;
                        ////frm.Height = cntrl.Height;

                        //frm1.Text = "InDoor Air Handling Configuration";
                        //frm1.ShowDialog();
                        //frm1.Dispose();
                        break;
                    //case "InDoor Ahu":

                    //    cntrl = new EazyLab.Equipments.Controls.cntrlAhuVer1((AhuVer1)_chamber.InDoorAhu);
                    //    cntrl.Dock = DockStyle.Fill;
                    //    cntrl.DisplayUpdateTime = Program.UpdateTime;

                    //    frm.Width = cntrl.Width;
                    //    frm.Height = cntrl.Height;
                    //    frm.Controls.Add(cntrl);
                    //    frm.Text = "InDoor Air Handling Configuration";
                    //    frm.ShowDialog();

                    //    break;
                    //case "OutDoor Ahu":
                    //    cntrl = new EazyLab.Equipments.Controls.cntrlAhuVer1((AhuVer1)_chamber.OutDoorAhu);
                    //    cntrl.Dock = DockStyle.Fill;
                    //    cntrl.DisplayUpdateTime = Program.UpdateTime;
                    //    frm.Width = cntrl.Width;
                    //    frm.Height = cntrl.Height;
                    //    frm.Controls.Add(cntrl);
                    //    frm.Text = "OutDoor Air Handling Configuration";
                    //    frm.ShowDialog();
                    //    break;
                    case "Configure Station":

                        frm = new frmCptStation(this.Chamber);
                        frm.ShowDialog();
                        break;

                    case "Regist Barcode Scanner":
                        frm = new frmBarcodeScannerRegist();

                        frm.ShowDialog();
                        frm.Dispose();
                        //CptChamberCntrl1.SetStation(3);
                        break;

                    case "Save Chamber":
                        //CptChamberCntrl1.Set_PV_NAMES();
                        //if (!Program.Chamber.Save(Program.DbDir + "Chamber.obj"))
                        //      if (!EazyLab.Utilties.SerializeObject.Save(_chamber, Program.DbDir + "Chamber.obj"))
                        //MessageBox.Show("Failed to save Chamber.\r\nPlease See Log file");
                        SaveTagsWithColor();
                        break;
                    case "Load Chamber":
                        LoadChamber();
                        if (Chamber == null)
                        {
                            MessageBox.Show("Failed to Load Chamber.\r\nPlease See Log file");
                            return;
                        }
                        // Program.Chamber = this.Chamber = chmbr;
                        break;
                    case "Temperature Profile":

                        frmCptProfile frm3 = new frmCptProfile();
                        frm3.ShowDialog(this);
                        break;

                    case "Connect All Stations":

                        this.Cursor = Cursors.WaitCursor;
                        //Parallel.ForEach(Chamber.Stations, T =>
                        //{
                        //    T.Connect(true);
                        //});

                        foreach (var c in Chamber.Stations) c.Connect(true);
                        Cntrl.SelectStation(0);
                        this.Cursor = Cursors.Default;
                        break;

                    default:
                        frm.Close();
                        break;

                }

            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }

        private void LoadTagsWithColor()
        {
            try
            {
                var data = DbAccess.GetAll<CptTagController>();
                foreach (var stdControl in Cntrl.StdControls)
                {
                    stdControl.PlotColor = Color.FromArgb(data.Find(x=>x.Name == stdControl.Name).RGB);
                    stdControl.Max = data.Find(x => x.Name == stdControl.Name).Max;
                    stdControl.Min = data.Find(x => x.Name == stdControl.Name).Min;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void SaveTagsWithColor()
        {
            foreach (var stdControl in Cntrl.StdControls)
            {
                var obj = new CptTagController()
                {
                    Name = stdControl.Name,
                    RGB = stdControl.PlotColor.ToArgb(),
                    Max = stdControl.Max,
                    Min = stdControl.Min,
                };
                DbAccess.Upsert(obj);
            }
        }


        //private void switchLedConnect_ValueChanged(object sender, ValueBooleanEventArgs e)
        //{
        //    //if (!Server.IsStarted) { Server.Start(); _chamber.Ahu.Initialize(); _chamber.Ahu.Connect(true); }
        //    //else { Server.Stop(); _chamber.Ahu.Connect(false); }
        //    switchLedConnect.Text = Server.IsStarted ? "DisConnect" : "Connect";
        //    timerUpdateDisplay.Enabled = true;
        //    switchLedConnect.NoEventUpdate = Server.IsStarted;
        //}

        private void timerUpdateDisplay_Tick(object sender, EventArgs e)
        {
            if (Server.IsStarted)
            {
                led1.Value = !led1.Value;

                //     var Lastdp = new RtuDataPacket(_station._noOfTempChannels);
                //   Lastdp.Read();

                //  rtuChamberCntrl2.UpdateDisplay(); 

            }
            else led1.Value = false;
        }

        void LoadChamber()
        {
            DbAccess dba = Server.DbAccess;
            this.Chamber = dba.db.GetCollection<CptChamber>().FindAll().ToList()[0];

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadTagsWithColor();
            timerUpdateDisplay.Interval = Program.UpdateTime;
            var cc = Server.DbAccess.GetAll<CptChamber>();
            if (cc.Count > 0)
            {
                Chamber = cc[0];
                Chamber.Initialize();
            }
            else
            {
                Chamber = new CptChamber();
                ToastMessage("Chamber need to be configured");
            }

            Cntrl.Chamber = Chamber;
            Cntrl.LoadEvents();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            ////CptChamberCntrl1.Set_PV_NAMES();
            //if (Program.Chamber.Save(Program.DbDir + "Chamber.obj"))
            //    MessageBox.Show("Failed to save Chamber.\r\nPlease See Log file");
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void switchLed1_ValueChanged(object sender, ValueBooleanEventArgs e)
        {
            //var frm = new ActiveStaations();
            //this.Hide();
            //frm.ShowDialog();
            //this.Show();




        }

        private void rtuChamberCntrl2_Load(object sender, EventArgs e)
        {

        }

        private void rtuChamberCntrl1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStripSetup_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void cptChamberCntrl1_Load(object sender, EventArgs e)
        {

        }


        private void btClsoe_Click(object sender, EventArgs e)
        {
            SaveTagsWithColor();
            this.Close();
            
        }
    }
}
