using System;
using System.Collections.Generic;

namespace RSM.BAL.DomainModels.Models
{
    public class StockBOL
    {
        public int CODE { get; set; }
        public int SCRIPCODE { get; set; }
        public string NSESYMBOL { get; set; }
        public string ScripName { get; set; }
        public string isin { get; set; }
        public int INDCODE { get; set; }
        public string INDSN { get; set; }
        public string SECTOR { get; set; }
        public string IND { get; set; }
        public int HSCODE { get; set; }
        public string house { get; set; }
        public int isBSE { get; set; }
        public int isNSE { get; set; }
        public decimal NOPEN { get; set; }
        public decimal NHIGH { get; set; }
        public decimal NLOW { get; set; }
        public decimal NCLOSE { get; set; }
        public decimal NLTP { get; set; }
        public decimal NVOLUME { get; set; }
        public decimal NPREVCLOSE { get; set; }
        public decimal NCHANGE { get; set; }
        public decimal NPERCHANGE { get; set; }
        public decimal NSE52HIGH { get; set; }
        public decimal NSE52LOW { get; set; }
        public string NPUPTIME { get; set; }
        public decimal BOPEN { get; set; }
        public decimal BHIGH { get; set; }
        public decimal BLOW { get; set; }
        public decimal BCLOSE { get; set; }
        public decimal BLTP { get; set; }
        public decimal BVOLUME { get; set; }
        public decimal BPREVCLOSE { get; set; }
        public decimal BCHANGE { get; set; }
        public decimal BPERCHANGE { get; set; }
        public decimal BSE52HIGH { get; set; }
        public decimal BSE52LOW { get; set; }
        public string BPUPTIME { get; set; }
        public decimal Fv { get; set; }
        public decimal PE { get; set; }
        public decimal EPS { get; set; }
        public decimal MCAP { get; set; }
        public decimal PBDTM { get; set; }
        public decimal ROE { get; set; }
        public decimal PATMargin { get; set; }
        public decimal ROCE { get; set; }
        public decimal YIELD { get; set; }
        public decimal IntCoverage { get; set; }
        public decimal DebtEq { get; set; }
        public decimal BV { get; set; }
        public decimal total_income { get; set; }
        public decimal tax { get; set; }
        public decimal total_expendiure { get; set; }
        public decimal PBT { get; set; }
        public decimal PAT { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string DataPoints { get; set; }
        public int rank { get; set; }
        public string HTML { get; set; }
        public string NSETradingSymbol { get; set; }
        public string OmneNSESymbol { get; set; }
        public string BSETradingSymbol { get; set; }
        public string OmneBSESymbol { get; set; }
        public string DPColumns { get; set; }
        public string DPText { get; set; }
        public string Recommended { get; set; }
        public decimal Ev_ebita { get; set; }
        public decimal Price_Book { get; set; }
        public decimal EVSales { get; set; }
        public decimal CASA { get; set; }
        public decimal RON { get; set; }
        public decimal _1monthNseHigh { get; set; }
        public decimal _1monthNseLow { get; set; }
        public decimal _1monthBseHigh { get; set; }
        public decimal _1monthBseLow { get; set; }
        public decimal _3monthNseHigh { get; set; }
        public decimal _3monthNseLow { get; set; }
        public decimal _3monthBseHigh { get; set; }
        public decimal _3monthBseLow { get; set; }
        public decimal _6monthNseHigh { get; set; }
        public decimal _6monthNseLow { get; set; }
        public decimal _6monthBseHigh { get; set; }
        public decimal _6monthBseLow { get; set; }
        public decimal _1weekNseHigh { get; set; }
        public decimal _1weekNseLow { get; set; }
        public decimal _1weekBseHigh { get; set; }
        public decimal _1weekBseLow { get; set; }
        public decimal _5yearBsePrice { get; set; }
        public decimal _5yearNsePrice { get; set; }
        public decimal _5yearReturnBsePercent { get; set; }
        public decimal _5yearReturnNsePercent { get; set; }
        public decimal _1yearNsePrice { get; set; }
        public decimal _1yearBsePrice { get; set; }
        public decimal _1yearReturnBsePercent { get; set; }
        public decimal _1yearReturnNsePercent { get; set; }
        public decimal _1monthBsePrice { get; set; }
        public decimal _1monthNsePrice { get; set; }
        public decimal _3yearBsePrice { get; set; }
        public decimal _3yearNsePrice { get; set; }
        public decimal _1weekReturnNsePercent { get; set; }
        public decimal _1weekReturnBsePercent { get; set; }
        public decimal _3yearNseHigh { get; set; }
        public decimal _3yearBseHigh { get; set; }
        public decimal _3yearReturnNsePercent { get; set; }
        public decimal _3yearReturnBsePercent { get; set; }
        public decimal _1monthReturnNsePercent { get; set; }
        public decimal _1monthReturnBsePercent { get; set; }
        public decimal _6monthReturnNsePercent { get; set; }
        public decimal _6monthReturnBsePercent { get; set; }
        public decimal _3monthReturnNsePercent { get; set; }
        public decimal _3monthReturnBsePercent { get; set; }
        //accord dp
        public int yearend { get; set; }
        public string mnmsymbolname { get; set; }
        public int IsSIP { get; set; }
        public string RelatedInfo { get; set; }
        public decimal BseTicksize { get; set; }
        public decimal NseTicksize { get; set; }
        public string NSEToken { get; set; }
        public string BSEToken { get; set; }
        public string Status { get; set; }
        public string Year_EndDate { get; set; }

        public decimal OmnesysNLTP { get; set; }
        public decimal OmnesysNOPEN { get; set; }
        public decimal OmnesysNHIGH { get; set; }
        public decimal OmnesysNLOW { get; set; }
        public decimal OmnesysNCLOSE { get; set; }

        public DateTime OmnesysNLOADTIME { get; set; }
        public decimal OmnesysBLTP { get; set; }
        public decimal OmnesysBOPEN { get; set; }
        public decimal OmnesysBHIGH { get; set; }
        public decimal OmnesysBLOW { get; set; }
        public decimal OmnesysBCLOSE { get; set; }
        public DateTime OmnesysBLOADTIME { get; set; }

        public decimal OmnesysNCHANGE { get; set; }
        public decimal OmnesysNPERCHANGE { get; set; }
        public decimal OmnesysBCHANGE { get; set; }
        public decimal OmnesysBPERCHANGE { get; set; }
        public DateTime LTT { get; set; }
    }


