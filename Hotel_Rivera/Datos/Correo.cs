using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Rivera.Datos
{
    public class Correo
    {
        public static void RecuperarContra(string contra)
        {
            // Variable que contiene la dirección de correo a la que se enviará el mensaje
            string correo = " ";
            try
            {
                // Configuración del cliente SMTP
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("correo", "contraseña");//del propietario

                // Crear el correo electrónico
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("correo");//del propietario
                mail.To.Add(correo); // Usar la dirección guardada en la variable
                mail.Subject = "Reestablecimiento de contraseña";
                mail.Body = "Su contraseña ha sido modificada a: "+ contra;

                // Enviar el correo electrónico
                client.Send(mail);

                Console.WriteLine("El correo se ha enviado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo: " + ex.Message);
            }
        }
    }
}
