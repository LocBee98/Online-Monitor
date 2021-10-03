using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformInterface.Forms
{
    public partial class FormHistory : Form
    {
        //Get ID respectively Date-Time
        string DateTimeQueryStart = string.Empty;
        string DateTimeQueryEnd = string.Empty;

        public FormHistory()
        {
            InitializeComponent();
            #region Choose Time Display and Export
            string[] hourStart = new string[24];
            string[] hourEnd = new string[24];
            string[] minStart = new string[12];
            string[] minEnd = new string[12];

            for (int i = 0; i < 24; i++)
            {
                hourStart[i] = i.ToString("00");
                hourEnd[i] = i.ToString("00");
            }
            pickHourStart.Items.AddRange(hourStart);
            pickHourStart.SelectedIndex = 0;
            pickHourEnd.Items.AddRange(hourEnd);
            pickHourEnd.SelectedIndex = 23;


            for (int i = 0; 5 * i < 60; i++)
            {
                var temp = 5 * i;
                minStart[i] = temp.ToString("00");
                minEnd[i] = temp.ToString("00");
            }
            pickMinStart.Items.AddRange(minStart);
            pickMinStart.SelectedIndex = 0;
            pickMinEnd.Items.AddRange(minEnd);
            pickMinEnd.SelectedIndex = 11;

            string[] Frequency = new string[] { "1", "5", "30", "60" };
            cmbFrequency.Items.AddRange(Frequency);
            cmbFrequency.SelectedIndex = 1;



            #endregion
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            btnExport.BackColor = FormMain._btnColorActive;
            btnShowData.BackColor = FormMain._btnColorActive;
            panelFrequency.BackColor = FormMain._btnColorActive;
            panelPickTime.BackColor = FormMain._btnColorActive;

        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            string _startID = string.Empty;
            string _endID = string.Empty;

            ////Get ID respectively Date-Time
            //string DateTimeQueryStart = string.Empty;
            //string DateTimeQueryEnd = string.Empty;
            DateTimeQueryStart = pickDateStart.Text + " " +  pickHourStart.Text + ":" + pickMinStart.Text;
            DateTimeQueryEnd = pickDateEnd.Text + " " + pickHourEnd.Text + ":" + pickMinEnd.Text;

            ////Get time to show:
            //ShowDateTimeQueryStart = pickDateStart.Text + "   " + pickHourStart.Text + ":" + pickMinEnd.Text;
            //ShowDateTimeQueryEnd = pickDateEnd.Text + "   " + pickHourEnd.Text + ":" + pickMinEnd.Text;

            Functions.SqlFunction SqlFC = new Functions.SqlFunction();
            DataTable _dt = new DataTable();

            //Query following Date-Time
            try
            {
                //Get ID Start
                _startID = SqlFC.getID_Query(DateTimeQueryStart);
                // Get ID End
                _endID = SqlFC.getID_Query(DateTimeQueryEnd);
                _dt = SqlFC.getDataTb_Excel(Int32.Parse(_startID), Int32.Parse(_endID), cmbFrequency.Text);




                dtgvHistory.DataSource = _dt;
                for (int i = 0; i < dtgvHistory.Rows.Count - 1; i++)
                {
                    dtgvHistory.Rows[i].Cells[0].Value = i + 1;
                }

                dtgvHistory.FirstDisplayedScrollingRowIndex = dtgvHistory.RowCount - 1;
                dtgvHistory.Refresh();
            }
            catch
            {
                DialogResult result = MessageBox.Show("Hãy chọn lại thời gian!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Functions.ExportExcel _Export = new Functions.ExportExcel();
            _Export.Export(dtgvHistory, DateTimeQueryStart, DateTimeQueryEnd);
        }
    }
}
