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
    

    public partial class FormMonitor : Form
    {
        //Thiet lập ngưỡng
        
        
        //Tinh so luong vuot nguong
        int eDust = 0;
        int eSO2 = 0;
        int eNOx = 0;
        int eCO = 0;
        //Tinh so luong chuan bi vuot nguong
        int peDust = 0;
        int peSO2 = 0;
        int peNOx = 0;
        int peCO = 0;
        // Tong vuot ngưỡng
        int sumE = 0;
        int sumPe = 0;
        //public static float O2_thres;


        //
        string[] dataStr = new string[11];
        List<TextBox> txbList = new List<TextBox>();

        public FormMonitor()
        {
            InitializeComponent();
            
        }

        private void FormMonitor_Load(object sender, EventArgs e)
        {
            //Change background panel
            Color color = FormMain._backColorMainForm;
            this.panelNote.BackColor = ThemeColor.ChangeColorBrightness(color, 0.2);
            this.panelStationInfo.BackColor = ThemeColor.ChangeColorBrightness(color, 0.2);

            //Add Note
            string[] indexNote = { "Note 1", "Note 2", "Note 3" };
            comboxSelectNote.Items.AddRange(indexNote);
            comboxSelectNote.SelectedIndex = 0;

            // Restore Note
            txbNote1.Text = varGlobal.Note1;
            txbNote2.Text = varGlobal.Note2;
            txbNote3.Text = varGlobal.Note3;



            //this.MinimumSize = new Size(1280, 720);


            timer1.Enabled = true;
            timer1.Interval = 5000;
            //// Make list text box to display measured value
            txbList.Add(txbTemp);
            txbList.Add(textBox2);
            txbList.Add(txbDust);
            txbList.Add(textBox4);
            txbList.Add(txbSO2);
            txbList.Add(txbNOx);
            txbList.Add(txbCO);
            txbList.Add(textBox7);
            txbList.Add(txbState);
            txbList.Add(txbExceed);
            txbList.Add(txbTrendToExceed);

            // Timer for Threshold
            timer2.Enabled = true;
            timer2.Interval = 10000;

            //Check exceed:
            checkExceed();

            //Update dataStr every 1 minute:
            dataStr[0] = varGlobal.Temp.ToString("0.00");
            dataStr[1] = varGlobal.Press.ToString("0.00");
            dataStr[2] = varGlobal.Dust.ToString("0.00");
            dataStr[3] = varGlobal.Flow.ToString("0.00");
            dataStr[4] = varGlobal.realDataEM5[0].ToString("0.00"); // SO2
            dataStr[5] = varGlobal.realDataEM5[1].ToString("0.00"); // NOx
            dataStr[6] = varGlobal.realDataEM5[2].ToString("0.00"); // O2
            dataStr[7] = varGlobal.realDataEM5[3].ToString("0.00"); // CO
            dataStr[8] = varGlobal.statEM5;
            dataStr[9] = sumE.ToString();
            dataStr[10] = sumPe.ToString();

            Thread t = new Thread(() => showTxb(txbList));
            t.Start();

        }

        #region Delegate
        public delegate void dlgShowTxb(List<TextBox> _txbList);

        public void showTxb(List<TextBox> _txbList)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new dlgShowTxb(showTxb), _txbList);
            }
            else
            {
                for (int i = 0; i < _txbList.Count; i++)
                {
                    _txbList[i].Text = dataStr[i];
                }
            }
        }
        #endregion// End Delegate


        private void timer1_Tick(object sender, EventArgs e)
        {
            //Check exceed
            checkExceed();

            //Update dataStr every 1 minute:
            dataStr[0] = varGlobal.Temp.ToString("0.00");
            dataStr[1] = varGlobal.Press.ToString("0.00");
            dataStr[2] = varGlobal.Dust.ToString("0.00");
            dataStr[3] = varGlobal.Flow.ToString("0.00");
            dataStr[4] = varGlobal.realDataEM5[0].ToString("0.00"); // SO2
            dataStr[5] = varGlobal.realDataEM5[1].ToString("0.00"); // NOx
            dataStr[6] = varGlobal.realDataEM5[2].ToString("0.00"); // O2
            dataStr[7] = varGlobal.realDataEM5[3].ToString("0.00"); // CO
            dataStr[8] = varGlobal.statEM5;
            dataStr[9] = sumE.ToString();
            dataStr[10] = sumPe.ToString();
            Thread t = new Thread(() => showTxb(txbList));
            t.Start();


        }

       
        //Note
        #region Note
        private void AddNote(ComboBox _ComboNote)
        {
            
            //Demo add one note
            if (txbNoteInput.Texts.Length != 0)
            {
                switch (_ComboNote.Text)
                {
                    case "Note 1":
                        txbNote1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm") + " | " + txbNoteInput.Texts;
                        _ComboNote.SelectedIndex = 1;
                        // Save to global var, and reload when close and open again this form!
                        //Final Solution: Save notes in txt file and reload when they are called. Update later!!!
                        varGlobal.Note1 = txbNote1.Text;
                        break;
                    case "Note 2":
                        txbNote2.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm") + " | " + txbNoteInput.Texts;
                        _ComboNote.SelectedIndex = 2;

                        // Save to global var, and reload when close and open again this form!
                        //Final Solution: Save notes in txt file and reload when they are called. Update later!!!
                        varGlobal.Note2 = txbNote2.Text;
                        break;
                    case "Note 3":
                        txbNote3.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm") + " | " + txbNoteInput.Texts;
                        _ComboNote.SelectedIndex = 0;

                        // Save to global var, and reload when close and open again this form!
                        //Final Solution: Save notes in txt file and reload when they are called. Update later!!!
                        varGlobal.Note3 = txbNote3.Text;

                        break;
                }
                txbNoteInput.Texts = "";
            }
           
           
            
        }
        private void DeleteNote(ComboBox _ComboNote)
        {
            txbNoteInput.Texts = "";
            switch (_ComboNote.Text)
            {
                case "Note 1":
                    txbNote1.Text = "";
                    varGlobal.Note1 = txbNote1.Text;

                    break;
                case "Note 2":
                    txbNote2.Text = "";
                    varGlobal.Note2 = txbNote2.Text;

                    break;
                case "Note 3":
                    txbNote3.Text = "";
                    varGlobal.Note3 = txbNote3.Text;


                    break;
            }
        }

        
        
       

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            AddNote(comboxSelectNote);
        }

        private void btnDeleteNote_Click_1(object sender, EventArgs e)
        {
            DeleteNote(comboxSelectNote);
        }
        #endregion


        //Cảnh báo vượt ngưỡng
        private void timer2_Tick(object sender, EventArgs e)
        {
            //checkExceed();
        }

        //kiem tra vượt ngưỡng
        private void checkExceed()
        {
            float heso;
            heso = settingParam.coef;

            //Dust
            if (varGlobal.Dust >= settingParam.dust_thres)
            {
                this.panelDust.BackColor = this.panelExceed.BackColor;
                this.txbDust.BackColor = this.panelExceed.BackColor;
                eDust = 1;
                peDust = 0;
            }
            else if (varGlobal.Dust >= heso * settingParam.dust_thres && varGlobal.Dust < settingParam.dust_thres)
            {
                this.panelDust.BackColor = this.panelTrendToExceed.BackColor;
                this.txbDust.BackColor = this.panelTrendToExceed.BackColor;
                eDust = 0;
                peDust = 1;
            }
            else
            {
                this.panelDust.BackColor = Color.FromArgb(44, 202, 115);
                this.txbDust.BackColor = Color.FromArgb(44, 202, 115);
                eDust = 0;
                peDust = 0;
            }
            //SO2
            if (varGlobal.realDataEM5[0] >= settingParam.SO2_thres)
            {
                this.panelSO2.BackColor = this.panelExceed.BackColor;
                this.txbSO2.BackColor = this.panelExceed.BackColor;
                eSO2 = 1;
                peSO2 = 0;
            }
            else if (varGlobal.realDataEM5[0] >= heso * settingParam.SO2_thres && varGlobal.realDataEM5[0] < settingParam.SO2_thres)
            {
                this.panelSO2.BackColor = this.panelTrendToExceed.BackColor;
                this.txbSO2.BackColor = this.panelTrendToExceed.BackColor;
                eSO2 = 0;
                peSO2 = 1;

            }
            else
            {
                this.panelSO2.BackColor = Color.FromArgb(44, 202, 115);
                this.txbSO2.BackColor = Color.FromArgb(44, 202, 115);
                eSO2 = 0;
                peSO2 = 0;
            }
            //NOx
            if (varGlobal.realDataEM5[1] >= settingParam.NOx_thres)
            {
                this.panelNOx.BackColor = this.panelExceed.BackColor;
                this.txbNOx.BackColor = this.panelExceed.BackColor;
                eNOx = 1;
                peNOx = 0;

            }
            else if (varGlobal.realDataEM5[1] >= heso * settingParam.NOx_thres && varGlobal.realDataEM5[1] < settingParam.NOx_thres)
            {
                this.panelNOx.BackColor = this.panelTrendToExceed.BackColor;
                this.txbNOx.BackColor = this.panelTrendToExceed.BackColor;
                eNOx = 0;
                peNOx = 1;


            }
            else
            {
                this.panelNOx.BackColor = Color.FromArgb(44, 202, 115);
                this.txbNOx.BackColor = Color.FromArgb(44, 202, 115);
                eNOx = 0;
                peNOx = 0;

            }
            //CO
            if (varGlobal.realDataEM5[3] >= settingParam.CO_thres)
            {
                this.panelCO.BackColor = this.panelExceed.BackColor;
                this.txbCO.BackColor = this.panelExceed.BackColor;
                eCO = 1;
                peCO = 0;

            }
            else if (varGlobal.realDataEM5[3] >= heso * settingParam.CO_thres && varGlobal.realDataEM5[3] < settingParam.CO_thres)
            {
                this.panelCO.BackColor = this.panelTrendToExceed.BackColor;
                this.txbCO.BackColor = this.panelTrendToExceed.BackColor;
                eCO = 0;
                peCO = 1;
            }
            else
            {
                this.panelCO.BackColor = Color.FromArgb(44, 202, 115);
                this.txbCO.BackColor = Color.FromArgb(44, 202, 115);
                eCO = 0;
                peCO = 0;
            }




            // Cảnh báo hiệu chuẩn
            if (varGlobal.statEM5 == "Hiệu chuẩn")
            {
                this.panelState.BackColor = this.panelTrendToExceed.BackColor;
                this.txbState.BackColor = this.panelTrendToExceed.BackColor;
            }
            else if (varGlobal.statEM5 == "Lỗi")
            {
                this.panelState.BackColor = this.panelExceed.BackColor;
                this.txbState.BackColor = this.panelExceed.BackColor;


            }
            else
            {
                this.panelState.BackColor = Color.FromArgb(44, 202, 115);
                this.txbState.BackColor = Color.FromArgb(44, 202, 115);

            }
            // Tổng vượt ngưỡng
            sumE = eDust + eSO2 + eNOx + eCO;
            sumPe = peDust + peSO2 + peNOx + peCO;
        }

       
    }
}
