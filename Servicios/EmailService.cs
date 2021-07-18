using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Servicios
{
    public class EmailService
    {
        private MailMessage email;
        private SmtpClient server;
        private MailAddress bcc;
        public EmailService()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("supprotahost@gmail.com", "Support.rota");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "smtp.gmail.com";
        }

        public void armarCorreo(string emailDestino, string asunto, string cuerpo, string tipoMenaje = "")
        {
            bcc = new MailAddress("rotahost@gmail.com");

            email = new MailMessage();
            email.From = new MailAddress("support.noresponse@rotahost.com");
            email.To.Add(emailDestino);
            email.Bcc.Add(bcc);
            email.Subject = asunto;
            email.IsBodyHtml = true;
            if(tipoMenaje != "")
            email.Body = "<h1>NOTIFICACIÓN AUTOMÁTICA DE ROTA HOST POR: "+tipoMenaje+" </h1> <br>Se han realizado cambios en su servicio. A continuación se agregará el detalle del mismo</br> <br>" + cuerpo+ "</br>";
            else
            {
                email.Body = cuerpo;
            }
        }
        
        public void enviarMail()
        {
            try
            {
                server.Send(email);
            }
            catch(Exception ex)
            {
                
            }
        }
    }    
}
