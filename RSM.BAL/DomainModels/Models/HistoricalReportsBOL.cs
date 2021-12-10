using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models
{
    public class SaudaSummaryResponseBOL
    {
        public string segment { get; set; }
        public Int64 sett_no { get; set; }
        public string date { get; set; }
        public string scrip_cd { get; set; }
        public decimal buyqty { get; set; }
        public decimal buyrate { get; set; }
        public decimal buyvalue { get; set; }
        public decimal sellqty { get; set; }
        public decimal sellrate { get; set; }
        public decimal sellvalue { get; set; }
        public decimal netqty { get; set; }
        public decimal netamt { get; set; }
    }

    public class SaudaSummaryRequestBOL
    {
        public string USERID { get; set; }
        public string PRIVILEGES { get; set; }
        public string BRANCHID { get; set; }
        public string ROLE { get; set; }
        public string EXCHANGE { get; set; }
        public string FDATE { get; set; }
        public string TDATE { get; set; }
        public string FPARTY { get; set; }




        public string TPARTY { get; set; }
        public string FSETTNO { get; set; }
        public string TSETTNO { get; set; }
        public string SETT_TYPE { get; set; }
        public string FSCRIP { get; set; }
        public string TSCRIP { get; set; }
        public string Product { get; set; }
        public string MESSAGECODE { get; set; }
        public string MESSAGE { get; set; }
    }
}
