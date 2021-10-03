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
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cEMSDataSet.CemsTable' table. You can move, or remove it, as needed.
            this.cemsTableTableAdapter.Fill(this.cEMSDataSet.CemsTable);

        }
    }
}