    public class StockBOLBroad
    {
        public int CODE { get; set; }
        public int SCRIPCODE { get; set; }
        public string NSESYMBOL { get; set; }
        public string ScripName { get; set; }
        public string isin { get; set; }
        public int INDCODE { get; set; }
        public string INDSN { get; set; }
        public string SECTOR { get; set; }
        public string IND { get; set; }
        public int HSCODE { get; set; }
        public string house { get; set; }
        public int isBSE { get; set; }
        public int isNSE { get; set; }
        public decimal NOPEN { get; set; }
        public decimal NHIGH { get; set; }
        public decimal NLOW { get; set; }
        public decimal NCLOSE { get; set; }
        public decimal NLTP { get; set; }
        public decimal NVOLUME { get; set; }
        public decimal NPREVCLOSE { get; set; }
        public decimal NCHANGE { get; set; }
        public decimal NPERCHANGE { get; set; }
        public decimal NSE52HIGH { get; set; }
        public decimal NSE52LOW { get; set; }
        public string NPUPTIME { get; set; }
        public decimal BOPEN { get; set; }
        public decimal BHIGH { get; set; }
        public decimal BLOW { get; set; }
        public decimal BCLOSE { get; set; }
        public decimal BLTP { get; set; }
        public decimal BVOLUME { get; set; }
        public decimal BPREVCLOSE { get; set; }
        public decimal BCHANGE { get; set; }
        public decimal BPERCHANGE { get; set; }
        public decimal BSE52HIGH { get; set; }
        public decimal BSE52LOW { get; set; }
        public string BPUPTIME { get; set; }
        public decimal Fv { get; set; }
        public decimal PE { get; set; }
        public decimal EPS { get; set; }
        public decimal MCAP { get; set; }
        public decimal PBDTM { get; set; }
        public decimal ROE { get; set; }
        public decimal PATMargin { get; set; }
        public decimal ROCE { get; set; }
        public decimal YIELD { get; set; }
        public decimal IntCoverage { get; set; }
        public decimal DebtEq { get; set; }
        public decimal BV { get; set; }
        public decimal total_income { get; set; }
        public decimal tax { get; set; }
        public decimal total_expendiure { get; set; }
        public decimal PBT { get; set; }
        public decimal PAT { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string DataPoints { get; set; }
        public int rank { get; set; }
        public string HTML { get; set; }
        public string NSETradingSymbol { get; set; }
        public string OmneNSESymbol { get; set; }
        public string BSETradingSymbol { get; set; }
        public string OmneBSESymbol { get; set; }
        public string DPColumns { get; set; }
        public string DPText { get; set; }
        public string Recommended { get; set; }
        public decimal Ev_ebita { get; set; }
        public decimal Price_Book { get; set; }
        public decimal EVSales { get; set; }
        public decimal CASA { get; set; }
        public decimal RON { get; set; }
        public decimal _1monthNseHigh { get; set; }
        public decimal _1monthNseLow { get; set; }
        public decimal _1monthBseHigh { get; set; }
        public decimal _1monthBseLow { get; set; }
        public decimal _3monthNseHigh { get; set; }
        public decimal _3monthNseLow { get; set; }
        public decimal _3monthBseHigh { get; set; }
        public decimal _3monthBseLow { get; set; }
        public decimal _6monthNseHigh { get; set; }
        public decimal _6monthNseLow { get; set; }
        public decimal _6monthBseHigh { get; set; }
        public decimal _6monthBseLow { get; set; }
        public decimal _1weekNseHigh { get; set; }
        public decimal _1weekNseLow { get; set; }
        public decimal _1weekBseHigh { get; set; }
        public decimal _1weekBseLow { get; set; }
        public decimal _5yearBsePrice { get; set; }
        public decimal _5yearNsePrice { get; set; }
        public decimal _5yearReturnBsePercent { get; set; }
        public decimal _5yearReturnNsePercent { get; set; }
        public decimal _1yearNsePrice { get; set; }
        public decimal _1yearBsePrice { get; set; }
        public decimal _1yearReturnBsePercent { get; set; }
        public decimal _1yearReturnNsePercent { get; set; }
        public decimal _1monthBsePrice { get; set; }
        public decimal _1monthNsePrice { get; set; }
        public decimal _3yearBsePrice { get; set; }
        public decimal _3yearNsePrice { get; set; }
        public decimal _1weekReturnNsePercent { get; set; }
        public decimal _1weekReturnBsePercent { get; set; }
        public decimal _3yearNseHigh { get; set; }
        public decimal _3yearBseHigh { get; set; }
        public decimal _3yearReturnNsePercent { get; set; }
        public decimal _3yearReturnBsePercent { get; set; }
        public decimal _1monthReturnNsePercent { get; set; }
        public decimal _1monthReturnBsePercent { get; set; }
        public decimal _6monthReturnNsePercent { get; set; }
        public decimal _6monthReturnBsePercent { get; set; }
        public decimal _3monthReturnNsePercent { get; set; }
        public decimal _3monthReturnBsePercent { get; set; }
        //accord dp
        public int yearend { get; set; }
        public string mnmsymbolname { get; set; }
        public int IsSIP { get; set; }
        public string RelatedInfo { get; set; }
        public decimal BseTicksize { get; set; }
        public decimal NseTicksize { get; set; }
        public string NSEToken { get; set; }
        public string BSEToken { get; set; }
        public string Status { get; set; }
        public string Year_EndDate { get; set; }

        public decimal OmnesysNLTP { get; set; }
        public decimal OmnesysNOPEN { get; set; }
        public decimal OmnesysNHIGH { get; set; }
        public decimal OmnesysNLOW { get; set; }
        public decimal OmnesysNCLOSE { get; set; }

        public DateTime OmnesysNLOADTIME { get; set; }
        public decimal OmnesysBLTP { get; set; }
        public decimal OmnesysBOPEN { get; set; }
        public decimal OmnesysBHIGH { get; set; }
        public decimal OmnesysBLOW { get; set; }
        public decimal OmnesysBCLOSE { get; set; }
        public DateTime OmnesysBLOADTIME { get; set; }

        public decimal OmnesysNCHANGE { get; set; }
        public decimal OmnesysNPERCHANGE { get; set; }
        public decimal OmnesysBCHANGE { get; set; }
        public decimal OmnesysBPERCHANGE { get; set; }

        public DateTime LTT { get; set; }

        public string EXCHANGE { get; set; }
        public string SEGMENT { get; set; }
        public int SEC_ID { get; set; }
        public decimal LTP { get; set; }
        public decimal OPEN { get; set; }
        public decimal HIGH { get; set; }
        public decimal LOW { get; set; }
        public decimal CLOSE { get; set; }
        public decimal VOLUME { get; set; }
        public decimal ASKPRICE { get; set; }
        public decimal ASK_QUAN { get; set; }
        public decimal BIDPRICE { get; set; }
        public decimal BID_QUAN { get; set; }
        public string Broad_LTT { get; set; }
        public string ATP { get; set; }
    }




