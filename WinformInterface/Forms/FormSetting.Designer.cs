
namespace WinformInterface.Forms
{
    partial class FormSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.lbStat = new System.Windows.Forms.Label();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbComEM5 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbComDMS = new System.Windows.Forms.ComboBox();
            this.cmbComPTF = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txbCoef = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbDuste = new System.Windows.Forms.TextBox();
            this.txbCOe = new System.Windows.Forms.TextBox();
            this.txbNOxe = new System.Windows.Forms.TextBox();
            this.txbSO2e = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.customButton2 = new WinformInterface.CustomControl.CustomButton();
            this.customButton1 = new WinformInterface.CustomControl.CustomButton();
            this.customPanel1 = new WinformInterface.CustomControl.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new WinformInterface.CustomControl.CustomButton();
            this.btnOpenDMS = new WinformInterface.CustomControl.CustomButton();
            this.btnOpenPT500 = new WinformInterface.CustomControl.CustomButton();
            this.btnOpenEM5 = new WinformInterface.CustomControl.CustomButton();
            this.btnCloseDMS = new WinformInterface.CustomControl.CustomButton();
            this.customPanel2 = new WinformInterface.CustomControl.CustomPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClosePT500 = new WinformInterface.CustomControl.CustomButton();
            this.customPanel3 = new WinformInterface.CustomControl.CustomPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCloseEM5 = new WinformInterface.CustomControl.CustomButton();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(967, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Modbus TCP/IP";
            // 
            // lbStat
            // 
            this.lbStat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStat.AutoSize = true;
            this.lbStat.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStat.Location = new System.Drawing.Point(968, 115);
            this.lbStat.Name = "lbStat";
            this.lbStat.Size = new System.Drawing.Size(132, 17);
            this.lbStat.TabIndex = 20;
            this.lbStat.Text = "Status Connection";
            // 
            // txbIP
            // 
            this.txbIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbIP.Location = new System.Drawing.Point(1071, 68);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(156, 22);
            this.txbIP.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(968, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "IP Server";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cấu hình thiết bị đo";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Serial Ports";
            // 
            // cmbComEM5
            // 
            this.cmbComEM5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbComEM5.ForeColor = System.Drawing.Color.OrangeRed;
            this.cmbComEM5.FormattingEnabled = true;
            this.cmbComEM5.Location = new System.Drawing.Point(164, 127);
            this.cmbComEM5.Name = "cmbComEM5";
            this.cmbComEM5.Size = new System.Drawing.Size(144, 24);
            this.cmbComEM5.TabIndex = 10;
            this.cmbComEM5.SelectedIndexChanged += new System.EventHandler(this.cmbComEM5_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Serial Ports";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Serial Ports";
            // 
            // cmbComDMS
            // 
            this.cmbComDMS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbComDMS.ForeColor = System.Drawing.Color.OrangeRed;
            this.cmbComDMS.FormattingEnabled = true;
            this.cmbComDMS.Location = new System.Drawing.Point(164, 491);
            this.cmbComDMS.Name = "cmbComDMS";
            this.cmbComDMS.Size = new System.Drawing.Size(144, 24);
            this.cmbComDMS.TabIndex = 10;
            // 
            // cmbComPTF
            // 
            this.cmbComPTF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbComPTF.ForeColor = System.Drawing.Color.OrangeRed;
            this.cmbComPTF.FormattingEnabled = true;
            this.cmbComPTF.Location = new System.Drawing.Point(164, 312);
            this.cmbComPTF.Name = "cmbComPTF";
            this.cmbComPTF.Size = new System.Drawing.Size(144, 24);
            this.cmbComPTF.TabIndex = 10;
            this.cmbComPTF.SelectedIndexChanged += new System.EventHandler(this.cmbComPTF_SelectedIndexChanged);
            // 
            // txbCoef
            // 
            this.txbCoef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCoef.Location = new System.Drawing.Point(660, 334);
            this.txbCoef.Name = "txbCoef";
            this.txbCoef.Size = new System.Drawing.Size(131, 22);
            this.txbCoef.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(544, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(267, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "Hệ số chuẩn bị vượt ngưỡng";
            // 
            // txbDuste
            // 
            this.txbDuste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbDuste.Location = new System.Drawing.Point(660, 223);
            this.txbDuste.Name = "txbDuste";
            this.txbDuste.Size = new System.Drawing.Size(131, 22);
            this.txbDuste.TabIndex = 32;
            // 
            // txbCOe
            // 
            this.txbCOe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCOe.Location = new System.Drawing.Point(660, 174);
            this.txbCOe.Name = "txbCOe";
            this.txbCOe.Size = new System.Drawing.Size(131, 22);
            this.txbCOe.TabIndex = 32;
            // 
            // txbNOxe
            // 
            this.txbNOxe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNOxe.Location = new System.Drawing.Point(660, 128);
            this.txbNOxe.Name = "txbNOxe";
            this.txbNOxe.Size = new System.Drawing.Size(131, 22);
            this.txbNOxe.TabIndex = 32;
            // 
            // txbSO2e
            // 
            this.txbSO2e.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbSO2e.Location = new System.Drawing.Point(660, 85);
            this.txbSO2e.Name = "txbSO2e";
            this.txbSO2e.Size = new System.Drawing.Size(131, 22);
            this.txbSO2e.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(544, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Thiết lập ngưỡng giới hạn";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(591, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "SO2";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(591, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "NOx";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(591, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Bụi";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(591, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "CO";
            // 
            // customButton2
            // 
            this.customButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 5;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(1106, 223);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(121, 40);
            this.customButton2.TabIndex = 35;
            this.customButton2.Text = "Ngắt kết nối";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 5;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(1106, 165);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(121, 40);
            this.customButton1.TabIndex = 35;
            this.customButton1.Text = "Kết nối";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customPanel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel1.BorderRadius = 5;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(50, 56);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(258, 50);
            this.customPanel1.TabIndex = 30;
            this.customPanel1.TextColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "EM5";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConfirm.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirm.BorderRadius = 5;
            this.btnConfirm.BorderSize = 0;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(685, 380);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(106, 40);
            this.btnConfirm.TabIndex = 31;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnOpenDMS
            // 
            this.btnOpenDMS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenDMS.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOpenDMS.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOpenDMS.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpenDMS.BorderRadius = 5;
            this.btnOpenDMS.BorderSize = 0;
            this.btnOpenDMS.FlatAppearance.BorderSize = 0;
            this.btnOpenDMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDMS.ForeColor = System.Drawing.Color.White;
            this.btnOpenDMS.Location = new System.Drawing.Point(202, 527);
            this.btnOpenDMS.Name = "btnOpenDMS";
            this.btnOpenDMS.Size = new System.Drawing.Size(106, 40);
            this.btnOpenDMS.TabIndex = 31;
            this.btnOpenDMS.Text = "Open";
            this.btnOpenDMS.TextColor = System.Drawing.Color.White;
            this.btnOpenDMS.UseVisualStyleBackColor = false;
            // 
            // btnOpenPT500
            // 
            this.btnOpenPT500.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenPT500.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOpenPT500.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOpenPT500.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpenPT500.BorderRadius = 5;
            this.btnOpenPT500.BorderSize = 0;
            this.btnOpenPT500.FlatAppearance.BorderSize = 0;
            this.btnOpenPT500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPT500.ForeColor = System.Drawing.Color.White;
            this.btnOpenPT500.Location = new System.Drawing.Point(202, 353);
            this.btnOpenPT500.Name = "btnOpenPT500";
            this.btnOpenPT500.Size = new System.Drawing.Size(106, 40);
            this.btnOpenPT500.TabIndex = 31;
            this.btnOpenPT500.Text = "Open";
            this.btnOpenPT500.TextColor = System.Drawing.Color.White;
            this.btnOpenPT500.UseVisualStyleBackColor = false;
            this.btnOpenPT500.Click += new System.EventHandler(this.btnOpenPT500_Click);
            // 
            // btnOpenEM5
            // 
            this.btnOpenEM5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenEM5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOpenEM5.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOpenEM5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpenEM5.BorderRadius = 5;
            this.btnOpenEM5.BorderSize = 0;
            this.btnOpenEM5.FlatAppearance.BorderSize = 0;
            this.btnOpenEM5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenEM5.ForeColor = System.Drawing.Color.White;
            this.btnOpenEM5.Location = new System.Drawing.Point(202, 165);
            this.btnOpenEM5.Name = "btnOpenEM5";
            this.btnOpenEM5.Size = new System.Drawing.Size(106, 40);
            this.btnOpenEM5.TabIndex = 31;
            this.btnOpenEM5.Text = "Open";
            this.btnOpenEM5.TextColor = System.Drawing.Color.White;
            this.btnOpenEM5.UseVisualStyleBackColor = false;
            this.btnOpenEM5.Click += new System.EventHandler(this.btnOpenEM5_Click);
            // 
            // btnCloseDMS
            // 
            this.btnCloseDMS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCloseDMS.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCloseDMS.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCloseDMS.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCloseDMS.BorderRadius = 5;
            this.btnCloseDMS.BorderSize = 0;
            this.btnCloseDMS.FlatAppearance.BorderSize = 0;
            this.btnCloseDMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseDMS.ForeColor = System.Drawing.Color.White;
            this.btnCloseDMS.Location = new System.Drawing.Point(50, 527);
            this.btnCloseDMS.Name = "btnCloseDMS";
            this.btnCloseDMS.Size = new System.Drawing.Size(106, 40);
            this.btnCloseDMS.TabIndex = 31;
            this.btnCloseDMS.Text = "Close";
            this.btnCloseDMS.TextColor = System.Drawing.Color.White;
            this.btnCloseDMS.UseVisualStyleBackColor = false;
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customPanel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel2.BorderRadius = 5;
            this.customPanel2.BorderSize = 0;
            this.customPanel2.Controls.Add(this.label3);
            this.customPanel2.ForeColor = System.Drawing.Color.White;
            this.customPanel2.Location = new System.Drawing.Point(50, 241);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(258, 50);
            this.customPanel2.TabIndex = 30;
            this.customPanel2.TextColor = System.Drawing.Color.White;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "PT500 - DMS";
            // 
            // btnClosePT500
            // 
            this.btnClosePT500.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClosePT500.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClosePT500.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClosePT500.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClosePT500.BorderRadius = 5;
            this.btnClosePT500.BorderSize = 0;
            this.btnClosePT500.FlatAppearance.BorderSize = 0;
            this.btnClosePT500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePT500.ForeColor = System.Drawing.Color.White;
            this.btnClosePT500.Location = new System.Drawing.Point(50, 353);
            this.btnClosePT500.Name = "btnClosePT500";
            this.btnClosePT500.Size = new System.Drawing.Size(106, 40);
            this.btnClosePT500.TabIndex = 31;
            this.btnClosePT500.Text = "Close";
            this.btnClosePT500.TextColor = System.Drawing.Color.White;
            this.btnClosePT500.UseVisualStyleBackColor = false;
            this.btnClosePT500.Click += new System.EventHandler(this.btnClosePT500_Click);
            // 
            // customPanel3
            // 
            this.customPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customPanel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel3.BorderRadius = 5;
            this.customPanel3.BorderSize = 0;
            this.customPanel3.Controls.Add(this.label15);
            this.customPanel3.ForeColor = System.Drawing.Color.White;
            this.customPanel3.Location = new System.Drawing.Point(50, 420);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(258, 50);
            this.customPanel3.TabIndex = 30;
            this.customPanel3.TextColor = System.Drawing.Color.White;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "Bụi - DMS";
            // 
            // btnCloseEM5
            // 
            this.btnCloseEM5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCloseEM5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCloseEM5.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCloseEM5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCloseEM5.BorderRadius = 5;
            this.btnCloseEM5.BorderSize = 0;
            this.btnCloseEM5.FlatAppearance.BorderSize = 0;
            this.btnCloseEM5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseEM5.ForeColor = System.Drawing.Color.White;
            this.btnCloseEM5.Location = new System.Drawing.Point(50, 165);
            this.btnCloseEM5.Name = "btnCloseEM5";
            this.btnCloseEM5.Size = new System.Drawing.Size(106, 40);
            this.btnCloseEM5.TabIndex = 31;
            this.btnCloseEM5.Text = "Close";
            this.btnCloseEM5.TextColor = System.Drawing.Color.White;
            this.btnCloseEM5.UseVisualStyleBackColor = false;
            this.btnCloseEM5.Click += new System.EventHandler(this.btnCloseEM5_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 617);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.lbStat);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnOpenDMS);
            this.Controls.Add(this.txbIP);
            this.Controls.Add(this.cmbComEM5);
            this.Controls.Add(this.txbCoef);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnOpenPT500);
            this.Controls.Add(this.txbDuste);
            this.Controls.Add(this.cmbComPTF);
            this.Controls.Add(this.txbCOe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOpenEM5);
            this.Controls.Add(this.txbNOxe);
            this.Controls.Add(this.cmbComDMS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbSO2e);
            this.Controls.Add(this.btnCloseDMS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnClosePT500);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCloseEM5);
            this.Name = "FormSetting";
            this.Text = "CẤU HÌNH HỆ THỐNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbStat;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbComEM5;
        private System.IO.Ports.SerialPort serialPort1;
        private CustomControl.CustomButton btnOpenDMS;
        private CustomControl.CustomButton btnOpenPT500;
        private CustomControl.CustomButton btnOpenEM5;
        private CustomControl.CustomButton btnCloseDMS;
        private CustomControl.CustomButton btnClosePT500;
        private CustomControl.CustomButton btnCloseEM5;
        private CustomControl.CustomPanel customPanel3;
        private System.Windows.Forms.Label label15;
        private CustomControl.CustomPanel customPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomControl.CustomPanel customPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbComDMS;
        private System.Windows.Forms.ComboBox cmbComPTF;
        private System.Windows.Forms.TextBox txbCoef;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbDuste;
        private System.Windows.Forms.TextBox txbCOe;
        private System.Windows.Forms.TextBox txbNOxe;
        private System.Windows.Forms.TextBox txbSO2e;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private CustomControl.CustomButton btnConfirm;
        private CustomControl.CustomButton customButton2;
        private CustomControl.CustomButton customButton1;
    }
}