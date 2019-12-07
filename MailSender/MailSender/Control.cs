using MailSenderLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MailSender
{
    class Control
    {
        public void Send(string user, string password)
        {
            try { (new EmailSender()).Send(user, password); }
            catch (Exception exception) { (new MessageError(exception.Message)).ShowDialog(); }
        }
    }
}