    public class OmnesysBOL
    {
        public DateTime EntryDate { get; set; }
        public string Token { get; set; }
        public string TradingSymbol { get; set; }
        public decimal AvgPrice { get; set; }
        public decimal OpenPrice { get; set; }
        public decimal ClosePrice { get; set; }
        public decimal LowPrice { get; set; }
        public decimal HighPrice { get; set; }
        public decimal TotTradQty { get; set; }
        public decimal TotalQty { get; set; }
        public decimal CumAvgPrice { get; set; }
        public string StartingTime { get; set; }
        public string EndingTime { get; set; }
        public int StartingSSBOE { get; set; }
        public decimal VolChange { get; set; }
        public decimal LTP { get; set; }
        public string LoadTime { get; set; }
    }
    public class _52weekBOL
    {
        public string STK_EXCHANGE { get; set; }
        public int SCRIPCODE { get; set; }
        public int FINCODE { get; set; }
        public string SYMBOL { get; set; }
        public string S_NAME { get; set; }
        public string SCRIP_GROUP { get; set; }
        public DateTime UPD_TIME { get; set; }
        public decimal FHigh { get; set; }
        public decimal FLow { get; set; }
        public DateTime FHDate { get; set; }
        public DateTime FLDate { get; set; }
    }
    public class StockReturns
    {
        public decimal _1monthReturnNsePercent { get; set; }
        public decimal _1monthReturnBsePercent { get; set; }
        public decimal _3monthReturnNsePercent { get; set; }
        public decimal _3monthReturnBsePercent { get; set; }
        public decimal _6monthReturnNsePercent { get; set; }
        public decimal _6monthReturnBsePercent { get; set; }
        public decimal _1YearReturnNsePercent { get; set; }
        public decimal _1YearReturnBsePercent { get; set; }
        public decimal _3YearReturnNsePercent { get; set; }
        public decimal _3YearReturnBsePercent { get; set; }
        public decimal _5YearReturnNsePercent { get; set; }
        public decimal _5YearReturnBsePercent { get; set; }
    }
    public class SliderBOL
    {
        public decimal MinBLTP { get; set; }
        public decimal MaxBLTP { get; set; }
        public decimal MinNLTP { get; set; }
        public decimal MaxNLTP { get; set; }
        public decimal MinBvol { get; set; }
        public decimal MaxBvol { get; set; }
        public decimal MinNvol { get; set; }
        public decimal MaxNvol { get; set; }
        public decimal MinMcap { get; set; }
        public decimal MaxMcap { get; set; }
    }
    public class BlinkData
    {
        public string ISIN { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
    }
    public class StockBasket
    {
        public Guid BasketId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TotalStocks { get; set; }
        public decimal MinAmt { get; set; }
        public decimal ReturnPercent { get; set; }
        public decimal _5YrReturnPercent { get; set; }
        public string ImageToBind { get; set; }
        public bool isRecommended { get; set; }
        public DateTime AddedDate { get; set; }
        public int Exchange { get; set; }
        // newly added by arti
        public string PdfToBind { get; set; }
        public string SubDescriptionToBind { get; set; }
        public decimal ReturnValuePercent { get; set; }
        //Added by Arti To sort Maxreturn 
        public decimal MaxReturn { get; set; }
        // public decimal ReturnYears { get; set; }
        public string ReturnYearsText { get; set; }
        //End

