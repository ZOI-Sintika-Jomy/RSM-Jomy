using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models.CasheModels
{
     public class CasheResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public object payLoad { get; set; }
        public double statusCode { get; set; }
        public string errormsg { get; set; }

    }
}
