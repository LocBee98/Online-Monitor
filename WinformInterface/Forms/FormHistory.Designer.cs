
namespace WinformInterface.Forms
{
    partial class FormHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistory));
            this.panelParameters = new System.Windows.Forms.Panel();
            this.btnExport = new WinformInterface.CustomControl.CustomButton();
            this.btnShowData = new WinformInterface.CustomControl.CustomButton();
            this.pickMinEnd = new System.Windows.Forms.ComboBox();
            this.cmbFrequency = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPickTime = new WinformInterface.CustomControl.CustomPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pickHourEnd = new System.Windows.Forms.ComboBox();
            this.panelFrequency = new WinformInterface.CustomControl.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pickHourStart = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pickDateEnd = new System.Windows.Forms.DateTimePicker();
            this.pickDateStart = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pickMinStart = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelShowData = new System.Windows.Forms.Panel();
            this.dtgvHistory = new System.Windows.Forms.DataGridView();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Press = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelParameters.SuspendLayout();
            this.panelPickTime.SuspendLayout();
            this.panelFrequency.SuspendLayout();
            this.panelShowData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panelParameters
            // 
            this.panelParameters.Controls.Add(this.btnExport);
            this.panelParameters.Controls.Add(this.btnShowData);
            this.panelParameters.Controls.Add(this.pickMinEnd);
            this.panelParameters.Controls.Add(this.cmbFrequency);
            this.panelParameters.Controls.Add(this.label3);
            this.panelParameters.Controls.Add(this.panelPickTime);
            this.panelParameters.Controls.Add(this.pickHourEnd);
            this.panelParameters.Controls.Add(this.panelFrequency);
            this.panelParameters.Controls.Add(this.label5);
            this.panelParameters.Controls.Add(this.pickHourStart);
            this.panelParameters.Controls.Add(this.label9);
            this.panelParameters.Controls.Add(this.pickDateEnd);
            this.panelParameters.Controls.Add(this.pickDateStart);
            this.panelParameters.Controls.Add(this.label10);
            this.panelParameters.Controls.Add(this.label4);
            this.panelParameters.Controls.Add(this.label6);
            this.panelParameters.Controls.Add(this.pickMinStart);
            this.panelParameters.Controls.Add(this.label7);
            this.panelParameters.Controls.Add(this.label8);
            this.panelParameters.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelParameters.Location = new System.Drawing.Point(0, 0);
            this.panelParameters.Name = "panelParameters";
            this.panelParameters.Size = new System.Drawing.Size(312, 673);
            this.panelParameters.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExport.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExport.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExport.BorderRadius = 5;
            this.btnExport.BorderSize = 0;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(38, 603);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(236, 50);
            this.btnExport.TabIndex = 61;
            this.btnExport.Text = "XUẤT DỮ LIỆU";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShowData.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnShowData.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnShowData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowData.BackgroundImage")));
            this.btnShowData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowData.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnShowData.BorderRadius = 5;
            this.btnShowData.BorderSize = 0;
            this.btnShowData.FlatAppearance.BorderSize = 0;
            this.btnShowData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowData.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowData.ForeColor = System.Drawing.Color.White;
            this.btnShowData.Location = new System.Drawing.Point(38, 539);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(236, 50);
            this.btnShowData.TabIndex = 61;
            this.btnShowData.Text = "XEM DỮ LIỆU";
            this.btnShowData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowData.TextColor = System.Drawing.Color.White;
            this.btnShowData.UseVisualStyleBackColor = false;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // pickMinEnd
            // 
            this.pickMinEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pickMinEnd.FormattingEnabled = true;
            this.pickMinEnd.Location = new System.Drawing.Point(123, 418);
            this.pickMinEnd.Name = "pickMinEnd";
            this.pickMinEnd.Size = new System.Drawing.Size(66, 24);
            this.pickMinEnd.TabIndex = 60;
            // 
            // cmbFrequency
            // 
            this.cmbFrequency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbFrequency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFrequency.FormattingEnabled = true;
            this.cmbFrequency.Location = new System.Drawing.Point(168, 44);
            this.cmbFrequency.Name = "cmbFrequency";
            this.cmbFrequency.Size = new System.Drawing.Size(90, 24);
            this.cmbFrequency.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Phút";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panelPickTime
            // 
            this.panelPickTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPickTime.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelPickTime.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.panelPickTime.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelPickTime.BorderRadius = 5;
            this.panelPickTime.BorderSize = 0;
            this.panelPickTime.Controls.Add(this.label2);
            this.panelPickTime.ForeColor = System.Drawing.Color.White;
            this.panelPickTime.Location = new System.Drawing.Point(43, 118);
            this.panelPickTime.Name = "panelPickTime";
            this.panelPickTime.Size = new System.Drawing.Size(226, 33);
            this.panelPickTime.TabIndex = 0;
            this.panelPickTime.TextColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời gian trích xuất";
            // 
            // pickHourEnd
            // 
            this.pickHourEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pickHourEnd.FormattingEnabled = true;
            this.pickHourEnd.Location = new System.Drawing.Point(123, 386);
            this.pickHourEnd.Name = "pickHourEnd";
            this.pickHourEnd.Size = new System.Drawing.Size(66, 24);
            this.pickHourEnd.TabIndex = 58;
            // 
            // panelFrequency
            // 
            this.panelFrequency.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelFrequency.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelFrequency.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.panelFrequency.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.panelFrequency.BorderRadius = 5;
            this.panelFrequency.BorderSize = 0;
            this.panelFrequency.Controls.Add(this.label1);
            this.panelFrequency.ForeColor = System.Drawing.Color.White;
            this.panelFrequency.Location = new System.Drawing.Point(43, 39);
            this.panelFrequency.Name = "panelFrequency";
            this.panelFrequency.Size = new System.Drawing.Size(119, 34);
            this.panelFrequency.TabIndex = 0;
            this.panelFrequency.TextColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tần suất";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Giờ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pickHourStart
            // 
            this.pickHourStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pickHourStart.FormattingEnabled = true;
            this.pickHourStart.Location = new System.Drawing.Point(125, 236);
            this.pickHourStart.Name = "pickHourStart";
            this.pickHourStart.Size = new System.Drawing.Size(66, 24);
            this.pickHourStart.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(41, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Ngày";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pickDateEnd
            // 
            this.pickDateEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pickDateEnd.CustomFormat = "dd-MM-yyyy";
            this.pickDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickDateEnd.Location = new System.Drawing.Point(123, 357);
            this.pickDateEnd.Name = "pickDateEnd";
            this.pickDateEnd.Size = new System.Drawing.Size(133, 22);
            this.pickDateEnd.TabIndex = 55;
            // 
            // pickDateStart
            // 
            this.pickDateStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pickDateStart.CustomFormat = "dd-MM-yyyy";
            this.pickDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickDateStart.Location = new System.Drawing.Point(125, 207);
            this.pickDateStart.Name = "pickDateStart";
            this.pickDateStart.Size = new System.Drawing.Size(133, 22);
            this.pickDateStart.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(39, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Thời gian kết thúc";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(40, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Thời gian bắt đầu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(43, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Ngày";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pickMinStart
            // 
            this.pickMinStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pickMinStart.FormattingEnabled = true;
            this.pickMinStart.Location = new System.Drawing.Point(125, 268);
            this.pickMinStart.Name = "pickMinStart";
            this.pickMinStart.Size = new System.Drawing.Size(66, 24);
            this.pickMinStart.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(42, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Giờ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(42, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "Phút";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panelShowData
            // 
            this.panelShowData.Controls.Add(this.dtgvHistory);
            this.panelShowData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowData.Location = new System.Drawing.Point(312, 0);
            this.panelShowData.Name = "panelShowData";
            this.panelShowData.Size = new System.Drawing.Size(950, 673);
            this.panelShowData.TabIndex = 1;
            // 
            // dtgvHistory
            // 
            this.dtgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col,
            this.DateTime,
            this.Temp,
            this.Press,
            this.Dust,
            this.Flow,
            this.SO2,
            this.NOx,
            this.CO,
            this.O2,
            this.State});
            this.dtgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHistory.Location = new System.Drawing.Point(0, 0);
            this.dtgvHistory.Name = "dtgvHistory";
            this.dtgvHistory.RowHeadersWidth = 51;
            this.dtgvHistory.RowTemplate.Height = 24;
            this.dtgvHistory.Size = new System.Drawing.Size(950, 673);
            this.dtgvHistory.TabIndex = 1;
            // 
            // Col
            // 
            this.Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Col.DataPropertyName = "Col";
            this.Col.FillWeight = 73.15421F;
            this.Col.Frozen = true;
            this.Col.HeaderText = "STT";
            this.Col.MinimumWidth = 6;
            this.Col.Name = "Col";
            this.Col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col.Width = 40;
            // 
            // DateTime
            // 
            this.DateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DateTime.DataPropertyName = "DateTime";
            this.DateTime.FillWeight = 147.0588F;
            this.DateTime.HeaderText = "Thời gian";
            this.DateTime.MinimumWidth = 6;
            this.DateTime.Name = "DateTime";
            this.DateTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateTime.Width = 120;
            // 
            // Temp
            // 
            this.Temp.DataPropertyName = "Temp";
            this.Temp.FillWeight = 97.7541F;
            this.Temp.HeaderText = "Nhiệt độ (°C)";
            this.Temp.MinimumWidth = 6;
            this.Temp.Name = "Temp";
            // 
            // Press
            // 
            this.Press.DataPropertyName = "Press";
            this.Press.FillWeight = 97.7541F;
            this.Press.HeaderText = "Áp suất (Pa)";
            this.Press.MinimumWidth = 6;
            this.Press.Name = "Press";
            // 
            // Dust
            // 
            this.Dust.DataPropertyName = "Dust";
            this.Dust.FillWeight = 97.7541F;
            this.Dust.HeaderText = "Bụi (mg/Nm3)";
            this.Dust.MinimumWidth = 6;
            this.Dust.Name = "Dust";
            // 
            // Flow
            // 
            this.Flow.DataPropertyName = "Flow";
            this.Flow.FillWeight = 97.7541F;
            this.Flow.HeaderText = "Lưu lượng (m3/h)";
            this.Flow.MinimumWidth = 6;
            this.Flow.Name = "Flow";
            // 
            // SO2
            // 
            this.SO2.DataPropertyName = "SO2";
            this.SO2.FillWeight = 97.7541F;
            this.SO2.HeaderText = "SO2 (mg/Nm3)";
            this.SO2.MinimumWidth = 6;
            this.SO2.Name = "SO2";
            // 
            // NOx
            // 
            this.NOx.DataPropertyName = "NOx";
            this.NOx.FillWeight = 97.7541F;
            this.NOx.HeaderText = "NOx (mg/Nm3)";
            this.NOx.MinimumWidth = 6;
            this.NOx.Name = "NOx";
            // 
            // CO
            // 
            this.CO.DataPropertyName = "CO";
            this.CO.FillWeight = 97.7541F;
            this.CO.HeaderText = "CO (mg/Nm3)";
            this.CO.MinimumWidth = 6;
            this.CO.Name = "CO";
            // 
            // O2
            // 
            this.O2.DataPropertyName = "O2";
            this.O2.FillWeight = 97.7541F;
            this.O2.HeaderText = "O2 (%V)";
            this.O2.MinimumWidth = 6;
            this.O2.Name = "O2";
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.FillWeight = 97.7541F;
            this.State.HeaderText = "Trạng thái";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelShowData);
            this.Controls.Add(this.panelParameters);
            this.Name = "FormHistory";
            this.Text = "LỊCH SỬ VÀ TRÍCH XUẤT DỮ LIỆU";
            this.Load += new System.EventHandler(this.FormHistory_Load);
            this.panelParameters.ResumeLayout(false);
            this.panelParameters.PerformLayout();
            this.panelPickTime.ResumeLayout(false);
            this.panelPickTime.PerformLayout();
            this.panelFrequency.ResumeLayout(false);
            this.panelFrequency.PerformLayout();
            this.panelShowData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelParameters;
        private System.Windows.Forms.ComboBox pickMinEnd;
        private System.Windows.Forms.ComboBox cmbFrequency;
        private System.Windows.Forms.Label label3;
        private CustomControl.CustomPanel panelPickTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pickHourEnd;
        private CustomControl.CustomPanel panelFrequency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pickHourStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker pickDateEnd;
        private System.Windows.Forms.DateTimePicker pickDateStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pickMinStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelShowData;
        private CustomControl.CustomButton btnExport;
        private CustomControl.CustomButton btnShowData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Press;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flow;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOx;
        private System.Windows.Forms.DataGridViewTextBoxColumn CO;
        private System.Windows.Forms.DataGridViewTextBoxColumn O2;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
    }
}