
namespace WinformInterface.Forms
{
    partial class FormCheckFile
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
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelectServer = new System.Windows.Forms.ComboBox();
            this.txbResult2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txbDetailResult = new MonitorVersion1.CustomItems.customTextBox1();
            this.txbResult = new MonitorVersion1.CustomItems.customTextBox1();
            this.btnCheckFile = new WinformInterface.CustomControl.CustomButton();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "KẾT QUẢ KIỂM TRA";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 112);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 31);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "NGÀY CẦN KIỂM TRA";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỰA CHỌN SERVER";
            // 
            // cmbSelectServer
            // 
            this.cmbSelectServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSelectServer.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectServer.FormattingEnabled = true;
            this.cmbSelectServer.Location = new System.Drawing.Point(569, 108);
            this.cmbSelectServer.Name = "cmbSelectServer";
            this.cmbSelectServer.Size = new System.Drawing.Size(315, 35);
            this.cmbSelectServer.TabIndex = 3;
            // 
            // txbResult2
            // 
            this.txbResult2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbResult2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbResult2.Location = new System.Drawing.Point(169, 420);
            this.txbResult2.Multiline = true;
            this.txbResult2.Name = "txbResult2";
            this.txbResult2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbResult2.Size = new System.Drawing.Size(635, 236);
            this.txbResult2.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txbDetailResult
            // 
            this.txbDetailResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbDetailResult.BackColor = System.Drawing.SystemColors.Window;
            this.txbDetailResult.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(64)))));
            this.txbDetailResult.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbDetailResult.BorderRadius = 10;
            this.txbDetailResult.BorderSize = 2;
            this.txbDetailResult.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDetailResult.Location = new System.Drawing.Point(159, 413);
            this.txbDetailResult.Multiline = true;
            this.txbDetailResult.Name = "txbDetailResult";
            this.txbDetailResult.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbDetailResult.PasswordChar = false;
            this.txbDetailResult.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbDetailResult.PlaceholderText = "Danh dách những file truyền thiếu (nếu có)";
            this.txbDetailResult.Size = new System.Drawing.Size(658, 248);
            this.txbDetailResult.TabIndex = 4;
            this.txbDetailResult.Texts = "";
            this.txbDetailResult.UnderlinedStyle = false;
            // 
            // txbResult
            // 
            this.txbResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbResult.BackColor = System.Drawing.SystemColors.Window;
            this.txbResult.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(64)))));
            this.txbResult.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbResult.BorderRadius = 10;
            this.txbResult.BorderSize = 2;
            this.txbResult.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResult.Location = new System.Drawing.Point(159, 342);
            this.txbResult.Multiline = false;
            this.txbResult.Name = "txbResult";
            this.txbResult.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbResult.PasswordChar = false;
            this.txbResult.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbResult.PlaceholderText = "Kết quả";
            this.txbResult.Size = new System.Drawing.Size(658, 37);
            this.txbResult.TabIndex = 4;
            this.txbResult.Texts = "";
            this.txbResult.UnderlinedStyle = false;
            // 
            // btnCheckFile
            // 
            this.btnCheckFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckFile.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCheckFile.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCheckFile.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCheckFile.BorderRadius = 5;
            this.btnCheckFile.BorderSize = 0;
            this.btnCheckFile.FlatAppearance.BorderSize = 0;
            this.btnCheckFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckFile.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckFile.ForeColor = System.Drawing.Color.White;
            this.btnCheckFile.Location = new System.Drawing.Point(155, 186);
            this.btnCheckFile.Name = "btnCheckFile";
            this.btnCheckFile.Size = new System.Drawing.Size(157, 44);
            this.btnCheckFile.TabIndex = 1;
            this.btnCheckFile.Text = "KIỂM TRA";
            this.btnCheckFile.TextColor = System.Drawing.Color.White;
            this.btnCheckFile.UseVisualStyleBackColor = false;
            this.btnCheckFile.Click += new System.EventHandler(this.txbCheckFile_Click);
            // 
            // FormCheckFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 673);
            this.Controls.Add(this.txbResult2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSelectServer);
            this.Controls.Add(this.txbDetailResult);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCheckFile);
            this.Controls.Add(this.label5);
            this.Name = "FormCheckFile";
            this.Text = "TÌNH TRẠNG TRUYỀN FILE LÊN SỞ TNMT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCheckFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CustomControl.CustomButton btnCheckFile;
        private System.Windows.Forms.Label label5;
        private MonitorVersion1.CustomItems.customTextBox1 txbResult;
        private System.Windows.Forms.ComboBox cmbSelectServer;
        private System.Windows.Forms.Label label1;
        private MonitorVersion1.CustomItems.customTextBox1 txbDetailResult;
        private System.Windows.Forms.TextBox txbResult2;
        private System.Windows.Forms.Timer timer1;
    }
}