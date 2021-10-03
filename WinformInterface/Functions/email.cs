using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace WinformInterface.Functions
{
    public class email
    {
        private string fromUser = null;
        private string fromPass = null;
        private string toUser = null;
        private string smtpServer = "smtp.gmail.com";

        //string   _fromUser = "vietmapenv.alarm@gmail.com";
        //string   _fromPass = "huyviet123";
        //    toUser = "locxuan@vietmapenv.vn";

        /* Construct Object */
        public email(string _fromUser, string _fromPass, string _toUser) { fromUser = _fromUser; fromPass = _fromPass; toUser = _toUser; }

        //Method
        public void sendMessage(string messageBody)
        {

            MailMessage message = new MailMessage(fromUser, toUser);
            message.Subject = "CẢNH BÁO MẤT TÍN HIỆU";
            message.Body = messageBody;
            SmtpClient client = new SmtpClient(smtpServer);
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(fromUser, fromPass);

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when send a message. Detail: \r\n" + ex.ToString());
            }
        }
    }
}
