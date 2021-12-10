using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models
{
   public  class BuyBack
    {
        public class BuyBackList
        {
            public string d { get; set; }
        }

        public static Dictionary<int, string> BuyBackExchangeMapping = new Dictionary<int, string>()
        {
                {1,"NSE" },
                {2,"BSE" },
        };
    }
}
