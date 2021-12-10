using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models
{
    public class MoreProductsBOL
    {
        public class NCD
        {
            public string Product_Name { get; set; }
            public string Interest_Rate { get; set; }
            public string Rating { get; set; }
            public string RatingBy { get; set; }
            public string Benefits { get; set; }
            public string Interest { get; set; }
            public string DetailPageUrl { get; set; }
            public string TransactionType { get; set; }
            public string RedirectURL { get; set; }

            public string CreationDate { get; set; }

            public string MPID { get; set; }
            public string Product_Id { get; set; }

        }
    }
}