        ////public Byte[] Image { get; set; }
        ////public string ImageToBind
        ////{
        ////    get
        ////    {
        ////        return "data:image/jpg;base64," + Convert.ToBase64String(this.Image);
        ////    }
        ////}
    }
    public class StockRuleBasedComponent
    {
        public Guid ComponentId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid SubCategoryId { get; set; }
        public string ComponentName { get; set; }
        public string Description { get; set; }
        public string Exchange { get; set; }
        public string Industry { get; set; }
        public string LTPMin { get; set; }
        public string LTPMax { get; set; }
        public string DayReturnMin { get; set; }
        public string DayReturnMax { get; set; }
        public string ChangeMin { get; set; }
        public string ChangeMax { get; set; }
        public string PerChangeMin { get; set; }
        public string PerChangeMax { get; set; }
        public string VolumeMin { get; set; }
        public string VolumeMax { get; set; }
        public string OpenPriceMin { get; set; }
        public string OpenPriceMax { get; set; }
        public string HighPriceMin { get; set; }
        public string HighPriceMax { get; set; }
        public string LowPriceMin { get; set; }
        public string LowPriceMax { get; set; }
        public string ClosePriceMin { get; set; }
        public string ClosePriceMax { get; set; }
        public string MCapMin { get; set; }
        public string MCapMax { get; set; }
        public string DVMin { get; set; }
        public string DVMax { get; set; }
        public string EPSMin { get; set; }
        public string EPSMax { get; set; }
        public string PEMin { get; set; }
        public string PEMax { get; set; }
        public string _1MonthLowMin { get; set; }
        public string _1MonthLowMax { get; set; }
        public string _1MonthHighMin { get; set; }
        public string _1MonthHighMax { get; set; }
        public string _52WeekLowMin { get; set; }
        public string _52WeekLowMax { get; set; }
        public string _52WeekHighMin { get; set; }
        public string _52WeekHighMax { get; set; }
        public string _1WeekPerMin { get; set; }
        public string _1WeekPerMax { get; set; }
        public string _1MonthPerMin { get; set; }
        public string _1MonthPerMax { get; set; }
        public string _3MonthPerMin { get; set; }
        public string _3MonthPerMax { get; set; }
        public string _6MonthPerMin { get; set; }
        public string _6MonthPerMax { get; set; }
        public string _1YearPerMin { get; set; }
        public string _1YearPerMax { get; set; }
        public string _3YearPerMin { get; set; }
        public string _3YearPerMax { get; set; }
        public string _5YearPerMin { get; set; }
        public string _5YearPerMax { get; set; }
        public string PBTMin { get; set; }
        public string PBTMax { get; set; }
        public string PATMin { get; set; }
        public string PATMax { get; set; }
        public string EVEbitdaMin { get; set; }
        public string EVEbitdaMax { get; set; }
        public string PriceBookMin { get; set; }
        public string PriceBookMax { get; set; }
        public string CasaMin { get; set; }
        public string CasaMax { get; set; }
        public string RONMin { get; set; }
        public string RONMax { get; set; }
        public string BVPSMin { get; set; }
        public string BVPSMax { get; set; }
        public string EVMin { get; set; }
        public string EVMax { get; set; }
        public string ROEMin { get; set; }
        public string ROEMax { get; set; }
        public string ROCEMin { get; set; }
        public string ROCEMax { get; set; }
        public string DebtEqMin { get; set; }
        public string DebtEqMax { get; set; }
        public string IntCoverageMin { get; set; }
        public string IntCoverageMax { get; set; }
        public string FVMin { get; set; }
        public string FVMax { get; set; }
        public string EPSTTMMin { get; set; }
        public string EPSTTMMax { get; set; }
        public string EbitdaMin { get; set; }
        public string EbitdaMax { get; set; }
        public string AddedBy { get; set; }
        public bool Status { get; set; }
        public int Action { get; set; }


    }
    public class StockBasketMarketData
    {
        public string ScripName { get; set; }
        public double LTP { get; set; }
        public double Change { get; set; }
        public double PerChange { get; set; }
        public double OmneLTP { get; set; }
        public double OmneChange { get; set; }
        public double OmnePerChange { get; set; }
        public double _1MonthReturns { get; set; }
        public double _6MonthReturns { get; set; }
        public double _1YearReturns { get; set; }
        public double _3YearReturns { get; set; }
        public double _5YearReturns { get; set; }
        public int Quantity { get; set; }
        public int FinCode { get; set; }
        public DateTime AccordUPTIME { get; set; }
        public DateTime OmnesysUPTIME { get; set; }
        public string HTML { get; set; }
        public string NSEToken { get; set; }
        public string BSEToken { get; set; }

    }
    public class StockBasketFundamentalData
    {
        public string ScripName { get; set; }
        public string Sector { get; set; }
        public double MCAP { get; set; }
        public string HealthScore { get; set; }
        public double ROE { get; set; }
        public double PAT { get; set; }
        public int FinCode { get; set; }
        public string HTML { get; set; }
    }
    public class StockMarketPicutre
    {
        public decimal lasttradedprice { get; set; }

