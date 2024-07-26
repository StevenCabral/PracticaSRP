using System.Net;
using System.Net.Mail;

namespace PracticaSRP
{
	internal class CorreoElectronicoService
	{
		public void EnviarCorreoElectronico()
		{
			//Nota: la impresion dara error al ser ejecutada, dado a que los datos correspondiente al servicio de correos son falsos.
			try
			{
				string from = "remitente@example.com";
				string to = "destinatario@example.com";
				string subject = "Asunto del correo";
				string body = "Mensaje";

				MailMessage mail = new MailMessage();
				mail.From = new MailAddress(from);
				mail.To.Add(new MailAddress(to));
				mail.Subject = subject;
				mail.Body = body;
				mail.IsBodyHtml = false;

				SmtpClient smtp = new SmtpClient("smtp.gmail.com");
				smtp.Port = 587;
				smtp.Credentials = new NetworkCredential("remitente@gmail.com", "contraseña");
				smtp.EnableSsl = true;

				smtp.Send(mail);
				Console.WriteLine("Correo Enviado Correctamente.");
			}
			catch (SmtpException ex)
			{
				Console.WriteLine($"Error al enviar el correo: {ex.Message} (Código: {ex.StatusCode})");
			}


		}
	}
}
