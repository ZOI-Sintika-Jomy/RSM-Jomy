using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BAL.DomainModels.Models
{
    class MyProfileBOL
    {
    }

    public class StockOrderBook
    {
        public string type { get; set; }
        public string exchange { get; set; }
        public string userid { get; set; }
        public string accid { get; set; }
        public string nestordernumber { get; set; }
        public string nestorderreqid { get; set; }
        public string transactiontype { get; set; }
        public string tradingsymbol { get; set; }
        public string symbol { get; set; }
        public string series { get; set; }
        public string token { get; set; }
        public string companyname { get; set; }
        public string price { get; set; }
        public string avgprice { get; set; }
        public int totalqty { get; set; }
        public int pendingqty { get; set; }
        public int dislcosedqty { get; set; }
        public int filledqty { get; set; }
        public string triggerprice { get; set; }
        public string exchangeorderno { get; set; }
        public string status { get; set; }
        public string rejectionreason { get; set; }
        public string ordertype { get; set; }
        public string orderentrytime { get; set; }
        public string productcode { get; set; }
        public string exchangetimestamp { get; set; }
        public string ordersource { get; set; }
        public string ordergenerationtype { get; set; }
        public string ordervalidity { get; set; }
        public string legorderindicator { get; set; }
        public decimal coverorderpercentage { get; set; }
        public string coverreflimitprice { get; set; }
        public string pricenumerator { get; set; }
        public string pricedenominator { get; set; }
        public string generalnumerator { get; set; }
        public string generaldenominator { get; set; }
        public string remarks { get; set; }
        public string marketprotectionpercentage { get; set; }
        public string sipindicator { get; set; }
        public string reporttype { get; set; }
        public string responsestatus { get; set; }
        public string errormsg { get; set; }
    }

    public class StockTradeBook
    {
        public string exchange { get; set; }
        public string userid { get; set; }
        public string accid { get; set; }
        public string nestordernumber { get; set; }
        public string nestorderreqid { get; set; }
        public string transactiontype { get; set; }
        public string tradingsymbol { get; set; }
        public string symbol { get; set; }
        public string series { get; set; }
        public string companyname { get; set; }
        public double price { get; set; }
        public int qty { get; set; }
        public string tradeid { get; set; }
        public string exchangeorderno { get; set; }
        public string orderentrytime { get; set; }
        public string productcode { get; set; }
        public string exchangetimestamp { get; set; }
        public string ordersource { get; set; }
        public string ordergenerationtype { get; set; }
        public string legorderindicator { get; set; }
        public decimal coverorderpercentage { get; set; }
        public decimal coverreflimitprice { get; set; }
        public string pricenumerator { get; set; }
        public string pricedenominator { get; set; }
        public string generalnumerator { get; set; }
        public string generaldenominator { get; set; }
        public string remarks { get; set; }

        public string sipindicator { get; set; }

        public string reporttype { get; set; }

        public string responsestatus { get; set; }

        public string errormsg { get; set; }

    }

    public class StockOrderDetail
    {
        public string exchange { get; set; }
        public string nestordernumber { get; set; }
        public string nestreqid { get; set; }
        public string transactiontype { get; set; }
        public string symbolname { get; set; }
        public string scripname { get; set; }
        public double pricetofill { get; set; }
        public double averageprice { get; set; }
        public double triggerprice { get; set; }
        public int qtytofill { get; set; }
        public int unfilledsize { get; set; }
        public int disclosedqty { get; set; }
        public string exchangeorderid { get; set; }
        public string status { get; set; }
        public string time { get; set; }
        public string text { get; set; }
        public string pricetype { get; set; }
        public string duration { get; set; }
        public string productcode { get; set; }
        public string responsestatus { get; set; }
        public string errormsg { get; set; }
    }

    public class ExchangeLogs
    {
        public string exchange { get; set; }
        public string ssboe { get; set; }
        public string exchangenews { get; set; }
        public string responsestatus { get; set; }
        public string errormsg { get; set; }
    }

    public class DPHoldings
    {
        public string tradingsymbol { get; set; }
        public int totalqty { get; set; }
        public int notionalqty { get; set; }
        public int usedqty { get; set; }
        public int balanceqty { get; set; }
        public int dpqty { get; set; }
        public double nseltp { get; set; }
        public double bseltp { get; set; }
        public double marketvalue { get; set; }
        public double haircut { get; set; }
        public double posthaircutvalue { get; set; }
        public string isin { get; set; }
        public string nsetradingsymbol { get; set; }
        public string bsetradingsymbol { get; set; }
        public string nsesymbol { get; set; }
        public string bsesymbol { get; set; }
        public string responsestatus { get; set; }
        public string errormsg { get; set; }
        public double sellableqty { get; set; }
        public string isBuyBack { get; set; }
        public double availablebuybackqty { get; set; }
        public string productcode { get; set; }
        
    }

    public class MarketStatus
    {
        public string exchsegment { get; set; }
        public string marketstatus { get; set; }
        public string text { get; set; }
        public string exchfeedtime { get; set; }
        public string sessionmode { get; set; }
        public string responsestatus { get; set; }
        public string errormsg { get; set; }
    }

    public class OrderLogs
    {
        public string clientcode { get; set; }
        public string exchange { get; set; }
        public string productcode { get; set; }
        public string tradingsymbol { get; set; }
        public int nestorderreqid { get; set; }
        public string ordervalidity { get; set; }
        public string status { get; set; }
        public string transactiontype { get; set; }
        public string nestorderno { get; set; }
        public string exchangeorderno { get; set; }
        public string customerfirm { get; set; }
        public string price { get; set; }
        public string triggerprice { get; set; }
        public int pendingqty { get; set; }
        public int filledqty { get; set; }
        public int disclosedqty { get; set; }
        public int totalqty { get; set; }
        public string orderentrytime { get; set; }
        public string pricetype { get; set; }
        public string text { get; set; }
        public string reporttype { get; set; }
        public string responsestatus { get; set; }
        public string errormsg { get; set; }
    }

    public class StockSIPOrderBook
    {
        public string accountid { get; set; }
        public string exchange { get; set; }
        public string ordertype { get; set; }
        public string productcode { get; set; }
        public string sip_investby { get; set; }
        public string sip_last_exec_date { get; set; }
        public string sip_nest_due_date { get; set; }
        public string sip_period { get; set; }
        public string sip_sequence_number { get; set; }
        public string sip_start_date { get; set; }
        public string sip_end_date { get; set; }
        public bool sipamountSpecified { get; set; }
        public string sipamountstr { get; set; }
        public string sipfrequency { get; set; }
        public bool sipquantitySpecified { get; set; }
        public string sipquantitystr { get; set; }
        public string symbol { get; set; }
        public string tradingsymbol { get; set; }
        public string transactiontype { get; set; }
        public string userid { get; set; }
        public string responsestatus { get; set; }
        public string errormsg { get; set; }

        /*
         below properties cannot be bind 
        */
        public string scripname { get; set; }
        public string status { get; set; }
        public string transactiondate { get; set; }
        public string ordersource { get; set; }
        public string payout { get; set; }
        public string remarks { get; set; }
        public string regno { get; set; }
        
    }

    public class RelianceETFData
    {
        public string CODE { get; set; }
        public string SCRIPCODE { get; set; }
        public string NSESYMBOL { get; set; }
        public string ISIN { get; set; }
        public string Nsetradingsymbol { get; set; }
        public string OmneNSESymbol { get; set; }
        public string Bsetradingsymbol { get; set; }
        public string OmneBSESymbol { get; set; }
        public string NSEToken { get; set; }
        public string BSEToken { get; set; }
        public string Status { get; set; }
        public string isNSE { get; set; }
        public string isBSE { get; set; }
        public string FundName { get; set; }
        public string SchemeCode { get; set; }
        public string NseTicksize { get; set; }
        public string BseTicksize { get; set; }

    }

    public class Sendpostreq
    {
        public string d { get; set; }
        public bool Email { get; set; }
    }

    public class OTPVerificationres
    {
        public string d { get; set; }

    }

    public class RadvantageReponse
    {
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string Token { get; set; }
    }

    // --------------added by poonam 20200928  for 60467 Start----------

    public class PostAuthData
    {
        public string PARTY_CODE { get; set; }
        public string SCRIP_CD { get; set; }
        public string ISIN { get; set; }
        public string QUANTITY { get; set; }
        public string SETTLEID { get; set; }
        public string TRADEDATE { get; set; }
        public string AUTHSTATUS { get; set; }// added by poonam 20200928  for 60467

    }

    // --------------added by poonam 20200928  for 60467 End----------

    // -----------Added by Arti 20210225 Adpative login start-----------------

    public class CDSLAdaptiveLoginData
    {
        public string clientcode { get; set; }
        public string userid { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string dpid { get; set; }
        public string profile { get; set; }
        public string date { get; set; }
        public string source { get; set; }
        public string ip { get; set; }
        public string imei { get; set; }
        public string Web_deviceid { get; set; }
        public string Mob_deviceid { get; set; }



    }
    // -----------Added by Arti 20210225 Adpative login End-----------------

}
