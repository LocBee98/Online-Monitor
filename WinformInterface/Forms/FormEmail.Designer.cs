
namespace WinformInterface.Forms
{
    partial class FormEmail
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
            this.cmbFreq = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirm = new WinformInterface.CustomControl.CustomButton();
            this.btnCancel = new WinformInterface.CustomControl.CustomButton();
            this.btnEnable3 = new MonitorVersion1.CustomItems.customToggleButton();
            this.txbEmail3 = new MonitorVersion1.CustomItems.customTextBox1();
            this.btnEnable2 = new MonitorVersion1.CustomItems.customToggleButton();
            this.txbEmail2 = new MonitorVersion1.CustomItems.customTextBox1();
            this.btnEnable1 = new MonitorVersion1.CustomItems.customToggleButton();
            this.txbEmail1 = new MonitorVersion1.CustomItems.customTextBox1();
            this.SuspendLayout();
            // 
            // cmbFreq
            // 
            this.cmbFreq.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFreq.FormattingEnabled = true;
            this.cmbFreq.Location = new System.Drawing.Point(272, 526);
            this.cmbFreq.Name = "cmbFreq";
            this.cmbFreq.Size = new System.Drawing.Size(121, 24);
            this.cmbFreq.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email 1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(100, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "Email 2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(100, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 33);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email 3";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(100, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 33);
            this.label4.TabIndex = 18;
            this.label4.Text = "Freq";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(66)))));
            this.btnConfirm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(66)))));
            this.btnConfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirm.BorderRadius = 10;
            this.btnConfirm.BorderSize = 0;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(856, 579);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 65);
            this.btnConfirm.TabIndex = 26;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.MouseLeave += new System.EventHandler(this.btnConfirm_MouseLeave);
            this.btnConfirm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnConfirm_MouseMove);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(66)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(66)))));
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(658, 579);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 65);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            this.btnCancel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseMove);
            // 
            // btnEnable3
            // 
            this.btnEnable3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnable3.Location = new System.Drawing.Point(886, 401);
            this.btnEnable3.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnEnable3.Name = "btnEnable3";
            this.btnEnable3.OffBackColor = System.Drawing.Color.Gray;
            this.btnEnable3.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnEnable3.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(202)))), ((int)(((byte)(115)))));
            this.btnEnable3.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnable3.Size = new System.Drawing.Size(120, 52);
            this.btnEnable3.TabIndex = 24;
            this.btnEnable3.UseVisualStyleBackColor = true;
            // 
            // txbEmail3
            // 
            this.txbEmail3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbEmail3.BackColor = System.Drawing.SystemColors.Window;
            this.txbEmail3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(66)))));
            this.txbEmail3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(71)))), ((int)(((byte)(43)))));
            this.txbEmail3.BorderRadius = 8;
            this.txbEmail3.BorderSize = 2;
            this.txbEmail3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail3.ForeColor = System.Drawing.Color.Black;
            this.txbEmail3.Location = new System.Drawing.Point(272, 401);
            this.txbEmail3.Multiline = true;
            this.txbEmail3.Name = "txbEmail3";
            this.txbEmail3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbEmail3.PasswordChar = false;
            this.txbEmail3.PlaceholderColor = System.Drawing.Color.IndianRed;
            this.txbEmail3.PlaceholderText = "Username";
            this.txbEmail3.Size = new System.Drawing.Size(536, 52);
            this.txbEmail3.TabIndex = 23;
            this.txbEmail3.TabStop = false;
            this.txbEmail3.Texts = "";
            this.txbEmail3.UnderlinedStyle = false;
            // 
            // btnEnable2
            // 
            this.btnEnable2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnable2.Location = new System.Drawing.Point(886, 280);
            this.btnEnable2.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnEnable2.Name = "btnEnable2";
            this.btnEnable2.OffBackColor = System.Drawing.Color.Gray;
            this.btnEnable2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnEnable2.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(202)))), ((int)(((byte)(115)))));
            this.btnEnable2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnable2.Size = new System.Drawing.Size(120, 52);
            this.btnEnable2.TabIndex = 22;
            this.btnEnable2.UseVisualStyleBackColor = true;
            // 
            // txbEmail2
            // 
            this.txbEmail2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbEmail2.BackColor = System.Drawing.SystemColors.Window;
            this.txbEmail2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(66)))));
            this.txbEmail2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(71)))), ((int)(((byte)(43)))));
            this.txbEmail2.BorderRadius = 8;
            this.txbEmail2.BorderSize = 2;
            this.txbEmail2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail2.ForeColor = System.Drawing.Color.Black;
            this.txbEmail2.Location = new System.Drawing.Point(272, 280);
            this.txbEmail2.Multiline = true;
            this.txbEmail2.Name = "txbEmail2";
            this.txbEmail2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbEmail2.PasswordChar = false;
            this.txbEmail2.PlaceholderColor = System.Drawing.Color.IndianRed;
            this.txbEmail2.PlaceholderText = "Username";
            this.txbEmail2.Size = new System.Drawing.Size(536, 52);
            this.txbEmail2.TabIndex = 21;
            this.txbEmail2.TabStop = false;
            this.txbEmail2.Texts = "";
            this.txbEmail2.UnderlinedStyle = false;
            // 
            // btnEnable1
            // 
            this.btnEnable1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnable1.Location = new System.Drawing.Point(886, 153);
            this.btnEnable1.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnEnable1.Name = "btnEnable1";
            this.btnEnable1.OffBackColor = System.Drawing.Color.Gray;
            this.btnEnable1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnEnable1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(202)))), ((int)(((byte)(115)))));
            this.btnEnable1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnable1.Size = new System.Drawing.Size(120, 52);
            this.btnEnable1.TabIndex = 20;
            this.btnEnable1.UseVisualStyleBackColor = true;
            // 
            // txbEmail1
            // 
            this.txbEmail1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbEmail1.BackColor = System.Drawing.SystemColors.Window;
            this.txbEmail1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(66)))));
            this.txbEmail1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(71)))), ((int)(((byte)(43)))));
            this.txbEmail1.BorderRadius = 8;
            this.txbEmail1.BorderSize = 2;
            this.txbEmail1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail1.ForeColor = System.Drawing.Color.Black;
            this.txbEmail1.Location = new System.Drawing.Point(272, 153);
            this.txbEmail1.Multiline = true;
            this.txbEmail1.Name = "txbEmail1";
            this.txbEmail1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbEmail1.PasswordChar = false;
            this.txbEmail1.PlaceholderColor = System.Drawing.Color.IndianRed;
            this.txbEmail1.PlaceholderText = "Username";
            this.txbEmail1.Size = new System.Drawing.Size(536, 52);
            this.txbEmail1.TabIndex = 19;
            this.txbEmail1.TabStop = false;
            this.txbEmail1.Texts = "";
            this.txbEmail1.UnderlinedStyle = false;
            // 
            // FormEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 711);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbFreq);
            this.Controls.Add(this.btnEnable3);
            this.Controls.Add(this.txbEmail3);
            this.Controls.Add(this.btnEnable2);
            this.Controls.Add(this.txbEmail2);
            this.Controls.Add(this.btnEnable1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEmail1);
            this.Name = "FormEmail";
            this.Text = "Thiết lập gửi cảnh báo qua email";
            this.Load += new System.EventHandler(this.FormEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFreq;
        private MonitorVersion1.CustomItems.customToggleButton btnEnable3;
        private MonitorVersion1.CustomItems.customTextBox1 txbEmail3;
        private MonitorVersion1.CustomItems.customToggleButton btnEnable2;
        private MonitorVersion1.CustomItems.customTextBox1 txbEmail2;
        private MonitorVersion1.CustomItems.customToggleButton btnEnable1;
        private MonitorVersion1.CustomItems.customTextBox1 txbEmail1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CustomControl.CustomButton btnCancel;
        private CustomControl.CustomButton btnConfirm;
    }
}