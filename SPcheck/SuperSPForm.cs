using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPcheck
{
    public partial class SuperSPForm : Form
    {

        private SerialPort sp = new SerialPort();
        private StringBuilder builder = new StringBuilder();
        //private long received_count = 0;
        //private long send_count = 0;
        List<ComboBox> CbbList = new List<ComboBox>();
        
        System.Windows.Forms.Timer timer;


        /// <summary>
        /// 有关参数
        /// </summary>
        Dictionary<int, int> DicBaudrateSet = new Dictionary<int, int> { { 1200, 1 }, { 2400, 2 }, { 4800, 3 }, { 9600, 4 }, { 19200, 5 }, { 38400, 6 }, { 57600, 7 }, { 115200, 8 } };
        Dictionary<string, int> DicParitySet = new Dictionary<string, int> { { "None", 0 }, { "Odd", 1 }, { "Even", 2 } };
        //int Rffrequency;
        Dictionary<int, int> DicRffactor = new Dictionary<int, int> { { 128, 7 }, { 256, 8 }, { 512, 9 }, { 1024, 10 }, { 2048, 11 }, { 4096, 12 } };
        Dictionary<string, int> DicRfmode = new Dictionary<string, int> { { "测试", 0 }, { "中心", 1 }, { "节点", 2 }, { "中继", 3 } };
        Dictionary<string, int> DicRfbw = new Dictionary<string, int> { { "62.5K", 6 }, { "125K", 7 },  { "250K", 8 },  { "500K", 9 } };
        //string NodeID;
        //string NetID;
        //int power;
        Dictionary<string, int> DicBreath = new Dictionary<string, int> { { "2s", 0 }, { "4s", 1 }, { "6s", 2 }, { "8s", 3 }, { "10s", 4 } };



        public SuperSPForm()
        {
            InitializeComponent();
            InitializeCOMConnectComponent();
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            this.openCloseSpbtn.Click += openCloseSpbtn_Click;
            this.openCloseSpbtn.Click += new System.EventHandler(this.buttonEnabled);
            //this.RfmodeCbb.SelectedIndexChanged += rfmodeCbb_IndexChanged;
            this.WriteallBtn.Click += new System.EventHandler(this.WriteallBtn_Click);
            this.ReadallBtn.Click += new System.EventHandler(this.ReadallBtn_Click);
            this.FormClosed += formclosed_Click;


            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;

            timer.Tick += timerTick;
            timer.Start();


        }

        private void timerTick(object o,EventArgs e)
        {

            toolStripStatusLabeltime.Text = DateTime.Now.ToString("G").Replace("/", "-");

        }
        


        private void InitializeCOMConnectComponent()
        {
            //COMPort
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            //将其显示到comboPorName控件中去  
            ComportCbb.Items.AddRange(ports);
            ComportCbb.SelectedIndex = ComportCbb.Items.Count > 0 ? 0 : -1;
            if (ComportCbb.Items.Count == 0)
            {
                MessageBox.Show("没有可用的串口，请连接需要设置的相应设备后重新打开软件重试。");
            }
            else
            {
                
            }

            //BundRate
            this.BaudrateCbb.Items.Add(1200);
            this.BaudrateCbb.Items.Add(2400);
            this.BaudrateCbb.Items.Add(4800);
            this.BaudrateCbb.Items.Add(9600);
            this.BaudrateCbb.Items.Add(19200);
            this.BaudrateCbb.Items.Add(38400);
            this.BaudrateCbb.Items.Add(57600);
            this.BaudrateCbb.Items.Add(115200);
            this.BaudrateCbb.SelectedIndex = 3;

            //Databit
            this.DatabitCbb.Items.Add(5);
            this.DatabitCbb.Items.Add(6);
            this.DatabitCbb.Items.Add(7);
            this.DatabitCbb.Items.Add(8);
            this.DatabitCbb.SelectedIndex = 3;

            //Stopbit
            this.StopbitCbb.Items.Add(1);
            this.StopbitCbb.Items.Add(1.5);
            this.StopbitCbb.Items.Add(2);
            this.StopbitCbb.SelectedIndex = 0;

            //Parity
            this.ParityCbb.Items.Add("None");
            this.ParityCbb.Items.Add("Odd");
            this.ParityCbb.Items.Add("Even");
            this.ParityCbb.SelectedIndex = 0;

            //Handshake
            this.HandshakeCbb.Items.Add("None");
            this.HandshakeCbb.SelectedIndex = 0;


            //RF_frequency
            this.RffrequencyCbb.Items.Add("490.20");
            this.RffrequencyCbb.SelectedIndex = 0;

            //RF_Factor
            this.RffactorCbb.Items.Add(128);
            this.RffactorCbb.Items.Add(256);
            this.RffactorCbb.Items.Add(512);
            this.RffactorCbb.Items.Add(1024);
            this.RffactorCbb.Items.Add(2048);
            this.RffactorCbb.Items.Add(4096);
            this.RffactorCbb.SelectedIndex = 4;

            //RF_Mode
            this.RfmodeCbb.Items.Add("测试");
            this.RfmodeCbb.Items.Add("中心");
            this.RfmodeCbb.Items.Add("节点");
            this.RfmodeCbb.Items.Add("中继");
            this.RfmodeCbb.SelectedIndex = 0;

            //RfbwCbb
            this.RfbwCbb.Items.Add("62.5K");
            this.RfbwCbb.Items.Add("125K");
            this.RfbwCbb.Items.Add("250K");
            this.RfbwCbb.Items.Add("500K");
            this.RfbwCbb.SelectedIndex = 1;

            //NodeID
            this.NodeidCbb.Items.Add("0");
            this.NodeidCbb.SelectedIndex = 0;


            //Breath
            this.BreathCbb.Items.Add("2s");
            this.BreathCbb.Items.Add("4s");
            this.BreathCbb.Items.Add("6s");
            this.BreathCbb.Items.Add("8s");
            this.BreathCbb.Items.Add("10s");
            this.BreathCbb.SelectedIndex = 2;

            //NetID
            this.NetidCbb.Items.Add("0");
            this.NetidCbb.SelectedIndex = 0;

            //Power
            this.PowerCbb.Items.Add(1);
            this.PowerCbb.Items.Add(2);
            this.PowerCbb.Items.Add(3);
            this.PowerCbb.Items.Add(4);
            this.PowerCbb.Items.Add(5);
            this.PowerCbb.Items.Add(6);
            this.PowerCbb.Items.Add(7);
            this.PowerCbb.SelectedIndex = 6;

            //BaudRateSet
            this.BaudratesetCbb.Items.Add(1200);
            this.BaudratesetCbb.Items.Add(2400);
            this.BaudratesetCbb.Items.Add(4800);
            this.BaudratesetCbb.Items.Add(9600);
            this.BaudratesetCbb.Items.Add(19200);
            this.BaudratesetCbb.Items.Add(38400);
            this.BaudratesetCbb.Items.Add(57600);
            this.BaudratesetCbb.Items.Add(115200);
            this.BaudratesetCbb.SelectedIndex = 3;

            //ParitySet
            this.ParitysetCbb.Items.Add("None");
            this.ParitysetCbb.Items.Add("Odd");
            this.ParitysetCbb.Items.Add("Even");
            this.ParitysetCbb.SelectedIndex = 0;

            //toolStripStatusLabel
            this.toolStripStatusLabels.Text = "就绪";
            toolStripStatusLabeltime.Text = DateTime.Now.ToString("G").Replace("/", "-");

            //CbbList
            CbbList.Add(ComportCbb);
            CbbList.Add(BaudrateCbb);
            CbbList.Add(DatabitCbb);
            CbbList.Add(StopbitCbb);
            CbbList.Add(ParityCbb);
            CbbList.Add(HandshakeCbb);
            CbbList.Add(RffrequencyCbb);
            CbbList.Add(RffactorCbb);
            CbbList.Add(RfmodeCbb);
            CbbList.Add(RfbwCbb);
            CbbList.Add(NodeidCbb);
            CbbList.Add(NetidCbb);
            CbbList.Add(BreathCbb);
            CbbList.Add(NetidCbb);
            CbbList.Add(PowerCbb);
            CbbList.Add(BaudratesetCbb);
            CbbList.Add(ParitysetCbb);

            /*textBox1.Text = "中心到节点发送时间间隔：" + (9 + int.Parse(BreathCbb.Text.Substring(0, BreathCbb.Text.Length - 1))) + "秒    |    中心通过中继到节点的发送时间间隔：" + (20 + int.Parse(BreathCbb.Text.Substring(0, BreathCbb.Text.Length - 1))) + "秒";*/


            for (int j = 0 ;j< CbbList.Count ;j++)
            {
                if(j<6)
                {
                    CbbList[j].Enabled = true;
                }
                else
                {
                    CbbList[j].Enabled = false;
                }
            }

        }


        private void openCloseSpbtn_Click(object sender, EventArgs e)
        {
            string comPort = this.ComportCbb.Text;
            string baudRate = this.BaudrateCbb.Text;
            string dataBits = this.DatabitCbb.Text;
            string stopBits = this.StopbitCbb.Text;
            string parity = this.ParityCbb.Text;
            string handshake = this.HandshakeCbb.Text;

            sp.ToString();

            if (openCloseSpbtn.Text == "打开")
            {
                if(!sp.IsOpen)
                {
                    OpenSerialPort(comPort, baudRate, dataBits, stopBits, parity, handshake);
                    if (sp.IsOpen) {
                        this.toolStripStatusLabels.Text=(DateTime.Now.ToString("T").Replace("/", "-")+ "   串口已打开");
                    openCloseSpbtn.Text = "关闭";
                        }
                    else
                    {
                        this.toolStripStatusLabels.Text=(DateTime.Now.ToString("T").Replace("/", "-")+ "  无法建立串口连接，请选择正确可用的串口后重试");
                    }
                }
                else
                {
                    
                }
                
            }
            else
            {
                if(sp.IsOpen)
                {
                    sp.Close();
                    openCloseSpbtn.Text = "打开";
                    this.toolStripStatusLabels.Text = (DateTime.Now.ToString("T").Replace("/", "-") + "  串口已关闭");
                }
                else
                {

                }
                
            }


        }


        private void OpenSerialPort(string comPort, string baudRate, string dataBits, string stopBits, string parity, string handshake)
        {
            if (comPort != null && comPort != "")
            {
                if (sp.IsOpen)
                {
                    Close();
                }
                sp.PortName = comPort;
                sp.BaudRate = Convert.ToInt32(baudRate);
                sp.DataBits = Convert.ToInt32(dataBits);

                if (handshake == "None")
                {
                    sp.RtsEnable = true;
                    sp.DtrEnable = true;
                }


                try
                {
                    sp.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBits);
                    sp.Parity = (Parity)Enum.Parse(typeof(Parity), parity);
                    sp.Handshake = (Handshake)Enum.Parse(typeof(Handshake), handshake);
                    sp.WriteTimeout = 1000; /*Write time out*/
                    sp.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }


            }
        }


        public List<byte> cmdListbyte(byte[] cmdcode)
        {
            List<byte> message2send = new List<byte>();
            try
            {
                //get byte to send
                List<int> initialbyteformer = new List<int> { 0xaf, 0xaf, 0x00, 0x00, 0xaf };
                foreach (byte item in initialbyteformer)
                {
                    message2send.Add(item);
                }
                //+命令码
                foreach (byte item in cmdcode)
                {
                    message2send.Add(item);
                }
                //+加长度
                byte len = new byte();
                message2send.Add(len);
                //以下到CS都是数据
                message2send.Add(((byte)DicBaudrateSet[int.Parse(BaudratesetCbb.Text)]));
                message2send.Add(((byte)DicParitySet[(ParitysetCbb.Text)]));

                //double rffrequency1 = (double.Parse(RffrequencyCbb.Text));
                frequency frequencyvalue = new frequency();
                frequencyvalue.frequencyvalueset = double.Parse(RffrequencyCbb.Text);
                double rffrequency1 = frequencyvalue.frequencyvalueset;
                double rffrequency2 = rffrequency1 * 1000000.0 / 61.03515625;
                int rffrequency3 = (int)rffrequency2;
                string rfbyte1 = rffrequency3.ToString("x");
                byte[] rfbyte2 = strToToHexByte(rfbyte1);
                //Rffrequency = ((int)rffrequency2)/1;
                //byte[] rfbyte = BitConverter.GetBytes(rffrequency2);
                if (rfbyte2.Length > 3)
                {
                    Console.WriteLine("RFfrequancy needs more bytes.");
                }
                for (int i = 0 ; i < rfbyte2.Length ; i++)
                {
                    message2send.Add(rfbyte2[i]);
                }

                message2send.Add(((byte)DicRffactor[int.Parse(RffactorCbb.Text)]));
                message2send.Add(((byte)DicRfmode[(RfmodeCbb.Text)]));
                message2send.Add(((byte)DicRfbw[(RfbwCbb.Text)]));
                /*
                模式  0 正常 1 中心 2节点 3中继
                功率 1 - 7
                id 节点 4字节 高位在前
                中继 3字节 高位在前
                message2send.Add((byte)(customID.Text));
                */
                
                if (RfmodeCbb.Text == "节点")
                {
                    
                    string NodeID = NodeidCbb.Text;
                    long NodeID_1 = long.Parse(NodeID);
                    string NodeID_2 = NodeID_1.ToString("X");
                    NodeID = NodeID_2.PadLeft(8, '0');
                    try
                    {
                        byte[] nodeid = strToToHexByte(NodeID);
                        for (int i = 0 ; i <= nodeid.Length - 1 ; i++)
                        {
                            message2send.Add(nodeid[i]);
                        }
                    }
                    catch
                    {

                    }
                }
                else if (RfmodeCbb.Text == "中继")
                {

                    string NodeID = NodeidCbb.Text;
                    long NodeID_1 = long.Parse(NodeID);
                    string NodeID_2 = NodeID_1.ToString("X");
                    NodeID = NodeID_2.PadLeft(6, '0');
                    try
                    {
                        byte[] nodeid = strToToHexByte(NodeID);
                        for (int i = 0 ; i <= nodeid.Length - 1 ; i++)
                        {
                            message2send.Add(nodeid[i]);
                        }
                    }
                    catch
                    {

                    }
                }
                else
                {

                    string NodeID = NodeidCbb.Text;
                    long NodeID_1 = long.Parse(NodeID);
                    string NodeID_2 = NodeID_1.ToString("X");
                    NodeID = NodeID_2.PadLeft(8, '0');
                    try
                    {
                        byte[] nodeid = strToToHexByte(NodeID);
                        for (int i = 0 ; i <= nodeid.Length - 1 ; i++)
                        {
                            message2send.Add(nodeid[i]);
                        }
                    }
                    catch
                    {

                    }
                }



                message2send.Add((byte)int.Parse(NetidCbb.Text));



                message2send.Add((byte)int.Parse(PowerCbb.Text));
                message2send.Add(((byte)DicBreath[(BreathCbb.Text)]));
                //返回len
                len = (byte)(message2send.Count - 8);
                message2send[7] = len;
                //CS
                byte cs;
                byte[] message2sent = new byte[1024];
                for (int i = 0 ; i < message2send.Count ; i++)
                {
                    message2sent[i] = message2send[i];
                }
                cs = checkSum(message2sent);
                message2send.Add(cs);

                //结束码
                List<int> initialbytelater = new List<int> { 0x0d, 0x0a };
                foreach (byte item in initialbytelater)
                {
                    message2send.Add(item);
                }
                //返回
                

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                Console.WriteLine("No blank should be left out.");
            }
            return message2send;

        }


        public byte checkSum(byte[] memoryspage)
        {
            int num = 0;
            byte b;

            for (int i = 0 ; i < memoryspage.Length ; i++)
            {
                num = (num + memoryspage[i]) % 0x100;

            }

            b = (byte)num;

            return b;
        }


        /// <summary>
        /// hexstring to hexbyte
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] strToToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            hexString = hexString.Replace("-", "");
            hexString = hexString.Replace(":", "");
            if ((hexString.Length % 2) != 0)
                hexString += "0";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0 ; i < returnBytes.Length ; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0 ; i < bytes.Length ; i++)
                {
                    returnStr += " " + bytes[i].ToString("X2");
                }
            }
            return returnStr.Trim();




        }


        private void rfmodeCbb_IndexChanged(object sender, EventArgs e)
        {
            
            if (RfmodeCbb.Text == "中继")
            {
                NodeidCbb.MaxLength = 10;
                NodeidCbb.Text = "0";
                
            }
            else
            {
                NodeidCbb.MaxLength = 3;
            }
            
            
        }

        private void formclosed_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Close();
            }
            else
            {

            }
        }

        public void buttonEnabled(object sender, EventArgs e)
        {
            for (int j = 0 ; j < CbbList.Count ; j++)
            {
                if (openCloseSpbtn.Text == "关闭")
                {
                    if (j < 6)
                    {
                        CbbList[j].Enabled = false;
                    }
                    else
                    {
                        CbbList[j].Enabled = true;
                    }
                    WriteallBtn.Enabled = true;
                    ReadallBtn.Enabled = true;
                }
                else
                {
                    if (j < 6)
                    {
                        CbbList[j].Enabled = true;
                    }
                    else
                    {
                        CbbList[j].Enabled = false;
                    }
                    WriteallBtn.Enabled = false;
                    ReadallBtn.Enabled = false;
                }

            }
        }

        List<byte> cmd8003 = new List<byte> { 0xaf, 0xaf, 0x00, 0x00, 0xaf, 0x80, 0x03, 0x02, 0x00, 0x00, 0x92, 0x0d, 0x0a };
        List<byte> cmd8004 = new List<byte> { 0xaf, 0xaf, 0x00, 0x00, 0xaf, 0x80, 0x04, 0x02, 0x00, 0x00, 0x93, 0x0d, 0x0a };
        List<byte> cmd8005 = new List<byte> { 0xaf, 0xaf, 0x00, 0x00, 0xaf, 0x80, 0x05, 0x02, 0x00, 0x00, 0x94, 0x0d, 0x0a };

        byte[] receivedata = new byte[1024];


        /// <summary>
        /// 写命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WriteallBtn_Click(object sender, EventArgs e)
        {
            this.WriteallBtn.Enabled = false;
            if (sp.IsOpen)
            {
                if (RfmodeCbb.Text == "中继")
                {
                    if(int.Parse(NodeidCbb.Text) > 0xffffff)
                    {
                        this.toolStripStatusLabels.Text=(DateTime.Now.ToString("T").Replace("/", "-")+ "  节点编号不可超过预计值16,777,215");
                    }
                    else
                    {
                        senddata();
                        //Thread.Sleep(500);
                        //this.WriteallBtn.Enabled = true;
                    }

                }
                else
                {
                    if (long.Parse(NodeidCbb.Text) > 0XFFFFFFFF)
                    {
                        this.toolStripStatusLabels.Text=(DateTime.Now.ToString("T").Replace("/", "-")+ "  节点编号超过内定值‭4,294,967,295‬");
                    }
                    else
                    {
                        if(int.Parse(NetidCbb.Text) > 0XFF)
                        {
                            this.toolStripStatusLabels.Text = (DateTime.Now.ToString("T").Replace("/", "-") + "  网络编号不可超过内定值255");
                        }
                        else
                        {
                            senddata();
                            //Thread.Sleep(500);
                            //this.WriteallBtn.Enabled = true;
                        }
                        
                    }
                }
            }
            else
            {
                this.toolStripStatusLabels.Text=(DateTime.Now.ToString("T").Replace("/", "-")+ "  没有串口连接");
            }
            Thread.Sleep(500);
            this.WriteallBtn.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public void senddata()
        {
            if (sp.IsOpen)
            {
                //this.WriteallBtn.Enabled = false;

                List<byte> cmd8001;
                byte[] cmdcode = new byte[] { 0x80, 0x01 };
                cmd8001 = cmdListbyte(cmdcode);
                byte[] cmd8001bytearray = new byte[cmd8001.Count];
                for (int i = 0 ; i < cmd8001.Count ; i++)
                {
                    cmd8001bytearray[i] = cmd8001[i];
                }

                Console.WriteLine("\r\n" + DateTime.Now.ToString("T").Replace("/", "-") + "  发送:" + "\r\n" + byteToHexStr(cmd8001bytearray) + "\r\n");
                receivedata = Transportation.SendAndRecvData(cmd8001bytearray, 1000, sp);

                
                if (receivedata != null && receivedata.Length >= 8)
                {
                    byte[] receivedata1 = new byte[cmd8001bytearray.Length - 3/*receivedata.Length - 3 - cmd8001bytearray.Length*/];
                    Array.Copy(receivedata, receivedata1, cmd8001bytearray.Length - 3 /*receivedata.Length - 3 -cmd8001bytearray.Length */);

                    if (checkSum(receivedata1) == receivedata[cmd8001bytearray.Length - 3/*receivedata.Length - 3 - cmd8001bytearray.Length*/])
                    {
                        Console.WriteLine(DateTime.Now.ToString("T").Replace("/", "-") + "  写入数据的响应校验正确");
                        Console.WriteLine("" + DateTime.Now.ToString("T").Replace("/", "-") + "  接收:" + "\r\n" + byteToHexStr(receivedata) + "\r\n");
                        this.toolStripStatusLabels.Text=(DateTime.Now.ToString("T").Replace("/", "-")+"  写入设置成功");// 判断出了问题。
                    }
                    else
                    {
                        this.toolStripStatusLabels.Text=(DateTime.Now.ToString("T").Replace("/", "-")+"  接收到的数据无效，请重试或选择正确的串口");
                    }
                }
                else
                {
                    this.toolStripStatusLabels.Text=(DateTime.Now.ToString("T").Replace("/", "-") + "  没有接收到有效的数据，请重试或选择正确的串口");
                }

                //this.WriteallBtn.Enabled = true;
                //this.WriteallBtn.f = true;
            }
            else
            {
                this.toolStripStatusLabels.Text=(DateTime.Now.ToString("T").Replace("/", "-")+"  没有串口连接");
            }
        }


        /// <summary>
        /// 读命令，返回数据，解析打印数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ReadallBtn_Click(object sender, EventArgs e)
        {
            this.ReadallBtn.Enabled = false;
            if (sp.IsOpen)
            {
                List<byte> cmd8002 = new List<byte> { 0xaf, 0xaf, 0x00, 0x00, 0xaf, 0x80, 0x02, 0x0d };

                byte[] cmd8002bytearray = new byte[0];
                foreach (byte item in cmd8002)
                {
                    cmd8002bytearray = Transportation.MergerArray(cmd8002bytearray, new byte[] { item });

                }
                byte cs = checkSum(cmd8002bytearray);

                cmd8002bytearray = Transportation.MergerArray(cmd8002bytearray, new byte[] { cs });
                byte[] laterbytea = new byte[] { 0x0d, 0x0a };
                cmd8002bytearray = Transportation.MergerArray(cmd8002bytearray, laterbytea);

                Console.WriteLine("\r\n" + DateTime.Now.ToString("T").Replace("/", "-") + "  发送:" + "\r\n" + byteToHexStr(cmd8002bytearray) + "\r\n");
                receivedata = Transportation.SendAndRecvData(cmd8002bytearray, 1000, sp);

                //判断回码
                if (receivedata != null && receivedata.Length >= 8)
                {
                    //this.ReadallBtn.Enabled = false;
                    byte[] receivedata1 = new byte[receivedata.Length - 3];
                    Array.Copy(receivedata, receivedata1, receivedata1.Length);
                    if (checkSum(receivedata1) == receivedata[receivedata.Length - 3])
                    {
                        Console.WriteLine(DateTime.Now.ToString("T").Replace("/", "-")+"读数据的响应校验正确");
                        Console.WriteLine("" + DateTime.Now.ToString("T").Replace("/", "-") + "  接收:" + "\r\n" + byteToHexStr(receivedata) + "\r\n");
                        try
                        {
                            //串口
                            //校验
                            //频率
                            //扩频
                            //模式
                            //扩频带宽
                            //id
                            //netid
                            //power
                            //Breath
                            byte[] raw = receivedata;
                            string baudrateRead = receivedata[8].ToString();
                            foreach (int key in DicBaudrateSet.Keys)
                            {
                                if (int.Parse(baudrateRead) == DicBaudrateSet[key]) BaudratesetCbb.Text = key.ToString();
                            }
                            //
                            string parityRead = receivedata[9].ToString();
                            foreach (string key in DicParitySet.Keys)
                            {
                                if (int.Parse(parityRead) == DicParitySet[key]) ParitysetCbb.Text = key;
                            }
                            //refrequency
                            string rffrequencyRead = receivedata[10].ToString("X2") + receivedata[11].ToString("X2") + receivedata[12].ToString("X2");
                            long rffrequency = Convert.ToInt64(rffrequencyRead, 16);
                            double rffrequencyread1 = rffrequency * 61.03515625 / 1000000;
                            string rffrequencyread2 = String.Format("{0:0.00}", rffrequencyread1);
                            RffrequencyCbb.Text = rffrequencyread2;

                            //
                            string a_rffrequencyRead = receivedata[13].ToString();
                            foreach (int key in DicRffactor.Keys)
                            {
                                if (int.Parse(a_rffrequencyRead) == DicRffactor[key]) RffactorCbb.Text = key.ToString();
                            }
                            foreach (string key in DicParitySet.Keys)
                            {
                                if (int.Parse(parityRead) == DicParitySet[key]) ParitysetCbb.Text = key;
                            }
                            //
                            string modeidRead = receivedata[14].ToString();
                            foreach (string key in DicRfmode.Keys)
                            {
                                if (int.Parse(modeidRead) == DicRfmode[key]) RfmodeCbb.Text = key;
                            }
                            //
                            string rfbwRead = receivedata[15].ToString();
                            foreach (string key in DicRfbw.Keys)
                            {
                                if (int.Parse(rfbwRead) == DicRfbw[key]) RfbwCbb.Text = key;
                            }
                            //NODEid
                            string raw1 = byteToHexStr(raw);
                            string raw2 = raw1.Replace(" ", "");
                            string nodeidRead;
                            if (RfmodeCbb.Text == "中继")
                            {
                                nodeidRead = raw2.Remove(raw2.Length - 12, 12).Remove(0, 32);
                            }
                            else
                            {
                                nodeidRead = raw2.Remove(raw2.Length - 12, 12).Remove(0, 32);
                            }

                            NodeidCbb.Text = Convert.ToInt64(nodeidRead,16).ToString();

                            //

                            string netidRead = receivedata[receivedata.Length - 6].ToString("X2");
                            NetidCbb.Text = Convert.ToInt64(netidRead, 16).ToString();

                            //
                            string powerRead = receivedata[receivedata.Length - 5].ToString("X2");

                            PowerCbb.Text = powerRead.Substring(1, 1);
                            //
                            string breathRead = receivedata[receivedata.Length - 4].ToString("X2");
                            foreach (string key in DicBreath.Keys)
                            {
                                if (int.Parse(breathRead) == DicBreath[key]) BreathCbb.Text = key;
                            }
                            this.toolStripStatusLabels.Text=(DateTime.Now.ToString("T").Replace("/", "-") +"  读取设置成功");
                            
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(DateTime.Now.ToString("T").Replace("/", "-")+"  接收数据的解析有问题，可能是数据格式的问题");
                        }

                    }
                    else
                    {
                        this.toolStripStatusLabels.Text=(DateTime.Now.ToString("T").Replace("/", "-")+"  没有接收到有效的数据，请重试或选择正确的串口");
                    }
                }
                else
                {
                    Console.WriteLine("Reveive invalid data");
                    this.toolStripStatusLabels.Text=(DateTime.Now.ToString("T").Replace("/", "-")+"  没有接收到有效的数据，请重试或选择正确的串口");
                }


            }
            else
            {
                this.toolStripStatusLabels.Text=(DateTime.Now.ToString("T").Replace("/", "-")+"  没有串口连接");
            }
            Thread.Sleep(500);
            this.ReadallBtn.Enabled = true;

        }

        private void SuperSPForm_Load(object sender, EventArgs e)
        {

        }


        public void breathCbbSelectedIndexChanged(object sender, EventArgs e)
        {
            /*textBox1.Text = "中心到节点发送时间间隔：" + (9 + int.Parse(BreathCbb.Text.Substring(0, BreathCbb.Text.Length-1))) + "秒    |    中心通过中继到节点的发送时间间隔：" + (20 + int.Parse(BreathCbb.Text.Substring(0, BreathCbb.Text.Length - 1))) + "秒";*/
        }
    }

    class frequency
    {
        double frequencyvalue;


        public double frequencyvalueset 
        {
            get { return frequencyvalue;}
            set
            {
                if (value <= 525 && value >= 125)
                {
                    frequencyvalue = value;
                }
                else
                {
                    MessageBox.Show("频率值要在125~525MHz之间.");
                    //Exception exception = new Exception("频率值在125~525MHz");
                    //throw exception;
                }
                
            }
        }
    }
}

