using System;
using System.Collections.Generic;
using System.Text;

namespace Servicios.Core.DTOS.Settings
{
    public class AppSettings
    {
        public Dictionary<string, string> ConnectionStrings { get; set; }
        public Dictionary<string, string> MailSettings { get; set; }
        public Dictionary<string, string> Servicios { get; set; }
        public Dictionary<string, string> GenerateToken { get; set; }
   }
}
