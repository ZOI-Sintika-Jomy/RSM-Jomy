using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models
{
    public class UPIModel
    {

        public string Client_ID { get; set; }
        public string Trans_ID { get; set; }
        public string Trans_Time { get; set; }
        public string Ref_ID { get; set; }
        public string Amount { get; set; }
        public string Status { get; set; }
        public string Account_ID { get; set; }
        public string StatusDescrip { get; set; }
        public string ToDate { get; set; }
        public string FromDate { get; set; }
    }

    public class UPITxnStatus
    {
        public List<string> UPIstatus { get; set; }
        public UPIModel UPIdetails { get; set; }
    }
    public class IPORequest
    {
        public string requestMsg { get; set; }
        public string pgMerchantId { get; set; }
    }
}
