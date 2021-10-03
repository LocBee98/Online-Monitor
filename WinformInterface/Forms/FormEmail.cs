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
    public partial class FormEmail : Form
    {
        public FormEmail()
        {
            InitializeComponent();
            getSetting();
            

        }

        public static string userEmail1, userEmail2, userEmail3;
        public static bool enable1, enable2, enable3;

        #region Button Setting
        private void btnConfirm_MouseMove(object sender, MouseEventArgs e)
        {
            btnConfirm.BackColor = Color.FromArgb(230, 79, 54);
        }

        private void btnConfirm_MouseLeave(object sender, EventArgs e)
        {
            btnConfirm.BackColor = Color.FromArgb(141, 198, 66);

        }

        private void btnCancel_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(230, 79, 54);
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(141, 198, 66);
        }


        #endregion


        private void FormEmail_Load(object sender, EventArgs e)
        {

        }

        private void AlarmForm_Load(object sender, EventArgs e)
        {
            this.btnCancel.BackColor = FormMain._backColorMainForm;
            this.btnConfirm.BackColor = FormMain._backColorMainForm;

            try
            {
                getSetting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getSetting()
        {
            string[] preSetting = new string[12];
            Functions.ReadWriteTxt _getFile = new Functions.ReadWriteTxt();
            preSetting = _getFile.readFile(@"txtSetting\appSetting.txt");

            //Email
            txbEmail1.Texts = preSetting[1];
            txbEmail2.Texts = preSetting[2];
            txbEmail3.Texts = preSetting[3];

            //Enable

            btnEnable1.Checked = Convert.ToBoolean(preSetting[5]);
            btnEnable2.Checked = Convert.ToBoolean(preSetting[6]);
            btnEnable3.Checked = Convert.ToBoolean(preSetting[7]);

            //Freq
            cmbFreq.Text = preSetting[9];
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string[] contents = { "1. User email", txbEmail1.Texts, txbEmail2.Texts, txbEmail3.Texts, "2. Enable", btnEnable1.Checked.ToString(), btnEnable2.Checked.ToString(), btnEnable3.Checked.ToString(), "3. Freq", cmbFreq.Text };
                Functions.ReadWriteTxt _writeFile = new Functions.ReadWriteTxt();
                _writeFile.writeFile(@"txtSetting\appSetting.txt", contents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            getSetting();

        }
    }
}
