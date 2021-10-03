
namespace WinformInterface.Forms
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cEMSDataSet = new WinformInterface.CEMSDataSet();
            this.cemsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cemsTableTableAdapter = new WinformInterface.CEMSDataSetTableAdapters.CemsTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cemsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.cemsTableBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(202, 151);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(612, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // cEMSDataSet
            // 
            this.cEMSDataSet.DataSetName = "CEMSDataSet";
            this.cEMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cemsTableBindingSource
            // 
            this.cemsTableBindingSource.DataMember = "CemsTable";
            this.cemsTableBindingSource.DataSource = this.cEMSDataSet;
            // 
            // cemsTableTableAdapter
            // 
            this.cemsTableTableAdapter.ClearBeforeFill = true;
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 687);
            this.Controls.Add(this.chart1);
            this.Name = "FormChart";
            this.Text = "BIỂU ĐỒ";
            this.Load += new System.EventHandler(this.FormChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cemsTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private CEMSDataSet cEMSDataSet;
        private System.Windows.Forms.BindingSource cemsTableBindingSource;
        private CEMSDataSetTableAdapters.CemsTableTableAdapter cemsTableTableAdapter;
    }
}