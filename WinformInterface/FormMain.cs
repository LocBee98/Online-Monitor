using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO.Ports;
using System.IO;
using System.Threading;
using EasyModbus;
using ModbusRTU;

namespace WinformInterface
{


    public partial class FormMain : Form
    {

        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //CEMS
        public static SerialPort sp1 = new SerialPort();
        //PT500
        public static SerialPort sp2 = new SerialPort();
        //DMS
        public static SerialPort sp3 = new SerialPort();

        //Get back color to send child Form
        public static Color _backColorMainForm;
        public static Color _btnColorActive;

        

        public FormMain()
        {
            InitializeComponent();
            random = new Random();
            
            sp1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            //Logo back color
            Color color = SelectThemeColor();
            panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);

            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Initial Window
            this.MinimumSize = new Size(1280, 720);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(50, 50);

            // CEMS CONFIGER
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer1.Interval = 10000;  // EM5
            timer2.Interval = 1000;  // Time read value TPF
            timer3.Enabled = true; // Insert Data to Database
            timer3.Interval = 1000;


            sp1.PortName = "COM5";
            sp1.BaudRate = 38400;
            sp1.DataBits = 8;
            sp1.StopBits = StopBits.One;
            sp1.Parity = Parity.None;
            sp1.Handshake = Handshake.None;
            sp1.RtsEnable = true;
            try
            {
                sp1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EM5 - COM5 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Serial Port 2: PT
            sp2.PortName = "COM3";
            try
            {
                //SerialPort sp2 = new SerialPort("COM3"); 
                modbusrtu.Instance().Open(sp2.PortName, 9600, Parity.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RS485 - TPF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region ChildForm
        //Method
        private Color SelectThemeColor()
        {
            ////Random Back Color
            //int index = random.Next(ThemeColor.ColorList.Count);
            //while (tempIndex == index)
            //{
            //    index = random.Next(ThemeColor.ColorList.Count);
            //}
            //tempIndex = index;
            int index = 0;
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            //MessageBox.Show(index.ToString(), "Get Index", MessageBoxButtons.OK, MessageBoxIcon.Information); -> Find index list color to delete
            
            
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Cambria", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    if (currentButton == btnEmail)
                    {
                        currentButton.Font = new System.Drawing.Font("Cambria", 10.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    panelTitleBar.BackColor = color;


                    _backColorMainForm = color;
                    _btnColorActive = color;

                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.FromArgb(255, 255, 225);
                    previousBtn.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                }
            }
        }
        /// <summary> Child Form

        private void OpenChildFrom(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Tag = childForm;
            this.panelDesktopPane.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;

            Color color = _backColorMainForm;
            childForm.BackColor = ThemeColor.ChangeColorBrightness(color, 0.8);


        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormMonitor(), sender);
            

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormHistory(), sender);
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormChart(), sender);
        }