        public int lasttradedqty { get; set; }

        public string lasttradedtime { get; set; }

        public double percentagechange { get; set; }

        public double abschange { get; set; }

        public string symbol { get; set; }

        public string series { get; set; }

        public double nooftrades { get; set; }

        public double weightedavg { get; set; }

        public string openrate { get; set; }

        public double previouscloserate { get; set; }

        public double highrate { get; set; }

        public double lowrate { get; set; }

        public string trend { get; set; }

        public string volume { get; set; }

        public int totalbuyqty { get; set; }

        public int totalsellqty { get; set; }

        public double lowercircuitlimit { get; set; }

        public double highercircuitlimit { get; set; }

        public int openinterest { get; set; }

        public string value { get; set; }

        public int triggerpercent { get; set; }

        public double yearlyhighprice { get; set; }

        public double yearlylowprice { get; set; }

        public string tradingsymbol { get; set; }

        public string companyname { get; set; }

        public string spotprice { get; set; }

        public string corporateaction { get; set; }
        public string status { get; set; }
        public string message { get; set; }

    }
    public class StockMarketDepth
    {
        public string bestbuysize1 { get; set; }
        public string bestbuyprice1 { get; set; }
        public string bestbuyorders1 { get; set; }
        public string bestbuysize2 { get; set; }
        public string bestbuyprice2 { get; set; }
        public string bestbuyorders2 { get; set; }
        public string bestbuysize3 { get; set; }
        public string bestbuyprice3 { get; set; }
        public string bestbuyorders3 { get; set; }
        public string bestbuysize4 { get; set; }
        public string bestbuyprice4 { get; set; }
        public string bestbuyorders4 { get; set; }
        public string bestbuysize5 { get; set; }
        public string bestbuyprice5 { get; set; }
        public string bestbuyorders5 { get; set; }
        public string bestsellsize1 { get; set; }
        public string bestsellprice1 { get; set; }
        public string bestsellorders1 { get; set; }
        public string bestsellsize2 { get; set; }
        public string bestsellprice2 { get; set; }
        public string bestsellorders2 { get; set; }
        public string bestsellsize3 { get; set; }
        public string bestsellprice3 { get; set; }
        public string bestsellorders3 { get; set; }
        public string bestsellsize4 { get; set; }
        public string bestsellprice4 { get; set; }
        public string bestsellorders4 { get; set; }
        public string bestsellsize5 { get; set; }
        public string bestsellprice5 { get; set; }
        public string bestsellorders5 { get; set; }
    }
    public class StockDP
    {
        public static Dictionary<string, string> Columns
        {
            get
            {
                Dictionary<string, string> lst = new Dictionary<string, string>();
                ///NSE BSE BASED --start
                lst.Add(value: "Open", key: "NOPEN");
                lst.Add(value: "High", key: "NHIGH");
                lst.Add(value: "Low", key: "NLOW");
                lst.Add(value: "Close", key: "NCLOSE");
                lst.Add(value: "52 Weeks High", key: "NSE52HIGH");
                lst.Add(value: "52 Weeks Low", key: "NSE52LOW");
                lst.Add(value: "Volume", key: "NVOLUME");
                lst.Add(value: "5 Year Return", key: "_5yearReturnNsePercent");
                lst.Add(value: "3 Year Return", key: "_3yearReturnNsePercent");
                lst.Add(value: "1 Year Return", key: "_1yearReturnNsePercent");
                lst.Add(value: "6 Month Return", key: "_6monthReturnNsePercent");
                lst.Add(value: "3 Month Return", key: "_3monthReturnNsePercent");
                lst.Add(value: "1 Month Return", key: "_1monthReturnNsePercent");
                lst.Add(value: "1 Week High", key: "_1weekNseHigh");
                lst.Add(value: "1 Week Low", key: "_1weekNseLow");
                lst.Add(value: "1 Lakh in 5 years (Returns)", key: "_5yearNsePrice");
                // lst.Add(value: "Day return %", key: "_1DayRet");

                ///NSE BSE BASED --end
                lst.Add(value: "Interest Coverage", key: "IntCoverage");
                lst.Add(value: "Face Value", key: "Fv");
                lst.Add(value: "Book Value per share", key: "BV");
                lst.Add(value: "Debt Equity", key: "DebtEq");
                lst.Add(value: "Profit Before Tax", key: "PBT");
                lst.Add(value: "Profit After Tax", key: "PAT");
                lst.Add(value: "CASA %", key: "CASA");
                lst.Add(value: "EVSales", key: "EVSales");

                lst.Add(value: "Sector", key: "SECTOR");
                lst.Add(value: "Market Capitalization", key: "MCAP");
                lst.Add(value: "Return on Equity", key: "ROE");
                lst.Add(value: "Price/Earning", key: "PE");
                lst.Add(value: "Earnings Per Share", key: "EPS");
                lst.Add(value: "Dividend Yield", key: "YIELD");
                lst.Add(value: "EV to EBITDA", key: "Ev_ebita");
                lst.Add(value: "Price Book", key: "Price_Book");
                return lst;
            }

        }
    }
    public class StockLimitAvailable
    {
        public double availablemarginlimit { get; set; }
        public double availablecashlimit { get; set; }
        public double availablederivativelimit { get; set; }
        public double availableoptionbuylimit { get; set; }
        public double withdrawablelimit { get; set; }
        public double cashbalance { get; set; }
        public double notionalcash { get; set; }
        public double collateralvalue { get; set; }
        public double payinamount { get; set; }
        public double adhocmargin { get; set; }
        public double netdeliveryamount { get; set; }
        public double deliverybrokage { get; set; }
        public double netpremimum { get; set; }
        public double bookedprofitlossonmarginpositions { get; set; }
        public double brokeragepresent { get; set; }
        public double unrealizedlossondeliverypositions { get; set; }
        public double marginusedforcashsegment { get; set; }
        public double marginusedforcoverorder { get; set; }
        public double spanmargin { get; set; }
        public double exposuremargin { get; set; }
        public double unrealizedlossonmarginpositions { get; set; }
        public double requestedpayout { get; set; }
        public double ipoamount { get; set; }
        public double mutualfundamount { get; set; }
        public double debittotal { get; set; }
        public double credittotal { get; set; }
        public string status { get; set; }
        public string errormsg { get; set; }

