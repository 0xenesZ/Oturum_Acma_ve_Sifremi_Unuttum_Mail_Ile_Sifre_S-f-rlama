using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WinFormOturumAcmaİslemi.Models
{
    public class MailYenilemeIstegi
    {
        WinFormOturumAcmaİslemiEntitiesConnectionDb db = new WinFormOturumAcmaİslemiEntitiesConnectionDb();
        public void Microsoft( string GondericiMail, string GondericiPass, string AliciMail)
        {
            Kullanici_Giris_Tablosu k =  db.Kullanici_Giris_Tablosu.FirstOrDefault(x =>x.Mail == GondericiMail);
            Random random = new Random();
            k.Password = random.Next(1000, 1000).ToString();
            db.SaveChanges();
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(GondericiMail, GondericiPass);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(GondericiMail, "Oturum Açma Projesi");
            mail.To.Add(AliciMail);
            mail.Subject = "Şifre yenileme talebinde bulundunuz";
            mail.IsBodyHtml = true;
            mail.Body = $@"{DateTime.Now.ToString()} Tarihinde şifre yenileme talebinde bulundunuz. Yeni şifreniz:{k.Password}";            
            sc.Send(mail);
        }
    }
}
