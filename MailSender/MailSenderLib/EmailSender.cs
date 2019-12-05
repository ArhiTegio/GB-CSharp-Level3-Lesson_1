using System.Net;
using System.Net.Mail;

namespace MailSenderLib
{
	/// <summary>
	/// 
	/// </summary>
    public sealed class EmailSender
    {
		/// <summary>
		/// Метод для отправки
		/// </summary>
		/// <param name="strUser"></param>
		/// <param name="strPass"></param>
		/// <exception cref="SmtpException"></exception>
		public void Send(string strUser, string strPass)
	    {
			const string from = "user@yandex.ru";
		    const string to = "user@gmail.com";

		    const string server = "smtp.yandex.ru";

		    try
		    {
			    using (var message = new MailMessage(from, to, "Test message", "Test messae body"))
			    using (var client = new SmtpClient(server) { EnableSsl = true,
				    Credentials = new NetworkCredential(strUser, strPass) })
			    {
				    client.Send(message);
			    }

			}
		    catch (SmtpException error)
		    {
			   throw new SmtpException(error.Message);
		    }
		}
	}
}