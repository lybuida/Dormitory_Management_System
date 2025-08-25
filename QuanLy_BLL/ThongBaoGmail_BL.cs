using QuanLy_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_BLL
{
    public class ThongBaoGmail_BL
    {
        private ThongBaoGmail_DL thongBaoGmail;

        public ThongBaoGmail_BL()
        {
            thongBaoGmail = new ThongBaoGmail_DL();
        }

        public List<string> LayDanhSachEmail()
        {
            return thongBaoGmail.LayDanhSachEmail();
        }

        public void GuiMailToanBo(string noidung, string tieuDe = "Thông báo từ Ký túc xá")
        {
            var emails = LayDanhSachEmail();
            if (emails.Count == 0) return;

            // Cấu hình SMTP
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("hethongktx@gmail.com", "ytma rcuq qtnn pfrc");

                // Tạo mail
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("hethongktx@gmail.com");
                    mail.Subject = tieuDe;
                    mail.Body = noidung;
                    mail.IsBodyHtml = true;

                    foreach (var email in emails)
                    {
                        mail.Bcc.Add(email); // dùng BCC thay cho To
                    }

                    smtp.Send(mail);
                }
            }
        }
    }
}
