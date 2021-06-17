using System.Collections.Generic;

namespace Skynet.Shared.Email
{
    public class Email
    {
        public List<string> To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }
        public string Smtp { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}