        private void btnCheckFile_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormCheckFile(), sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormSetting(), sender);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormInfo(), sender);
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new Forms.FormEmail(), sender);
        }

        #endregion

        #region CEMS - READ AND PROCESSING DATA
        string[] dataStr = new string[9];

        List<TextBox> txbList = new List<TextBox>();


        #region RS232-COMMUNICATION

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (sp1.IsOpen)
            {
                try
                {
                    sendDataToEM5();
                }
                catch (TimeoutException)
                {
                    MessageBox.Show("Request to EM5 fail!");
                }
            }
        }

        private void DataReceivedHandler(object sender,
                            SerialDataReceivedEventArgs e)
        {
            int intBuffer;
            intBuffer = sp1.BytesToRead;
            byte[] byteBuffer = new byte[intBuffer];
            sp1.Read(byteBuffer, 0, intBuffer);
            //Test với ssCom thì intBuffer = 33, nhưng chạy chạy thì intBuffer = 31.
            //if ((intBuffer == 31) && (byteBuffer[0] == 0x7B) && (byteBuffer[1] == 0x7B) && (byteBuffer[2] == 0x44) && (byteBuffer[3] == 0xBB))

            if (true)
            {
                try
                {
                    getDataStr(byteBuffer);
                }
                catch
                {
                    MessageBox.Show("Lỗi đọc tín hiệu từ EM5!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void getDataStr(byte[] bytesRS232)
        {
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    dataStr[i] = BitConverter.ToSingle(bytesRS232, 4 * (i + 1)).ToString("0.00");
                    //Get Measured value of EM5
                    varGlobal.realDataEM5[i] = BitConverter.ToSingle(bytesRS232, 4 * (i + 1));
                }
                byte[] STAT = new byte[2];
                STAT[1] = 0x00;
                STAT[0] = bytesRS232[28];

                //Get state of Em5
                if (BitConverter.ToInt16(STAT, 0) == 1)
                {
                    varGlobal.statEM5 = "Hiệu chuẩn";
                }
                else if (BitConverter.ToInt16(STAT, 0) == 2)
                {
                    varGlobal.statEM5 = "Lỗi";
                }
                else
                {
                    varGlobal.statEM5 = "Đo";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void sendDataToEM5() /// Request to EM5
        {
            if (sp1.IsOpen)
            {
                byte[] bytesToSend = new byte[6] { 0x7B, 0x7B, 0x44, 0x66, 0x7B, 0x7D };
                sp1.Write(bytesToSend, 0, bytesToSend.Length);
            }
            else MessageBox.Show("COM chưa mở.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        #endregion

        #region Conversion
        private float Two_int16_to_float(Int16 val1, Int16 val2)
        {
            var byteVal1 = BitConverter.GetBytes(val1);
            var byteVal2 = BitConverter.GetBytes(val2);
            byte[] temp = new byte[4];
            temp[0] = byteVal1[0];
            temp[1] = byteVal1[1];
            temp[2] = byteVal2[0];
            temp[3] = byteVal2[1];
            return BitConverter.ToSingle(temp, 0);
        }

        private void Float_to_two_Int16(float val, ref ushort val1, ref ushort val2)
        {
            byte[] Value_Bytes = BitConverter.GetBytes(val); // 0-1-2-3
            val1 = BitConverter.ToUInt16(Value_Bytes, 0);
            val2 = BitConverter.ToUInt16(Value_Bytes, 2);
        }
        #endregion

        #region MOdbus RTU for TPF
        private short[] mbRead(ushort numberReg)
        {
            short[] mbData = new short[numberReg];

            try
            {
                modbusrtu.Instance().FC03(1, 0, numberReg, ref mbData);

                //Each register have length of 16bit
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Modbus RTU - COM3", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return mbData;
        }
        //private short[] mbRead2(ushort numberReg)
        //{
        //    short[] mbData2 = new short[numberReg];

        //    try
        //    {
        //        modbusrtu.Instance().FC03(2, 0, numberReg, ref mbData2);

        //        //Each register have length of 16bit
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Modbus RTU - COM3", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return mbData2;
        //}

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            ushort nbRegister = 8;
            //ushort nbRegister2 = 2;

            short[] dataTemp = new short[nbRegister];
            short[] dataTemp2 = new short[nbRegister];


            dataTemp = mbRead(nbRegister);
            //dataTemp2 = mbRead2(nbRegister2);

            varGlobal.Temp = Two_int16_to_float(dataTemp[0], dataTemp[1]);
            varGlobal.Press = Two_int16_to_float(dataTemp[2], dataTemp[3]);
            varGlobal.Dust = Two_int16_to_float(dataTemp[4], dataTemp[5]); 
            // varGlobal.Dust = Two_int16_to_float(dataTemp2[0], dataTemp2[1]); // Thuc te DMS ID khac nen phải đọc như này

            varGlobal.Flow = Two_int16_to_float(dataTemp[6], dataTemp[7]);
        }

        #endregion

        #region MODBUS TCP/IP
        //ModbusClient tcpClient1 = new ModbusClient("192.168.1.120", 502);    //Ip Address and Port of Modbus TCP Server
        

        #endregion

        #endregion

        #region INSERT DATA TO DATABASE
        private void timer3_Tick(object sender, EventArgs e)
        {
            //Clock
            lbClock.Text = DateTime.Now.ToString("dd-MM-yyyy   HH:mm:ss");

            varGlobal.DateTime = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
            varGlobal.Minute = DateTime.Now.Minute;

            // Insert data into Sql Server every minute
            if (DateTime.Now.Second == 0)
            {
                try
                {
                    Functions.SqlFunction SqlFC = new Functions.SqlFunction();
                    SqlFC.insertInToDataBase(varGlobal.ID, varGlobal.Minute, varGlobal.DateTime, varGlobal.Temp, varGlobal.Press, varGlobal.Dust, varGlobal.Flow, varGlobal.realDataEM5[0], varGlobal.realDataEM5[1], varGlobal.realDataEM5[3], varGlobal.realDataEM5[2], varGlobal.statEM5);
                    varGlobal.ID += 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region EMAIL
        //string userEmail1 = "";
        //string userEmail2 = "";
        //string userEmail3 = "";
        //bool enable1 = false;
        //bool enable2 = false;
        //bool enable3 = false;
        //string freq = "";
        //string emailContents = "";

        //private void timer4_Tick(object sender, EventArgs e)
        //{
        //    string fromUser = "vietmapenv.alarm@gmail.com";
        //    string fromPass = "xxxxxxxx";
        //    string toUser1 = userEmail1;
        //    string toUser2 = userEmail2;
        //    string toUser3 = userEmail3;

        //    Functions.email email1 = new Functions.email(fromUser, fromPass, toUser1);
        //    Functions.email email2 = new Functions.email(fromUser, fromPass, toUser2);
        //    Functions.email email3 = new Functions.email(fromUser, fromPass, toUser3);

        //    bool isSend = false;
            //string emailContents = getContents();
            //if (enable1)
            //{
            //    email1.sendMessage(emailContents);
            //}
            //if (enable2)
            //{
            //    email1.sendMessage(emailContents);
            //}
            //if (enable3)
            //{
            //    email1.sendMessage(emailContents);
            //}
        ////}
        //public void getSettingEmail()
        //{
        //    string[] preSetting = new string[12];
        //    Functions.ReadWriteTxt _getFile = new Functions.ReadWriteTxt();
        //    preSetting = _getFile.readFile(@"txtSetting\appSetting.txt");
        //    //Email
        //    userEmail1 = preSetting[1];
        //    userEmail2 = preSetting[2];
        //    userEmail3 = preSetting[3];
        //    //Enable
        //    enable1 = Convert.ToBoolean(preSetting[5]);
        //    enable2 = Convert.ToBoolean(preSetting[6]);
        //    enable3 = Convert.ToBoolean(preSetting[7]);
        //    //Freq
        //    freq = preSetting[9];
        //}
        #endregion

        #region Close - Minimize Form

        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnClose.BackColor = Color.FromArgb(229, 76, 60);
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.BackColor = Color.FromArgb(139, 194, 64);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnMinimize.BackColor = Color.FromArgb(229, 76, 60);
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            this.btnMinimize.BackColor = Color.FromArgb(139, 194, 64);
        }









        #endregion

        
    }
}
