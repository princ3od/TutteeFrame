using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace TutteeFrame
{
    class MailHelper
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool Send(string _toMail, string _subject, string _body)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtpClient = new SmtpClient();

                mailMessage.From = new MailAddress("princ3od@gmail.com", "TutteeFrameCorp", System.Text.Encoding.UTF8);
                mailMessage.To.Add(new MailAddress(_toMail));
                mailMessage.Subject = "Mật khẩu cho tài khoản TutteeFrame";
                mailMessage.Body = "Vui lòng không cung cấp mật khẩu sau đây cho bất kì ai, vì bất kì lí do gì!\n Tên đăng nhập: TC123456 - Mật khẩu: 123456";

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.EnableSsl = true;
                System.Net.NetworkCredential networkCredential = new System.Net.NetworkCredential();
                networkCredential.UserName = "princ3od@gmail.com";
                networkCredential.Password = "princ3daudaihoc";
                smtpClient.Credentials = networkCredential;
                smtpClient.Port = 587;
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
    }
}
