using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models
{
    public class PMSBOL
    {
        public string MPID { get; set; }
        public string Product_Name { get; set; }
        public string Returns { get; set; }
        public string Years { get; set; }
        public string Investment_Details { get; set; }
        public  string Inception_date  { get; set; }
        public string DetailPageUrl { get; set; }
        public string TransactionType { get; set; }
        public string RedirectURL { get; set; }
        public string CreationDate { get; set; }

        public string Return_date { get; set; }
    }
}
