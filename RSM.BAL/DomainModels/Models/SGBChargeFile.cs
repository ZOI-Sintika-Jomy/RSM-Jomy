using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models
{
   public class SGBChargeFile
    {
       
        public string ClientId { get; set; }
        public string ChequeAmount { get; set; }
        public string SGBTitle { get; set; }
        public double ApplicationNo { get; set; }

    }
}
