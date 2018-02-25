using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail
{
    public static class WpfTestMailSender
    {
        public static string smtpServer = "smtp.yandex.ru";
        public static int port = 25;
        public static string mailFrom = "";
        public static string mailTo = "";
        public static string password = "";
        public static string message = "";
        public static string caption = "";
        public static string attachFile = null;
    }
}
