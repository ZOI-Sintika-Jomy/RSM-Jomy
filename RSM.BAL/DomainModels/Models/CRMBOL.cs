using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models
{
   public  class CRMBOL
    {
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }

        public bool UserExistsFlg { get; set; }
        public string responseStatus { get; set; }
        public string Remarks { get; set; }



       
    }
}
