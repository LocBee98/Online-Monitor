using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WinformInterface.Forms
{
    public partial class FormCheckFile : Form
    {

        string[] listedFile = new string[288];

        public FormCheckFile()
        {
            InitializeComponent();
            cmbSelectServer.Items.Add("SERVER VIETMAP ENV");
            cmbSelectServer.Items.Add("SERVER SỞ TNMT");
            cmbSelectServer.SelectedIndex = 0;
            this.btnCheckFile.BackColor = FormMain._backColorMainForm;

        }

        private void FormCheckFile_Load(object sender, EventArgs e)
        {
            #region Tạo file mẫu cần truyền lên ftp server
            int k = 0;
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    listedFile[k] = i.ToString("00") + (5 * j).ToString("00") + "00";
                    k += 1;
                }
            }
            #endregion

            this.txbResult2.Visible = false;

        }



        //Delegate for CheckFC
        private delegate void dlgCheckFC();
        private void checkFC()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new dlgCheckFC(checkFC));
            }
            else
            {
                //Create file first
                dateTimePicker1.CustomFormat = "yyyyMMdd";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;

                for (int i = 0; i < 288; i++)
                {

                    listedFile[i] = "BN_NMMT_KHITHA_" + dateTimePicker1.Text + listedFile[i] + ".txt";
                }


                Functions.ftp myFtp = new Functions.ftp(@"ftp://113.160.155.126", "minhtien", "minhtienftp@123");
                dateTimePicker1.CustomFormat = "yyyy/MM/dd";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;

                string dir = "/MINH TIEN/" + dateTimePicker1.Text + "/";
                int iCountServer = myFtp.listFileName(dir).Count;
                txbResult.Texts = iCountServer.ToString();

                if (iCountServer == listedFile.Length)
                {
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    MessageBox.Show("Đã truyền đủ " + iCountServer.ToString() + "/288 file ngày : " + dateTimePicker1.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbResult.Texts = "Đã truyền đủ " + iCountServer.ToString() + "/288 file ngày : " + dateTimePicker1.Text;
                }
                else
                {
                    dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                    txbResult2.Text = "Chi tiết những file thiếu ngày " + dateTimePicker1.Text + ":\r\n";
                    int index = 1;
                    //Console.WriteLine("Những file thiếu là: "); //The missing files are:
                    for (int i = 0; i < listedFile.Length; i++)
                    {
                        bool isLost = myFtp.listFileName(dir).Contains(listedFile[i]);
                        if (isLost != true)
                        {
                            //txbDetailResult.Texts = listedFile[i] + "\r\n";
                            txbResult2.Text += index.ToString() + ". " + listedFile[i] + "\r\n";
                            index += 1;
                        }
                    }
                    this.txbResult2.Visible = true;

                }
            }



        }



        private void txbCheckFile_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Thread tCheck = new Thread(() => { checkFC(); });
            tCheck.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //progressBar1.PerformLayout();
        }
    }
}
