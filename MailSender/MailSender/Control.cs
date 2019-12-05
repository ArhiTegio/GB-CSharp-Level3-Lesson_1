using MailSenderLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    class Control
    {
        public void Send(string user, string password)
        {
            try { (new EmailSender()).Send(user, password); }
            catch (Exception exception) { (new MessageSendCompletedDlg(exception.Message)).ShowDialog(); }
        }
    }
}
