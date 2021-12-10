using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models
{
   public class TrendingOrderBook
    {
        public string OrderDate { get; set; }
        public string ScripId { get; set; }
        public double ApplicationNo { get; set; }
        public string Category { get; set; }
        public string ApplicantName { get; set; }
        public string Depository { get; set; }
        public string DpID { get; set; }
        public string ClientId { get; set; }
        public string Quantity { get; set; }
        public string cutoffFlag { get; set; }
        public string Rate { get; set; }
        public string ChequeReceivedFlag { get; set; }
        public string ChequeAmount { get; set; }
        public double ChequeNumber { get; set; }
        public string PanNo { get; set; }
        public string BankName { get; set; }
        public double TransactionId { get; set; }
        public string Status { get; set; }
        public double AllotedUnits { get; set; }
        public string Asset { get; set; }
        public string SGBTitle { get; set; }
        public string NewDpID { get; set; }
        public string Exchange { get; set; }
        public string NSEToken { get; set; }
        public string BSEToken { get; set; }

        public double Price1 { get; set; }
        public double Price2 { get; set; }
        public double Price3 { get; set; }
        public double Minapln { get; set; }
        public double Qty1 { get; set; }
        public double Qty2 { get; set; }
        public double Qty3 { get; set; }
        public string UPIID { get; set; }
        public string IssueType { get; set; }
        public double IssuePrice { get; set; }
        public double IssuePrice1 { get; set; }
        public double IssuePrice2 { get; set; }
        public string IPO_Cutoff_flag1 { get; set; }
        public string IPO_Cutoff_flag2 { get; set; }
        public string IPO_Cutoff_flag3 { get; set; }
        public double MaxrSub { get; set; }
        public DateTime CloseDate { get; set; }
        public DateTime Opendate { get; set; }
        public string CancelledBy { get; set; }
        public string Shareholder { get; set; }


    }
}
