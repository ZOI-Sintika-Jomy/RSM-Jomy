using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models
{
    public class WishlistBOL
    {
        public class stockfavorites
        {
            public int FinCode { get; set; }
            public string scripname { get; set; }
            public int exchange { get; set; }
            public decimal LTP { get; set; }
            public decimal changeprice { get; set; }
            public decimal perchange { get; set; }
            public decimal mcap { get; set; }
            public string addeddate { get; set; }
            public string NSETradingSymbol { get; set; }
            public string OmneNSESymbol { get; set; }
            public string BSETradingSymbol { get; set; }
            public string OmneBSESymbol { get; set; }
            public string NSEToken { get; set; }
            public string BSEToken { get; set; }
            public string BPUPTIME { get; set; }
            public string NPUPTIME { get; set; }
            public string NseTicksize { get; set; }
            public string BseTicksize { get; set; }

        }
        public class MfFavourites
        {
            public string scheme_name { get; set; }
            public int mininvt { get; set; }
            public decimal navrs { get; set; }
            public string navdate { get; set; }
            public int schemecode { get; set; }
            public decimal change { get; set; }
            public decimal perchange { get; set; }
            public string amccode { get; set; }
            public decimal sipminamount { get; set; }
            public int optcode { get; set; }
            public string defaultopt { get; set; }
            public string purallowed { get; set; }
            public string sipflag { get; set; }
            public string schemetype { get; set; }
            public string option
            {
                get
                {
                    return defaultopt == "Dividend Payout" ? "DP" : "DR";
                }
            }
        }

        public class stockbasketfav
        {
            public string id { get; set; }
            public string title { get; set; }
            public int exchange { get; set; }
            public int Quantity { get; set; }
            public decimal Total { get; set; }
            public decimal Return_Percent { get; set; }
            // AARTI BASKET EXCEL ISSUE
            public int TotalStock { get; set; }
            public decimal OneYearReturn { get; set; }
            public decimal ManualReturnValue { get; set; }
            public string ManualText { get; set; }
        }

        public class mFbasketfav
        {
            public string id { get; set; }
            public string title { get; set; }
            public int mininv { get; set; }
            public decimal navrs { get; set; }
        }
    }

}
