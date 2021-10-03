using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
namespace WinformInterface.Functions
{
    class ExportExcel
    {
        
        string path = @"D:\VIETMAPENV\CODER\WINFORM\WinformInterface\WinformInterface\bin\Debug\Reference.xlsx";
        //string path = @"\Reference.xlsx";

        public void OpenExcel(/*string _path, int _sheet*/)
        {
            _Application _excel = new excel.Application();
            _Workbook wb = _excel.Workbooks.Open(path);
            Microsoft.Office.Interop.Excel._Worksheet ws = wb.Worksheets[1];
            ws = wb.ActiveSheet;

            _excel.Visible = true;

        }
        public void Export(DataGridView dataGridView, string timeStart, string timeEnd)
        {

            _Application _excel = new excel.Application();
            _Workbook wb = _excel.Workbooks.Open(path);
            Microsoft.Office.Interop.Excel._Worksheet ws = wb.Worksheets[1];
            ws = wb.ActiveSheet;

            _excel.Visible = true;

            // Do du lieu vao sheet
            ws.Cells[9, 2] = timeStart;
            ws.Cells[10, 2] = timeEnd;
            ws.Cells[12, 1] = "STT";
            //ws.Cells[2, 1] = dataGridView.
            ws.Cells[12, 2] = "Thời gian";
            ws.Cells[12, 3] = "Nhiệt độ (°C)";
            ws.Cells[12, 4] = "Áp suất (Pa)";
            ws.Cells[12, 5] = "Bụi (mg/Nm3)";
            ws.Cells[12, 6] = "Lưu lượng m3/h)";
            ws.Cells[12, 7] = "SO2 (mg/Nm3)";
            ws.Cells[12, 8] = "NOx (mg/Nm3)";
            ws.Cells[12, 9] = "CO (mg/Nm3)";
            ws.Cells[12, 10] = "O2 (%V)";
            ws.Cells[12, 11] = "Trạng thái EM5";
            for (int i = 0; i < dataGridView.RowCount - 1; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    //ws.Cells[i + 3, 1] = i + 1; Make No. Column
                    ws.Cells[i + 13, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                }
            }



        }
    }
}
