using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models
{
    public class NetcoreEmailBOL
    {

        public string subject { get; set; }
        public string fromEmail { get; set; }
        public string replyTo { get; set; }
        public string fromName { get; set; }
        public string toEmail { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Body { get; set; }
        public string Tags { get; set; }

    }
}