        public double availabledeliverylimit { get; set; }
        public double investmentproductslimit { get; set; }
        public double withdrawablefunds { get; set; }
        public double netdeliverysellamount { get; set; }
        public double premiumpresent { get; set; }
        public double realisedmtom { get; set; }
        public double notionalcashcredit { get; set; }
        public double notionalcashdebit { get; set; }
        public double adhocmargincredit { get; set; }
        public double adhocmargindebit { get; set; }
        public double netdeliverysellamountcredit { get; set; }
        public double netdeliverybuyamountdebit { get; set; }
        public double premiumpresentcredit { get; set; }
        public double premiumpresentdebit { get; set; }
        public double realisedmtomcredit { get; set; }
        public double realisedmtomdebit { get; set; }
        public double boMarginRequired { get; set; }
        public double directcollateralvalue { get; set; }
        public double marginusedforcobo { get; set; }
        public double debitamount { get; set; }
        public double shortfallamount { get; set; }
        public string clientriskprofile { get; set; }
        public double deliverymarginprsnt { get; set; } //issue id: 59118 Change by Arti 20200925


    }

    //new Poonam commodity limit
    public class CommLimitAvailable
    {
        public double availablemarginlimit { get; set; }
        public double availablederivativelimit { get; set; }
        public double availableoptionbuylimit { get; set; }
        public double withdrawablelimit { get; set; }
        public double debitamount { get; set; }
        public double shortfallamount { get; set; }
        public double debittotal { get; set; }
        public double credittotal { get; set; }
        public double withdrawablefunds { get; set; }
        public double cashbalance { get; set; }
        public double notionalcash { get; set; }
        public double collateralvalue { get; set; }
        public double payinamount { get; set; }
        public double adhocmargin { get; set; }
        public double netdeliverysellamount { get; set; }
        public double netpremimum { get; set; }
        public double bookedprofitlossonmarginpositions { get; set; }
        public double deliverybrokage { get; set; }
        public double brokeragepresent { get; set; }
        public double spanmargin { get; set; }
        public double exposuremargin { get; set; }
        public double premiumpresent { get; set; }
        public double realisedmtom { get; set; }
        public double unrealizedlossonmarginpositions { get; set; }
        public double requestedpayout { get; set; }
        public double marginusedforcobo { get; set; }
        public double notionalcashcredit { get; set; }
        public double notionalcashdebit { get; set; }
        public double adhocmargincredit { get; set; }
        public double adhocmargindebit { get; set; }
        public double premiumpresentcredit { get; set; }
        public double premiumpresentdebit { get; set; }
        public double realisedmtomcredit { get; set; }
        public double realisedmtomdebit { get; set; }
        public double directcollateralvalue { get; set; }
        public string status { get; set; }
        public string clientriskprofile { get; set; }
        public string errormsg { get; set; }

