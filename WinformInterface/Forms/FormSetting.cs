using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;


namespace WinformInterface.Forms
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();


            string[] ports = SerialPort.GetPortNames();
            cmbComEM5.Items.AddRange(ports);
            cmbComEM5.SelectedIndex = 4;

            cmbComPTF.Items.AddRange(ports);
            cmbComPTF.SelectedIndex = 0;

            cmbComDMS.Items.AddRange(ports);
            cmbComDMS.SelectedIndex = 0;

        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            txbCoef.Text = settingParam.coef.ToString("0.00");
            txbDuste.Text = settingParam.dust_thres.ToString("0.00");
            txbSO2e.Text = settingParam.SO2_thres.ToString("0.00");
            txbNOxe.Text = settingParam.NOx_thres.ToString("0.00");
            txbCOe.Text = settingParam.CO_thres.ToString("0.00");

        }

        #region Setting COM EM5




        //private void btnOpen_Click_1(object sender, EventArgs e)
        //{
        //    if (FormMain.sp1.IsOpen == false)
        //    {
        //        try
        //        {
        //            FormMain.sp1.Open();
        //            MessageBox.Show("Thay đổi cấu hình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        //private void cmbCOM_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    if (FormMain.sp1.IsOpen)
        //    {
        //        FormMain.sp1.Close();
        //    }

        //    FormMain.sp1.PortName = cmbComEM5.SelectedItem.ToString(); // Gán PortName bằng COM đã chọn 
        //}

        //private void cmbBaud_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    if (FormMain.sp1.IsOpen)
        //    {
        //        FormMain.sp1.Close();
        //    }
        //    FormMain.sp1.BaudRate = Convert.ToInt32(cmbBaud.Text);
        //}

        //private void cmbParity_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    if (FormMain.sp1.IsOpen)
        //    {
        //        FormMain.sp1.Close();
        //    }
        //    switch (cmbParity.SelectedItem.ToString())
        //    {
        //        case "None":
        //            FormMain.sp1.Parity = Parity.None;
        //            break;
        //        case "Even":
        //            FormMain.sp1.Parity = Parity.Even;
        //            break;
        //        case "Odd":
        //            FormMain.sp1.Parity = Parity.Odd;
        //            break;
        //    }
        //}

        //private void cmbDataBit_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (FormMain.sp1.IsOpen)
        //    {
        //        FormMain.sp1.Close();
        //    }
        //    FormMain.sp1.DataBits = Convert.ToInt32(cmbDataBit.Text);
        //}

        //private void cmbStop_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    if (FormMain.sp1.IsOpen)
        //    {
        //        FormMain.sp1.Close();
        //    }
        //    switch (cmbStop.SelectedItem.ToString())
        //    {
        //        case "1":
        //            FormMain.sp1.StopBits = StopBits.One;
        //            break;
        //        case "1.5":
        //            FormMain.sp1.StopBits = StopBits.OnePointFive;
        //            break;
        //        case "2":
        //            FormMain.sp1.StopBits = StopBits.Two;
        //            break;

        //    }
        //}

        



        private void btnCloseEM5_Click(object sender, EventArgs e)
        {
            if (FormMain.sp1.IsOpen)
            {
                try
                {
                    FormMain.sp1.Close();
                    MessageBox.Show("Đã đóng cổng " + FormMain.sp1.PortName + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOpenEM5_Click(object sender, EventArgs e)
        {
            if (FormMain.sp1.IsOpen == false)
            {
                try
                {
                    FormMain.sp1.Open();
                    MessageBox.Show("Thay đổi cấu hình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbComEM5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormMain.sp1.IsOpen)
            {
                FormMain.sp1.Close();
            }
            FormMain.sp1.PortName = cmbComEM5.SelectedItem.ToString(); // Gán PortName bằng COM đã chọn 
        }

        //PT Setting
        private void cmbComPTF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormMain.sp2.IsOpen)
            {
                FormMain.sp2.Close();
            }
            FormMain.sp2.PortName =cmbComPTF.SelectedItem.ToString(); // Gán PortName bằng COM đã chọn 
        }

        private void btnClosePT500_Click(object sender, EventArgs e)
        {
            if (FormMain.sp2.IsOpen)
            {
                try
                {
                    FormMain.sp2.Close();
                    MessageBox.Show("Đã đóng cổng " + FormMain.sp2.PortName + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOpenPT500_Click(object sender, EventArgs e)
        {
            if (FormMain.sp2.IsOpen == false)
            {
                try
                {
                    FormMain.sp2.Open();
                    MessageBox.Show("Thay đổi cấu hình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                settingParam.coef = float.Parse(txbCoef.Text);
                settingParam.dust_thres = float.Parse(txbDuste.Text);
                settingParam.NOx_thres = float.Parse(txbNOxe.Text);
                settingParam.CO_thres = float.Parse(txbCOe.Text);
                settingParam.SO2_thres = float.Parse(txbSO2e.Text);
                MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Save parameters into Database and Reload when app first run
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }
    
    
    // Modbus TCP/IP setting

    
    }
}
