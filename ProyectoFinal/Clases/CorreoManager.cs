using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    public class CorreoManager
    {
        private string myEmail = "jersonchambi29@gmail.com";
        private string MyPassword = "vvke foqh qvzq rolw";
        private string MyAlias = "SoftVet";
        private string[] myAdjuntos;
        private MailMessage mCorreo;

        public CorreoManager()
        {
        }

        public void CrearCuerpoCorreo(string destino, string asunto, string mensaje, string[] adjuntos)
        {
            mCorreo = new MailMessage();
            mCorreo.From = new MailAddress(myEmail, MyAlias, System.Text.Encoding.UTF8);
            mCorreo.To.Add(destino.Trim());
            mCorreo.Subject = asunto.Trim();
            mCorreo.Body = mensaje.Trim();
            mCorreo.IsBodyHtml = true;
            mCorreo.Priority = MailPriority.High;

            for (int i = 0; i < adjuntos.Length; i++)
            {
                mCorreo.Attachments.Add(new Attachment(adjuntos[i]));
            }
        }

        public void Enviar()
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Port = 25;
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new NetworkCredential(myEmail, MyPassword);
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors) { return true; };
                smtp.EnableSsl = true;
                smtp.Send(mCorreo);
            }
            catch (Exception e)
            {
                throw new Exception($"Error al enviar el correo: {e.Message}");
            }
        }
    }
}