        //new add Arti 20200228
        public double additionalmarginprsnt { get; set; }
        public double additionalpreexpirymarginprsnt { get; set; }
        public double tendermarginprsnt { get; set; }
        public double deliverymarginprsnt { get; set; }
        public double specialmarginprsnt { get; set; }


    }

    //new Poonam commodity limit end


    public class StockMarginRequired
    {
        public double marginrequired { get; set; }
        public string status { get; set; }
        public string errormsg { get; set; }
    }
    public class StockBasketLimitAvailable
    {
        public double availablemarginlimit { get; set; }
        public double availablecashlimit { get; set; }
        public double availablederivativelimit { get; set; }
        public double availableoptionbuylimit { get; set; }
        public double withdrawablelimit { get; set; }
        public double collateralvalue { get; set; }
        public double notionalcashdebit { get; set; }
        public string status { get; set; }
        public string errormsg { get; set; }

    }
    public class StockSymbols
    {
        public string NSESymbol { get; set; }
        public string NSETradingSymbol { get; set; }
        public string BSESymbol { get; set; }
        public string BSETradingSymbol { get; set; }
        public string ISIN { get; set; }
        public double NSETickSize { get; set; }
        public double BSETickSize { get; set; }
        public string Status { get; set; }
        public string ErrorMsg { get; set; }
    }
    public class stockbasketplaceorder
    {
        public string basketid { get; set; }
        public string userid { get; set; }
        public string token { get; set; }
        public string accid { get; set; }
        public string exchg { get; set; }
        public string disclosedqty { get; set; }
        public string orderduration { get; set; }
        public string ordertype { get; set; }
        public string price { get; set; }
        public string pricetype { get; set; }
        public string producttype { get; set; }
        public string qty { get; set; }
        public string symbol { get; set; }
        public string tradingsymbol { get; set; }
        public string transactiontype { get; set; }
        public string triggerprice { get; set; }
        public string confirmationmsg { get; set; }
        public string orderstatus { get; set; }
        public string scripname { get; set; }
        public string fincode { get; set; }
        public string transactionid { get; set; }
        public string remarks { get; set; }
    }
    public class cartstockplaceorder
    {
        public string cartitemid { get; set; }
        public string exchange { get; set; }
        public string tradingsymbol { get; set; }
        public string symbol { get; set; }
        public string price { get; set; }
        public string qty { get; set; }
        public string triggerprice { get; set; }
        public string disclosedqty { get; set; }
        public string transactiontype { get; set; }
        public string pricetype { get; set; }
        public string producttype { get; set; }
        public string orderduration { get; set; }
        public string ordertype { get; set; }
        public string userid { get; set; }
        public string token { get; set; }
        public string accid { get; set; }
        public string fincode { get; set; }
        public string orderstatus { get; set; }
        public string scripname { get; set; }
        public string ltp { get; set; }
        public string remarks { get; set; }
        public string orderSource { get; set; }

    }
    public class cartstockbasketplaceorder
    {
        public string basketid { get; set; }
        public string userid { get; set; }
        public string token { get; set; }
        public string accid { get; set; }
        public string exchg { get; set; }
        public string disclosedqty { get; set; }
        public string orderduration { get; set; }
        public string ordertype { get; set; }
        public string price { get; set; }
        public string pricetype { get; set; }
        public string producttype { get; set; }
        public string qty { get; set; }
        public string symbol { get; set; }
        public string tradingsymbol { get; set; }
        public string transactiontype { get; set; }
        public string triggerprice { get; set; }
        public string confirmationmsg { get; set; }
        public string orderstatus { get; set; }
        public string scripname { get; set; }
        public string fincode { get; set; }
        public string transactionid { get; set; }
        public string remarks { get; set; }
    }
    public class advisorstockplaceorder
    {
        public string cartitemid { get; set; }
        public string exchange { get; set; }
        public string tradingsymbol { get; set; }
        public string symbol { get; set; }
        public string price { get; set; }
        public string qty { get; set; }
        public string triggerprice { get; set; }
        public string disclosedqty { get; set; }
        public string transactiontype { get; set; }
        public string pricetype { get; set; }
        public string producttype { get; set; }
        public string orderduration { get; set; }
        public string ordertype { get; set; }
        public string userid { get; set; }
        public string token { get; set; }
        public string accid { get; set; }
        public string fincode { get; set; }
        public string orderstatus { get; set; }
        public string scripname { get; set; }
        public string transactionid { get; set; }
    }
    public class cartmfbasketplaceorder
    {
        public string basketid { get; set; }
        public string userid { get; set; }
        public string token { get; set; }
        public string mftoken { get; set; }
        public string schemecode { get; set; }
        public string mininvt { get; set; }
        public string option { get; set; }
        public string mode { get; set; }
        public string folio { get; set; }
        public string schemename { get; set; }
        public string accid { get; set; }
        public string txntype { get; set; }
        public string funds { get; set; }
    }
    public class AzureSearchResult
    {
        public string odatacontext { get; set; }
        public int odatacount { get; set; }
        public AzureSearchResultResponse[] value { get; set; }
    }
    public class AzureSearchResultResponse
    {
        public float searchscore { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string[] Codes { get; set; }
        public string URI { get; set; }
    }
    public class StockTickerItem
    {
        public string SYMBOL { get; set; }
        public string LTP { get; set; }
        public string OPEN { get; set; }
        public string HIGH { get; set; }
        public string LOW { get; set; }
        public string CLOSEPRICE { get; set; }
        public string CHANGE { get; set; }
        public string PER_CHANGE { get; set; }
        public string PREV_PRICE { get; set; }
    }
    public class updatestockbasketcontent
    {
        public string userid { get; set; }
        public string token { get; set; }
        public string exchange { get; set; }
        public string symbol { get; set; }
        public string tradingsymbol { get; set; }
        public string isBuyNow { get; set; }
        public string fincode { get; set; }
    }


    public class stocksipbasketplaceorder
    {
        public string basketid { get; set; }
        public string userid { get; set; }
        public string token { get; set; }
        public string accid { get; set; }
        public string exchg { get; set; }
        public decimal qty { get; set; }
        public string symbol { get; set; }
        public string tradingsymbol { get; set; }
        public string siptype { get; set; }
        public string frequency { get; set; }
        public string startdate { get; set; }
        public int tenure { get; set; }
        public string confirmationmsg { get; set; }
        public string orderstatus { get; set; }
        public string scripname { get; set; }
        public string fincode { get; set; }
        public string transactionid { get; set; }
    }


    public class stocksipadvisorplaceorder
    {
        public string userid { get; set; }
        public string token { get; set; }
        public string accid { get; set; }
        public string exchg { get; set; }
        public string tradingsymbol { get; set; }
        public string symbol { get; set; }
        public string siptype { get; set; }
        public decimal investamount { get; set; }
        public string frequency { get; set; }
        public string startdate { get; set; }
        public int tenure { get; set; }
        public string confirmationmsg { get; set; }
        public string orderstatus { get; set; }
        public string scripname { get; set; }
        public string fincode { get; set; }
        public string transactionid { get; set; }
    }
}


