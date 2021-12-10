using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models
{
   public class BuybackAdmin
    {

        public string OrderDate { get; set; }
        public string ScripId { get; set; }
        public double ApplicationNo { get; set; }
        public string Category { get; set; }
        public string ApplicantName { get; set; }
        public string Depository { get; set; }
        public string NewDpID { get; set; }
        public string ClientId { get; set; }
        public string Quantity { get; set; }
        public string ISIN { get; set; }
        public string SGBTitle { get; set; }
       
    }
}
